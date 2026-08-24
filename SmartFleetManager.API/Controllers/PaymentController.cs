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
    public class PaymentController : ControllerBase
    {
        private readonly AppDbContext _context;
        private readonly IAccountTransactionService _transactionService;
        private readonly ILogger<PaymentController> _logger;

        public PaymentController(AppDbContext context, ILogger<PaymentController> logger, IAccountTransactionService transactionService)
        {
            _context = context;
            _logger = logger;
            _transactionService = transactionService;
        }

        // GET: api/<PaymentController>
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Payment>>> GetPayments(string yearCode)
        {
            _logger.LogInformation("Fetching all expenses from database.");
            try
            {
                var payments = await _context.payments.Where(f => f.IsCancelled == false && f.YearCode == yearCode).ToListAsync();
                _logger.LogInformation("Fetched {Count} invoices.", payments.Count);
                return Ok(payments);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error occurred while fetching payments.");
                return StatusCode(500, $"An error occurred while retrieving data.{ex.StackTrace}");
            }
        }

        // GET api/<GetyearlySummary>
        [HttpGet("GetyearlySummary")]
        public async Task<ActionResult<Payment>> GetPaymentsByYear()
        {
            _logger.LogInformation("Fetching payments Summary");
            try
            {
                var payment = await _context.payments
                            .Where(p => p.PayDate.Year == DateTime.Now.Year).ToListAsync();

                if (payment == null)
                {
                    _logger.LogWarning("Payments for current year not found.");
                    return NotFound();
                }

                return Ok(payment);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error occurred while fetching payment for year.");
                return StatusCode(500, $"An error occurred while retrieving the yearly payment.{ex.StackTrace}");
            }
        }

        // GET: api/<CustomerController>
        [HttpGet("CurrentCode/{yearCode}")]
        public async Task<ActionResult<IEnumerable<int>>> GetCurrentCode(string yearCode)
        {
            _logger.LogInformation("Fetching current/last Payment code from database.");
            if (string.IsNullOrEmpty(yearCode))
            {
                _logger.LogWarning("YearCode missing. Error occurred while fetching current payment Code.");
                return StatusCode(405, "An error occurred while generating next payment number.");
            }
            try
            {
                var currentCode = await _context.payments.Where(f => f.YearCode == yearCode).OrderByDescending(p => p.Id)
                        .Select(s => (int?)s.paymentNo).FirstOrDefaultAsync() ?? 0;
                _logger.LogInformation("Fetched {currentCode} for Payment.", currentCode);
                return Ok(new { CurrentCode = currentCode });
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error occurred while fetching current Payment Code.");
                return StatusCode(500, "An error occurred while retrieving data.");
            }
        }

        // GET api/<PaymentController>/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Payment>> GetPaymentsById(int id)
        {
            _logger.LogInformation("Fetching payments with ID {Id}.", id);
            try
            {
                var payment = await _context.payments
                            .Include(t => t.Details)
                            .FirstOrDefaultAsync(t => t.Id == id);

                if (payment == null)
                {
                    _logger.LogWarning("Payments with ID {Id} not found.", id);
                    return NotFound();
                }

                return Ok(payment);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error occurred while fetching payment with ID {Id}.", id);
                return StatusCode(500, $"An error occurred while retrieving the payment.{ex.StackTrace}");
            }
        }

        [HttpPost("AccountPosting")]
        public async Task<IActionResult> AccountPosting([FromBody] PostingFilterDTO filter)
        {
            var payments = await _context.payments
                .Include(i => i.Details)
                .Where(p => (p.PayDate >= filter.StartDate &&
                            p.PayDate <= filter.EndDate) && p.IsCancelled == false).ToListAsync();

            if (!payments.Any())
            {
                return NotFound("No payments found for the selected date range.");
            }

            foreach (var payment in payments)
            {
                if (payment != null)
                {
                    await _transactionService.CreatePaymentTransactionAsync(payment);
                }
            }

            return Ok(new
            {
                Message = "Payment posting completed",
                Count = payments.Count
            });
        }

        [HttpPost("AccoutPosting/{receiptId}")]
        public async Task<IActionResult> PostBillToAccounting(int paymentd)
        {
            // Load the bill from DB
            var payment = await GetPaymentForPosting(paymentd);
            if (payment == null)
                return NotFound($"Payment with Id {paymentd} not found.");

            if (payment.AccountStatus == "Posted")
                return BadRequest("Payment is already posted to accounting.");

            // Post to accounting
            await _transactionService.CreatePaymentTransactionAsync(payment);

            return Ok(new { BillId = paymentd });
        }

        [HttpGet("GetPaymentForPosting/{id}")]
        private async Task<Payment?> GetPaymentForPosting(int id)
        {
            _logger.LogInformation("Fetching Payment with ID {Id}.", id);
            try
            {
                var receipt = await _context.payments
                            .Include(t => t.Details)
                            .FirstOrDefaultAsync(t => t.Id == id);

                if (receipt == null)
                {
                    _logger.LogWarning("Payments with ID {Id} not found.", id);
                    return null;
                }

                return receipt;
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error occurred while fetching Payment with ID {Id}.", id);
                return null;
            }
        }

        // POST api/<PaymentController>
        [HttpPost]
        public async Task<ActionResult<Payment>> PostPayment(Payment payment)
        {
            _logger.LogInformation("Creating a new payment.");
            try
            {
                _context.payments.Add(payment);
                await _context.SaveChangesAsync();

                _logger.LogInformation("payment created with ID {Id}.", payment.Id);
                return CreatedAtAction(nameof(GetPaymentsById), new { id = payment.Id }, payment);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error occurred while creating a new payment.");
                return StatusCode(500, $"An error occurred while posting the payment.{ex.StackTrace}");
            }
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> PutPayment(int id, Payment payment)
        {
            _logger.LogInformation("Updating payment with ID {Id}.", id);

            if (id != payment.Id)
                return BadRequest("Payment ID mismatch");

            var existingPayment = await _context.payments
                .Include(r => r.Details)
                    .ThenInclude(d => d.InvoiceAllocations)
                .FirstOrDefaultAsync(r => r.Id == id);

            if (existingPayment == null)
                return NotFound();

            // ==========================
            // Update header fields
            // ==========================
            _context.Entry(existingPayment).CurrentValues.SetValues(payment);


            // =====================================================
            // HANDLE Payment DETAILS
            // =====================================================
            if (payment.Details != null)
            {
                // 1️⃣ REMOVE deleted details
                foreach (var existingDetail in existingPayment.Details.ToList())
                {
                    if (!payment.Details.Any(d => d.Id == existingDetail.Id))
                    {
                        // Remove allocations first (safe if no cascade)
                        _context.PaymentAllocations.RemoveRange(existingDetail.InvoiceAllocations);

                        _context.paymentsDetail.Remove(existingDetail);
                    }
                }

                // ADD / UPDATE details
                foreach (var detail in payment.Details)
                {
                    var existingDetail = existingPayment.Details
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
                                    _context.PaymentAllocations.Remove(existingAllocation);
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
                                    allocation.PaymentDetailId = existingDetail.Id;

                                    existingDetail.InvoiceAllocations.Add(allocation);
                                }
                            }
                        }
                    }
                    else
                    {
                        // New Detail
                        detail.Id = 0;
                        detail.PaymentId = existingPayment.Id;

                        if (detail.InvoiceAllocations != null)
                        {
                            foreach (var allocation in detail.InvoiceAllocations)
                            {
                                allocation.Id = 0;
                            }
                        }

                        existingPayment.Details.Add(detail);
                    }
                }
            }

            await _context.SaveChangesAsync();

            return Ok(existingPayment);
        }

        // DELETE api/<PaymentController>/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeletePayment(int id)
        {
            _logger.LogInformation("Deleting payment with ID {Id}.", id);
            try
            {
                var payment = await _context.payments.FindAsync(id);
                if (payment == null)
                {
                    _logger.LogWarning("Attempted to delete non-existent payment with ID {Id}.", id);
                    return NotFound();
                }

                if (payment.AccountStatus == "Posted")
                {
                    var msg = $"Payment is posted to accounts with {payment.AccountTransactionId}. Payment cannot be cancelled.";
                    _logger.LogWarning(msg);
                    return BadRequest(new { error = msg });
                }

                _context.payments.Remove(payment);
                await _context.SaveChangesAsync();

                _logger.LogInformation("Payment with ID {Id} deleted successfully.", id);
                return NoContent();
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error occurred while deleting payment with ID {Id}.", id);
                return StatusCode(500, $"An error occurred while deleting the payment.{ex.StackTrace}");
            }
        }

        private bool InvoiceExists(int id)
        {
            return _context.payments.Any(e => e.Id == id);
        }
    }
}
