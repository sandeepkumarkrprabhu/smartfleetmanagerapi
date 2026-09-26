using Microsoft.EntityFrameworkCore;
using SmartFleet.Data;
using SmartFleetManager.API.Interfaces;
using SmartFleetManager.API.Models;

namespace SmartFleetManager.API.Services
{
    public class CashBookService : ICashBookService
    {
        private readonly AppDbContext _context;

        public CashBookService(AppDbContext context)
        {
            _context = context;
        }

        public async Task<CashBookResultDto> GetCashBookAsync(CashBookFilterDto filter)
        {
            if (filter.FromDate.Date > filter.ToDate.Date)
            {
                throw new ArgumentException("FromDate cannot be greater than ToDate.");
            }

            var fromDate = filter.FromDate.Date;
            var toDate = filter.ToDate.Date;
            var toDateExclusive = toDate.AddDays(1);

            var account = await _context.AccountMasters
                .AsNoTracking()
                .Where(a => a.AccountID == filter.AccountId)
                .Select(a => new
                {
                    a.AccountID,
                    a.AccountCode,
                    a.AccountName
                })
                .SingleOrDefaultAsync();

            if (account == null)
            {
                throw new KeyNotFoundException($"Account {filter.AccountId} was not found.");
            }

            var openingQuery = _context.AccountTransactionDetails
                .AsNoTracking()
                .Where(d =>
                    d.AccountID == filter.AccountId &&
                    d.AccountTransaction.TransactionDate < fromDate);

            openingQuery = ApplyCommonFilters(openingQuery, filter);

            var openingBalance = filter.IncludeOpeningBalance
                ? await openingQuery.SumAsync(d => d.Debit - d.Credit)
                : 0m;

            var entriesQuery = _context.AccountTransactionDetails
                .AsNoTracking()
                .Where(d =>
                    d.AccountID == filter.AccountId &&
                    d.AccountTransaction.TransactionDate >= fromDate &&
                    d.AccountTransaction.TransactionDate < toDateExclusive);

            entriesQuery = ApplyCommonFilters(entriesQuery, filter);

            var details = await entriesQuery
                .OrderBy(d => d.AccountTransaction.TransactionDate)
                .ThenBy(d => d.TransactionId)
                .ThenBy(d => d.Id)
                .Select(d => new
                {
                    d.Id,
                    d.TransactionId,
                    Date = d.AccountTransaction.TransactionDate,
                    d.AccountTransaction.DocumentType,
                    d.AccountTransaction.ReferenceNo,
                    d.Narration,
                    d.Debit,
                    d.Credit
                })
                .ToListAsync();

            var entries = details
                .GroupBy(d => new
                {
                    d.TransactionId,
                    d.Date,
                    d.DocumentType,
                    d.ReferenceNo
                })
                .OrderBy(g => g.Key.Date)
                .ThenBy(g => g.Key.TransactionId)
                .Select(g => new CashBookEntryDto
                {
                    Date = g.Key.Date,
                    DocumentType = g.Key.DocumentType ?? string.Empty,
                    ReferenceNo = g.Key.ReferenceNo ?? string.Empty,
                    Description = string.Join("; ",
                        g.Select(x => x.Narration)
                            .Where(x => !string.IsNullOrWhiteSpace(x))
                            .Distinct()),
                    Receipt = g.Sum(x => x.Debit),
                    Payment = g.Sum(x => x.Credit),
                    TransactionId = g.Key.TransactionId
                })
                .ToList();

            var runningBalance = openingBalance;

            foreach (var entry in entries)
            {
                runningBalance += entry.Receipt - entry.Payment;
                entry.Balance = runningBalance;
            }

            var totalReceipt = entries.Sum(e => e.Receipt);
            var totalPayment = entries.Sum(e => e.Payment);

            return new CashBookResultDto
            {
                AccountId = account.AccountID,
                AccountCode = account.AccountCode,
                AccountName = account.AccountName,
                FromDate = fromDate,
                ToDate = toDate,
                OpeningBalance = openingBalance,
                Entries = entries,
                TotalReceipt = totalReceipt,
                TotalPayment = totalPayment,
                ClosingBalance = runningBalance
            };
        }

        private static IQueryable<SmartFleet.Data.Models.AccountTransactionDetail> ApplyCommonFilters(
            IQueryable<SmartFleet.Data.Models.AccountTransactionDetail> query,
            CashBookFilterDto filter)
        {
            if (filter.BranchId.HasValue)
            {
                query = query.Where(d =>
                    d.AccountTransaction.branchId == filter.BranchId.Value);
            }

            if (!string.IsNullOrWhiteSpace(filter.YearCode))
            {
                query = query.Where(d =>
                    d.AccountTransaction.YearCode == filter.YearCode);
            }

            if (!string.IsNullOrWhiteSpace(filter.DocumentType))
            {
                query = query.Where(d =>
                    d.AccountTransaction.DocumentType == filter.DocumentType);
            }

            if (!string.IsNullOrWhiteSpace(filter.ReferenceNo))
            {
                query = query.Where(d =>
                    d.AccountTransaction.ReferenceNo.Contains(filter.ReferenceNo));
            }

            return query;
        }
    }
}
