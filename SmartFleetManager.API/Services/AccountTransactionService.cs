using Microsoft.EntityFrameworkCore;
using SmartFleet.Data;
using SmartFleet.Data.Models;
using SmartFleetManager.API.Interfaces;

namespace SmartFleetManager.API.Services
{
    public class AccountTransactionService : IAccountTransactionService
    {
        private readonly AppDbContext _context;
        private const string currencyCode = "INR";
        private const int currencyExchangeRate = 1;
        private readonly ILogger<AccountTransactionService> _logger;

        public AccountTransactionService(AppDbContext context, ILogger<AccountTransactionService> logger)
        {
            _context = context;
            _logger = logger;
        }

        public async Task<long> CreateTransactionAsync(AccountTransaction transaction, List<AccountTransactionDetail> details)
        {
            using var dbTransaction = await _context.Database.BeginTransactionAsync();

            await ValidateBalancedAsync(details);
            await ValidateFinancialYearAsync(transaction.YearCode, transaction.TransactionDate);

            _context.AccountTransactions.Add(transaction);
            await _context.SaveChangesAsync();

            foreach (var d in details)
            {
                d.TransactionId = transaction.Id;

                // Auto base currency calculation
                d.BaseDebit = d.Debit * transaction.ExchangeRate;
                d.BaseCredit = d.Credit * transaction.ExchangeRate;
            }

            await _context.AccountTransactionDetails.AddRangeAsync(details);
            await _context.SaveChangesAsync();
            await dbTransaction.CommitAsync();
            return transaction.Id;
        }

