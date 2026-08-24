using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SmartFleet.Data;
using SmartFleet.Data.Models;

namespace SmartFleetManager.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserPreferenceController : ControllerBase
    {
        private readonly AppDbContext _context;
        private readonly ILogger<UserPreferenceController> _logger;

        public UserPreferenceController(AppDbContext context, ILogger<UserPreferenceController> logger)
        {
            _context = context;
            _logger = logger;
        }

        // GET: api/<userpreferenceController>
        [HttpGet("{id}")]
        public async Task<ActionResult<IEnumerable<UserPreferences>>> GetUserPreferences(int id)
        {
            _logger.LogInformation("Fetching all user Preferences from database.");
            try
            {
                var preferences = await _context.UserPreferences.Where(f => f.EmployeeID == id).ToListAsync();
                _logger.LogInformation("Fetched {Count} user preferences.", preferences.Count);
                return Ok(preferences);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error occurred while fetching user preferences.");
                return StatusCode(500, "An error occurred while retrieving data.");
            }
        }


        // GET: api/<userpreferenceController>
        [HttpGet("GetDefaultFinancialyear/{id}")]
        public async Task<ActionResult<IEnumerable<FinancialYear>>> GetDefaultFinancialyear(int id)
        {
            _logger.LogInformation("Fetching user default financial year from database.");
            try
            {
                var preference = await _context.UserPreferences.Where(f => f.EmployeeID == id && f.KeyName == "DefaultFinancialYear").FirstOrDefaultAsync();
                var financialYear = await _context.FinancialYears.Where(f => f.Code == preference.KeyValue).FirstOrDefaultAsync();
                _logger.LogInformation("Fetched {selectedRec} user default financial preferences.", preference);
                return Ok(financialYear);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error occurred while fetching user financial preferences.");
                return StatusCode(500, "An error occurred while retrieving data.");
            }
        }
        // POST api/<userpreferenceController>
        [HttpPost]
        public async Task<ActionResult<Location>> PostUserPreference(UserPreferences preference)
        {
            _logger.LogInformation("Creating a new user Preference.");
            try
            {
                var userModule = _context.UserPreferences.Where(f => f.KeyName == preference.KeyName && f.EmployeeID == preference.EmployeeID).FirstOrDefault();
                if (userModule == null)
                {
                    _context.UserPreferences.Add(preference);
                    await _context.SaveChangesAsync();

                    _logger.LogInformation("User Preference created with ID {Id}.", preference.Id);
                    return CreatedAtAction(nameof(GetUserPreferences), new { id = preference.Id }, preference);
                }
                else
                {
                    userModule.EmployeeID = preference.EmployeeID;
                    userModule.KeyValue = preference.KeyValue;
                    await _context.SaveChangesAsync();
                    _logger.LogInformation("user preference with ID {Id} updated successfully.", userModule.Id);
                    return Ok(preference);

                }
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error occurred while creating a new user preference.");
                return StatusCode(500, "An error occurred while creating the user preference.");
            }
        }

        // PUT api/<userpreferenceController>/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutUserPrefernce(int id, UserPreferences preference)
        {
            _logger.LogInformation("Updating location with ID {Id}.", id);

            if (id != preference.Id)
            {
                _logger.LogWarning("user preference ID mismatch for PUT request. Route ID: {RouteId}, Body ID: {BodyId}", id, preference.Id);
                return BadRequest("user preference ID mismatch");
            }

            _context.Entry(preference).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
                _logger.LogInformation("user preference with ID {Id} updated successfully.", id);
                return Ok(preference);
            }
            catch (DbUpdateConcurrencyException ex)
            {

                _logger.LogWarning("Attempted to update non-existent user preference with ID {Id}.", id);

            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error occurred while updating user preference with ID {Id}.", id);
                return StatusCode(500, "An error occurred while updating the user preference.");
            }

            return NoContent();
        }


    }
}
