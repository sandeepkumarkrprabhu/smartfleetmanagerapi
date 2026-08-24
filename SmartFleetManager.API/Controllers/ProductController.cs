using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SmartFleet.Data;
using SmartFleet.Data.Models;

namespace SmartFleetManager.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly AppDbContext _context;
        private readonly ILogger<ProductController> _logger;

        public ProductController(AppDbContext context, ILogger<ProductController> logger)
        {
            _context = context;
            _logger = logger;
        }

        // GET: api/<ProductController>
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Product>>> GetProducts()
        {
            _logger.LogInformation("Fetching all products from database.");
            try
            {
                var products = await _context.Products.ToListAsync();
                _logger.LogInformation("Fetched {Count} products.", products.Count);
                return Ok(products);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error occurred while fetching products.");
                return StatusCode(500, "An error occurred while retrieving data.");
            }
        }

        // GET: api/<ProductController>
        [HttpGet("CurrentCode")]
        public async Task<ActionResult<IEnumerable<int>>> GetCurrentCode()
        {
            _logger.LogInformation("Fetching current/last product code from database.");
            try
            {
                var currentCode = await _context.Products.OrderByDescending(p => p.Id).Select(s => s.ProductCode).FirstOrDefaultAsync();
                _logger.LogInformation("Fetched {currentCode} for Product.", currentCode);
                return Ok(new { CurrentCode = currentCode });
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error occurred while fetching current employee Code.");
                return StatusCode(500, "An error occurred while retrieving data.");
            }
        }

        // GET api/<ProductController>/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Product>> GetProduct(int id)
        {
            _logger.LogInformation("Fetching product with ID {Id}.", id);
            try
            {
                var company = await _context.Products.FindAsync(id);

                if (company == null)
                {
                    _logger.LogWarning("Product with ID {Id} not found.", id);
                    return NotFound();
                }

                return Ok(company);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error occurred while fetching product with ID {Id}.", id);
                return StatusCode(500, "An error occurred while retrieving the product.");
            }
        }

        // POST api/<ProductController>
        [HttpPost]
        public async Task<ActionResult<Product>> PostProduct(Product product)
        {
            _logger.LogInformation("Creating a new Product.");
            try
            {
                if (product == null)
                    return BadRequest("Invalid request data.");

                // Trim name
                var name = product.Name?.Trim();

                // 1️⃣ Validation - Empty Name
                if (string.IsNullOrWhiteSpace(name))
                {
                    return BadRequest("product name is required.");
                }

                // 2️⃣ Check if already exists (case insensitive)
                bool isAlreadyExists = await _context.Products
                    .AnyAsync(c => c.Name.ToLower() == name);

                if (isAlreadyExists)
                {
                    return Conflict("product already exists.");
                }

                _context.Products.Add(product);
                await _context.SaveChangesAsync();

                _logger.LogInformation("Product created with ID {Id}.", product.Id);
                return CreatedAtAction(nameof(GetProduct), new { id = product.Id }, product);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error occurred while creating a new product.");
                return StatusCode(500, "An error occurred while creating the product.");
            }
        }

        // PUT api/<ProductController>/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutProduct(int id, Product product)
        {
            _logger.LogInformation("Updating product with ID {Id}.", id);

            if (id != product.Id)
            {
                _logger.LogWarning("Product ID mismatch for PUT request. Route ID: {RouteId}, Body ID: {BodyId}", id, product.Id);
                return BadRequest("Product ID mismatch");
            }

            _context.Entry(product).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
                _logger.LogInformation("Product with ID {Id} updated successfully.", id);
                return Ok(product);
            }
            catch (DbUpdateConcurrencyException ex)
            {
                if (!ProductExists(id))
                {
                    _logger.LogWarning("Attempted to update non-existent product with ID {Id}.", id);
                    return NotFound();
                }
                else
                {
                    _logger.LogError(ex, "Concurrency error while updating product with ID {Id}.", id);
                    throw;
                }
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error occurred while updating unit with ID {Id}.", id);
                return StatusCode(500, "An error occurred while updating the product.");
            }

            return NoContent();
        }

        // DELETE api/<ProductController>/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteProduct(int id)
        {
            _logger.LogInformation("Deleting product with ID {Id}.", id);
            try
            {
                var product = await _context.Products.FindAsync(id);
                if (product == null)
                {
                    _logger.LogWarning("Attempted to delete non-existent product with ID {Id}.", id);
                    return NotFound();
                }

                _context.Products.Remove(product);
                await _context.SaveChangesAsync();

                _logger.LogInformation("Product with ID {Id} deleted successfully.", id);
                return NoContent();
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error occurred while deleting product with ID {Id}.", id);
                return StatusCode(500, "An error occurred while deleting the product.");
            }
        }

        private bool ProductExists(int id)
        {
            return _context.Products.Any(e => e.Id == id);
        }
    }
}
