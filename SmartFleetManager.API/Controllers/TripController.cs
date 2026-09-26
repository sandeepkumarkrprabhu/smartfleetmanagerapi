using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SmartFleet.Data.Models;
using SmartFleetManager.API.Interfaces;
using SmartFleetManager.API.Models;

namespace SmartFleetManager.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TripController : ControllerBase
    {
        private readonly ITripService _tripService;
        private readonly ILogger<TripController> _logger;

        public TripController(ILogger<TripController> logger, ITripService tripService)
        {
            _logger = logger;
            _tripService = tripService;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<TripTransactionView>>> GetTrips(string yearCode)
        {
            try { return Ok(await _tripService.GetTripsAsync(yearCode)); }
            catch (Exception ex) { _logger.LogError(ex, "Error occurred while fetching trip/dispatch."); return StatusCode(500, "An error occurred while retrieving data."); }
        }

        [HttpGet("GetPendingInvoiceTrips")]
        public async Task<IActionResult> GetPendingInvoiceTrips()
        {
            try { return Ok(await _tripService.GetPendingInvoiceTripsAsync()); }
            catch (Exception ex) { _logger.LogError(ex, "Error occurred while fetching trip/dispatch."); return StatusCode(500, "An error occurred while retrieving data."); }
        }

        [HttpGet("GetLatestTrips")]
        public async Task<IActionResult> GetRecentTrips()
        {
            try { return Ok(new { latestTrips = await _tripService.GetRecentTripsAsync() }); }
            catch (Exception ex) { _logger.LogError(ex, "Error occurred while fetching recent trips."); return StatusCode(500, "An error occurred while retrieving data."); }
        }

        [HttpGet("GetTripReport")]
        public async Task<IActionResult> GetTripReport([FromQuery] TripReportFilterDto filter)
        {
            try { return Ok(await _tripService.GetTripReportAsync(filter)); }
            catch (Exception ex) { _logger.LogError(ex, "Error occurred while fetching trip report."); return StatusCode(500, "An error occurred while retrieving data."); }
        }

        [HttpGet("CurrentCode")]
        public async Task<IActionResult> GetCurrentCode()
        {
            try { return Ok(new { CurrentCode = await _tripService.GetCurrentCodeAsync() }); }
            catch (Exception ex) { _logger.LogError(ex, "Error occurred while fetching current trip Code."); return StatusCode(500, "An error occurred while retrieving data."); }
        }

        [HttpPost("AccountPosting")]
        public async Task<IActionResult> AccountPosting([FromBody] PostingFilterDTO filter)
        {
            var trips = await _tripService.GetTripsForPostingAsync(filter);
            if (!trips.Any()) return NotFound("No trips found for the selected date range.");
            foreach (var trip in trips) await _tripService.PostTripToAccountsAsync(trip.Id);
            return Ok(new { Message = "Lorry Receipt posting completed", Count = trips.Count });
        }

        [HttpGet("PendingOrders/{id}")]
        public async Task<IActionResult> GetCustomerPendingOrders(int id)
        {
            try { return Ok(await _tripService.GetCustomerPendingOrdersAsync(id)); }
            catch (Exception ex) { _logger.LogError(ex, "Error occurred while fetching pending trips/orders."); return StatusCode(500, $"An error occurred while retrieving data. Error: {ex.Message}"); }
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<TripTransaction>> GetTrip(int id)
        {
            try
            {
                var trip = await _tripService.GetTripAsync(id);
                return trip == null ? NotFound() : Ok(trip);
            }
            catch (Exception ex) { _logger.LogError(ex, "Error occurred while fetching trip with ID {Id}.", id); return StatusCode(500, "An error occurred while retrieving the trip/dispatch."); }
        }

        [HttpGet("trips")]
        public async Task<IActionResult> GetTrips([FromQuery] TripReportFilterDto filter)
        {
            try { return Ok(await _tripService.GetTripsAsync(filter)); }
            catch (Exception ex) { _logger.LogError(ex, "Error occurred while fetching trips."); return StatusCode(500, "An error occurred while retrieving data."); }
        }

        [HttpPost]
        public async Task<ActionResult<TripTransaction>> PostTrip(TripTransaction trip)
        {
            try
            {
                if (trip == null) return BadRequest("Invalid request data.");
                var created = await _tripService.CreateTripAsync(trip);
                return CreatedAtAction(nameof(GetTrip), new { id = created.Id }, created);
            }
            catch (ArgumentException ex) { return BadRequest(ex.Message); }
            catch (InvalidOperationException ex) { return Conflict(ex.Message); }
            catch (Exception ex) { _logger.LogError(ex, "Error occurred while creating a new trip."); return StatusCode(500, "An error occurred while creating the trip."); }
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> PutTrip(int id, TripTransaction trip)
        {
            if (id != trip.Id) return BadRequest("Trip ID mismatch");
            try
            {
                if (!await _tripService.UpdateTripAsync(id, trip)) return NotFound();
                return NoContent();
            }
            catch (DbUpdateConcurrencyException ex) { _logger.LogError(ex, "Error occurred while updating trip with ID {Id}.", id); return StatusCode(500, "An error occurred while updating the trip."); }
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteTrip(int id)
        {
            try
            {
                if (!await _tripService.DeleteTripAsync(id)) return NotFound();
                return NoContent();
            }
            catch (Exception ex) { _logger.LogError(ex, "Error occurred while deleting trip/dispatch with ID {Id}.", id); return StatusCode(500, "An error occurred while deleting the trip/dispatch."); }
        }
    }
}