        // Invoice Posting
        public async Task<long> CreateInvoiceTransactionAsync(Bill bill)
        {
            try
            {
                // 1. Get Customer Account (sub-ledger)
                var customerAccId = _context.Customers
                    .Where(p => p.Id == bill.CustomerId)
                    .Select(p => p.AccountId)
                    .FirstOrDefault() ?? 0;

                var billDetails = _context.BillItemDetails.Where(f => f.BTId == bill.Id).ToList();

                if (customerAccId == 0)
                    throw new Exception("Customer account not mapped.");

                // 2. Get Clearing Account
                var clearingAccountId = await _context.accountPostingSettings
                    .Where(f => f.DocumentType == "Invoice" && f.DocumentSubType.ToLower() == "TripDebtorAccount")
                    .Select(f => f.CreditAccountID)
                    .FirstOrDefaultAsync();

                if (clearingAccountId == 0)
                    throw new Exception("Clearing account not configured.");

                // 3. Create Transaction Header
                var transaction = new AccountTransaction
                {
                    TransactionDate = bill.BillDate,
                    DocumentType = "Invoice",
                    ReferenceNo = bill.RMTInvoiceNo.ToString(),
                    AccountID = 0, // No ledger impact here
                    TotalAmount = bill.GrandAmount,
                    CurrencyCode = currencyCode,
                    ExchangeRate = currencyExchangeRate,
                    YearCode = bill.YearCode,
                    AccountingStatus = "Posted",
                    Status = "Posted",
                    CreatedDate = DateTime.UtcNow,
                    branchId = bill.BranchId,
                    DocumentRefId = bill.Id,
                };

                // 4. Prepare Details
                var details = new List<AccountTransactionDetail>();

                void AddDebit(decimal amount, int accountId, string narration)
                {
                    if (amount <= 0) return;

                    details.Add(new AccountTransactionDetail
                    {
                        AccountID = accountId,
                        Debit = amount,
                        Credit = 0,
                        BaseDebit = Math.Round(amount * currencyExchangeRate, 2),
                        BaseCredit = 0,
                        Narration = narration,
                        branchID = bill.BranchId
                    });
                }

                void AddCredit(decimal amount, int accountId, string narration)
                {
                    if (amount <= 0) return;

                    details.Add(new AccountTransactionDetail
                    {
                        AccountID = accountId,
                        Debit = 0,
                        Credit = amount,
                        BaseDebit = 0,
                        BaseCredit = Math.Round(amount * currencyExchangeRate, 2),
                        Narration = narration,
                        branchID = bill.BranchId
                    });
                }

                // 5. Add Accounting Entries (CORE STEP)

                string narration = $"Invoice {bill.RMTInvoiceNo}";

                // Debit Customer AR
                AddDebit(bill.GrandAmount, customerAccId, narration);

                // Sale Total Amount Credit Clearing (from LR)
                AddCredit(bill.TotalAmount, clearingAccountId, $"Against LR {billDetails?.FirstOrDefault()?.LrNo}");

                if (bill.TaxPer > 0)
                {
                    var outPutIGSTAccountId = await _context.accountPostingSettings
                    .Where(f => f.DocumentType == "Invoice" && f.DocumentSubType.ToLower() == "IGSTAccountId")
                    .Select(f => f.CreditAccountID)
                    .FirstOrDefaultAsync();

                    var outPutCGSTAccountId = await _context.accountPostingSettings
                    .Where(f => f.DocumentType == "Invoice" && f.DocumentSubType.ToLower() == "CGSTAccountId")
                    .Select(f => f.CreditAccountID)
                    .FirstOrDefaultAsync();

                    var outputSGSTAccountId = await _context.accountPostingSettings
                    .Where(f => f.DocumentType == "Invoice" && f.DocumentSubType.ToLower() == "SGSTAccountId")
                    .Select(f => f.CreditAccountID)
                    .FirstOrDefaultAsync();

                    if (bill.IGST > 0)
                    {
                        // Credit Clearing (from LR)
                        AddCredit(bill.IGST, outPutIGSTAccountId, $"Output IGST Tax amount against LR {billDetails?.FirstOrDefault()?.LrNo} and invoice {bill.RMTInvoiceNo}");
                    }
                    else
                    {
                        AddCredit(bill.CGST, outPutCGSTAccountId, $"Output CGST Tax amount against LR {billDetails?.FirstOrDefault()?.LrNo} and invoice {bill.RMTInvoiceNo}");
                        AddCredit(bill.SGST, outputSGSTAccountId, $"Output SGST Tax amount against LR {billDetails?.FirstOrDefault()?.LrNo} and invoice {bill.RMTInvoiceNo}");
                    }
                }

                // 6. Validate Balance
                var totalDebit = details.Sum(x => x.Debit);
                var totalCredit = details.Sum(x => x.Credit);

                if (totalDebit != totalCredit)
                    throw new Exception($"Transaction not balanced. for Invoice No: {bill.RMTInvoiceNo} Dr: {totalDebit}, Cr: {totalCredit}");

                // 7. Save Transaction (Header + Details)
                var transactionId = await CreateTransactionAsync(transaction, details);

                // 8. Update Bill
                bill.AccountTransactionId = Convert.ToInt32(transactionId);
                bill.AccountStatus = "Posted";

                _context.BillTransaction.Update(bill);
                await _context.SaveChangesAsync();

                return transactionId;
            }
            catch
            {
                throw;
            }
        }

        // Trip Posting
        public async Task<long> CreateTripTransactionAsync(TripTransaction trip)
        {
            if (trip.TransactionStatus == "Posted")
            {
                _logger.LogError($"Trip already posted for LR No: {trip.ReferenceNo} dated {trip.LRDate} for route {trip.Route} with status {trip.Status}");
                throw new Exception("Trip already posted.");
            }

            try
            {
                var accountPostingAccs = await _context.accountPostingSettings
                    .Where(f => f.DocumentType == "Trip")
                    .ToListAsync();

                if (!accountPostingAccs.Any())
                {
                    _logger.LogError($"Account Posting settings not configured. please update the accounts in postting settings.");
                    throw new Exception("Account posting settings not configured.");
                }

                var tripClearingAcc = accountPostingAccs
                    .Where(f => f.DocumentSubType == "TripDebtorAccount")
                    .Select(s => s.DebitAccountId)
                    .FirstOrDefault();

                if (tripClearingAcc == 0)
                {
                    _logger.LogError($"Trip Debtor Account not mapped for account posting of trips.");
                    throw new Exception("Trip Debtor account not mapped.");
                }

                var transactionId = await PostCompleteTripAsync(trip, accountPostingAccs, tripClearingAcc);

                trip.TransactionStatus = "Posted";
                trip.TransactionReferenceId = Convert.ToInt32(transactionId);
                _context.TripTransaction.Update(trip);
                await _context.SaveChangesAsync();
                return transactionId;
            }
            catch (Exception ex)
            {
                _logger.LogError($"Error on posting the trips. Error Details: {ex.StackTrace}");
                throw;
            }
        }

