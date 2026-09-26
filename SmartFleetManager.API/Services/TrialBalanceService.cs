using Microsoft.EntityFrameworkCore;
using SmartFleet.Data;
using SmartFleetManager.API.Interfaces;
using SmartFleetManager.API.Models;

namespace SmartFleetManager.API.Services
{
    public class TrialBalanceService : ITrialBalanceService
    {
        private readonly AppDbContext _context;

        public TrialBalanceService(AppDbContext context)
        {
            _context = context;
        }

        public async Task<List<TrialBalanceGroupResult>> GetTrialBalanceAsync(TrialBalanceReportFilterDTO filterDTO)
        {
            var financialYear = await _context.FinancialYears
                .FirstOrDefaultAsync(p => p.Code == filterDTO.FinancialYearCode);

            if (financialYear == null)
                throw new KeyNotFoundException("Invalid Financial Year");

            var trialBalance = await (
                from a in _context.AccountMasters.AsNoTracking()
                join d in _context.AccountTransactionDetails.AsNoTracking()
                    on a.AccountID equals d.AccountID into ad
                from d in ad.DefaultIfEmpty()
                join h in _context.AccountTransactions.AsNoTracking()
                    on d.TransactionId equals h.Id into dh
                from h in dh.DefaultIfEmpty()
                where h == null ||
                      (h.YearCode == filterDTO.FinancialYearCode &&
                       h.AccountingStatus == "Posted")
                group new { d, a } by new
                {
                    a.AccountID,
                    a.AccountCode,
                    a.AccountName,
                    a.AccountGroupCode,
                    a.GroupName
                }
                into g
                select new TrialBalanceReportResult
                {
                    AccountID = g.Key.AccountID,
                    AccountCode = g.Key.AccountCode,
                    AccountName = g.Key.AccountName,
                    GroupId = g.Key.AccountGroupCode,
                    GroupName = g.Key.GroupName,
                    DebitAmt = g.Sum(x => x.d != null ? x.d.BaseDebit : 0),
                    CreditAmt = g.Sum(x => x.d != null ? x.d.BaseCredit : 0)
                }
            )
            .OrderBy(x => x.AccountCode)
            .ToListAsync();

            if (!filterDTO.IsIncludeZeroBalanceAcc)
            {
                trialBalance = trialBalance
                    .Where(x => x.DebitAmt != 0 || x.CreditAmt != 0)
                    .ToList();
            }

            if (filterDTO.IsShowGroupWise)
            {
                return trialBalance
                    .GroupBy(x => new { x.GroupId, x.GroupName })
                    .Select(g => new TrialBalanceGroupResult
                    {
                        GroupId = g.Key.GroupId,
                        GroupName = g.Key.GroupName,
                        TotalDebit = g.Sum(x => x.DebitAmt),
                        TotalCredit = g.Sum(x => x.CreditAmt),
                        Accounts = g.OrderBy(x => x.AccountCode).ToList()
                    })
                    .OrderBy(x => x.GroupName)
                    .ToList();
            }

            return new List<TrialBalanceGroupResult>
            {
                new TrialBalanceGroupResult
                {
                    GroupId = string.Empty,
                    GroupName = "All Accounts",
                    TotalDebit = trialBalance.Sum(x => x.DebitAmt),
                    TotalCredit = trialBalance.Sum(x => x.CreditAmt),
                    Accounts = trialBalance.OrderBy(x => x.AccountCode).ToList()
                }
            };
        }
    }
}
