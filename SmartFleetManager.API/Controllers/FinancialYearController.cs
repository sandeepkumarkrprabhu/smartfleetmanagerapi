using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SmartFleet.Data;
using SmartFleet.Data.Models;

namespace SmartFleetManager.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FinancialYearController : ControllerBase
    {
        private readonly AppDbContext _context;
        private readonly ILogger<FinancialYearController> _logger;

        public FinancialYearController(AppDbContext context, ILogger<FinancialYearController> logger)
        {
            _context = context;
            _logger = logger;
        }

        // GET: api/<FinancialYearController>
        [HttpGet]
        public async Task<ActionResult<IEnumerable<FinancialYear>>> GetFinancialYears()
        {
            _logger.LogInformation("Fetching all financial year from database.");
            try
            {
                var finyears = await _context.FinancialYears.Where(f => f.IsActive && !(f.IsYearClosed??false)).ToListAsync();
                _logger.LogInformation("Fetched {Count} financial year.", finyears.Count);
                return Ok(finyears);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error occurred while fetching financial years.");
                return StatusCode(500, "An error occurred while retrieving data.");
            }
        }

        // GET: api/<FinancialYearController>
        [HttpGet("{id}")]
        public async Task<ActionResult<IEnumerable<FinancialYear>>> GetFinancialYearById(string id)
        {
            _logger.LogInformation("Fetching all financial year from database.");
            try
            {
                var preferences = await _context.FinancialYears.Where(f => f.Code == id).ToListAsync();
                _logger.LogInformation("Fetched {Count} financial year.", preferences.Count);
                return Ok(preferences);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error occurred while fetching financial year.");
                return StatusCode(500, "An error occurred while retrieving data.");
            }
        }

        // POST api/<FinancialYearController>
        //[HttpPost]
        //public async Task<ActionResult<Location>> PostFinancialyear(FinancialYear finyear)
        //{
        //    _logger.LogInformation("Creating a new user Preference.");
        //    try
        //    {
        //        var userModule = _context.FinancialYears.Where(f => f. == "DefaultModule" && f.EmployeeID == finyear.EmployeeID).FirstOrDefault();
        //        if (userModule == null)
        //        {
        //            _context.UserPreferences.Add(finyear);
        //            await _context.SaveChangesAsync();

        //            _logger.LogInformation("User Preference created with ID {Id}.", finyear.Id);
        //            return CreatedAtAction(nameof(GetUserPreferences), new { id = finyear.Id }, finyear);
        //        }
        //        else
        //        {
        //            userModule.EmployeeID = finyear.EmployeeID;
        //            userModule.KeyValue = finyear.KeyValue;
        //            await _context.SaveChangesAsync();
        //            _logger.LogInformation("user preference with ID {Id} updated successfully.", userModule.Id);
        //            return Ok(finyear);

        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        _logger.LogError(ex, "Error occurred while creating a new user preference.");
        //        return StatusCode(500, "An error occurred while creating the user preference.");
        //    }
        //}

        // PUT api/<FinancialYearController>/5
        //[HttpPut("{id}")]
        //public async Task<IActionResult> PutUserPrefernce(int id, UserPreferences preference)
        //{
        //    _logger.LogInformation("Updating location with ID {Id}.", id);

        //    if (id != preference.Id)
        //    {
        //        _logger.LogWarning("user preference ID mismatch for PUT request. Route ID: {RouteId}, Body ID: {BodyId}", id, preference.Id);
        //        return BadRequest("user preference ID mismatch");
        //    }

        //    _context.Entry(preference).State = EntityState.Modified;

        //    try
        //    {
        //        await _context.SaveChangesAsync();
        //        _logger.LogInformation("user preference with ID {Id} updated successfully.", id);
        //        return Ok(preference);
        //    }
        //    catch (DbUpdateConcurrencyException ex)
        //    {

        //        _logger.LogWarning("Attempted to update non-existent user preference with ID {Id}.", id);

        //    }
        //    catch (Exception ex)
        //    {
        //        _logger.LogError(ex, "Error occurred while updating user preference with ID {Id}.", id);
        //        return StatusCode(500, "An error occurred while updating the user preference.");
        //    }

        //    return NoContent();
        //}
    }
}
