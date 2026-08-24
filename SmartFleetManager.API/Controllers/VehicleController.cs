using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SmartFleet.Data;
using SmartFleet.Data.Models;

namespace SmartFleetManager.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VehicleController : ControllerBase
    {
        private readonly AppDbContext _context;
        private readonly ILogger<VehicleController> _logger;
        private const string VehicleAccountCode = "1400";
        private const string GroupName = "Vehicle";

        public VehicleController(AppDbContext context, ILogger<VehicleController> logger)
        {
            _context = context;
            _logger = logger;
        }

        // GET: api/<VehicleController>
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Vehicle>>> GetVehicles()
        {
            _logger.LogInformation("Fetching all vehicles from database.");
            try
            {
                var vehicles = await _context.Vehilces.ToListAsync();
                _logger.LogInformation("Fetched {Count} vehicles.", vehicles.Count);
                return Ok(vehicles);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error occurred while fetching vehicles.");
                return StatusCode(500, "An error occurred while retrieving data.");
            }
        }

        // GET: api/<UnitController>
        [HttpGet("CurrentCode")]
        public async Task<ActionResult<IEnumerable<int>>> GetCurrentCode()
        {
            _logger.LogInformation("Fetching current/last vehicle code from database.");
            try
            {
                var currentCode = await _context.Vehilces.OrderByDescending(p => p.Id).Select(s => s.VehicleCode).FirstOrDefaultAsync();
                _logger.LogInformation("Fetched {currentCode} for vehicle.", currentCode);
                return Ok(new { CurrentCode = currentCode });
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error occurred while fetching current vehicle Code.");
                return StatusCode(500, "An error occurred while retrieving data.");
            }
        }

        // GET api/<VehicleController>/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Vehicle>> GetVehicle(int id)
        {
            _logger.LogInformation("Fetching vehicle with ID {Id}.", id);
            try
            {
                var vehicle = await _context.Vehilces.FindAsync(id);

                if (vehicle == null)
                {
                    _logger.LogWarning("Vehicle with ID {Id} not found.", id);
                    return NotFound();
                }

                return Ok(vehicle);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error occurred while fetching vehicle with ID {Id}.", id);
                return StatusCode(500, "An error occurred while retrieving the vehicle.");
            }
        }

        // GET api/<CompanyController>/5
        [HttpGet("GetVehicleAccount/{id}")]
        public async Task<ActionResult<Vehicle>> GetVehicleAccount(int id)
        {
            _logger.LogInformation("Fetching vehicle with Account ID {Id}.", id);
            try
            {
                var vehicle = await _context.Vehilces.Where(f => f.AccountId == id).FirstOrDefaultAsync();

                if (vehicle == null)
                {
                    _logger.LogWarning("Vehicle with ID {Id} not found.", id);
                    return NotFound();
                }

                return Ok(vehicle);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error occurred while fetching vehicle with ID {Id}.", id);
                return StatusCode(500, "An error occurred while retrieving the vehicle.");
            }
        }

        // POST api/<VehicleController>
        [HttpPost]
        public async Task<ActionResult<Vehicle>> PostVehicle(Vehicle vehicle)
        {
            _logger.LogInformation("Creating a new Vehicle.");
            try
            {
                if (vehicle == null)
                    return BadRequest("Invalid request data.");

                // Trim name
                var name = vehicle.Name?.Trim();

                // 1️⃣ Validation - Empty Name
                if (string.IsNullOrWhiteSpace(name))
                {
                    return BadRequest("vehicle name is required.");
                }

                // 2️⃣ Check if already exists (case insensitive)
                bool isAlreadyExists = await _context.Vehilces
                    .AnyAsync(c => c.Name.ToLower() == name);

                if (isAlreadyExists)
                {
                    return Conflict("vehicle already exists.");
                }

                var parentAccount = await _context.AccountMasters.Where(f => f.AccountCode == VehicleAccountCode).FirstOrDefaultAsync();
                var parentAccountId = parentAccount?.AccountID ?? 0;
                var accountGroup = parentAccount?.AccountGroupCode??"";
                var accountType = parentAccount?.AccountType?? "";
                var accounts = await _context.AccountMasters.Where(f => f.ParentAccountID == parentAccountId).OrderBy(o => o.AccountID).ToListAsync();
                var nextAccountCode = accounts.Select(a => int.Parse(a.AccountCode)).Max() + 1; 
                AccountMaster newVehicleAccount = new AccountMaster
                {
                    AccountCode = nextAccountCode.ToString(),
                    AccountName = vehicle.Name,
                    AccountType = accountType,
                    AccountGroupCode = accountGroup,
                    Address = string.Empty,
                    BranchID = 1,
                    CreatedAt = DateTime.UtcNow,
                    IsActive = true,
                    LastUpdatedAt = vehicle.LastUpdatedAt,
                    GroupName = GroupName,
                    Notes = string.Empty,
                    ParentAccountID = parentAccountId,
                    AccountMode = "Vehicle"
                };
                
                _context.AccountMasters.Add(newVehicleAccount);
                await _context.SaveChangesAsync();
                var newAccountId = newVehicleAccount.AccountID;

                vehicle.AccountId = newAccountId;
                _context.Vehilces.Add(vehicle);
                await _context.SaveChangesAsync();

                _logger.LogInformation("Vehicle created with ID {Id}.", vehicle.Id);
                return CreatedAtAction(nameof(GetVehicle), new { id = vehicle.Id }, vehicle);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error occurred while creating a new vehicle.");
                return StatusCode(500, "An error occurred while creating the vehicle.");
            }
        }

        // PUT api/<VehicleController>/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutVehicle(int id, Vehicle vehicle)
        {
            _logger.LogInformation("Updating vehicle with ID {Id}.", id);

            if (id != vehicle.Id)
            {
                _logger.LogWarning("Vehicle ID mismatch for PUT request. Route ID: {RouteId}, Body ID: {BodyId}", id, vehicle.Id);
                return BadRequest("Vehicle ID mismatch");
            }

            _context.Entry(vehicle).State = EntityState.Modified;

            // Update AccountId only if provided
            if (!String.IsNullOrEmpty(vehicle.AccountId.ToString()))
            {
                var accountRec = await _context.AccountMasters
                    .FirstOrDefaultAsync(a => a.AccountID == vehicle.AccountId);

                if (accountRec != null)
                {
                    accountRec.AccountName = vehicle.Name;
                    accountRec.Address = string.Empty;
                    accountRec.BranchID = 1;
                    accountRec.IsActive = vehicle.IsActive;
                    accountRec.LastUpdatedAt = DateTime.Now;
                    accountRec.GroupName = GroupName;
                    accountRec.Notes = string.Empty;
                    accountRec.AccountMode = "Vehicle";
                }
            }

            try
            {
                await _context.SaveChangesAsync();
                _logger.LogInformation("Vehicle with ID {Id} updated successfully.", id);
                return Ok(vehicle);
            }
            catch (DbUpdateConcurrencyException ex)
            {
                if (!VehicleExists(id))
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

        // DELETE api/<VehicleController>/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteVehicle(int id)
        {
            _logger.LogInformation("Deleting vehicle with ID {Id}.", id);
            try
            {
                var vehicle = await _context.Vehilces.FindAsync(id);
                if (vehicle == null)
                {
                    _logger.LogWarning("Attempted to delete non-existent vehicle with ID {Id}.", id);
                    return NotFound();
                }

                _context.Vehilces.Remove(vehicle);
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

        private bool VehicleExists(int id)
        {
            return _context.Vehilces.Any(e => e.Id == id);
        }
    }
}