        private async Task<long> PostCompleteTripAsync(TripTransaction trip, List<AccountPostingSettings> accountPostingAccs, int customerAccId)
        {
            var branchId = 1;

            var vehicle = _context.Vehilces
                .Where(f => f.Id == trip.VehicleId)
                .Select(s => new { s.Name, s.AccountId })
                .FirstOrDefault();

            var vehicleNumber = vehicle?.Name ?? "";
            var vehicleAccId = vehicle?.AccountId ?? 0;

            var accountReceivableAccId = accountPostingAccs
                .Where(f => f.DocumentSubType == "Main")
                .Select(s => s.DebitAccountId)
                .FirstOrDefault();

            if (accountReceivableAccId == 0)
                throw new Exception("Accounts Receivable Account is not mapped.");

            // 🔹 DRIVER ACCOUNT
            var driverAccId = _context.Employees
                .Where(e => e.Id == trip.EmployeeId)
                .Select(e => e.EmpAccountID)
                .FirstOrDefault() ?? 0;

            if (trip.DriverBata > 0 && driverAccId == 0)
                throw new Exception("Driver account not mapped.");

            // 🔹 VEHICLE ACCOUNT VALIDATION (only if fuel exists)
            if (trip.FuelCharges > 0 && vehicleAccId == 0)
                throw new Exception("Vehicle account not mapped.");

            // 🔹 CASH/BANK ACCOUNT
            var cashAccId = accountPostingAccs
                .FirstOrDefault(f => f.DocumentSubType == "ExpenseBankAccount")
                ?.CreditAccountID ?? 0;

            if (cashAccId == 0)
                throw new Exception("Expense Bank/Cash account not mapped.");

            var transaction = new AccountTransaction
            {
                TransactionDate = trip.LRDate,
                DocumentType = "Trip",
                ReferenceNo = trip.ReferenceNo ?? 0.ToString(),
                AccountID = accountReceivableAccId,
                CurrencyCode = currencyCode,
                ExchangeRate = currencyExchangeRate,
                YearCode = trip.YearCode,
                AccountingStatus = "Posted",
                Status = "Posted",
                CreatedDate = DateTime.UtcNow,
                branchId = branchId,
                DocumentRefId = trip.Id,
            };

            var details = new List<AccountTransactionDetail>();

            decimal totalDebit = 0;
            decimal totalCredit = 0;

            void AddDebit(decimal amount, int accountId, string narration)
            {
                if (amount <= 0) return;
                if (accountId == 0) throw new Exception($"Debit account missing for {narration}");

                totalDebit += amount;

                details.Add(new AccountTransactionDetail
                {
                    AccountID = accountId,
                    Debit = amount,
                    Credit = 0,
                    BaseDebit = amount * currencyExchangeRate,
                    Narration = narration,
                    branchID = branchId
                });
            }

            void AddCredit(decimal amount, int accountId, string narration)
            {
                if (amount <= 0) return;
                if (accountId == 0) throw new Exception($"Credit account missing for {narration}");

                totalCredit += amount;

                details.Add(new AccountTransactionDetail
                {
                    AccountID = accountId,
                    Debit = 0,
                    Credit = amount,
                    BaseCredit = amount * currencyExchangeRate,
                    Narration = narration,
                    branchID = branchId
                });
            }

            // ============================================
            // 1. CUSTOMER DEBIT
            // ============================================
            var description = $"Customer Receivable for Trip {trip.ReferenceNo} dated {trip.LRDate:dd/MM/yyyy} for Vehicle {vehicleNumber} ({trip.Route})";
            AddDebit(trip.TotalCost, customerAccId, description);

            // ============================================
            // 2. INCOME
            // ============================================
            var incomeMappings = new[]
            {
                new { Amount = trip.FrieghtCharges ?? 0, SubType = "FreightIncomeAcc", Name = "Freight Charges" },
                new { Amount = trip.LoadingCost, SubType = "LoadingUnloadingChargesIncomeAcc", Name = "Loading Unloading" },
                new { Amount = trip.HandlingCharges ?? 0, SubType = "HandlingIncomeAcc", Name = "Handling Charges" },
                new { Amount = trip.HaltingCharges ?? 0, SubType = "HaltingIncomeAcc", Name = "Halting Charges" },
                new { Amount = trip.LRCharges ?? 0, SubType = "LRChargesIncomeAcc", Name = "LR Charges" }
            };

            foreach (var income in incomeMappings)
            {
                if (income.Amount <= 0) continue;

                var acc = accountPostingAccs
                    .FirstOrDefault(a => a.DocumentSubType == income.SubType)
                    ?? throw new Exception($"Missing mapping for {income.SubType}");

                AddCredit(income.Amount, acc.CreditAccountID, $"Income: {income.Name} for Trip {trip.ReferenceNo}");
            }

            // ============================================
            // 3. EXPENSES
            // ============================================
            var expenseMappings = new[]
            {
                new { Amount = trip.DriverBata, SubType = "DriverBataExpenseAcc", Name = "Driver Bata" },
                new { Amount = trip.TollCharges, SubType = "TollExpenseAcc", Name = "Toll" },
                new { Amount = trip.FuelCharges, SubType = "FuelExpenseAcc", Name = "Fuel" },
                new { Amount = trip.CommissionAmt, SubType = "AgentCommissionExpenseAcc", Name = "Commission" },
                new { Amount = trip.InsuranceAmount, SubType = "InsuranceExpenseAcc", Name = "Insurance" },
                new { Amount = trip.PackagingCharges, SubType = "PackagingExpenseAcc", Name = "Packaging" },
                new { Amount = trip.AdditionalCost, SubType = "AdditionalChargesExpenseAcc", Name = "Additional" }
            };

            foreach (var expense in expenseMappings)
            {
                if (expense.Amount <= 0) continue;

                var acc = accountPostingAccs
                    .FirstOrDefault(a => a.DocumentSubType == expense.SubType)
                    ?? throw new Exception($"Missing mapping for {expense.SubType}");

                var narration = $"{expense.Name} for Trip {trip.ReferenceNo}";

                // 🔹 DRIVER BATA → Always payable
                if (expense.SubType == "DriverBataExpenseAcc")
                {
                    AddDebit(expense.Amount, acc.DebitAccountId, narration);
                    AddCredit(expense.Amount, driverAccId, narration);
                }
                // 🔹 FUEL
                else if (expense.SubType == "FuelExpenseAcc")
                {
                    AddDebit(expense.Amount, acc.DebitAccountId, narration);

                    if (acc.IsTripExpensePaidAlready)
                        AddCredit(expense.Amount, cashAccId, narration + " (Paid)");
                    else
                        AddCredit(expense.Amount, vehicleAccId, narration + " (Vehicle Payable)");
                }
                // 🔹 OTHER EXPENSES
                else
                {
                    AddDebit(expense.Amount, acc.DebitAccountId, narration);

                    if (acc.IsTripExpensePaidAlready)
                        AddCredit(expense.Amount, cashAccId, narration + " (Paid)");
                    else
                        AddCredit(expense.Amount, acc.CreditAccountID, narration + " (Payable)");
                }
            }

            // ============================================
            // 4. VENDOR RENT
            // ============================================
            if (trip.VendorRentCharges > 0)
            {
                var vendorExpenseAcc = accountPostingAccs
                    .FirstOrDefault(f => f.DocumentSubType == "VendorRentExpenseAcc")
                    ?.DebitAccountId ?? 0;

                var vendorAccId = _context.Vendors
                    .Where(p => p.Id == trip.VendorId)
                    .Select(s => s.AccountId)
                    .FirstOrDefault() ?? 0;

                if (vendorAccId == 0)
                    throw new Exception("Vendor account not mapped.");

                AddDebit(trip.VendorRentCharges ?? 0, vendorExpenseAcc, $"Vendor Rent for Trip {trip.ReferenceNo}");
                AddCredit(trip.VendorRentCharges ?? 0, vendorAccId, $"Vendor Payable for Trip {trip.ReferenceNo}");
            }

            // ============================================
            // FINAL CHECK
            // ============================================
            if (totalDebit != totalCredit)
                throw new Exception($"Transaction not balanced. Debit: {totalDebit}, Credit: {totalCredit}");

            transaction.TotalAmount = totalDebit;

            return await CreateTransactionAsync(transaction, details);
        }

