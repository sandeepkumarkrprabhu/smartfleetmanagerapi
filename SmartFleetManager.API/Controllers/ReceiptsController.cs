using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SmartFleet.Data;
using SmartFleet.Data.Models;
using SmartFleetManager.API.Interfaces;
using SmartFleetManager.API.Models;

namespace SmartFleetManager.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ReceiptsController : ControllerBase
    {
        private readonly AppDbContext _context;
        private readonly IAccountTransactionService _transactionService;
        private readonly ILogger<ReceiptsController> _logger;

        public ReceiptsController(AppDbContext context, ILogger<ReceiptsController> logger, IAccountTransactionService transactionService)
        {
            _context = context;
            _logger = logger;
            _transactionService = transactionService;
        }

        // GET: api/<ReceiptsController>
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Receipt>>> GetReceipts(string yearCode)
        {
            _logger.LogInformation("Fetching all receipts from database.");
            try
            {
                var Receipts = await _context.Receipts.Where(f => f.IsCancelled == false && f.YearCode == yearCode).ToListAsync();
                _logger.LogInformation("Fetched {Count} invoices.", Receipts.Count);
                return Ok(Receipts);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error occurred while fetching comapny branch Receipts.");
                return StatusCode(500, $"An error occurred while retrieving data.{ex.StackTrace}");
            }
        }

        // GET api/<GetyearlySummary>
        [HttpGet("GetyearlySummary")]
        public async Task<ActionResult<Receipt>> GetReceiptsByYear()
        {
            _logger.LogInformation("Fetching receipts Summary");
            try
            {
                var payment = await _context.Receipts
                            .Where(p => p.ReceiptDate.Year == DateTime.Now.Year).ToListAsync();

                if (payment == null)
                {
                    _logger.LogWarning("Receipts for current year not found.");
                    return NotFound();
                }

                return Ok(payment);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error occurred while fetching receipts for year.");
                return StatusCode(500, $"An error occurred while retrieving the yearly receipts.{ex.StackTrace}");
            }
        }

        // GET api/<ReceiptsController>/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Receipt>> GetReceiptsById(int id)
        {
            _logger.LogInformation("Fetching Receipts with ID {Id}.", id);
            try
            {
                var Receipt = await _context.Receipts
                            .Include(t => t.Details)
                            .ThenInclude(d => d.InvoiceAllocations)
                            .FirstOrDefaultAsync(t => t.Id == id);

                if (Receipt == null)
                {
                    _logger.LogWarning("Receipts with ID {Id} not found.", id);
                    return NotFound();
                }

                return Ok(Receipt);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error occurred while fetching Receipt with ID {Id}.", id);
                return StatusCode(500, $"An error occurred while retrieving the Receipt.{ex.StackTrace}");
            }
        }

        [HttpGet("GetReceiptForPosting/{id}")]
        private async Task<Receipt?> GetReceiptForPosting(int id)
        {
            _logger.LogInformation("Fetching Receipts with ID {Id}.", id);
            try
            {
                var receipt = await _context.Receipts
                            .Include(t => t.Details)
                            .FirstOrDefaultAsync(t => t.Id == id);

                if (receipt == null)
                {
                    _logger.LogWarning("Receipts with ID {Id} not found.", id);
                    return null;
                }

                return receipt;
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error occurred while fetching Receipt with ID {Id}.", id);
                return null;
            }
        }

        // GET: api/<CustomerController>
        [HttpGet("CurrentCode/{yearCode}")]
        public async Task<ActionResult<IEnumerable<int>>> GetCurrentCode(string yearCode)
        {
            _logger.LogInformation("Fetching current/last Receipt code from database.");
            if (string.IsNullOrEmpty(yearCode))
            {
                _logger.LogWarning("YearCode missing. Error occurred while fetching current Receipt Code.");
                return StatusCode(405, "An error occurred while generating next receipt number.");
            }
            try
            {
                var currentCode = await _context.Receipts.Where(f => f.YearCode == yearCode).OrderByDescending(p => p.Id)
                        .Select(s => (int?)s.receiptNo).FirstOrDefaultAsync() ?? 0;
                _logger.LogInformation("Fetched {currentCode} for Receipt.", currentCode);
                return Ok(new { CurrentCode = currentCode });
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error occurred while fetching current Receipt Code.");
                return StatusCode(500, "An error occurred while retrieving data.");
            }
        }

        [HttpPost("AccountPosting")]
        public async Task<IActionResult> AccountPosting([FromBody] PostingFilterDTO filter)
        {
            var receipts = await _context.Receipts
                .Include(i => i.Details)
                .Where(p => (p.ReceiptDate >= filter.StartDate.Date &&
                            p.ReceiptDate <= filter.EndDate.Date) && p.AccountStatus != "Posted" && p.IsCancelled == false).ToListAsync();

            if (!receipts.Any())
            {
                return NotFound("No receipts found for the selected date range.");
            }

            foreach (var receipt in receipts)
            {
                if (receipt != null)
                {
                    await _transactionService.CreateReceiptTransactionAsync(receipt);
                }
            }

            return Ok(new
            {
                Message = "Receipt posting completed",
                Count = receipts.Count
            });
        }

        [HttpPost("AccoutPosting/{receiptId}")]
        public async Task<IActionResult> PostBillToAccounting(int receiptId)
        {
            // Load the bill from DB
            var receipt = await GetReceiptForPosting(receiptId);
            if (receipt == null)
                return NotFound($"Bill with Id {receiptId} not found.");

            if (receipt.AccountStatus == "Posted")
                return BadRequest("Bill is already posted to accounting.");

            // Post to accounting
            await _transactionService.CreateReceiptTransactionAsync(receipt);

            return Ok(new { BillId = receiptId });
        }

        // POST api/<ReceiptsController>
        [HttpPost]
        public async Task<ActionResult<Receipt>> PostReceipts(Receipt receipt)
        {
            _logger.LogInformation("Creating a new Receipt.");
            try
            {
                _context.Receipts.Add(receipt);
                await _context.SaveChangesAsync();

                await _transactionService.CreateReceiptTransactionAsync(receipt);

                _logger.LogInformation("Receipt created with ID {Id}.", receipt.Id);
                return CreatedAtAction(nameof(GetReceiptsById), new { id = receipt.Id }, receipt);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error occurred while creating a new Receipt.");
                return StatusCode(500, $"An error occurred while posting the Receipt.{ex.StackTrace}");
            }
        }

        // PUT api/<ReceiptsController>/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutReceipt(int id, Receipt receipt)
        {
            _logger.LogInformation("Updating receipt with ID {Id}.", id);

            if (id != receipt.Id)
                return BadRequest("Receipt ID mismatch");

            var existingReceipt = await _context.Receipts
                .Include(r => r.Details)
                    .ThenInclude(d => d.InvoiceAllocations)
                .FirstOrDefaultAsync(r => r.Id == id);

            if (existingReceipt == null)
                return NotFound();

            // =========================================
            // 1️ Delete AccountTransaction
            // =========================================
            if (receipt.AccountStatus == "Posted")
            {
                // Find the transaction by TransactionReferenceId
                var accountTransaction = await _context.AccountTransactions
                    .FirstOrDefaultAsync(t => t.Id == receipt.AccountTransactionId);

                if (accountTransaction != null)
                {
                    // Remove the account transaction
                    _context.AccountTransactions.Remove(accountTransaction);
                    _context.SaveChanges();
                }
            }

            // ==========================
            // Update header fields
            // ==========================
            receipt.AccountTransactionId = 0;
            receipt.AccountStatus = "Draft";
            _context.Entry(existingReceipt).CurrentValues.SetValues(receipt);


            // =====================================================
            // HANDLE RECEIPT DETAILS
            // =====================================================
            if (receipt.Details != null)
            {
                // 1️⃣ REMOVE deleted details
                foreach (var existingDetail in existingReceipt.Details.ToList())
                {
                    if (!receipt.Details.Any(d => d.Id == existingDetail.Id))
                    {
                        // Remove allocations first (safe if no cascade)
                        _context.ReceiptAllocations.RemoveRange(existingDetail.InvoiceAllocations);

                        _context.ReceiptsDetail.Remove(existingDetail);
                    }
                }

                // 2️⃣ ADD / UPDATE details
                foreach (var detail in receipt.Details)
                {
                    var existingDetail = existingReceipt.Details
                        .FirstOrDefault(d => d.Id == detail.Id);

                    if (existingDetail != null)
                    {
                        // Update detail scalar properties
                        _context.Entry(existingDetail).CurrentValues.SetValues(detail);

                        // ========================================
                        // HANDLE INVOICE ALLOCATIONS
                        // ========================================
                        if (detail.InvoiceAllocations != null)
                        {
                            // REMOVE deleted allocations
                            foreach (var existingAllocation in existingDetail.InvoiceAllocations.ToList())
                            {
                                if (!detail.InvoiceAllocations
                                    .Any(a => a.Id == existingAllocation.Id))
                                {
                                    _context.ReceiptAllocations.Remove(existingAllocation);
                                }
                            }

                            // ADD / UPDATE allocations
                            foreach (var allocation in detail.InvoiceAllocations)
                            {
                                var existingAllocation = existingDetail.InvoiceAllocations
                                    .FirstOrDefault(a => a.Id == allocation.Id);

                                if (existingAllocation != null)
                                {
                                    _context.Entry(existingAllocation)
                                        .CurrentValues
                                        .SetValues(allocation);
                                }
                                else
                                {
                                    // Ensure FK is set correctly
                                    allocation.Id = 0;
                                    allocation.ReceiptDetailId = existingDetail.Id;

                                    existingDetail.InvoiceAllocations.Add(allocation);
                                }
                            }
                        }
                    }
                    else
                    {
                        // New Detail
                        detail.Id = 0;
                        detail.ReceiptId = existingReceipt.Id;

                        if (detail.InvoiceAllocations != null)
                        {
                            foreach (var allocation in detail.InvoiceAllocations)
                            {
                                allocation.Id = 0;
                            }
                        }

                        existingReceipt.Details.Add(detail);
                    }
                }
            }

            await _context.SaveChangesAsync();

            var receiptDet = _context.Receipts.Where(f => f.Id == receipt.Id).FirstOrDefault();


            await _transactionService.CreateReceiptTransactionAsync(receiptDet);

            return Ok(existingReceipt);
        }

        // DELETE api/<ReceiptsController>/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteReceipt(int id)
        {
            _logger.LogInformation("Deleting Receipt with ID {Id}.", id);
            try
            {
                var receipt = await _context.Receipts.FindAsync(id);
                if (receipt == null)
                {
                    _logger.LogWarning("Attempted to delete non-existent Receipt with ID {Id}.", id);
                    return NotFound();
                }
                
                if (receipt.AccountStatus == "Posted")
                {
                    var msg = $"Receipt is posted to accounts with {receipt.AccountTransactionId}. Receipt cannot be cancelled.";
                    _logger.LogWarning(msg);
                    return BadRequest(new { error = msg });
                }

                _context.Receipts.Remove(receipt);
                await _context.SaveChangesAsync();

                _logger.LogInformation("Receipt with ID {Id} deleted successfully.", id);
                return NoContent();
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error occurred while deleting Receipt with ID {Id}.", id);
                return StatusCode(500, $"An error occurred while deleting the Receipt.{ex.StackTrace}");
            }
        }

        private bool InvoiceExists(int id)
        {
            return _context.Receipts.Any(e => e.Id == id);
        }
    }
}
