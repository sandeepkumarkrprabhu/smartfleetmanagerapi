using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SmartFleet.Data;
using SmartFleet.Data.Models;

namespace SmartFleetManager.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LocationController : ControllerBase
    {
        private readonly AppDbContext _context;
        private readonly ILogger<LocationController> _logger;

        public LocationController(AppDbContext context, ILogger<LocationController> logger)
        {
            _context = context;
            _logger = logger;
        }

        // GET: api/<LocationController>
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Location>>> GetLocations()
        {
            _logger.LogInformation("Fetching all locations from database.");
            try
            {
                var locations = await _context.Locations.ToListAsync();
                _logger.LogInformation("Fetched {Count} locations.", locations.Count);
                return Ok(locations);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error occurred while fetching locations.");
                return StatusCode(500, "An error occurred while retrieving data.");
            }
        }


        // GET: api/<UnitController>
        [HttpGet("CurrentCode")]
        public async Task<ActionResult<IEnumerable<int>>> GetCurrentCode()
        {
            _logger.LogInformation("Fetching current/last location code from database.");
            try
            {
                var currentCode = await _context.Locations.OrderByDescending(p => p.Id).Select(s => s.LocationCode).FirstOrDefaultAsync();
                _logger.LogInformation("Fetched {currentCode} for location.", currentCode);
                return Ok(new { CurrentCode = currentCode });
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error occurred while fetching current employee Code.");
                return StatusCode(500, "An error occurred while retrieving data.");
            }
        }

        // GET api/<LocationController>/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Location>> GetLocation(int id)
        {
            _logger.LogInformation("Fetching location with ID {Id}.", id);
            try
            {
                var location = await _context.Locations.FindAsync(id);

                if (location == null)
                {
                    _logger.LogWarning("Location with ID {Id} not found.", id);
                    return NotFound();
                }

                return Ok(location);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error occurred while fetching location with ID {Id}.", id);
                return StatusCode(500, "An error occurred while retrieving the location.");
            }
        }

        // POST api/<LocationController>
        [HttpPost]
        public async Task<ActionResult<Location>> PostLocation(Location location)
        {
            _logger.LogInformation("Creating a new Location.");
            try
            {
                if (location == null)
                    return BadRequest("Invalid request data.");

                // Trim name
                var name = location.Name?.Trim();

                // 1️⃣ Validation - Empty Name
                if (string.IsNullOrWhiteSpace(name))
                {
                    return BadRequest("location name is required.");
                }

                // 2️⃣ Check if already exists (case insensitive)
                bool isAlreadyExists = await _context.Locations
                    .AnyAsync(c => c.Name.ToLower() == name);

                if (isAlreadyExists)
                {
                    return Conflict("location already exists.");
                }

                _context.Locations.Add(location);
                await _context.SaveChangesAsync();

                _logger.LogInformation("Location created with ID {Id}.", location.Id);
                return CreatedAtAction(nameof(GetLocation), new { id = location.Id }, location);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error occurred while creating a new location.");
                return StatusCode(500, "An error occurred while creating the location.");
            }
        }

        // PUT api/<LocationController>/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutLocation(int id, Location location)
        {
            _logger.LogInformation("Updating location with ID {Id}.", id);

            if (id != location.Id)
            {
                _logger.LogWarning("Location ID mismatch for PUT request. Route ID: {RouteId}, Body ID: {BodyId}", id, location.Id);
                return BadRequest("Location ID mismatch");
            }

            _context.Entry(location).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
                _logger.LogInformation("Location with ID {Id} updated successfully.", id);
                return Ok(location);
            }
            catch (DbUpdateConcurrencyException ex)
            {
                if (!LocationExists(id))
                {
                    _logger.LogWarning("Attempted to update non-existent location with ID {Id}.", id);
                    return NotFound();
                }
                else
                {
                    _logger.LogError(ex, "Concurrency error while updating location with ID {Id}.", id);
                    throw;
                }
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error occurred while updating location with ID {Id}.", id);
                return StatusCode(500, "An error occurred while updating the location.");
            }

            return NoContent();
        }

        // DELETE api/<LocationController>/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteLocation(int id)
        {
            _logger.LogInformation("Deleting location with ID {Id}.", id);
            try
            {
                var location = await _context.Locations.FindAsync(id);
                if (location == null)
                {
                    _logger.LogWarning("Attempted to delete non-existent location with ID {Id}.", id);
                    return NotFound();
                }

                _context.Locations.Remove(location);
                await _context.SaveChangesAsync();

                _logger.LogInformation("Location with ID {Id} deleted successfully.", id);
                return NoContent();
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error occurred while deleting location with ID {Id}.", id);
                return StatusCode(500, "An error occurred while deleting the loction.");
            }
        }

        private bool LocationExists(int id)
        {
            return _context.Companies.Any(e => e.Id == id);
        }
    }
}
