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
        public async Task<ActionResult<IEnumerable<TripTransactionView>>> GetTrips(string yearCode) => Ok(await _tripService.GetTripsAsync(yearCode));

        [HttpGet("GetPendingInvoiceTrips")]
        public async Task<IActionResult> GetPendingInvoiceTrips() => Ok(await _tripService.GetPendingInvoiceTripsAsync());

        [HttpGet("GetLatestTrips")]
        public async Task<IActionResult> GetRecentTrips() => Ok(new { latestTrips = await _tripService.GetRecentTripsAsync() });

        [HttpGet("GetTripReport")]
        public async Task<IActionResult> GetTripReport([FromQuery] TripReportFilterDto filter) => Ok(await _tripService.GetTripReportAsync(filter));

        [HttpGet("CurrentCode")]
        public async Task<IActionResult> GetCurrentCode() => Ok(new { CurrentCode = await _tripService.GetCurrentCodeAsync() });

        [HttpPost("AccountPosting")]
        public async Task<IActionResult> AccountPosting([FromBody] PostingFilterDTO filter)
        {
            var trips = await _tripService.GetTripsForPostingAsync(filter);
            if (!trips.Any()) return NotFound("No trips found for the selected date range.");
            foreach (var trip in trips) await _tripService.PostTripToAccountsAsync(trip.Id);
            return Ok(new { Message = "Lorry Receipt posting completed", Count = trips.Count });
        }

        [HttpGet("PendingOrders/{id}")]
        public async Task<IActionResult> GetCustomerPendingOrders(int id) => Ok(await _tripService.GetCustomerPendingOrdersAsync(id));

        [HttpGet("{id}")]
        public async Task<ActionResult<TripTransaction>> GetTrip(int id)
        {
            var trip = await _tripService.GetTripAsync(id);
            return trip == null ? NotFound() : Ok(trip);
        }

        [HttpGet("trips")]
        public async Task<IActionResult> GetTrips([FromQuery] TripReportFilterDto filter) => Ok(await _tripService.GetTripsAsync(filter));

        [HttpPost]
        public async Task<ActionResult<TripTransaction>> PostTrip(TripTransaction trip)
        {
            if (trip == null) return BadRequest("Invalid request data.");
            try
            {
                var created = await _tripService.CreateTripAsync(trip);
                return CreatedAtAction(nameof(GetTrip), new { id = created.Id }, created);
            }
            catch (ArgumentException ex) { return BadRequest(ex.Message); }
            catch (InvalidOperationException ex) { return Conflict(ex.Message); }
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> PutTrip(int id, TripTransaction trip)
        {
            if (id != trip.Id) return BadRequest("Trip ID mismatch");
            if (!await _tripService.UpdateTripAsync(id, trip)) return NotFound();
            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteTrip(int id)
        {
            if (!await _tripService.DeleteTripAsync(id)) return NotFound();
            return NoContent();
        }
    }
}