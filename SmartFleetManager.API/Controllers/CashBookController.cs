using Microsoft.AspNetCore.Mvc;
using SmartFleetManager.API.Interfaces;
using SmartFleetManager.API.Models;

namespace SmartFleetManager.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CashBookController : ControllerBase
    {
        private readonly ICashBookService _cashBookService;

        public CashBookController(ICashBookService cashBookService)
        {
            _cashBookService = cashBookService;
        }

        [HttpPost("Report")]
        public async Task<IActionResult> GetReport([FromBody] CashBookFilterDto filter)
        {
            try
            {
                var result = await _cashBookService.GetCashBookAsync(filter);
                return Ok(result);
            }
            catch (ArgumentException ex)
            {
                return BadRequest(ex.Message);
            }
            catch (KeyNotFoundException ex)
            {
                return NotFound(ex.Message);
            }
        }
    }
}
