using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SmartFleet.Data;
using SmartFleet.Data.Models;

namespace SmartFleetManager.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AccountPostingController : ControllerBase
    {
        private readonly AppDbContext _context;
        private readonly ILogger<AccountPostingController> _logger;

        public AccountPostingController(AppDbContext context, ILogger<AccountPostingController> logger)
        {
            _context = context;
            _logger = logger;
        }

        // GET: api/<BranchController>
        [HttpGet]
        public async Task<ActionResult<IEnumerable<AccountPostingSettings>>> GetAccountPosting()
        {
            _logger.LogInformation("Fetching all account posting settings from database.");
            try
            {
                var accountPostingSettings = await _context.accountPostingSettings.ToListAsync();
                _logger.LogInformation("Fetched {Count} account posting settings.", accountPostingSettings.Count);
                return Ok(accountPostingSettings);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error occurred while fetching account posting settings.");
                return StatusCode(500, "An error occurred while retrieving data.");
            }
        }

        // GET api/<BranchController>/5
        [HttpGet("{id}")]
        public async Task<ActionResult<AccountPostingSettings>> GetAccountPosting(int id)
        {
            _logger.LogInformation("Fetching Account Posting with ID {Id}.", id);
            try
            {
                var company = await _context.accountPostingSettings.FindAsync(id);

                if (company == null)
                {
                    _logger.LogWarning("Account Posting with ID {Id} not found.", id);
                    return NotFound();
                }

                return Ok(company);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error occurred while fetching Account Posting with ID {Id}.", id);
                return StatusCode(500, "An error occurred while retrieving the account posting.");
            }
        }

        // POST api/<BrachLocation>
        [HttpPost]
        public async Task<ActionResult<AccountPostingSettings>> PostBranch(AccountPostingSettings postingSettings)
        {
            _logger.LogInformation("Creating a new posting account.");
            try
            {
                _context.accountPostingSettings.Add(postingSettings);
                await _context.SaveChangesAsync();

                _logger.LogInformation("Account Posting created with ID {Id}.", postingSettings.Id);
                return CreatedAtAction(nameof(GetAccountPosting), new { id = postingSettings.Id }, postingSettings);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error occurred while creating a new Branch.");
                return StatusCode(500, "An error occurred while creating the Branch.");
            }
        }
    }
}
