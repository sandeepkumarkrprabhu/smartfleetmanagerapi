using Microsoft.AspNetCore.Mvc;
using SmartFleetManager.API.Interfaces;

namespace SmartFleetManager.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ApplicationLicenseController : ControllerBase
    {
        private readonly IApplicationLicenseService _licenseService;

        public ApplicationLicenseController(IApplicationLicenseService licenseService)
        {
            _licenseService = licenseService;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var result = await _licenseService.GetLicenseStatusAsync();
            return Ok(result);
        }
    }
}