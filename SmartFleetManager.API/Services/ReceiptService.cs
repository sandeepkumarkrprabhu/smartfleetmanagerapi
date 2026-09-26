using Microsoft.EntityFrameworkCore;
using SmartFleet.Data;
using SmartFleet.Data.Models;
using SmartFleetManager.API.Interfaces;
using SmartFleetManager.API.Models;

namespace SmartFleetManager.API.Services
{
    public class ReceiptService : IReceiptService
    {
        private readonly AppDbContext _context;
        private readonly IAccountTransactionService _accountTransactionService;

        public ReceiptService(
            AppDbContext context,
            IAccountTransactionService accountTransactionService)
        {
            _context = context;
            _accountTransactionService = accountTransactionService;
        }

        public async Task<IEnumerable<Receipt>> GetReceiptsAsync(string yearCode)
        {
            return await _context.Receipts
                .Where(f => f.IsCancelled == false && f.YearCode == yearCode)
                .ToListAsync();
        }

        public async Task<IEnumerable<Receipt>> GetReceiptsByYearAsync()
        {
            return await _context.Receipts
                .Where(p => p.ReceiptDate.Year == DateTime.Now.Year)
                .ToListAsync();
        }

        public async Task<Receipt?> GetReceiptByIdAsync(int id)
        {
            return await _context.Receipts
                .Include(t => t.Details)
                .ThenInclude(d => d.InvoiceAllocations)
                .FirstOrDefaultAsync(t => t.Id == id);
        }

        public async Task<Receipt?> GetReceiptForPostingAsync(int id)
        {
            return await _context.Receipts
                .Include(t => t.Details)
                .FirstOrDefaultAsync(t => t.Id == id);
        }

        public async Task<int> GetCurrentCodeAsync(string yearCode)
        {
            return await _context.Receipts
                .Where(f => f.YearCode == yearCode)
                .OrderByDescending(p => p.Id)
                .Select(s => (int?)s.receiptNo)
                .FirstOrDefaultAsync() ?? 0;
        }

        public async Task<IReadOnlyList<Receipt>> GetReceiptsForPostingAsync(PostingFilterDTO filter)
        {
            return await _context.Receipts
                .Include(i => i.Details)
                .Where(p =>
                    p.ReceiptDate >= filter.StartDate.Date &&
                    p.ReceiptDate <= filter.EndDate.Date &&
                    p.AccountStatus != "Posted" &&
                    p.IsCancelled == false)
                .ToListAsync();
        }

        public async Task<Receipt> CreateReceiptAsync(Receipt receipt)
        {
            _context.Receipts.Add(receipt);
            await _context.SaveChangesAsync();

            await _accountTransactionService.CreateReceiptTransactionAsync(receipt);

            return receipt;
        }

        public async Task<Receipt?> UpdateReceiptAsync(int id, Receipt receipt)
        {
            var existingReceipt = await _context.Receipts
                .Include(r => r.Details)
                .ThenInclude(d => d.InvoiceAllocations)
                .FirstOrDefaultAsync(r => r.Id == id);

            if (existingReceipt == null)
                return null;

            if (receipt.AccountStatus == "Posted")
            {
                var accountTransaction = await _context.AccountTransactions
                    .FirstOrDefaultAsync(t => t.Id == receipt.AccountTransactionId);

                if (accountTransaction != null)
                {
                    _context.AccountTransactions.Remove(accountTransaction);
                    await _context.SaveChangesAsync();
                }
            }

            receipt.AccountTransactionId = 0;
            receipt.AccountStatus = "Draft";
            _context.Entry(existingReceipt).CurrentValues.SetValues(receipt);

            if (receipt.Details != null)
            {
                foreach (var existingDetail in existingReceipt.Details.ToList())
                {
                    if (!receipt.Details.Any(d => d.Id == existingDetail.Id))
                    {
                        _context.ReceiptAllocations.RemoveRange(existingDetail.InvoiceAllocations);
                        _context.ReceiptsDetail.Remove(existingDetail);
                    }
                }

                foreach (var detail in receipt.Details)
                {
                    var existingDetail = existingReceipt.Details
                        .FirstOrDefault(d => d.Id == detail.Id);

                    if (existingDetail != null)
                    {
                        _context.Entry(existingDetail).CurrentValues.SetValues(detail);

                        if (detail.InvoiceAllocations != null)
                        {
                            foreach (var existingAllocation in existingDetail.InvoiceAllocations.ToList())
                            {
                                if (!detail.InvoiceAllocations.Any(a => a.Id == existingAllocation.Id))
                                    _context.ReceiptAllocations.Remove(existingAllocation);
                            }

                            foreach (var allocation in detail.InvoiceAllocations)
                            {
                                var existingAllocation = existingDetail.InvoiceAllocations
                                    .FirstOrDefault(a => a.Id == allocation.Id);

                                if (existingAllocation != null)
                                {
                                    _context.Entry(existingAllocation).CurrentValues.SetValues(allocation);
                                }
                                else
                                {
                                    allocation.Id = 0;
                                    allocation.ReceiptDetailId = existingDetail.Id;
                                    existingDetail.InvoiceAllocations.Add(allocation);
                                }
                            }
                        }
                    }
                    else
                    {
                        detail.Id = 0;
                        detail.ReceiptId = existingReceipt.Id;

                        if (detail.InvoiceAllocations != null)
                        {
                            foreach (var allocation in detail.InvoiceAllocations)
                                allocation.Id = 0;
                        }

                        existingReceipt.Details.Add(detail);
                    }
                }
            }

            await _context.SaveChangesAsync();

            var receiptForPosting = await _context.Receipts
                .Include(r => r.Details)
                .FirstOrDefaultAsync(r => r.Id == id);

            if (receiptForPosting != null)
                await _accountTransactionService.CreateReceiptTransactionAsync(receiptForPosting);

            return existingReceipt;
        }

        public async Task<bool> DeleteReceiptAsync(int id)
        {
            var receipt = await _context.Receipts.FindAsync(id);

            if (receipt == null)
                return false;

            if (receipt.AccountStatus == "Posted")
                throw new InvalidOperationException(
                    $"Receipt is posted to accounts with {receipt.AccountTransactionId}. Receipt cannot be cancelled.");

            _context.Receipts.Remove(receipt);
            await _context.SaveChangesAsync();

            return true;
        }

        public async Task PostReceiptToAccountsAsync(int receiptId)
        {
            var receipt = await GetReceiptForPostingAsync(receiptId);

            if (receipt == null)
                throw new KeyNotFoundException($"Receipt with Id {receiptId} not found.");

            if (receipt.AccountStatus == "Posted")
                throw new InvalidOperationException("Receipt is already posted to accounting.");

            await _accountTransactionService.CreateReceiptTransactionAsync(receipt);
        }
    }
}