using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SmartFleet.Data;
using SmartFleet.Data.Models;

namespace SmartFleetManager.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TripAcknowledgementController : ControllerBase
    {
        private readonly AppDbContext _context;
        private readonly ILogger<TripAcknowledgementController> _logger;
        private readonly IWebHostEnvironment _env;


        public TripAcknowledgementController(AppDbContext context, ILogger<TripAcknowledgementController> logger, IWebHostEnvironment env)
        {
            _context = context;
            _logger = logger;
            _env = env;
        }

        // GET: api/<TripAcknoledgementController>
        [HttpGet]
        public async Task<ActionResult<IEnumerable<TripReceiptAcknoledgementsInfo>>> GetDeliveryReceipt()
        {
            _logger.LogInformation("Fetching all acknoledgements from database.");
            try
            {
                var units = await _context.TripReceiptAcknoledgementsInfos.ToListAsync();
                _logger.LogInformation("Fetched {Count} acknoledgements.", units.Count);
                return Ok(units);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error occurred while fetching acknoledgements.");
                return StatusCode(500, "An error occurred while retrieving data.");
            }
        }

        // GET api/<TripAcknoledgementController>/5
        [HttpGet("{id}")]
        public async Task<ActionResult<TripReceiptAcknoledgementsInfo>> GetDeliveryReceipt(int id)
        {
            _logger.LogInformation("Fetching receipt with ID {Id}.", id);
            try
            {
                var receipt = await _context.TripReceiptAcknoledgementsInfos.Where(p => p.TripId.Equals(id)).FirstOrDefaultAsync();

                if (receipt == null)
                {
                    _logger.LogWarning("Trip Receipt with ID {Id} not found.", id);
                    return NotFound();
                }

                return Ok(receipt);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error occurred while fetching unit with ID {Id}.", id);
                return StatusCode(500, "An error occurred while retrieving the unit.");
            }
        }

        // POST api/<TripAcknoledgementController>
        [HttpPost]
        public async Task<ActionResult<TripReceiptAcknoledgementsInfo>> PostDeliveryReceipt(TripReceiptAcknoledgementsInfo receipt)
        {
            _logger.LogInformation("Creating a new trip acknoledgement.");
            try
            {
                _context.TripReceiptAcknoledgementsInfos.Add(receipt);
                var trip = await _context.TripTransaction.Where(p => p.Id == receipt.TripId).FirstOrDefaultAsync();
                if (trip != null)
                {
                    // code for updating the receiptStatus
                    trip.IsReceiptReceived = true;
                    _context.TripTransaction.Update(trip);
                }
                await _context.SaveChangesAsync();

                _logger.LogInformation("Delivery Receipt created with ID {Id}.", receipt.Id);
                return CreatedAtAction(nameof(GetDeliveryReceipt), new { id = receipt.Id }, receipt);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error occurred while creating a Trip Delivery Receipt.");
                return StatusCode(500, "An error occurred while creating the Trip Delivery Receipt.");
            }
        }

        // PUT api/<CompanyController>/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutDeliveryReceipt(int id, TripReceiptAcknoledgementsInfo deliveryReceipt)
        {
            _logger.LogInformation("Updating Delivery Receipt with ID {Id}.", id);

            if (id != deliveryReceipt.Id)
            {
                _logger.LogWarning("Delivery Receipt ID mismatch for PUT request. Route ID: {RouteId}, Body ID: {BodyId}", id, deliveryReceipt.Id);
                return BadRequest("Delivery Receipt ID mismatch");
            }

            _context.Entry(deliveryReceipt).State = EntityState.Modified;
            var trip = await _context.TripTransaction.Where(p => p.Id == deliveryReceipt.TripId).FirstOrDefaultAsync();
            if (trip != null)
            {
                // code for updating the receiptStatus
                trip.IsReceiptReceived = true;
                _context.TripTransaction.Update(trip);
            }
            try
            {
                await _context.SaveChangesAsync();
                _logger.LogInformation("Delivery Receipt with ID {Id} updated successfully.", id);
                return Ok(deliveryReceipt);
            }
            catch (DbUpdateConcurrencyException ex)
            {
                if (!DeliveryReceiptExists(id))
                {
                    _logger.LogWarning("Attempted to update non-existent Delivery Receipt with ID {Id}.", id);
                    return NotFound();
                }
                else
                {
                    _logger.LogError(ex, "Concurrency error while updating Delivery Receipt with ID {Id}.", id);
                    throw;
                }
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error occurred while updating Delivery Receipt with ID {Id}.", id);
                return StatusCode(500, "An error occurred while updating the Delivery Receipt.");
            }

            return NoContent();
        }

        // DELETE api/<UnitController>/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteDeliveryReceipt(int id)
        {
            _logger.LogInformation("Deleting Delivery Receipt with ID {Id}.", id);
            try
            {
                var unit = await _context.Units.FindAsync(id);
                if (unit == null)
                {
                    _logger.LogWarning("Attempted to delete non-existent Delivery Receipt with ID {Id}.", id);
                    return NotFound();
                }

                _context.Units.Remove(unit);
                await _context.SaveChangesAsync();

                _logger.LogInformation("Delivery Receipt with ID {Id} deleted successfully.", id);
                return NoContent();
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error occurred while deleting Delivery Receipt with ID {Id}.", id);
                return StatusCode(500, "An error occurred while deleting the Delivery Receipt.");
            }
        }

        private bool DeliveryReceiptExists(int id)
        {
            return _context.TripReceiptAcknoledgementsInfos.Any(e => e.Id == id);
        }
    }
}
