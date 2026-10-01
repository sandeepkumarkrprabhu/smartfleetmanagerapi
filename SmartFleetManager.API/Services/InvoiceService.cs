using Microsoft.EntityFrameworkCore;
using SmartFleet.Data;
using SmartFleet.Data.Models;
using SmartFleetManager.API.Interfaces;
using SmartFleetManager.API.Models;

namespace SmartFleetManager.API.Services
{
    public class InvoiceService : IInvoiceService
    {
        private readonly AppDbContext _context;
        private readonly IAccountTransactionService _accountTransactionService;

        public InvoiceService(AppDbContext context, IAccountTransactionService accountTransactionService)
        {
            _context = context;
            _accountTransactionService = accountTransactionService;
        }

        public async Task<IEnumerable<CustomerInvoice>> GetCustomerBillsAsync(string yearCode)
        {
            var raw = await (
                from b in _context.BillTransaction
                join bd in _context.BillItemDetails on b.Id equals bd.BTId
                join t in _context.TripTransaction on bd.TripId equals t.Id
                join c in _context.Customers on b.CustomerId equals c.Id
                where b.IsDeleted != true && b.status != "" && b.YearCode == yearCode
                select new
                {
                    b.Id, b.RMTInvoiceNo, b.Code, b.BillDate, b.CustomerId,
                    c.Name, c.Address, c.Phone, c.Email, c.GSTNo, c.PanNo,
                    b.status, b.GrandAmount, t.ReferenceNo
                }).ToListAsync();

            return raw.GroupBy(x => new
            {
                x.Id, x.RMTInvoiceNo, x.Code, x.BillDate, x.CustomerId,
                x.Name, x.Address, x.Phone, x.Email, x.GSTNo, x.PanNo,
                x.status, x.GrandAmount
            }).Select(g => new CustomerInvoice
            {
                Id = g.Key.Id, RMTInvoiceNo = g.Key.RMTInvoiceNo, InvoiceNo = g.Key.Code,
                InvoiceDate = g.Key.BillDate, CustomerId = g.Key.CustomerId.ToString(),
                CustomerName = g.Key.Name, CustomerAddress = g.Key.Address,
                CustomerPhoneNo = g.Key.Phone, CustomerEmail = g.Key.Email,
                CustomerGST = g.Key.GSTNo, CustomerPanNo = g.Key.PanNo,
                status = g.Key.status, TotalAmount = g.Key.GrandAmount,
                LrNo = string.Join(",", g.Select(x => x.ReferenceNo)
                    .Where(x => !string.IsNullOrWhiteSpace(x)).Distinct())
            }).OrderByDescending(x => x.InvoiceDate)
              .ThenByDescending(x => x.RMTInvoiceNo).ToList();
        }