        //Receipt Posting
        public async Task<long> CreateReceiptTransactionAsync(Receipt receipt)
        {
            if (receipt == null) throw new ArgumentNullException(nameof(receipt));
            if (receipt.Details == null || !receipt.Details.Any())
                throw new InvalidOperationException("Receipt must have at least one detail.");

            // Start DB transaction
            //await using var dbTransaction = await _context.Database.BeginTransactionAsync();

            try
            {
                // 1️⃣ Create AccountTransaction header
                var transaction = new AccountTransaction
                {
                    TransactionDate = receipt.ReceiptDate,
                    DocumentType = "Receipt",
                    ReferenceNo = receipt.receiptNo.ToString(),
                    AccountID = receipt.ToAccountId ?? 0,      // Cash/Bank account
                    TotalAmount = receipt.TotalAmount,
                    CurrencyCode = currencyCode,
                    ExchangeRate = currencyExchangeRate,
                    YearCode = receipt.YearCode ?? DateTime.Now.Year.ToString(),
                    AccountingStatus = "Posted",
                    Status = "Posted",
                    CreatedBy = 1,                            // TODO: set current user
                    UpdatedBy = 1,
                    CreatedDate = DateTime.UtcNow,
                    UpdatedDate = DateTime.UtcNow,
                    branchId = 1,
                    DocumentRefId = receipt.Id
                };

                _context.AccountTransactions.Add(transaction);
                await _context.SaveChangesAsync(); // Save to get transaction.Id

                // 2️⃣ Prepare Transaction Details
                var details = new List<AccountTransactionDetail>();

                // Debit the ToAccount (Cash/Bank)
                var debitDetail = new AccountTransactionDetail
                {
                    TransactionId = transaction.Id,
                    AccountID = receipt.ToAccountId ?? 0,
                    Debit = receipt.TotalAmount,
                    Credit = 0,
                    BaseDebit = receipt.TotalAmount * currencyExchangeRate,
                    BaseCredit = 0,
                    Narration = $"Receipt #{receipt.receiptNo} received",
                    InvoiceTransactionID = 0,
                    AllocationAmount = 0,
                    branchID = null
                };
                details.Add(debitDetail);

                // Credit each ReceiptDetail account
                foreach (var item in receipt.Details)
                {
                    var creditDetail = new AccountTransactionDetail
                    {
                        TransactionId = transaction.Id,
                        AccountID = item.AccountId,
                        Debit = 0,
                        Credit = item.Amount,
                        BaseDebit = 0,
                        BaseCredit = item.Amount * currencyExchangeRate,
                        Narration = item.Description ?? $"Receipt #{receipt.receiptNo} detail",
                        InvoiceTransactionID = item.Id,
                        AllocationAmount = 0,
                        branchID = null
                    };
                    details.Add(creditDetail);
                }

                // 3️⃣ Validate Debit = Credit
                if (details.Sum(d => d.Debit) != details.Sum(d => d.Credit))
                    throw new InvalidOperationException("Transaction is not balanced. Total debit must equal total credit.");

                // 4️⃣ Save Details
                _context.AccountTransactionDetails.AddRange(details);

                receipt.AccountTransactionId = Convert.ToInt32(transaction.Id);
                receipt.AccountStatus = "Posted";
                _context.Receipts.Update(receipt);
                await _context.SaveChangesAsync(); // Save to get transaction.Id

                return transaction.Id;
            }
            catch
            {
                //await dbTransaction.RollbackAsync();
                throw;
            }
        }

