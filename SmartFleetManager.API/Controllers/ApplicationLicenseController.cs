using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using SmartFleet.Data;
using SmartFleet.Data.Models;
using SmartFleet.Utility;

namespace SmartFleetManager.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ApplicationLicenseController : ControllerBase
    {
        private readonly AppDbContext _context;

        public ApplicationLicenseController(AppDbContext context)
        {
            _context = context;
        }
        [HttpGet]
        public async Task<IActionResult> Get()
        {

            var companyDetail = await _context.Companies.FirstOrDefaultAsync();
            if (string.IsNullOrEmpty(companyDetail?.LicenseCode??""))
            {
                return BadRequest("Product License missing. Please contact Support team.");
            }
            var result = ProductValidateHelper.ValidateProductKeyWithMessage(companyDetail?.LicenseCode??"", companyDetail?.Name??"");
            return Ok(result);
        }
    }
}
