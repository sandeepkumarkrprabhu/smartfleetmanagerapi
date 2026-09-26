using Microsoft.AspNetCore.Mvc;
using SmartFleet.Data.Models;
using SmartFleetManager.API.Interfaces;
using SmartFleetManager.API.Models;

namespace SmartFleetManager.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ReceiptsController : ControllerBase
    {
        private readonly IReceiptService _receiptService;
        private readonly ILogger<ReceiptsController> _logger;

        public ReceiptsController(
            IReceiptService receiptService,
            ILogger<ReceiptsController> logger)
        {
            _receiptService = receiptService;
            _logger = logger;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Receipt>>> GetReceipts(string yearCode)
        {
            _logger.LogInformation("Fetching all receipts for year {YearCode}.", yearCode);
            try
            {
                return Ok(await _receiptService.GetReceiptsAsync(yearCode));
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error occurred while fetching receipts.");
                return StatusCode(500, "An error occurred while retrieving data.");
            }
        }

        [HttpGet("GetyearlySummary")]
        public async Task<ActionResult<IEnumerable<Receipt>>> GetReceiptsByYear()
        {
            _logger.LogInformation("Fetching receipts summary.");
            try
            {
                return Ok(await _receiptService.GetReceiptsByYearAsync());
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error occurred while fetching receipts for year.");
                return StatusCode(500, "An error occurred while retrieving the yearly receipts.");
            }
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Receipt>> GetReceiptsById(int id)
        {
            _logger.LogInformation("Fetching receipt with ID {Id}.", id);
            try
            {
                var receipt = await _receiptService.GetReceiptByIdAsync(id);
                return receipt == null ? NotFound() : Ok(receipt);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error occurred while fetching receipt with ID {Id}.", id);
                return StatusCode(500, "An error occurred while retrieving the receipt.");
            }
        }

        [HttpGet("CurrentCode/{yearCode}")]
        public async Task<IActionResult> GetCurrentCode(string yearCode)
        {
            if (string.IsNullOrWhiteSpace(yearCode))
                return StatusCode(405, "An error occurred while generating next receipt number.");

            try
            {
                var currentCode = await _receiptService.GetCurrentCodeAsync(yearCode);
                return Ok(new { CurrentCode = currentCode });
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error occurred while fetching current receipt code.");
                return StatusCode(500, "An error occurred while retrieving data.");
            }
        }

        [HttpPost("AccountPosting")]
        public async Task<IActionResult> AccountPosting([FromBody] PostingFilterDTO filter)
        {
            try
            {
                var receipts = await _receiptService.GetReceiptsForPostingAsync(filter);

                if (!receipts.Any())
                    return NotFound("No receipts found for the selected date range.");

                foreach (var receipt in receipts)
                    await _receiptService.PostReceiptToAccountsAsync(receipt.Id);

                return Ok(new
                {
                    Message = "Receipt posting completed",
                    Count = receipts.Count
                });
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error occurred while posting receipts to accounting.");
                return StatusCode(500, "An error occurred while posting receipts.");
            }
        }

        [HttpPost("AccoutPosting/{receiptId}")]
        public async Task<IActionResult> PostBillToAccounting(int receiptId)
        {
            try
            {
                await _receiptService.PostReceiptToAccountsAsync(receiptId);
                return Ok(new { BillId = receiptId });
            }
            catch (KeyNotFoundException)
            {
                return NotFound($"Receipt with Id {receiptId} not found.");
            }
            catch (InvalidOperationException ex)
            {
                return BadRequest(ex.Message);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error occurred while posting receipt {Id}.", receiptId);
                return StatusCode(500, "An error occurred while posting the receipt.");
            }
        }

        [HttpPost]
        public async Task<ActionResult<Receipt>> PostReceipts(Receipt receipt)
        {
            _logger.LogInformation("Creating a new receipt.");
            try
            {
                var created = await _receiptService.CreateReceiptAsync(receipt);

                return CreatedAtAction(
                    nameof(GetReceiptsById),
                    new { id = created.Id },
                    created);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error occurred while creating receipt.");
                return StatusCode(500, "An error occurred while posting the receipt.");
            }
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> PutReceipt(int id, Receipt receipt)
        {
            if (id != receipt.Id)
                return BadRequest("Receipt ID mismatch");

            try
            {
                var updated = await _receiptService.UpdateReceiptAsync(id, receipt);

                if (updated == null)
                    return NotFound();

                return Ok(updated);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error occurred while updating receipt with ID {Id}.", id);
                return StatusCode(500, "An error occurred while updating the receipt.");
            }
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteReceipt(int id)
        {
            _logger.LogInformation("Deleting receipt with ID {Id}.", id);
            try
            {
                var deleted = await _receiptService.DeleteReceiptAsync(id);

                if (!deleted)
                    return NotFound();

                return NoContent();
            }
            catch (InvalidOperationException ex)
            {
                return BadRequest(new { error = ex.Message });
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error occurred while deleting receipt with ID {Id}.", id);
                return StatusCode(500, "An error occurred while deleting the receipt.");
            }
        }
    }
}