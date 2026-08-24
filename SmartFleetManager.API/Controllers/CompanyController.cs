using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SmartFleet.Data;
using SmartFleet.Data.Models;

namespace SmartFleetManager.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CompanyController : ControllerBase
    {
        private readonly AppDbContext _context;
        private readonly ILogger<CompanyController> _logger;

        public CompanyController(AppDbContext context, ILogger<CompanyController> logger)
        {
            _context = context;
            _logger = logger;
        }

        // GET: api/<CompanyController>
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Company>>> GetCompanies()
        {
            _logger.LogInformation("Fetching all companies from database.");
            try
            {
                var companies = await _context.Companies.ToListAsync();
                _logger.LogInformation("Fetched {Count} companies.", companies.Count);
                return Ok(companies);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error occurred while fetching companies.");
                return StatusCode(500, "An error occurred while retrieving data.");
            }
        }

        // GET api/<CompanyController>/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Company>> GetCompany(int id)
        {
            _logger.LogInformation("Fetching company with ID {Id}.", id);
            try
            {
                var company = await _context.Companies.FindAsync(id);

                if (company == null)
                {
                    _logger.LogWarning("Company with ID {Id} not found.", id);
                    return NotFound();
                }

                return Ok(company);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error occurred while fetching company with ID {Id}.", id);
                return StatusCode(500, "An error occurred while retrieving the company.");
            }
        }

        // POST api/<CompanyController>
        [HttpPost]
        public async Task<ActionResult<Company>> PostCompany(Company company)
        {
            _logger.LogInformation("Creating a new company.");
            try
            {
                _context.Companies.Add(company);
                await _context.SaveChangesAsync();

                _logger.LogInformation("Company created with ID {Id}.", company.Id);
                return CreatedAtAction(nameof(GetCompany), new { id = company.Id }, company);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error occurred while creating a new company.");
                return StatusCode(500, "An error occurred while creating the company.");
            }
        }

        // PUT api/<CompanyController>/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutCompany(int id, Company company)
        {
            _logger.LogInformation("Updating company with ID {Id}.", id);

            if (id != company.Id)
            {
                _logger.LogWarning("Company ID mismatch for PUT request. Route ID: {RouteId}, Body ID: {BodyId}", id, company.Id);
                return BadRequest("Company ID mismatch");
            }

            _context.Entry(company).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
                _logger.LogInformation("Company with ID {Id} updated successfully.", id);
                return Ok(company);
            }
            catch (DbUpdateConcurrencyException ex)
            {
                if (!CompanyExists(id))
                {
                    _logger.LogWarning("Attempted to update non-existent company with ID {Id}.", id);
                    return NotFound();
                }
                else
                {
                    _logger.LogError(ex, "Concurrency error while updating company with ID {Id}.", id);
                    throw;
                }
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error occurred while updating company with ID {Id}.", id);
                return StatusCode(500, "An error occurred while updating the company.");
            }

            return NoContent();
        }

        // DELETE api/<CompanyController>/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteCompany(int id)
        {
            _logger.LogInformation("Deleting company with ID {Id}.", id);
            try
            {
                var company = await _context.Companies.FindAsync(id);
                if (company == null)
                {
                    _logger.LogWarning("Attempted to delete non-existent company with ID {Id}.", id);
                    return NotFound();
                }

                _context.Companies.Remove(company);
                await _context.SaveChangesAsync();

                _logger.LogInformation("Company with ID {Id} deleted successfully.", id);
                return NoContent();
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error occurred while deleting company with ID {Id}.", id);
                return StatusCode(500, "An error occurred while deleting the company.");
            }
        }

        private bool CompanyExists(int id)
        {
            return _context.Companies.Any(e => e.Id == id);
        }
    }
}
