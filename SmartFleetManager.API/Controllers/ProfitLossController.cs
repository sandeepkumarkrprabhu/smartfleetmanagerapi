using Azure.Core;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SmartFleet.Data;
using SmartFleet.Data.Models;
using SmartFleetManager.API.Models;

namespace SmartFleetManager.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProfitLossController : ControllerBase
    {
        private readonly AppDbContext _context;
        private readonly ILogger<ProfitLossController> _logger;

        public ProfitLossController(AppDbContext context, ILogger<ProfitLossController> logger)
        {
            _context = context;
            _logger = logger;
        }

        // GET: api/<AccountController>
        [HttpGet]
        public async Task<ActionResult<IEnumerable<ProfitLossResponse>>> GetProfitLoss([FromQuery] ProfitLossRequestDTO filterDTO)
        {
            _logger.LogInformation("Processing the profit Loss accounts from database.");
            try
            {
                var query = from d in _context.AccountTransactionDetails
                            join h in _context.AccountTransactions
                                on d.TransactionId equals h.Id
                            join a in _context.AccountMasters
                                on d.AccountID equals a.AccountID
                            where h.TransactionDate >= filterDTO.FromDate
                               && h.TransactionDate <= filterDTO.ToDate
                            select new
                            {
                                a.AccountName,
                                a.AccountGroupCode,
                                d.Debit,
                                d.Credit
                            };

                    var income = query
                        .Where(x => x.AccountGroupCode.ToUpper() == "INCOME")
                        .GroupBy(x => x.AccountName)
                        .Select(g => new PLItem
                        {
                            AccountName = g.Key,
                            Amount = g.Sum(x => x.Credit - x.Debit)
                        })
                        .ToList();

                    var expenses = query
                        .Where(x => x.AccountGroupCode.ToUpper() == "EXP")
                        .GroupBy(x => x.AccountName)
                        .Select(g => new PLItem
                        {
                            AccountName = g.Key,
                            Amount = g.Sum(x => x.Debit - x.Credit)
                        })
                        .ToList();

                var totalIncome = income.Sum(x => x.Amount);
                var totalExpense = expenses.Sum(x => x.Amount);

                var response = new ProfitLossResponse
                {
                    Income = income,
                    Expenses = expenses,
                    TotalIncome = totalIncome,
                    TotalExpense = totalExpense,
                    NetProfit = totalIncome - totalExpense
                };
                return Ok(response);

            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error occurred while processing profit Loss account.");
                return StatusCode(500, "An error occurred while processing profit Loss account.");
            }
        }
    }
}
