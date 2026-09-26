using Microsoft.AspNetCore.Mvc;
using SmartFleet.Data.Models;
using SmartFleetManager.API.Interfaces;
using SmartFleetManager.API.Models;

namespace SmartFleetManager.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PaymentController : ControllerBase
    {
        private readonly IPaymentService _paymentService;
        private readonly ILogger<PaymentController> _logger;

        public PaymentController(IPaymentService paymentService, ILogger<PaymentController> logger)
        {
            _paymentService = paymentService;
            _logger = logger;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Payment>>> GetPayments(string yearCode)
        {
            _logger.LogInformation("Fetching all expenses.");
            try
            {
                var payments = await _paymentService.GetPaymentsAsync(yearCode);
                return Ok(payments);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error occurred while fetching payments.");
                return StatusCode(500, $"An error occurred while retrieving data.{ex.StackTrace}");
            }
        }

        [HttpGet("GetyearlySummary")]
        public async Task<ActionResult<Payment>> GetPaymentsByYear()
        {
            try
            {
                return Ok(await _paymentService.GetPaymentsByYearAsync());
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error occurred while fetching payment for year.");
                return StatusCode(500, $"An error occurred while retrieving the yearly payment.{ex.StackTrace}");
            }
        }

        [HttpGet("CurrentCode/{yearCode}")]
        public async Task<ActionResult<IEnumerable<int>>> GetCurrentCode(string yearCode)
        {
            if (string.IsNullOrEmpty(yearCode))
                return StatusCode(405, "An error occurred while generating next payment number.");

            try
            {
                return Ok(new { CurrentCode = await _paymentService.GetCurrentCodeAsync(yearCode) });
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error occurred while fetching current Payment Code.");
                return StatusCode(500, "An error occurred while retrieving data.");
            }
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Payment>> GetPaymentsById(int id)
        {
            try
            {
                var payment = await _paymentService.GetPaymentByIdAsync(id);
                return payment == null ? NotFound() : Ok(payment);
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
            try
            {
                var payments = await _paymentService.GetPaymentsForPostingAsync(filter);
                if (!payments.Any())
                    return NotFound("No payments found for the selected date range.");

                foreach (var payment in payments)
                    await _paymentService.PostPaymentToAccountsAsync(payment.Id);

                return Ok(new { Message = "Payment posting completed", Count = payments.Count });
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error occurred while posting payments to accounting.");
                return StatusCode(500, $"An error occurred while posting payments.{ex.StackTrace}");
            }
        }

        [HttpPost("AccoutPosting/{receiptId}")]
        public async Task<IActionResult> PostBillToAccounting(int paymentd)
        {
            try
            {
                await _paymentService.PostPaymentToAccountsAsync(paymentd);
                return Ok(new { BillId = paymentd });
            }
            catch (KeyNotFoundException ex)
            {
                return NotFound(ex.Message);
            }
            catch (InvalidOperationException ex)
            {
                return BadRequest(ex.Message);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error occurred while posting payment {PaymentId} to accounting.", paymentd);
                return StatusCode(500, $"An error occurred while posting the payment.{ex.StackTrace}");
            }
        }

        [HttpPost]
        public async Task<ActionResult<Payment>> PostPayment(Payment payment)
        {
            try
            {
                var createdPayment = await _paymentService.CreatePaymentAsync(payment);
                return CreatedAtAction(nameof(GetPaymentsById), new { id = createdPayment.Id }, createdPayment);
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
            try
            {
                var updatedPayment = await _paymentService.UpdatePaymentAsync(id, payment);
                return updatedPayment == null ? NotFound() : Ok(updatedPayment);
            }
            catch (ArgumentException ex)
            {
                return BadRequest(ex.Message);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error occurred while updating payment with ID {Id}.", id);
                return StatusCode(500, $"An error occurred while updating the payment.{ex.StackTrace}");
            }
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeletePayment(int id)
        {
            try
            {
                var deleted = await _paymentService.DeletePaymentAsync(id);
                return deleted ? NoContent() : NotFound();
            }
            catch (InvalidOperationException ex)
            {
                return BadRequest(new { error = ex.Message });
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error occurred while deleting payment with ID {Id}.", id);
                return StatusCode(500, $"An error occurred while deleting the payment.{ex.StackTrace}");
            }
        }
    }
}