using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SmartFleet.Data;
using SmartFleet.Data.Models;

namespace SmartFleetManager.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AccountController : ControllerBase
    {
        private readonly AppDbContext _context;
        private readonly ILogger<AccountController> _logger;
        private const string cashAccountCode = "1000";
        private const string bankAccountCode = "1100";
        private const string expenseAccountGroupCode ="EXP";

        public AccountController(AppDbContext context, ILogger<AccountController> logger)
        {
            _context = context;
            _logger = logger;
        }

        // GET: api/<AccountController>
        [HttpGet]
        public async Task<ActionResult<IEnumerable<AccountMaster>>> GetAccounts()
        {
            _logger.LogInformation("Fetching all accounts from database.");
            try
            {
                var accounts = await _context.AccountMasters.ToListAsync();
                _logger.LogInformation("Fetched {Count} accounts.", accounts.Count);
                return Ok(accounts);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error occurred while fetching accounts.");
                return StatusCode(500, "An error occurred while retrieving data.");
            }
        }

        // GET: api/<AccountController>
        [HttpGet("GetJournalAccounts")]
        public async Task<ActionResult<IEnumerable<AccountMaster>>> GetJournalAccounts()
        {
            _logger.LogInformation("Fetching all accounts from database.");
            try
            {
                var accounts = await _context.AccountMasters.Where(f => f.ParentAccountID > 0).ToListAsync();
                _logger.LogInformation("Fetched {Count} accounts.", accounts.Count);
                return Ok(accounts);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error occurred while fetching accounts.");
                return StatusCode(500, "An error occurred while retrieving data.");
            }
        }

        // GET: api/<AccountController>
        [HttpGet("GetRecentTransactions")]
        public async Task<ActionResult<IEnumerable<AccountMaster>>> GetRecentTransactions()
        {
            _logger.LogInformation("Fetching all recent account transactions from database.");
            try
            {

                var accounts = await _context.AccountMasters.Where(f => f.ParentAccountID > 0).ToListAsync();
                _logger.LogInformation("Fetched {Count} accounts.", accounts.Count);
                return Ok(accounts);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error occurred while fetching accounts.");
                return StatusCode(500, "An error occurred while retrieving data.");
            }
        }

        // Accounts for Receipt Entry
        [HttpGet("GetToAccounts")]
        public async Task<ActionResult<IEnumerable<AccountMaster>>> GetToAccounts()
        {
            _logger.LogInformation("Fetching all asset accounts from database.");
            try
            {
                var accounts = await _context.AccountMasters.Where(f => f.IsActive && f.AccountGroupCode.ToLower() == "asset" && f.ParentAccountID > 0).ToListAsync();
                _logger.LogInformation("Fetched {Count} accounts.", accounts.Count);
                return Ok(accounts);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error occurred while fetching accounts.");
                return StatusCode(500, "An error occurred while retrieving data.");
            }
        }

        // Accounts for Receipt Entry
        [HttpGet("GetFromAccounts")]
        public async Task<ActionResult<IEnumerable<AccountMaster>>> GetFromAccounts()
        {
            _logger.LogInformation("Fetching all liability and expense accounts from database.");
            try
            {
                var accounts = await _context.AccountMasters
                    .Where(f => f.IsActive && (f.AccountGroupCode.ToLower().Contains("exp") 
                    || f.AccountGroupCode.ToLower().Contains("liab")) && f.ParentAccountID > 0)
                    .ToListAsync();
                _logger.LogInformation("Fetched {Count} accounts.", accounts.Count);
                return Ok(accounts);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error occurred while fetching accounts.");
                return StatusCode(500, "An error occurred while retrieving data.");
            }
        }

         // GET: api/<AccountController>
        [HttpGet("GetCashAccount")]
        public async Task<ActionResult<IEnumerable<AccountMaster>>> GetCashAccount()
        {
            _logger.LogInformation("Fetching all cash accounts from database.");
            try
            {
                var selectedGroupAccount = await _context.AccountMasters.FirstOrDefaultAsync(f => f.AccountCode == cashAccountCode);
                var accounts = await _context.AccountMasters.Where(f => f.ParentAccountID == selectedGroupAccount.AccountID && f.IsActive).ToListAsync();
                _logger.LogInformation("Fetched {Count} accounts.", accounts.Count);
                return Ok(accounts);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error occurred while fetching accounts.");
                return StatusCode(500, "An error occurred while retrieving data.");
            }
        }

        // GET: api/<AccountController>
        [HttpGet("ExpenseAccount")]
        public async Task<ActionResult<IEnumerable<AccountMaster>>> GetPaymentAccount()
        {
            _logger.LogInformation("Fetching all payment accounts from database.");
            try
            {
                var accounts = await _context.AccountMasters.Where(f => f.AccountGroupCode == expenseAccountGroupCode && f.IsActive).ToListAsync();
                
                _logger.LogInformation("Fetched {Count} bank accounts.", accounts.Count);
                return Ok(accounts);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error occurred while fetching accounts.");
                return StatusCode(500, "An error occurred while retrieving data.");
            }
        }

        // GET: api/<AccountController>
        [HttpGet("GetBankAccount")]
        public async Task<ActionResult<IEnumerable<AccountMaster>>> GetBankAccount()
        {
            _logger.LogInformation("Fetching all bank accounts from database.");
            try
            {
                var selectedGroupAccount = await _context.AccountMasters.FirstOrDefaultAsync(f => f.AccountCode == bankAccountCode);
                var accounts = await _context.AccountMasters.Where(f => f.ParentAccountID == selectedGroupAccount.AccountID && f.IsActive).ToListAsync();
                _logger.LogInformation("Fetched {Count} bank accounts.", accounts.Count);
                return Ok(accounts);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error occurred while fetching accounts.");
                return StatusCode(500, "An error occurred while retrieving data.");
            }
        }

        // GET: api/<AccountController>
        [HttpGet("Code")]
        public async Task<ActionResult<IEnumerable<int>>> GetCurrentCode(int code)
        {
            _logger.LogInformation("Fetching current/last account code from database.");
            try
            {
                var currentCode = await _context.AccountMasters.MaxAsync(p => p.ParentAccountID == code);
                _logger.LogInformation("Fetched {currentCode} for account.", currentCode);
                return Ok(new { CurrentCode = currentCode });
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error occurred while fetching current account Code.");
                return StatusCode(500, "An error occurred while retrieving data.");
            }
        }

        // GET api/<AccountController>/5
        [HttpGet("GetAccount/{id}")]
        public async Task<ActionResult<AccountMaster>> GetAccount(int id)
        {
            _logger.LogInformation("Fetching Account with ID {Id}.", id);
            try
            {
                var account = await _context.AccountMasters.FindAsync(id);

                if (account == null)
                {
                    _logger.LogWarning("Account with ID {Id} not found.", id);
                    return NotFound();
                }

                _logger.LogInformation("Account with ID {Id} found.", account);
                return Ok(account);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error occurred while fetching account with ID {Id}.", id);
                return StatusCode(500, "An error occurred while retrieving the account.");
            }
        }

        // GET api/<AccountController>/5
        [HttpGet("{accountCode}")]
        public async Task<ActionResult<AccountMaster>> GetAccount(string accountCode)
        {
            _logger.LogInformation("Fetching Account with Account Code {accountCode}.", accountCode);
            try
            {
                var account = await _context.AccountMasters.Where(p => p.AccountCode == accountCode).FirstOrDefaultAsync();

                if (account == null)
                {
                    _logger.LogWarning("Account with account code {accountCode} not found.", accountCode);
                    return NotFound();
                }

                return Ok(account);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error occurred while fetching account with ID {accountCode}.", accountCode);
                return StatusCode(500, "An error occurred while retrieving the account.");
            }
        }

        [HttpGet("GetNextAccountCode/{parentID}")]
        public async Task<ActionResult<object>> GetNextAccountCode(int parentID)
        {
            _logger.LogInformation("Generating next account code for Parent ID {parentID}.", parentID);

            try
            {
                // Get parent
                var parent = await _context.AccountMasters
                    .FirstOrDefaultAsync(p => p.AccountID == parentID);

                if (parent == null)
                    return NotFound("Parent account not found");

                // Get children
                var children = await _context.AccountMasters
                    .Where(p => p.ParentAccountID == parentID)
                    .ToListAsync();

                string nextCode;

                if (!children.Any())
                {
                    // First child
                    nextCode = IncrementCode(parent.AccountCode);
                }
                else
                {
                    // Get max code safely (string-aware)
                    var maxCode = children
                        .Where(c => !string.IsNullOrEmpty(c.AccountCode))
                        .Select(c => c.AccountCode)
                        .OrderByDescending(c => ExtractNumericPart(c))
                        .First();

                    nextCode = IncrementCode(maxCode);
                }

                return Ok(new { code = nextCode });
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error generating code for Parent ID {parentID}.", parentID);
                return StatusCode(500, "Error generating account code");
            }
        }

        #region Helper for Account Next Code
            private int ExtractNumericPart(string code)
            {
                var numberPart = new string(code.Where(char.IsDigit).ToArray());

                if (int.TryParse(numberPart, out int num))
                    return num;

                return 0;
            }

            private string IncrementCode(string code)
            {
                if (string.IsNullOrEmpty(code))
                    return "1";

                // Split prefix + numeric part
                var prefix = new string(code.TakeWhile(c => !char.IsDigit(c)).ToArray());
                var numberPart = new string(code.SkipWhile(c => !char.IsDigit(c)).ToArray());

                if (int.TryParse(numberPart, out int num))
                {
                    var incremented = (num + 1).ToString().PadLeft(numberPart.Length, '0');
                    return prefix + incremented;
                }

                // If no numeric part → append 1
                return code + "1";
            }

        #endregion

        // POST api/<AccountController>
        [HttpPost]
        public async Task<ActionResult<AccountMaster>> PostAccount(AccountMaster account)
        {
            _logger.LogInformation("Creating a new account.");
            try
            {
                _context.AccountMasters.Add(account);
                await _context.SaveChangesAsync();

                _logger.LogInformation("Account created with ID {Id}.", account.AccountID);
                return CreatedAtAction(nameof(GetAccount), new { id = account.AccountID }, account);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error occurred while creating a new account.");
                return StatusCode(500, "An error occurred while creating the account.");
            }
        }

        // PUT api/<AccountController>/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutAccount(int id, AccountMaster account)
        {
            _logger.LogInformation("Updating account with ID {Id}.", id);

            if (id != account.AccountID)
            {
                _logger.LogWarning("Account ID mismatch for PUT request. Route ID: {RouteId}, Body ID: {BodyId}", id, account.AccountID);
                return BadRequest("Account ID mismatch");
            }

            _context.Entry(account).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
                _logger.LogInformation("Account with ID {Id} updated successfully.", id);
                return Ok(account);
            }
            catch (DbUpdateConcurrencyException ex)
            {
                if (!AccountExists(id))
                {
                    _logger.LogWarning("Attempted to update non-existent account with ID {Id}.", id);
                    return NotFound();
                }
                else
                {
                    _logger.LogError(ex, "Concurrency error while updating account with ID {Id}.", id);
                    throw;
                }
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error occurred while updating account with ID {Id}.", id);
                return StatusCode(500, "An error occurred while updating the account.");
            }

            return NoContent();
        }

        // DELETE api/<CompanyController>/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteAccount(int id)
        {
            _logger.LogInformation("Deleting account with ID {Id}.", id);
            try
            {
                var account = await _context.AccountMasters.FindAsync(id);
                if (account == null)
                {
                    _logger.LogWarning("Attempted to delete non-existent account with ID {Id}.", id);
                    return NotFound();
                }

                _context.AccountMasters.Remove(account);
                await _context.SaveChangesAsync();

                _logger.LogInformation("Account with ID {Id} deleted successfully.", id);
                return NoContent();
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error occurred while deleting account with ID {Id}.", id);
                return StatusCode(500, "An error occurred while deleting the account.");
            }
        }

        private bool AccountExists(int id)
        {
            return _context.AccountMasters.Any(e => e.AccountID == id);
        }
    }
}