        public async Task<IEnumerable<MonthlyInvoiceSummaryPrint>> GetCustomerInvoiceSummaryPrintAsync(int id)
        {
            var companyDetail = await _context.Companies.AsNoTracking().FirstOrDefaultAsync();
            var invoices = await (from b in _context.BillTransaction
                join bd in _context.BillItemDetails on b.Id equals bd.BTId
                join t in _context.TripTransaction on bd.TripId equals t.Id
                join v in _context.Vehilces on t.VehicleId equals v.Id
                join bc in _context.Customers on b.CustomerId equals bc.Id
                join l in _context.Locations on t.OriginId equals l.Id
                where b.Id == id
                orderby t.LRDate
                select new MonthlyInvoiceSummaryPrint
                {
                    CompanyName = companyDetail.Name ?? "", CompanyAddress = companyDetail.Address,
                    CompanyEmail = companyDetail.EmailId, CompanyPhoneNo = companyDetail.ContactPhone,
                    CompanyGST = companyDetail.GSTNo, CompanyPAN = companyDetail.PANNo,
                    CompanySACNo = companyDetail.SACNo, BillNo = b.RMTInvoiceNo.ToString(),
                    BillDate = b.BillDate, BillingPeriod = ($"{b.BIllFromDate:dd/MM/yyyy} - {b.BillToDate:dd/MM/yyyy}"),
                    BillAmount = b.TotalAmount, CustomerName = bc.Name ?? "", CustomerAddress = bc.Address,
                    CustomerPhoneNo = bc.Phone, CustomerEmail = bc.Email, CustomerGST = bc.GSTNo,
                    CustomerPAN = bc.PanNo, InvoiceTemplateName = bc.InvoiceTemplateName ?? "",
                    InvoiceNo = (from tc in _context.TripConsigneeDetails where tc.TripTransactionId == t.Id select tc.InvoiceNo).FirstOrDefault() ?? "",
                    InvoiceDate = t.LRDate, LoadingPoint = l.Name,
                    OffLoadingPoint = string.Join("/ ", from tc in _context.TripConsigneeDetails
                        join ol in _context.Locations on tc.DestinationId equals ol.Id
                        where tc.TripTransactionId == t.Id select ol.Name),
                    allInvoiceFreights = string.Join(", ", _context.TripConsigneeDetails.Where(tc => tc.TripTransactionId == t.Id).Select(tc => tc.FreightCharges)),
                    DeliveryCharges = t.AdditionalCost, LoadingUnloadingCharges = t.LoadingCost, totalAmount = t.TotalCost,
                    ConsigneeName = string.Join("/ ", from tc in _context.TripConsigneeDetails
                        join c in _context.Customers on tc.ToConsigneeId equals c.Id
                        where tc.TripTransactionId == t.Id select c.Name),
                    LrNo = string.Join("/ ", _context.TripConsigneeDetails.Where(tc => tc.TripTransactionId == t.Id).Select(tc => tc.LRNo)),
                    LrDate = t.LRDate, VehicleNo = v.Name, VehicleType = v.VehicleType, KMS = t.Kms ?? 0,
                    mtnNo = t.MtnNo ?? 0, goodsValue = t.GoodsValue ?? 0, haltingCharges = t.HaltingCharges ?? 0,
                    FreightCharges = t.FrieghtCharges ?? 0, Remarks = t.Notes ?? "", IsSalesReturn = t.IsSalesReturnTrip
                }).ToListAsync();
            return invoices.Select((x, index) => { x.SlNo = index + 1; return x; }).ToList();
        }

        public async Task<object?> GetOutstandingInvoicesAsync(int id)
        {
            return await (from bt in _context.BillTransaction
                join c in _context.Customers on bt.CustomerId equals c.Id
                where c.AccountId == id && bt.status == "Billed" && bt.IsDeleted != true
                orderby bt.RMTInvoiceNo
                select new { bt.Id, bt.RMTInvoiceNo, bt.TotalAmount, bt.CustomerId, c.AccountId, c.Name, bt.BillDate }).ToListAsync();
        }

        public async Task<object?> GetVendorOutstandingInvoiceAsync(int id)
        {
            return await (from bt in _context.BillTransaction
                join bi in _context.BillItemDetails on bt.Id equals bi.BTId
                join t in _context.TripTransaction on bi.TripId equals t.Id
                join v in _context.Vendors on t.VendorId equals v.Id
                where v.AccountId == id && bt.status == "Billed" && bt.IsDeleted != true && t.VendorRentCharges > 0
                orderby bt.RMTInvoiceNo
                select new { bt.Id, bt.RMTInvoiceNo, TotalAmount = t.VendorRentCharges, bt.CustomerId, v.AccountId, v.Name, bt.BillDate }).ToListAsync();
        }

