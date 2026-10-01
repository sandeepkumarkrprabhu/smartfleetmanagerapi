using Microsoft.AspNetCore.Mvc;
using SmartFleetManager.API.Interfaces;
using SmartFleetManager.API.Models;

namespace SmartFleetManager.API.Controllers
{
    [ApiController]
    [Route("api/dashboard/accounts")]
    public class AccountsDashboardController : ControllerBase
    {
        private readonly IAccountsDashboardService _dashboardService;

        public AccountsDashboardController(
            IAccountsDashboardService dashboardService)
        {
            _dashboardService = dashboardService;
        }

        [HttpGet]
        public async Task<ActionResult<AccountsDashboardDto>> Get(
            [FromQuery] AccountsDashboardFilterDto filter)
        {
            try
            {
                var result = await _dashboardService.GetDashboardAsync(filter);
                return Ok(result);
            }
            catch (ArgumentException ex)
            {
                return BadRequest(new { message = ex.Message });
            }
        }
    }
}
