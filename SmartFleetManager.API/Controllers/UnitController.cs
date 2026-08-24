using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SmartFleet.Data;
using SmartFleet.Data.Models;

namespace SmartFleetManager.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UnitController : ControllerBase
    {
        private readonly AppDbContext _context;
        private readonly ILogger<UnitController> _logger;

        public UnitController(AppDbContext context, ILogger<UnitController> logger)
        {
            _context = context;
            _logger = logger;
        }

        // GET: api/<UnitController>
        [HttpGet]
        public async Task<ActionResult<IEnumerable<TripAcknoledgement>>> Getunits()
        {
            _logger.LogInformation("Fetching all units from database.");
            try
            {
                var units = await _context.Units.ToListAsync();
                _logger.LogInformation("Fetched {Count} units.", units.Count);
                return Ok(units);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error occurred while fetching units.");
                return StatusCode(500, "An error occurred while retrieving data.");
            }
        }

        // GET: api/<UnitController>
        [HttpGet("CurrentCode")]
        public async Task<ActionResult<IEnumerable<int>>> GetCurrentCode()
        {
            _logger.LogInformation("Fetching current/last unit code from database.");
            try
            {
                var currentCode = await _context.Units.OrderByDescending(p => p.Id).Select(s => s.UnitCode).FirstOrDefaultAsync();
                _logger.LogInformation("Fetched {currentCode} for unit.", currentCode);
                return Ok(new { CurrentCode = currentCode });
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error occurred while fetching current employee Code.");
                return StatusCode(500, "An error occurred while retrieving data.");
            }
        }

        // GET api/<UnitController>/5
        [HttpGet("{id}")]
        public async Task<ActionResult<TripAcknoledgement>> GetUnit(int id)
        {
            _logger.LogInformation("Fetching unit with ID {Id}.", id);
            try
            {
                var unit = await _context.Units.FindAsync(id);

                if (unit == null)
                {
                    _logger.LogWarning("Unit with ID {Id} not found.", id);
                    return NotFound();
                }

                return Ok(unit);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error occurred while fetching unit with ID {Id}.", id);
                return StatusCode(500, "An error occurred while retrieving the unit.");
            }
        }

        // POST api/<UnitController>
        [HttpPost]
        public async Task<ActionResult<TripAcknoledgement>> PostUnit(TripAcknoledgement unit)
        {
            _logger.LogInformation("Creating a new unit.");
            try
            {
                if (unit == null)
                    return BadRequest("Invalid request data.");

                // Trim name
                var name = unit.Name?.Trim();

                // 1️⃣ Validation - Empty Name
                if (string.IsNullOrWhiteSpace(name))
                {
                    return BadRequest("unit name is required.");
                }

                // 2️⃣ Check if already exists (case insensitive)
                bool isAlreadyExists = await _context.Units
                    .AnyAsync(c => c.Name.ToLower() == name);

                if (isAlreadyExists)
                {
                    return Conflict("unit already exists.");
                }

                _context.Units.Add(unit);
                await _context.SaveChangesAsync();

                _logger.LogInformation("Unit created with ID {Id}.", unit.Id);
                return CreatedAtAction(nameof(GetUnit), new { id = unit.Id }, unit);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error occurred while creating a new unit.");
                return StatusCode(500, "An error occurred while creating the unit.");
            }
        }

        // PUT api/<CompanyController>/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutUnit(int id, TripAcknoledgement unit)
        {
            _logger.LogInformation("Updating unit with ID {Id}.", id);

            if (id != unit.Id)
            {
                _logger.LogWarning("Unit ID mismatch for PUT request. Route ID: {RouteId}, Body ID: {BodyId}", id, unit.Id);
                return BadRequest("Unit ID mismatch");
            }

            _context.Entry(unit).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
                _logger.LogInformation("Unit with ID {Id} updated successfully.", id);
                return Ok(unit);
            }
            catch (DbUpdateConcurrencyException ex)
            {
                if (!UnitExists(id))
                {
                    _logger.LogWarning("Attempted to update non-existent unit with ID {Id}.", id);
                    return NotFound();
                }
                else
                {
                    _logger.LogError(ex, "Concurrency error while updating unit with ID {Id}.", id);
                    throw;
                }
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error occurred while updating unit with ID {Id}.", id);
                return StatusCode(500, "An error occurred while updating the unit.");
            }

            return NoContent();
        }

        // DELETE api/<UnitController>/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteUnit(int id)
        {
            _logger.LogInformation("Deleting unit with ID {Id}.", id);
            try
            {
                var unit = await _context.Units.FindAsync(id);
                if (unit == null)
                {
                    _logger.LogWarning("Attempted to delete non-existent unit with ID {Id}.", id);
                    return NotFound();
                }

                _context.Units.Remove(unit);
                await _context.SaveChangesAsync();

                _logger.LogInformation("Unit with ID {Id} deleted successfully.", id);
                return NoContent();
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error occurred while deleting unit with ID {Id}.", id);
                return StatusCode(500, "An error occurred while deleting the unit.");
            }
        }

        private bool UnitExists(int id)
        {
            return _context.Units.Any(e => e.Id == id);
        }
    }
}