        public async Task<CustomerInvoice?> GetCustomerInvoiceAsync(int id)
        {
            var company = await _context.Companies.AsNoTracking().FirstOrDefaultAsync();
            var header = await (from b in _context.BillTransaction
                join c in _context.Customers on b.CustomerId equals c.Id
                where b.Id == id
                select new { b.Id, b.Code, b.RMTInvoiceNo, b.BillDate, b.TotalAmount, b.status, b.TaxPer, b.TotalTaxAmount, b.GrandAmount,
                    CustomerId = c.Id, CustomerName = c.Name, CustomerAddress = c.Address, CustomerPhoneNo = c.Phone,
                    CustomerEmail = c.Email, CustomerGST = c.GSTNo, CustomerPan = c.PanNo, CustomerTemplate = c.InvoiceTemplateName }).FirstOrDefaultAsync();
            if (header == null) return null;

            var details = await (from bd in _context.BillItemDetails
                join t in _context.TripTransaction on bd.TripId equals t.Id
                join v in _context.Vehilces on t.VehicleId equals v.Id
                join o in _context.Locations on bd.OriginId equals o.Id
                join d in _context.Locations on bd.DestinationId equals d.Id
                where bd.BTId == id
                orderby t.LRDate 
                select new CustomerInvoiceDetail
                {
                    LRDate = t.LRDate, FromCustomerName = t.FromCustomer.Name ?? "", ToCustomerName = t.ToCustomer.Name ?? "",
                    FromStockistName = t.FromStockist.Name ?? "", Origin = o.Name, Destination = d.Name, LRNo = t.ReferenceNo ?? "",
                    InvoiceNo = t.InvoiceNo ?? "", KMS = t.Kms ?? 0, GoodsValue = t.GoodsValue ?? 0, Freight = t.FrieghtCharges ?? 0,
                    haltingCharges = t.HaltingCharges ?? 0, handlingCharges = t.HandlingCharges ?? 0, LoadingCharges = t.LoadingCost,
                    LrCharges = t.LRCharges ?? 0, EstiamteCost = t.TotalCost, TripId = bd.TripId, VehicleId = bd.VehicleId,
                    VehicleType = v.VehicleType, DriverId = bd.EmployeeId, Route = bd.Route, TripCode = t.Code, VehicleNo = v.Name,
                    remarks = t.Notes ?? "", IsSalesReturn = t.IsSalesReturnTrip,
                    Description = string.Join(", ", _context.TripConsigneeDetails.Where(tc => tc.TripTransactionId == t.Id)
                        .Join(_context.Products, tc => tc.ProductId, p => p.Id, (tc, p) => p.Name).ToList())
                }).ToListAsync();

            var consignee = await (from bd in _context.BillItemDetails
                join t in _context.TripTransaction on bd.TripId equals t.Id
                join c in _context.TripConsigneeDetails on bd.TripId equals c.TripTransactionId
                join d in _context.Locations on c.DestinationId equals d.Id
                join cu in _context.Customers on c.ToConsigneeId equals cu.Id
                where bd.BTId == id
                select new CustomerInvoiceConsigneeDetails
                {
                    CustomerName = cu.Name, LocationName = d.Name, LRNo = c.LRNo ?? "",
                    invoiceNo = c.InvoiceNo ?? "", GoodsValue = c.GoodsValue ?? 0
                }).ToListAsync();

            return new CustomerInvoice
            {
                CompanyName = company?.Name, CompanyAddress = company?.Address, CompanyPhoneNo = company?.ContactPhone,
                CompanyEmail = company?.EmailId, CompanyGst = company?.GSTNo, CompanyPan = company?.PANNo, CompanySac = company?.SACNo,
                InvoiceNo = header.Code, RMTInvoiceNo = header.RMTInvoiceNo, InvoiceDate = header.BillDate,
                CustomerId = header.CustomerId.ToString(), CustomerName = header.CustomerName, CustomerAddress = header.CustomerAddress,
                CustomerPhoneNo = header.CustomerPhoneNo, CustomerEmail = header.CustomerEmail, CustomerGST = header.CustomerGST,
                CustomerPanNo = header.CustomerPan, InvoiceTemplateName = header.CustomerTemplate, TotalAmount = header.TotalAmount,
                TaxPer = header.TaxPer, TotalTax = header.TotalTaxAmount, GrandAmount = header.GrandAmount, status = header.status,
                LrNo = string.Join(", ", details.Select(x => x.LRNo).Where(x => !string.IsNullOrWhiteSpace(x)).Distinct()),
                LRDate = details.First().LRDate, isSalesReturn = details.FirstOrDefault()?.IsSalesReturn ?? false,
                Details = details, ConsigneeDetails = consignee
            };
        }

        public async Task<IEnumerable<CustomerInvoiceGSTSummaryResult>> GetInvoiceGSTReportAsync(InvoiceReportFilterDto filter)
        {
            return (await (from b in _context.BillTransaction join c in _context.Customers on b.CustomerId equals c.Id
                where b.BillDate >= filter.FromDate && b.BillDate <= filter.ToDate && !b.IsDeleted && !string.IsNullOrEmpty(b.status)
                select new CustomerInvoiceGSTSummaryResult
                {
                    BillDate = b.BillDate, BillNo = b.RMTInvoiceNo, CustomerID = b.CustomerId, CustomerName = c.Name,
                    Place = c.Address, GSTNo = c.GSTNo, Amount = b.TotalAmount, IGST = b.IGST, SGST = b.SGST, CGST = b.CGST, Total = b.GrandAmount
                }).ToListAsync()).OrderBy(x => x.BillNo).Select((x, i) => { x.SlNo = i + 1; return x; }).ToList();
        }

