using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SmartFleet.Data;
using SmartFleet.Data.Models;

namespace SmartFleetManager.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VehicleFuelController : ControllerBase
    {
        private readonly AppDbContext _context;
        private readonly ILogger<VehicleFuelController> _logger;

        public VehicleFuelController(AppDbContext context, ILogger<VehicleFuelController> logger)
        {
            _context = context;
            _logger = logger;
        }

        // GET: api/<VehicleFuelController>
        [HttpGet]
        public async Task<ActionResult<IEnumerable<FuelLog>>> GetFuelDetails()
        {
            _logger.LogInformation("Fetching all vehicle fuel logs from database.");
            try
            {
                var fuelLogs = await _context.FuelLog.ToListAsync();
                _logger.LogInformation("Fetched {Count} fuel logs.", fuelLogs.Count);
                return Ok(fuelLogs);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error occurred while fetching fuel logs.");
                return StatusCode(500, "An error occurred while retrieving data.");
            }
        }

        // GET api/<VehicleFuelController>/5
        [HttpGet("{id}")]
        public async Task<ActionResult<FuelLog>> GetVehicleFuel(int id)
        {
            _logger.LogInformation("Fetching fuel log with ID {Id}.", id);
            try
            {
                var company = await _context.FuelLog.FindAsync(id);

                if (company == null)
                {
                    _logger.LogWarning("Fuel log with ID {Id} not found.", id);
                    return NotFound();
                }

                return Ok(company);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error occurred while fetching fuel log with ID {Id}.", id);
                return StatusCode(500, "An error occurred while retrieving the fuel log.");
            }
        }

        // POST api/<VehicleFuelController>
        [HttpPost]
        public async Task<ActionResult<FuelLog>> PostVehicleFuel(FuelLog fuelRec)
        {
            _logger.LogInformation("Creating a new vehicle fuel log.");
            try
            {
                _context.FuelLog.Add(fuelRec);
                await _context.SaveChangesAsync();

                _logger.LogInformation("vehicle fuel +log created with ID {Id}.", fuelRec.FuelLogId);
                return CreatedAtAction(nameof(GetVehicleFuel), new { id = fuelRec.FuelLogId }, fuelRec);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error occurred while creating a new fuel log.");
                return StatusCode(500, "An error occurred while creating the fuel log.");
            }
        }

    }
}
