using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SmartFleet.Data;
using SmartFleet.Data.Models;

namespace SmartFleetManager.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TaxController : ControllerBase
    {
        private readonly AppDbContext _context;
        private readonly ILogger<TaxController> _logger;
        public TaxController(AppDbContext context, ILogger<TaxController> logger)
        {
            _context = context;
            _logger = logger;
        }

        // GET: api/<LocationController>
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Tax>>> GetTaxes()
        {
            _logger.LogInformation("Fetching all taxes from database.");
            try
            {
                var taxes = await _context.Taxes.ToListAsync();
                _logger.LogInformation("Fetched {Count} taxes.", taxes.Count);
                return Ok(taxes);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error occurred while fetching taxes.");
                return StatusCode(500, "An error occurred while retrieving data.");
            }
        }
    }
}