        // Payment Posting
        public async Task<long> CreatePaymentTransactionAsync(Payment payment)
        {
            if (payment == null) throw new ArgumentNullException(nameof(payment));
            if (payment.Details == null || !payment.Details.Any())
                throw new InvalidOperationException("Payment must have at least one detail.");

            try
            {
                // Create AccountTransaction header
                var transaction = new AccountTransaction
                {
                    TransactionDate = payment.PayDate,
                    DocumentType = "Payment",
                    ReferenceNo = payment.paymentNo.ToString(),
                    AccountID = payment.FromAccountId,   // Cash / Bank account
                    TotalAmount = payment.TotalAmount,
                    CurrencyCode = currencyCode,
                    ExchangeRate = currencyExchangeRate,
                    YearCode = payment.YearCode ?? DateTime.Now.Year.ToString(),
                    AccountingStatus = "Posted",
                    Status = "Posted",
                    CreatedBy = 1,
                    UpdatedBy = 1,
                    CreatedDate = DateTime.UtcNow,
                    UpdatedDate = DateTime.UtcNow,
                    branchId = 1,
                    DocumentRefId = payment.Id
                };

                _context.AccountTransactions.Add(transaction);
                await _context.SaveChangesAsync();

                var details = new List<AccountTransactionDetail>();

                // Credit Cash/Bank Account
                var creditDetail = new AccountTransactionDetail
                {
                    TransactionId = transaction.Id,
                    AccountID = payment.FromAccountId,
                    Debit = 0,
                    Credit = payment.TotalAmount,
                    BaseDebit = 0,
                    BaseCredit = payment.TotalAmount * currencyExchangeRate,
                    Narration = $"Payment #{payment.paymentNo} paid",
                    InvoiceTransactionID = 0,
                    AllocationAmount = 0,
                    branchID = null
                };

                details.Add(creditDetail);

                // 3️⃣ Debit Payment Details
                foreach (var item in payment.Details)
                {
                    var debitDetail = new AccountTransactionDetail
                    {
                        TransactionId = transaction.Id,
                        AccountID = item.AccountId,
                        Debit = item.Amount,
                        Credit = 0,
                        BaseDebit = item.Amount * currencyExchangeRate,
                        BaseCredit = 0,
                        Narration = item.Description ?? $"Payment #{payment.paymentNo} detail",
                        InvoiceTransactionID = item.Id,
                        AllocationAmount = 0,
                        branchID = null
                    };

                    details.Add(debitDetail);
                }

                // Validate Debit = Credit
                if (details.Sum(d => d.Debit) != details.Sum(d => d.Credit))
                    throw new InvalidOperationException("Transaction is not balanced.");

                // Save Details
                _context.AccountTransactionDetails.AddRange(details);

                payment.AccountTransactionId = Convert.ToInt32(transaction.Id);
                payment.AccountStatus = "Posted";
                _context.payments.Update(payment);
                await _context.SaveChangesAsync(); // Save to get transaction.Id

                return transaction.Id;
            }
            catch
            {
                throw;
            }
        }
        //Journal Posting
        public async Task<long> CreateJournalTransactionAsync(JournalEntry journal)
        {
            if (journal == null || journal.Lines == null || !journal.Lines.Any())
                throw new ArgumentException("Journal entry must have at least one line.");

            using var dbTransaction = await _context.Database.BeginTransactionAsync();

            try
            {
                // Create main AccountTransaction
                var transaction = new AccountTransaction
                {
                    TransactionDate = journal.EntryDate,
                    DocumentType = "Journal", //journal.JournalType ?? "Journal",
                    ReferenceNo = journal.ReferenceNumber ?? $"JNL-{journal.JournalNo}",
                    AccountID = 0, // Not linked to a single account for journal
                    TotalAmount = journal.TotalDebit, // Could use TotalDebit or sum of all lines
                    CurrencyCode = currencyCode,
                    ExchangeRate = currencyExchangeRate,
                    YearCode = journal.YearCode ?? DateTime.Now.Year.ToString(),
                    AccountingStatus = "Posted",
                    Status = "Posted",
                    CreatedDate = DateTime.UtcNow,
                    DocumentRefId = journal.JournalEntryId,
                };

                _context.AccountTransactions.Add(transaction);
                await _context.SaveChangesAsync();

                // Map journal lines to AccountTransactionDetails
                var details = new List<AccountTransactionDetail>();

                foreach (var line in journal.Lines)
                {
                    var detail = new AccountTransactionDetail
                    {
                        TransactionId = transaction.Id,
                        AccountID = line.AccountId,
                        Debit = line.Debit,
                        Credit = line.Credit,
                        BaseDebit = line.Debit * currencyExchangeRate,
                        BaseCredit = line.Credit * currencyExchangeRate,
                        Narration = line.Description ?? $"Journal Line {line.JournalEntryLineId}",
                    };

                    details.Add(detail);
                }

                await _context.AccountTransactionDetails.AddRangeAsync(details);
                await _context.SaveChangesAsync();

                await dbTransaction.CommitAsync();

                return transaction.Id;
            }
            catch
            {
                await dbTransaction.RollbackAsync();
                throw;
            }
        }

