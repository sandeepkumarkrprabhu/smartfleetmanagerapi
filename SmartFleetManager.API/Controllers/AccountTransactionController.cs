using Microsoft.AspNetCore.Mvc;
using SmartFleetManager.API.Interfaces;
using SmartFleetManager.API.Models;

namespace SmartFleetManager.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AccountTransactionController : ControllerBase
    {
        private readonly IAccountStatementService _accountStatementService;
        private readonly ITrialBalanceService _trialBalanceService;

        public AccountTransactionController(
            IAccountStatementService accountStatementService,
            ITrialBalanceService trialBalanceService)
        {
            _accountStatementService = accountStatementService;
            _trialBalanceService = trialBalanceService;
        }

        // POST: api/<AccountTransactionController>/AccountStatement
        [HttpPost("AccountStatement")]
        public async Task<IActionResult> GetStatement([FromBody] AccountStatmentFilterDTO filter)
        {
            var transactions = await _accountStatementService.GetStatementAsync(filter);
            return Ok(transactions);
        }

        // GET: api/<AccountTransactionController>
        [HttpGet]
        public async Task<ActionResult<List<TrialBalanceGroupResult>>> GetTrialBalanceReport(
            [FromQuery] TrialBalanceReportFilterDTO filterDTO)
        {
            try
            {
                var result = await _trialBalanceService.GetTrialBalanceAsync(filterDTO);
                return Ok(result);
            }
            catch (KeyNotFoundException ex)
            {
                return NotFound(ex.Message);
            }
        }
    }
}
