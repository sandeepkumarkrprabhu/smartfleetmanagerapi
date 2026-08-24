using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SmartFleet.Data;
using SmartFleetManager.API.Models;

namespace SmartFleetManager.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AccountTransactionController : ControllerBase
    {
        private readonly AppDbContext _context;
        private readonly ILogger<AccountTransactionController> _logger;

        public AccountTransactionController(AppDbContext context, ILogger<AccountTransactionController> logger)
        {
            _context = context;
            _logger = logger;
        }

        //POST: api/<AccountTransactionController>
        [HttpPost("AccountStatement")]
        public async Task<IActionResult> GetStatement([FromBody] AccountStatmentFilterDTO filter)
        {
            var transactions = await _context.AccountTransactionDetails
                .Where(d => d.AccountID == filter.AccountId &&
                            d.AccountTransaction.TransactionDate >= filter.startDate &&
                            d.AccountTransaction.TransactionDate <= filter.endDate)
                .OrderBy(d => d.AccountTransaction.TransactionDate)
                .Select(d => new AccountStatementResult
                {
                    Date = d.AccountTransaction.TransactionDate,
                    ReferenceNo = d.AccountTransaction.ReferenceNo,
                    TransactionType = d.AccountTransaction.DocumentType,
                    Description = d.Narration,
                    Debit = d.Debit,
                    Credit = d.Credit
                })
                .ToListAsync();

            decimal runningBalance = 0;

            foreach (var item in transactions)
            {
                runningBalance += item.Debit - item.Credit;
                item.Balance = runningBalance;
            }

            return Ok(transactions);
        }

        // GET: api/<AccountTransactionController>
        [HttpGet]
        public async Task<ActionResult<List<TrialBalanceGroupResult>>> GetTrialBalanceReport([FromQuery] TrialBalanceReportFilterDTO filterDTO)
        {
            var financialYear = await _context.FinancialYears
                .FirstOrDefaultAsync(p => p.Code == filterDTO.FinancialYearCode);

            if (financialYear == null)
                return NotFound("Invalid Financial Year");

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

            // Remove zero balance accounts if required
            if (!filterDTO.IsIncludeZeroBalanceAcc)
            {
                trialBalance = trialBalance
                    .Where(x => x.DebitAmt != 0 || x.CreditAmt != 0)
                    .ToList();
            }

            List<TrialBalanceGroupResult> result;

            // GROUPED RESULT
            if (filterDTO.IsShowGroupWise)
            {
                result = trialBalance
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
            else
            {
                // SINGLE DEFAULT GROUP
                result = new List<TrialBalanceGroupResult>
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

            return Ok(result);
        }
    }
}
