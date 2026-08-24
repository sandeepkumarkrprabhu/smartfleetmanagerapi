using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SmartFleet.Data;

namespace SmartFleetManager.API.Controllers
{
    [ApiController]
    [Route("api/fileupload")]
    public class FileUploadController : ControllerBase
    {
        private readonly AppDbContext _context;
        private readonly IWebHostEnvironment _env;
        private readonly ILogger<FileUploadController> _logger;

        public FileUploadController(AppDbContext context,
            IWebHostEnvironment env,
            ILogger<FileUploadController> logger)
        {
            _context = context;
            _env = env;
            _logger = logger;
        }

        [HttpPut("upload")]
        [DisableRequestSizeLimit]
        public async Task<IActionResult> UploadReceipt(
    [FromQuery] int tripId,
    [FromQuery] string fileName)
        {
            try
            {
                var tripReceipt = _context.TripReceiptAcknoledgementsInfos.Where(p => p.TripId == tripId).FirstOrDefault();
                if (tripReceipt != null && !string.IsNullOrWhiteSpace(tripReceipt.UploadedReceiptUrl))
                {
                    // UploadedReceiptUrl example: /public/receipts/2008_2025_12345.pdf
                    var relativePath = tripReceipt.UploadedReceiptUrl
                        .TrimStart('/', '\\')
                        .Replace("/", Path.DirectorySeparatorChar.ToString());

                    var tripReceiptPath = Path.Combine(_env.WebRootPath, relativePath);

                    if (System.IO.File.Exists(tripReceiptPath))
                    {
                        System.IO.File.Delete(tripReceiptPath);
                    }
                }


                if (string.IsNullOrWhiteSpace(_env.WebRootPath))
                    return StatusCode(500, "wwwroot not found");

                var extension = Path.GetExtension(fileName);
                if (string.IsNullOrEmpty(extension))
                    return BadRequest("Invalid file");

                var year = DateTime.UtcNow.Year;
                var random = Random.Shared.Next(100000, 999999);

                var storedFileName = $"{tripId}_{year}_{random}{extension}";

                var receiptsPath = Path.Combine(
                    _env.WebRootPath,
                    "public",
                    "receipts"
                );

                Directory.CreateDirectory(receiptsPath);

                var fullPath = Path.Combine(receiptsPath, storedFileName);

                await using var fs = new FileStream(fullPath, FileMode.Create);
                await Request.Body.CopyToAsync(fs);
                
                return Ok(new
                {
                    fileName = storedFileName,
                    relativePath = $"/public/receipts/{storedFileName}"
                });
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }
    }
}