        public async Task<IEnumerable<CustomerInvoiceSummary>> GetCustomerInvoiceSummaryReportAsync(InvoiceReportFilterDto filter)
        {
            var query = from b in _context.BillTransaction
                join bd in _context.BillItemDetails on b.Id equals bd.BTId
                join t in _context.TripTransaction on bd.TripId equals t.Id
                join c in _context.Customers on b.CustomerId equals c.Id
                where !b.IsDeleted && !string.IsNullOrEmpty(b.status)
                select new { b.Id, c.Name, b.status, b.RMTInvoiceNo, t.ReferenceNo, b.BillDate, b.GrandAmount, TripLR = t.ReferenceNo };
            if (!string.IsNullOrWhiteSpace(filter.Customer)) query = query.Where(x => x.Name.Contains(filter.Customer));
            if (!string.IsNullOrWhiteSpace(filter.Status)) query = query.Where(x => x.status.Contains(filter.Status));
            if (!string.IsNullOrWhiteSpace(filter.InvoiceNo)) query = query.Where(x => x.RMTInvoiceNo.ToString().Contains(filter.InvoiceNo));
            if (!string.IsNullOrWhiteSpace(filter.LrNo)) query = query.Where(x => x.ReferenceNo.Contains(filter.LrNo));
            if (filter.FromDate.HasValue) query = query.Where(x => x.BillDate >= filter.FromDate.Value);
            if (filter.ToDate.HasValue) query = query.Where(x => x.BillDate <= filter.ToDate.Value);

            var rows = await query.GroupBy(x => new { x.Id, x.RMTInvoiceNo, x.BillDate, x.GrandAmount })
                .Select(g => new { g.Key.RMTInvoiceNo, g.Key.BillDate, g.Key.GrandAmount, LRList = g.Select(x => x.TripLR) }).ToListAsync();
            return rows.OrderBy(x => x.RMTInvoiceNo).Select((x, i) => new CustomerInvoiceSummary
            {
                SlNo = i + 1, BillNo = x.RMTInvoiceNo, BillDate = x.BillDate, GrandTotal = x.GrandAmount,
                LRNo = string.Join(", ", x.LRList.Where(lr => !string.IsNullOrWhiteSpace(lr)).Distinct())
            }).ToList();
        }

        public async Task<IEnumerable<CustomerInvoice>> GetInvoiceReportAsync(InvoiceReportFilterDto filter)
        {
            var query = from b in _context.BillTransaction
                join bd in _context.BillItemDetails on b.Id equals bd.BTId
                join t in _context.TripTransaction on bd.TripId equals t.Id
                join c in _context.Customers on b.CustomerId equals c.Id
                join v in _context.Vehilces on t.VehicleId equals v.Id
                join d in _context.Locations on bd.DestinationId equals d.Id
                join tc0 in _context.TripConsigneeDetails on t.Id equals tc0.Id into tcGroup
                from tc in tcGroup.DefaultIfEmpty()
                join cc0 in _context.Customers on tc.ToConsigneeId equals cc0.Id into ccGroup
                from cc in ccGroup.DefaultIfEmpty()
                where b.IsDeleted != true && !string.IsNullOrEmpty(b.status) && t.Status != "Cancelled"
                select new { b.Id, InvoiceNo = b.RMTInvoiceNo, b.BillDate, b.CustomerId, CustomerName = c.Name,
                    CustomerAddress = c.Address, CustomerPhoneNo = c.Phone, CustomerEmail = c.Email, CustomerGST = c.GSTNo,
                    CustomerPanNo = c.PanNo, InvoiceTemplateName = c.InvoiceTemplateName, LrNo = t.ReferenceNo, t.LRDate,
                    t.StartDate, t.ExpectedDeliveryDate, t.ActualDeliveryDate, b.status, t.Notes, t.LoadingCost,
                    CommissionAmount = t.CommissionAmt, AdditionalAmount = t.AdditionalCost, TotalAmount = t.TotalCost,
                    VehicleNo = v.Name, FreightCharges = t.FrieghtCharges, b.GrandAmount,
                    ConsigneeName = cc != null ? cc.Name : "", LocationName = d.Name };
            if (!string.IsNullOrWhiteSpace(filter.Customer)) query = query.Where(x => x.CustomerName.Contains(filter.Customer));
            if (!string.IsNullOrWhiteSpace(filter.Status)) query = query.Where(x => x.status.Contains(filter.Status));
            if (!string.IsNullOrWhiteSpace(filter.InvoiceNo)) query = query.Where(x => x.InvoiceNo.ToString().Contains(filter.InvoiceNo));
            if (!string.IsNullOrWhiteSpace(filter.LrNo)) query = query.Where(x => x.LrNo.Contains(filter.LrNo));
            if (filter.FromDate.HasValue) query = query.Where(x => x.BillDate >= filter.FromDate.Value);
            if (filter.ToDate.HasValue) query = query.Where(x => x.BillDate <= filter.ToDate.Value);

            var rows = await query.ToListAsync();
            return rows.GroupBy(x => x.Id).Select(g => new CustomerInvoice
            {
                Id = g.Key, InvoiceNo = g.First().InvoiceNo.ToString(), RMTInvoiceNo = g.First().InvoiceNo,
                InvoiceDate = g.First().BillDate, CustomerId = g.First().CustomerId.ToString(), CustomerName = g.First().CustomerName,
                CustomerAddress = g.First().CustomerAddress, CustomerPhoneNo = g.First().CustomerPhoneNo, CustomerEmail = g.First().CustomerEmail,
                CustomerGST = g.First().CustomerGST, CustomerPanNo = g.First().CustomerPanNo, InvoiceTemplateName = g.First().InvoiceTemplateName ?? "",
                LrNo = g.First().LrNo ?? "", LRDate = g.First().LRDate, StartDate = g.First().StartDate,
                ExpectedDeliveryDate = g.First().ExpectedDeliveryDate, ActualDeliveryDate = g.First().ActualDeliveryDate ?? DateTime.MinValue,
                status = g.First().status, Notes = g.First().Notes ?? "", LoadingCost = g.First().LoadingCost,
                CommissionAmount = g.First().CommissionAmount, AdditionalAmount = g.First().AdditionalAmount, TotalAmount = g.First().TotalAmount,
                VehicleNo = g.First().VehicleNo, FreightCharges = g.First().FreightCharges ?? 0, TaxPer = 0, TotalTax = 0,
                GrandAmount = g.First().GrandAmount,
                ConsigneeName = string.Join(", ", g.Select(x => x.ConsigneeName).Where(x => !string.IsNullOrWhiteSpace(x)).Distinct()),
                ToLocationName = string.Join(", ", g.Select(x => x.LocationName).Where(x => !string.IsNullOrWhiteSpace(x)).Distinct())
            }).OrderBy(x => x.RMTInvoiceNo).ToList();
        }