        public async Task<long> ReverseTransactionAsync(int transactionId, string reversedBy)
        {
            // Fetch the original transaction with its details
            var originalTransaction = await _context.AccountTransactions.Include(t => t.AccountTransactionDetails).FirstOrDefaultAsync(t => t.Id == transactionId);

            if (originalTransaction == null)
                throw new ArgumentException($"Transaction with Id {transactionId} not found.");

            using var dbTransaction = await _context.Database.BeginTransactionAsync();

            try
            {
                // Create a reversing transaction header
                var reverseTransaction = new AccountTransaction
                {
                    TransactionDate = DateTime.UtcNow,
                    DocumentType = originalTransaction.DocumentType + " - Reversal",
                    ReferenceNo = originalTransaction.ReferenceNo,
                    AccountID = originalTransaction.AccountID,
                    TotalAmount = originalTransaction.TotalAmount,
                    CurrencyCode = originalTransaction.CurrencyCode,
                    ExchangeRate = originalTransaction.ExchangeRate,
                    YearCode = originalTransaction.YearCode,
                    AccountingStatus = "Posted",
                    Status = "Reversed",
                    CreatedDate = DateTime.UtcNow,
                    branchId = originalTransaction.branchId
                };

                _context.AccountTransactions.Add(reverseTransaction);
                await _context.SaveChangesAsync();

                var reverseDetails = new List<AccountTransactionDetail>();

                // Reverse each detail line: swap Debit/Credit
                foreach (var detail in originalTransaction.AccountTransactionDetails)
                {
                    reverseDetails.Add(new AccountTransactionDetail
                    {
                        TransactionId = reverseTransaction.Id,
                        AccountID = detail.AccountID,
                        Debit = detail.Credit,
                        Credit = detail.Debit,
                        BaseDebit = detail.BaseCredit,
                        BaseCredit = detail.BaseDebit,
                        Narration = $"Reversal of Transaction {originalTransaction.Id}: {detail.Narration}",
                        branchID = detail.branchID,
                        CostCenterID = detail.CostCenterID,
                        AllocationAmount = detail.AllocationAmount
                    });
                }

                await _context.AccountTransactionDetails.AddRangeAsync(reverseDetails);
                await _context.SaveChangesAsync();

                await dbTransaction.CommitAsync();

                return reverseTransaction.Id;
            }
            catch
            {
                await dbTransaction.RollbackAsync();
                throw;
            }
        }

