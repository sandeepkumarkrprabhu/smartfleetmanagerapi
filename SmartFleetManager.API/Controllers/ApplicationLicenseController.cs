using Microsoft.AspNetCore.Mvc;
using SmartFleetManager.API.Interfaces;
using SmartFleetManager.API.Models;

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

        [HttpPut]
        public async Task<IActionResult> Update([FromBody] UpdateCompanyLicenseRequest request)
        {
            if (!ModelState.IsValid)
                return ValidationProblem(ModelState);

            try
            {
                var result = await _licenseService.UpdateCompanyLicenseAsync(request.LicenseCode);

                if (result == null)
                    return NotFound(new { message = "Company details are not configured." });

                return Ok(result);
            }
            catch (ArgumentException ex)
            {
                return BadRequest(new { message = ex.Message });
            }
        }
    }
}