        public async Task<string?> GetCurrentCodeAsync() =>
            await _context.BillTransaction.Where(f => f.IsDeleted != true).OrderByDescending(p => p.Id).Select(s => s.Code).FirstOrDefaultAsync();

        public async Task<Bill?> GetInvoiceDetailAsync(int invoiceNo) =>
            await _context.BillTransaction.Where(p => p.IsDeleted != true && p.RMTInvoiceNo == invoiceNo).FirstOrDefaultAsync();

        public async Task<int> GetCurrentRMTInvoiceNoAsync(string yearCode) =>
            await _context.BillTransaction.Where(f => f.YearCode == yearCode && !f.IsDeleted).MaxAsync(p => (int?)p.RMTInvoiceNo) ?? 0;

        public async Task<Bill?> GetCustomerInvoiceByIdAsync(int id) =>
            await _context.BillTransaction.Include(t => t.ProductDetails).FirstOrDefaultAsync(t => t.Id == id);

        public async Task<List<Bill>> GetCustomerInvoicePendingAsync() =>
            await _context.BillTransaction.Include(t => t.ProductDetails).Where(p => p.status == "Completed" && p.IsDeleted != true).ToListAsync();

        public async Task<IReadOnlyList<Bill>> GetInvoicesForPostingAsync(PostingFilterDTO filter) =>
            await _context.BillTransaction.Where(p => p.BillDate >= filter.StartDate && p.BillDate <= filter.EndDate &&
                p.AccountStatus != "Posted" && p.IsDeleted == false && (p.AccountTransactionId ?? 0) == 0).ToListAsync();

        public async Task<Bill?> GetInvoiceForPostingAsync(int id) =>
            await _context.BillTransaction.Include(t => t.ProductDetails).FirstOrDefaultAsync(t => t.Id == id);

