using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SmartFleet.Data;
using SmartFleet.Data.Models;

namespace SmartFleetManager.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ApplicationModuleSettingController : ControllerBase
    {
        private readonly AppDbContext _context;
        private readonly ILogger<ApplicationModuleSettingController> _logger;

        public ApplicationModuleSettingController(AppDbContext context, ILogger<ApplicationModuleSettingController> logger)
        {
            _context = context;
            _logger = logger;
        }

        // GET: api/ApplicationModuleSetting
        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            try
            {
                var settings = await _context.applicationModuleSettings.ToListAsync();
                return Ok(settings);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error fetching settings");
                return StatusCode(500, "Internal server error");
            }
        }

        // GET: api/ApplicationModuleSetting/module/Accounts
        [HttpGet("module/{moduleName}")]
        public async Task<IActionResult> GetByModule(string moduleName)
        {
            try
            {
                var settings = await _context.applicationModuleSettings
                    .Where(x => x.ModuleName == moduleName)
                    .ToListAsync();

                return Ok(settings);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error fetching module settings");
                return StatusCode(500, "Internal server error");
            }
        }

        // ✅ GET: api/ApplicationModuleSetting/key/Accounts.AllowBackDateEntry
        [HttpGet("key/{key}")]
        public async Task<IActionResult> GetByKey(string key)
        {
            try
            {
                var setting = await _context.applicationModuleSettings
                    .FirstOrDefaultAsync(x => x.SettingKey == key);

                if (setting == null)
                    return NotFound();

                return Ok(setting);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error fetching setting by key");
                return StatusCode(500, "Internal server error");
            }
        }

        // ✅ POST: api/ApplicationModuleSetting
        [HttpPost]
        public async Task<IActionResult> Create(ApplicationModuleSetting model)
        {
            try
            {
                // Prevent duplicate keys
                var exists = await _context.applicationModuleSettings
                    .AnyAsync(x => x.SettingKey == model.SettingKey);

                if (exists)
                    return BadRequest("Setting key already exists.");

                _context.applicationModuleSettings.Add(model);
                await _context.SaveChangesAsync();

                return Ok(model);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error creating setting");
                return StatusCode(500, "Internal server error");
            }
        }

        // ✅ PUT: api/ApplicationModuleSetting/5
        [HttpPut("{id}")]
        public async Task<IActionResult> Update(int id, ApplicationModuleSetting model)
        {
            if (id != model.Id)
                return BadRequest("Invalid ID");

            try
            {
                var existing = await _context.applicationModuleSettings.FindAsync(id);

                if (existing == null)
                    return NotFound();

                // Update fields
                existing.ModuleName = model.ModuleName;
                existing.SettingName = model.SettingName;
                existing.SettingKey = model.SettingKey;
                existing.DataType = model.DataType;
                existing.DefaultValue = model.DefaultValue;
                existing.IsEditable = model.IsEditable;
                existing.IsActive = model.IsActive;
                existing.Description = model.Description;

                await _context.SaveChangesAsync();

                return Ok(existing);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error updating setting");
                return StatusCode(500, "Internal server error");
            }
        }

        // ✅ DELETE: api/ApplicationModuleSetting/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            try
            {
                var setting = await _context.applicationModuleSettings.FindAsync(id);

                if (setting == null)
                    return NotFound();

                _context.applicationModuleSettings.Remove(setting);
                await _context.SaveChangesAsync();

                return Ok("Deleted successfully");
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error deleting setting");
                return StatusCode(500, "Internal server error");
            }
        }
    }
}