using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SmartFleet.Data;

namespace SmartFleetManager.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ModuleController : ControllerBase
    {
        private readonly AppDbContext _context;
        private readonly ILogger<ModuleController> _logger;

        public ModuleController(AppDbContext context, ILogger<ModuleController> logger)
        {
            _context = context;
            _logger = logger;
        }

        // GET: api/ModuleController
        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            try
            {
                var settings = await _context.ModuleMasters.ToListAsync();
                return Ok(settings);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error fetching module master");
                return StatusCode(500, "Internal server error");
            }
        }
    }
}
