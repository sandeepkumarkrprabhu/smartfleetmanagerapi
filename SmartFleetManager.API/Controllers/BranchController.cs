using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SmartFleet.Data;
using SmartFleet.Data.Models;

namespace SmartFleetManager.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BranchController : ControllerBase
    {
        private readonly AppDbContext _context;
        private readonly ILogger<BranchController> _logger;

        public BranchController(AppDbContext context, ILogger<BranchController> logger)
        {
            _context = context;
            _logger = logger;
        }

        // GET: api/<BranchController>
        [HttpGet]
        public async Task<ActionResult<IEnumerable<BrachLocation>>> GetBranches()
        {
            _logger.LogInformation("Fetching all company branches from database.");
            try
            {
                var companies = await _context.Branches.ToListAsync();
                _logger.LogInformation("Fetched {Count} branches.", companies.Count);
                return Ok(companies);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error occurred while fetching braches.");
                return StatusCode(500, "An error occurred while retrieving data.");
            }
        }

        // GET api/<BranchController>/5
        [HttpGet("{id}")]
        public async Task<ActionResult<BrachLocation>> GetBranch(int id)
        {
            _logger.LogInformation("Fetching branch with ID {Id}.", id);
            try
            {
                var company = await _context.Branches.FindAsync(id);

                if (company == null)
                {
                    _logger.LogWarning("Branch with ID {Id} not found.", id);
                    return NotFound();
                }

                return Ok(company);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error occurred while fetching branch with ID {Id}.", id);
                return StatusCode(500, "An error occurred while retrieving the branch.");
            }
        }

        // POST api/<BrachLocation>
        [HttpPost]
        public async Task<ActionResult<BrachLocation>> PostBranch(BrachLocation branch)
        {
            _logger.LogInformation("Creating a new branch.");
            try
            {
                _context.Branches.Add(branch);
                await _context.SaveChangesAsync();

                _logger.LogInformation("Branch created with ID {Id}.", branch.Id);
                return CreatedAtAction(nameof(GetBranch), new { id = branch.Id }, branch);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error occurred while creating a new Branch.");
                return StatusCode(500, "An error occurred while creating the Branch.");
            }
        }

        // PUT api/<CompanyController>/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutBranch(int id, BrachLocation branch)
        {
            _logger.LogInformation("Updating Branch with ID {Id}.", id);

            if (id != branch.Id)
            {
                _logger.LogWarning("Branch ID mismatch for PUT request. Route ID: {RouteId}, Body ID: {BodyId}", id, branch.Id);
                return BadRequest("Branch ID mismatch");
            }

            _context.Entry(branch).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
                _logger.LogInformation("Branch with ID {Id} updated successfully.", id);
                return Ok(branch);
            }
            catch (DbUpdateConcurrencyException ex)
            {
                if (!BranchExists(id))
                {
                    _logger.LogWarning("Attempted to update non-existent branch with ID {Id}.", id);
                    return NotFound();
                }
                else
                {
                    _logger.LogError(ex, "Concurrency error while updating branch with ID {Id}.", id);
                    throw;
                }
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error occurred while updating branch with ID {Id}.", id);
                return StatusCode(500, "An error occurred while updating the branch.");
            }

            return NoContent();
        }

        // DELETE api/<BrachController>/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteBranch(int id)
        {
            _logger.LogInformation("Deleting branch with ID {Id}.", id);
            try
            {
                var branch = await _context.Branches.FindAsync(id);
                if (branch == null)
                {
                    _logger.LogWarning("Attempted to delete non-existent branch with ID {Id}.", id);
                    return NotFound();
                }

                _context.Branches.Remove(branch);
                await _context.SaveChangesAsync();

                _logger.LogInformation("Branch with ID {Id} deleted successfully.", id);
                return NoContent();
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error occurred while deleting branch with ID {Id}.", id);
                return StatusCode(500, "An error occurred while deleting the branch.");
            }
        }

        private bool BranchExists(int id)
        {
            return _context.Branches.Any(e => e.Id == id);
        }
    }
}
