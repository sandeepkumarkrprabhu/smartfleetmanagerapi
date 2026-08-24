using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SmartFleet.Data;
using SmartFleet.Data.Models;
using SmartFleetManager.API.Models;

namespace SmartFleetManager.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VehicleRentController : ControllerBase
    {
        private readonly AppDbContext _context;
        private readonly ILogger<VehicleRentController> _logger;

        public VehicleRentController(AppDbContext context, ILogger<VehicleRentController> logger)
        {
                _context = context;
            _logger = logger;
        }

        // GET: api/<VehicleRentController>
        [HttpGet]
        public async Task<ActionResult<IEnumerable<FuelLog>>> GetVehicleRentDetails()
        {
            _logger.LogInformation("Fetching all vehicle rent agreement logs from database.");
            try
            {
                var vehicleRents = await (from vr in _context.vehicleVendorRents
                                   join v in _context.Vehilces on vr.VehicleId equals v.Id
                                   join ve in _context.Vendors on vr.VendorId equals ve.Id
                                   select new VehicleRentAgreementViewModel
                                   {
                                       Id = vr.Id,  
                                       VendorId = vr.VendorId,
                                       VehicleId = vr.VehicleId,
                                       VendorName = ve.Name,
                                       VehicleNumber = v.Name,
                                       RentFromDate = vr.RentFromDate,
                                       RentToDate = vr.RentToDate,
                                       RentAmount = vr.RentAmount,
                                       IsActive = vr.IsActive,
                                   }).ToListAsync();
                _logger.LogInformation("Fetched {Count} fuel logs.", vehicleRents.Count);
                return Ok(vehicleRents);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error occurred while fetching vehicle rent agreement logs.");
                return StatusCode(500, "An error occurred while retrieving data.");
            }
        }

        // GET api/<VehicleRentController>/5
        [HttpGet("{id}")]
        public async Task<ActionResult<FuelLog>> GetVehicleRent(int id)
        {
            _logger.LogInformation("Fetching vehicle Rent agreement log with ID {Id}.", id);
            try
            {
                var company = await _context.vehicleVendorRents.FindAsync(id);

                if (company == null)
                {
                    _logger.LogWarning("Fuel log with ID {Id} not found.", id);
                    return NotFound();
                }

                return Ok(company);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error occurred while fetching vehicle rent agreement log with ID {Id}.", id);
                return StatusCode(500, "An error occurred while retrieving the fuel log.");
            }
        }

        // POST api/<VehicleRentController>
        [HttpPost]
        public async Task<ActionResult<FuelLog>> PostVehicleRent(VehicleVendorRents vehicleRent)
        {
            _logger.LogInformation("Creating a new vehicle rent agreement.");
            try
            {
                vehicleRent.CreatedOn = DateTime.Now;
                _context.vehicleVendorRents.Add(vehicleRent);
                await _context.SaveChangesAsync();

                _logger.LogInformation("vehicle vehicleagreement created with ID {Id}.", vehicleRent.Id);
                return CreatedAtAction(nameof(GetVehicleRent), new { id = vehicleRent.Id }, vehicleRent);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error occurred while creating a new vehicle agreement.");
                return StatusCode(500, "An error occurred while creating the vehicle agreement.");
            }
        }

        // PUT api/<VehicleRentController>/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutVehicle(int id, VehicleVendorRents vehicleRent)
        {
            _logger.LogInformation("Updating vehicle rent with ID {Id}.", id);

            if (id != vehicleRent.Id)
            {
                _logger.LogWarning("Vehicle ID mismatch for PUT request. Route ID: {RouteId}, Body ID: {BodyId}", id, vehicleRent.Id);
                return BadRequest("Vehicle ID mismatch");
            }

            _context.Entry(vehicleRent).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
                _logger.LogInformation("Vehicle Rent with ID {Id} updated successfully.", id);
                return Ok(vehicleRent);
            }
            catch (DbUpdateConcurrencyException ex)
            {
                if (!VehicleRentExists(id))
                {
                    _logger.LogWarning("Attempted to update non-existent vehicle with ID {Id}.", id);
                    return NotFound();
                }
                else
                {
                    _logger.LogError(ex, "Concurrency error while updating vehicle with ID {Id}.", id);
                    throw;
                }
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error occurred while updating vehicle with ID {Id}.", id);
                return StatusCode(500, "An error occurred while updating the vehicle.");
            }

            return NoContent();
        }

        // DELETE api/<VehicleRentController>/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteVehicle(int id)
        {
            _logger.LogInformation("Deleting vehicle with ID {Id}.", id);
            try
            {
                var vehicleRent = await _context.vehicleVendorRents.FindAsync(id);
                if (vehicleRent == null)
                {
                    _logger.LogWarning("Attempted to delete non-existent vehicle with ID {Id}.", id);
                    return NotFound();
                }

                _context.vehicleVendorRents.Remove(vehicleRent);
                await _context.SaveChangesAsync();

                _logger.LogInformation("Vehicle with ID {Id} deleted successfully.", id);
                return NoContent();
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error occurred while deleting vehicle with ID {Id}.", id);
                return StatusCode(500, "An error occurred while deleting the vehicle.");
            }
        }

        private bool VehicleRentExists(int id)
        {
            return _context.vehicleVendorRents.Any(e => e.Id == id);
        }
    }
}
