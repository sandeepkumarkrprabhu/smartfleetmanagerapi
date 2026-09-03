using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SmartFleet.Data;
using SmartFleet.Data.Models;
using SmartFleetManager.API.Interfaces;

namespace SmartFleetManager.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class JournalEntryController : ControllerBase
    {
        private readonly AppDbContext _context;
        private readonly ILogger<JournalEntryController> _logger;
        private readonly IJournalTransactionService _journalTransactionService;
        private readonly IAccountTransactionService _transactionService;

        public JournalEntryController(AppDbContext context, ILogger<JournalEntryController> logger, IJournalTransactionService journalTransactionService)
        {
            _context = context;
            _logger = logger;
            _journalTransactionService = journalTransactionService;
        }

        // GET: api/<JournalEntryController>
        [HttpGet]
        public async Task<ActionResult<IEnumerable<JournalEntry>>> GetJournals(string yearCode)
        {
            _logger.LogInformation("Fetching all journal entries from database.");
            try
            {
                var journalEntries = await _context.JournalEntries.
                                    Where(f => f.YearCode == yearCode)
                                    .Include(f => f.Lines)
                                    .ToListAsync();
                _logger.LogInformation("Fetched {Count} journal entries.", journalEntries.Count);
                return Ok(journalEntries);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error occurred while fetching journal entries.");
                return StatusCode(500, $"An error occurred while retrieving data.{ex.StackTrace}");
            }
        }

        // GET api/<GetyearlySummary>
        [HttpGet("GetyearlySummary")]
        public async Task<ActionResult<Payment>> GetJournalByYear(int yearCode)
        {
            _logger.LogInformation("Fetching journal entries Summary");
            try
            {
                var payment = await _context.JournalEntries
                            .Where(p => p.EntryDate.Year == yearCode).ToListAsync();

                if (payment == null)
                {
                    _logger.LogWarning("Journal Entries for current year not found.");
                    return NotFound();
                }

                return Ok(payment);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error occurred while fetching journal entries for year.");
                return StatusCode(500, $"An error occurred while retrieving the yearly journal entries.{ex.StackTrace}");
            }
        }

        // GET: api/<JournalEntryController>
        [HttpGet("CurrentCode/{yearCode}")]
        public async Task<ActionResult<IEnumerable<int>>> GetCurrentCode(string yearCode)
        {
            _logger.LogInformation("Fetching current/last journal No from database.");
            try
            {
                var currentCode = await _context.JournalEntries.Where(f => f.YearCode == yearCode).OrderByDescending(p => p.JournalEntryId)
                        .Select(s => (int?)s.JournalNo).FirstOrDefaultAsync() ?? 0;
                _logger.LogInformation("Fetched {currentCode} for Payment.", currentCode);
                return Ok(new { CurrentCode = currentCode });
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error occurred while fetching current journal No.");
                return StatusCode(500, "An error occurred while retrieving data.");
            }
        }

        // GET api/<JournalEntryController>/5
        [HttpGet("{id}")]
        public async Task<ActionResult<JournalEntry>> GetJournalEntryById(int id)
        {
            _logger.LogInformation("Fetching journal entry with ID {Id}.", id);
            try
            {
                var journalEntry = await _context.JournalEntries
                            .Include(t => t.Lines)
                            .FirstOrDefaultAsync(t => t.JournalEntryId == id);

                if (journalEntry == null)
                {
                    _logger.LogWarning("Journal Entry with ID {Id} not found.", id);
                    return NotFound();
                }

                return Ok(journalEntry);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error occurred while fetching journal entry with ID {Id}.", id);
                return StatusCode(500, $"An error occurred while retrieving the journal entry.{ex.StackTrace}");
            }
        }

        // POST api/<JournalEntryController>
        [HttpPost]
        public async Task<ActionResult<Payment>> PostJournalEntry(JournalEntry journal)
        {
            _logger.LogInformation("Creating a new Journal Entry.");
            try
            {
                _context.JournalEntries.Add(journal);
                await _context.SaveChangesAsync();

                await _journalTransactionService.PostTripToAccountsAsync(journal.JournalEntryId);

                _logger.LogInformation("Journal Entry created with ID {Id}.", journal.JournalEntryId);
                return CreatedAtAction(nameof(GetJournalEntryById), new { id = journal.JournalEntryId }, journal);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error occurred while creating a new journal Entry.");
                return StatusCode(500, $"An error occurred while posting the journal.{ex.StackTrace}");
            }
        }

        // PUT api/<JournalEntryController>/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutJournalEntry(int id, JournalEntry journal)
        {
            _logger.LogInformation("Updating journal with ID {Id}.", id);

            if (id != journal.JournalEntryId)
            {
                return BadRequest("Journal ID mismatch");
            }

            var existingJournal = await _context.JournalEntries
                .Include(j => j.Lines) 
                .FirstOrDefaultAsync(j => j.JournalEntryId == id);

            if (existingJournal == null)
            {
                return NotFound();
            }

            // =========================================
            // 1️ Delete AccountTransaction
            // =========================================
            if (journal.AccountStatus == "Posted")
            {
                // Find the transaction by TransactionReferenceId
                var accountTransaction = await _context.AccountTransactions
                    .FirstOrDefaultAsync(t => t.Id == journal.AccountTransactionId);

                if (accountTransaction != null)
                {
                    // Remove the account transaction
                    _context.AccountTransactions.Remove(accountTransaction);
                    _context.SaveChanges();
                }
            }


            // Update scalar properties
            _context.Entry(existingJournal).CurrentValues.SetValues(journal);

            // If you have JournalLines (child collection)
            if (journal.Lines != null)
            {
                // Remove deleted lines
                foreach (var existingLine in existingJournal.Lines.ToList())
                {
                    if (!journal.Lines.Any(l => l.JournalEntryId == existingLine.JournalEntryId))
                    {
                        _context.JournalEntriesLine.Remove(existingLine);
                    }
                }

                // Add or update lines
                foreach (var line in journal.Lines)
                {
                    var existingLine = existingJournal.Lines
                        .FirstOrDefault(l => l.JournalEntryLineId == line.JournalEntryLineId);

                    if (existingLine != null)
                    {
                        _context.Entry(existingLine).CurrentValues.SetValues(line);
                    }
                    else
                    {
                        existingJournal.Lines.Add(line);
                    }
                }
            }

            await _context.SaveChangesAsync();

            await _journalTransactionService.PostTripToAccountsAsync(existingJournal.JournalEntryId);

            return Ok(existingJournal);
        }

        // DELETE api/<PaymentController>/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteJournal(int id)
        {
            _logger.LogInformation("Deleting journal with ID {Id}.", id);
            try
            {
                var journal = await _context.JournalEntries.FindAsync(id);
                if (journal == null)
                {
                    _logger.LogWarning("Attempted to delete non-existent journal with ID {Id}.", id);
                    return NotFound();
                }

                _context.JournalEntries.Remove(journal);
                await _context.SaveChangesAsync();

                _logger.LogInformation("journal with ID {Id} deleted successfully.", id);
                return NoContent();
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error occurred while deleting journal with ID {Id}.", id);
                return StatusCode(500, $"An error occurred while deleting the journal.{ex.StackTrace}");
            }
        }


        private bool journalExists(int id)
        {
            return _context.JournalEntries.Any(e => e.JournalEntryId == id);
        }
    }
}