        public async Task<Bill> CreateInvoiceAsync(Bill bill)
        {
            var financialYear = await _context.FinancialYears.Where(p => p.Code == bill.YearCode).FirstOrDefaultAsync();
            if (bill.BillDate < financialYear?.FinStartDate || bill.BillDate > financialYear?.FinEndDate)
                throw new InvalidOperationException("Transaction date must be within the financial year.");

            var billItems = bill.ProductDetails?.ToList();
            bill.ProductDetails = null;
            _context.BillTransaction.Add(bill);
            await _context.SaveChangesAsync();

            if (billItems != null && billItems.Any())
            {
                foreach (var item in billItems) item.BTId = bill.Id;
                await _context.BillItemDetails.AddRangeAsync(billItems);
                await _context.SaveChangesAsync();
            }

            var tripIds = billItems?.Where(p => p.TripId > 0).Select(p => p.TripId).Distinct().ToList();
            if (tripIds != null && tripIds.Any())
            {
                var trips = await _context.TripTransaction.Where(t => tripIds.Contains(t.Id)).ToListAsync();
                trips.ForEach(t => t.BillNo = bill.Id);
                trips.ForEach(t => t.Status = "Billed");
                await _context.SaveChangesAsync();
                await PostInvoiceToAccountsAsync(bill.Id);
            }
            return bill;
        }

        public async Task<Bill?> UpdateInvoiceAsync(int id, Bill bill)
        {
            var financialYear = await _context.FinancialYears.Where(p => p.Code == bill.YearCode).FirstOrDefaultAsync();
            if (bill.BillDate < financialYear?.FinStartDate || bill.BillDate > financialYear?.FinEndDate)
                throw new InvalidOperationException("Transaction date must be within the financial year.");
            if (id != bill.Id) throw new ArgumentException("Invoice ID mismatch");

            if (bill.AccountStatus == "Posted")
            {
                var tx = await _context.AccountTransactions.FirstOrDefaultAsync(t => t.Id == bill.AccountTransactionId);
                if (tx != null)
                {
                    _context.AccountTransactions.Remove(tx);
                    await _context.SaveChangesAsync();
                }
            }

            bill.AccountStatus = "Draft";
            bill.AccountTransactionId = 0;
            _context.Entry(bill).State = EntityState.Modified;
            try
            {
                await _context.SaveChangesAsync();
                await PostInvoiceToAccountsAsync(bill.Id);
                return bill;
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!await InvoiceExistsAsync(id)) return null;
                throw;
            }
        }

        public async Task<bool> DeleteInvoiceAsync(int id)
        {
            var bill = await _context.BillTransaction.FindAsync(id);
            if (bill == null) return false;
            if (bill.AccountStatus == "verified")
                throw new InvalidOperationException($"Invoice is verified to accounts with {bill.AccountTransactionId}. Invoice cannot be cancelled.");

            if ((bill.AccountTransactionId ?? 0) > 0)
            {
                var tx = await _context.AccountTransactions.FirstOrDefaultAsync(t => t.Id == bill.AccountTransactionId);
                if (tx != null)
                {
                    _context.AccountTransactions.Remove(tx);
                    await _context.SaveChangesAsync();
                }
            }

            bill.IsDeleted = true;
            bill.RMTInvoiceNo = 0;
            bill.TotalAmount = 0;
            bill.status = "Deleted";
            var trips = await _context.TripTransaction.Where(t => t.BillNo == id).ToListAsync();
            trips.ForEach(t => t.BillNo = null);
            trips.ForEach(t => t.Status = "Delivered");
            await _context.SaveChangesAsync();
            return true;
        }

        private Task<bool> InvoiceExistsAsync(int id) => _context.BillTransaction.AnyAsync(e => e.Id == id);

        public async Task PostInvoiceToAccountsAsync(int invoiceId)
        {
            var invoice = await _context.BillTransaction.FirstOrDefaultAsync(i => i.Id == invoiceId);
            if (invoice == null) throw new Exception("Invoice not found.");
            if (invoice.AccountStatus == "Posted") throw new Exception("Invoice already posted.");
            var transactionId = await _accountTransactionService.CreateInvoiceTransactionAsync(invoice);
            invoice.AccountTransactionId = Convert.ToInt32(transactionId);
            invoice.AccountStatus = "Posted";
            await _context.SaveChangesAsync();
        }

        public async Task UnpostInvoiceAsync(int invoiceId)
        {
            var invoice = await _context.BillTransaction.FirstOrDefaultAsync(x => x.Id == invoiceId);
            if (invoice == null || invoice.AccountTransactionId == null) throw new Exception("Invoice not posted.");
            await _accountTransactionService.ReverseTransactionAsync(invoice.AccountTransactionId.Value, "Admin");
            invoice.AccountTransactionId = null;
            invoice.status = "NotPosted";
            await _context.SaveChangesAsync();
        }
    }
}