        public Task<AccountTransaction> GetTransactionByIdAsync(long transactionId)
        {
            throw new NotImplementedException();
        }

        public Task ValidateBalancedAsync(List<AccountTransactionDetail> details)
        {
            if (details == null || !details.Any())
                throw new ArgumentException("Transaction details cannot be empty.");

            decimal totalDebit = details.Sum(d => d.Debit);
            decimal totalCredit = details.Sum(d => d.Credit);

            if (totalDebit != totalCredit)
                throw new InvalidOperationException(
                    $"Transaction is not balanced. Total Debit: {totalDebit}, Total Credit: {totalCredit}"
                );

            return Task.CompletedTask;
        }

        public async Task ValidateFinancialYearAsync(string yearCode, DateTime transactionDate)
        {
            if (string.IsNullOrWhiteSpace(yearCode))
                throw new ArgumentException("Year code cannot be empty.");

            // Fetch the financial year from DB
            var financialYear = await _context.FinancialYears
                .FirstOrDefaultAsync(fy => fy.Code == yearCode);

            if (financialYear == null)
                throw new InvalidOperationException($"Financial year '{yearCode}' not found.");

            if (transactionDate < financialYear.FinStartDate || transactionDate > financialYear.FinEndDate)
                throw new InvalidOperationException(
                    $"Transaction date {transactionDate:yyyy-MM-dd} is outside the financial year {financialYear.FinStartDate:yyyy-MM-dd} to {financialYear.FinEndDate:yyyy-MM-dd}."
                );
        }
    }
}
