using Microsoft.EntityFrameworkCore;
using SmartFleet.Data;
using SmartFleet.Utility;
using SmartFleetManager.API.Interfaces;
using SmartFleetManager.API.Models;
using System.Globalization;

namespace SmartFleetManager.API.Services
{
    public class AccountsDashboardService : IAccountsDashboardService
    {
        private readonly AppDbContext _context;

        public AccountsDashboardService(AppDbContext context)
        {
            _context = context;
        }

        public async Task<AccountsDashboardDto> GetDashboardAsync(
            AccountsDashboardFilterDto filter)
        {
            if (filter.FromDate == default)
                throw new ArgumentException("FromDate is required.");

            if (filter.ToDate == default)
                throw new ArgumentException("ToDate is required.");

            var fromDate = filter.FromDate.Date;
            var toDateExclusive = filter.ToDate.Date.AddDays(1);

            if (fromDate >= toDateExclusive)
                throw new ArgumentException("FromDate must be earlier than or equal to ToDate.");

            var balanceQuery =
                from d in _context.AccountTransactionDetails.AsNoTracking()
                join h in _context.AccountTransactions.AsNoTracking()
                    on d.TransactionId equals h.Id
                join a in _context.AccountMasters.AsNoTracking()
                    on d.AccountID equals a.AccountID
                where h.AccountingStatus == "Posted"
                      && h.TransactionDate < toDateExclusive
                      && (filter.BranchId == null || h.branchId == filter.BranchId)
                      && (string.IsNullOrWhiteSpace(filter.YearCode) || h.YearCode == filter.YearCode)
                select new
                {
                    a.AccountType,
                    a.IsCashAccount,
                    a.IsBankAccount,
                    d.BaseDebit,
                    d.BaseCredit
                };

            var balances = await balanceQuery
                .GroupBy(x => new
                {
                    x.AccountType,
                    x.IsCashAccount,
                    x.IsBankAccount
                })
                .Select(g => new
                {
                    g.Key.AccountType,
                    g.Key.IsCashAccount,
                    g.Key.IsBankAccount,
                    Debit = g.Sum(x => x.BaseDebit),
                    Credit = g.Sum(x => x.BaseCredit)
                })
                .ToListAsync();

            var totalAssets = balances
                .Where(x => x.AccountType == FleetConstants.ASSET_TYPE_NAME)
                .Sum(x => x.Debit - x.Credit);

            var totalLiabilities = balances
                .Where(x => x.AccountType == FleetConstants.LIABILITY_TYPE_NAME)
                .Sum(x => x.Credit - x.Debit);

            var cashAndBank = balances
                .Where(x => x.IsCashAccount || x.IsBankAccount)
                .Sum(x => x.Debit - x.Credit);

            var monthlyQuery =
                from d in _context.AccountTransactionDetails.AsNoTracking()
                join h in _context.AccountTransactions.AsNoTracking()
                    on d.TransactionId equals h.Id
                join a in _context.AccountMasters.AsNoTracking()
                    on d.AccountID equals a.AccountID
                where h.AccountingStatus == "Posted"
                      && h.TransactionDate >= fromDate
                      && h.TransactionDate < toDateExclusive
                      && (filter.BranchId == null || h.branchId == filter.BranchId)
                      && (string.IsNullOrWhiteSpace(filter.YearCode) || h.YearCode == filter.YearCode)
                      && (a.AccountType == FleetConstants.INCOME_TYPE_NAME
                          || a.AccountType == FleetConstants.EXPENSE_TYPE_NAME)
                select new
                {
                    h.TransactionDate,
                    a.AccountType,
                    d.BaseDebit,
                    d.BaseCredit
                };

            var monthlyRows = await monthlyQuery
                .GroupBy(x => new
                {
                    x.TransactionDate.Year,
                    x.TransactionDate.Month,
                    x.AccountType
                })
                .Select(g => new
                {
                    g.Key.Year,
                    g.Key.Month,
                    g.Key.AccountType,
                    Debit = g.Sum(x => x.BaseDebit),
                    Credit = g.Sum(x => x.BaseCredit)
                })
                .ToListAsync();

            var monthlyLookup = monthlyRows.ToDictionary(
                x => (x.Year, x.Month, x.AccountType),
                x => x.AccountType == FleetConstants.INCOME_TYPE_NAME
                    ? x.Credit - x.Debit
                    : x.Debit - x.Credit);

            var monthlyFinancials = new List<MonthlyFinancialDto>();

            var monthCursor = new DateTime(fromDate.Year, fromDate.Month, 1);
            var lastMonth = new DateTime(
                filter.ToDate.Year,
                filter.ToDate.Month,
                1);

            while (monthCursor <= lastMonth)
            {
                monthlyLookup.TryGetValue(
                    (monthCursor.Year, monthCursor.Month, FleetConstants.INCOME_TYPE_NAME),
                    out var income);

                monthlyLookup.TryGetValue(
                    (monthCursor.Year, monthCursor.Month, FleetConstants.EXPENSE_TYPE_NAME),
                    out var expense);

                monthlyFinancials.Add(new MonthlyFinancialDto
                {
                    Month = monthCursor.ToString("MMM", CultureInfo.InvariantCulture),
                    Income = income,
                    Expense = expense,
                    ProfitLoss = income - expense
                });

                monthCursor = monthCursor.AddMonths(1);
            }

            return new AccountsDashboardDto
            {
                TotalAssets = totalAssets,
                TotalLiabilities = totalLiabilities,
                CashAndBank = cashAndBank,
                ProfitLoss = monthlyFinancials.Sum(x => x.ProfitLoss),
                MonthlyFinancials = monthlyFinancials
            };
        }
    }
}
