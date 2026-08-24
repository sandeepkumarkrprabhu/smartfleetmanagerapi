using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SmartFleet.Data;
using SmartFleet.Data.Models;
using SmartFleet.Utility;
using System.Net;
using System.Numerics;
using static Azure.Core.HttpHeader;

namespace SmartFleetManager.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        private readonly AppDbContext _context;
        private readonly ILogger<CustomerController> _logger;
        private const string CustomerAccountCode = "1200";
        private const string GroupNameAttribute = "Receivables";

        public CustomerController(AppDbContext context, ILogger<CustomerController> logger)
        {
            _context = context;
            _logger = logger;
        }

        // GET: api/<CustomerController>
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Customer>>> GetCustomers()
        {
            _logger.LogInformation("Fetching all customers from database.");
            try
            {
                var customers = await _context.Customers.ToListAsync();
                _logger.LogInformation("Fetched {Count} customers.", customers.Count);
                return Ok(customers);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error occurred while fetching customers.");
                return StatusCode(500, "An error occurred while retrieving data.");
            }
        }

        // GET: api/<CustomerController>
        [HttpGet("GetStockistCustomers")]
        public async Task<ActionResult<IEnumerable<Customer>>> GetStockistCustomers()
        {
            _logger.LogInformation("Fetching all Stockist customers from database.");
            try
            {
                var customers = await _context.Customers.Where(f => f.CustomerType == "Agents").ToListAsync();
                _logger.LogInformation("Fetched {Count} Stockist customers.", customers.Count);
                return Ok(customers);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error occurred while fetching Stockist customers.");
                return StatusCode(500, "An error occurred while retrieving data.");
            }
        }

        // GET: api/<CustomerController>
        [HttpGet("CurrentCode")]
        public async Task<ActionResult<IEnumerable<int>>> GetCurrentCode()
        {
            _logger.LogInformation("Fetching current/last customer code from database.");
            try
            {
                var currentCode = await _context.Customers.OrderByDescending(p => p.Id).Select(s => s.CustomerCode).FirstOrDefaultAsync();
                _logger.LogInformation("Fetched {currentCode} for customer.", currentCode);
                return Ok(new { CurrentCode = currentCode });
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error occurred while fetching current customer Code.");
                return StatusCode(500, "An error occurred while retrieving data.");
            }
        }

        // GET api/<CompanyController>/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Customer>> GetCustomer(int id)
        {
            _logger.LogInformation("Fetching customer with ID {Id}.", id);
            try
            {
                var customer = await _context.Customers.FindAsync(id);

                if (customer == null)
                {
                    _logger.LogWarning("Customer with ID {Id} not found.", id);
                    return NotFound();
                }

                return Ok(customer);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error occurred while fetching customer with ID {Id}.", id);
                return StatusCode(500, "An error occurred while retrieving the customer.");
            }
        }

        // GET api/<CompanyController>/5
        [HttpGet("GetCustomerAccount/{id}")]
        public async Task<ActionResult<Customer>> GetCustomerAccount(int id)
        {
            _logger.LogInformation("Fetching customer with Account ID {Id}.", id);
            try
            {
                var customer = await _context.Customers.Where(f => f.AccountId == id).FirstOrDefaultAsync();

                if (customer == null)
                {
                    _logger.LogWarning("Customer with ID {Id} not found.", id);
                    return NotFound();
                }

                return Ok(customer);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error occurred while fetching customer with ID {Id}.", id);
                return StatusCode(500, "An error occurred while retrieving the customer.");
            }
        }

        // POST api/<CompanyController>
        [HttpPost]
        public async Task<ActionResult<Customer>> PostCompany(Customer customer)
        {
            ArgumentNullException.ThrowIfNull(customer);
            _logger.LogInformation("Creating a new customer.");
            try
            {
                if (customer == null)
                    return BadRequest("Invalid request data.");

                // Trim name
                var name = customer.Name?.Trim();

                // 1️⃣ Validation - Empty Name
                if (string.IsNullOrWhiteSpace(name))
                {
                    return BadRequest("Customer name is required.");
                }

                // 2️⃣ Check if already exists (case insensitive)
                bool isAlreadyExists = await _context.Customers
                    .AnyAsync(c => c.Name.ToLower() == name);

                if (isAlreadyExists)
                {
                    return Conflict("Customer already exists.");
                }
                var parentAccount = await _context.AccountMasters.Where(f => f.AccountCode == CustomerAccountCode).FirstOrDefaultAsync();
                var parentAccountId = parentAccount?.AccountID ?? 0;
                var accountGroup = parentAccount?.AccountGroupCode ?? "";
                var accountType = parentAccount?.AccountType ?? "";
                var accounts = await _context.AccountMasters.Where(f => f.ParentAccountID == parentAccountId).OrderBy(o => o.AccountID).ToListAsync();
                var nextAccountCode = accounts.Select(a => int.Parse(a.AccountCode)).Max() + 1;
                AccountMaster newCustomerAccount = new AccountMaster
                {
                    AccountCode = nextAccountCode.ToString(),
                    AccountName = customer.Name,
                    AccountType = accountType,
                    AccountGroupCode = accountGroup,
                    Address = customer.Address,
                    BranchID = customer.BranchID,
                    CreatedAt = DateTime.UtcNow,
                    IsActive = customer.IsActive,
                    LastUpdatedAt = customer.LastUpdatedAt,
                    GroupName = GroupNameAttribute,
                    Notes = string.Empty,
                    ParentAccountID = parentAccountId,
                    AccountMode = "Customers",
                };

                _context.AccountMasters.Add(newCustomerAccount);
                await _context.SaveChangesAsync();
                var newAccountId = newCustomerAccount.AccountID;

                customer.AccountId = newAccountId;
                _context.Customers.Add(customer);
                await _context.SaveChangesAsync();

                _logger.LogInformation("Customer created with ID {Id}.", customer.Id);
                return CreatedAtAction(nameof(GetCustomer), new { id = customer.Id }, customer);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error occurred while creating a new company.");
                return StatusCode(500, "An error occurred while creating the company.");
            }
        }

        // PUT api/<CompanyController>/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutCustomer(int id, Customer customer)
        {
            _logger.LogInformation("Updating customer with ID {Id}.", id);

            if (id != customer.Id)
            {
                _logger.LogWarning("Customer ID mismatch for PUT request. Route ID: {RouteId}, Body ID: {BodyId}", id, customer.Id);
                return BadRequest("Customer ID mismatch");
            }

            // Load existing record from DB
            var dbCustomer = await _context.Customers
                .Include(v => v.AccountMaster) // Include navigation if needed
                .FirstOrDefaultAsync(v => v.Id == id);

            if (dbCustomer == null)
            {
                _logger.LogWarning("Attempted to update non-existent customer with ID {Id}.", id);
                return NotFound(new { message = "Customer not found" });
            }

            // Update scalar properties manually
            dbCustomer.CustomerCode = customer.CustomerCode;
            dbCustomer.Name = customer.Name;
            dbCustomer.ContactPerson = customer.ContactPerson;
            dbCustomer.Email = customer.Email;
            dbCustomer.Phone = customer.Phone;
            dbCustomer.Address = customer.Address;
            dbCustomer.TaxNumber = customer.TaxNumber;
            dbCustomer.PaymentTerms = customer.PaymentTerms;
            dbCustomer.CustomerType = customer.CustomerType;
            dbCustomer.BillingMode = customer.BillingMode;
            dbCustomer.IsActive = customer.IsActive;
            dbCustomer.BranchID = customer.BranchID;
            dbCustomer.LastUpdatedAt = DateTime.Now;
            dbCustomer.GSTNo = customer.GSTNo;
            dbCustomer.PanNo = customer.PanNo;
            dbCustomer.State = customer.State;
            dbCustomer.IsTaxableInvoice = customer.IsTaxableInvoice;
            dbCustomer.InvoiceTemplateName = customer.InvoiceTemplateName;

            // Update AccountId only if provided
            if (customer.AccountId.HasValue)
            {
                var accountRec = await _context.AccountMasters
                    .FirstOrDefaultAsync(a => a.AccountID == customer.AccountId.Value);

                if (accountRec != null)
                {
                    accountRec.AccountName = customer.Name;
                    accountRec.Address = customer.Address;
                    accountRec.BranchID = customer.BranchID;
                    accountRec.IsActive = customer.IsActive;
                    accountRec.LastUpdatedAt = DateTime.Now;
                    accountRec.GroupName = GroupNameAttribute;
                    accountRec.Notes = string.Empty;
                    accountRec.AccountMode = "Customers";
                }
            }

            try
            {
                await _context.SaveChangesAsync();
                _logger.LogInformation("Customer with ID {Id} updated successfully.", id);
                return Ok(customer);
            }
            catch (DbUpdateConcurrencyException ex)
            {
                if (!CustomerExists(id))
                {
                    _logger.LogWarning("Attempted to update non-existent customer with ID {Id}.", id);
                    return NotFound();
                }
                else
                {
                    _logger.LogError(ex, "Concurrency error while updating customer with ID {Id}.", id);
                    throw;
                }
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error occurred while updating customer with ID {Id}.", id);
                return StatusCode(500, "An error occurred while updating the customer.");
            }

            return NoContent();
        }

        // DELETE api/<CompanyController>/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteCustomer(int id)
        {
            _logger.LogInformation("Deleting customer with ID {Id}.", id);
            try
            {
                var customer = await _context.Customers.FindAsync(id);
                if (customer == null)
                {
                    _logger.LogWarning("Attempted to delete non-existent customer with ID {Id}.", id);
                    return NotFound();
                }

                if (!string.IsNullOrEmpty(customer.AccountId.ToString()))
                {
                    var customerAcc = await _context.AccountMasters.Where(p => p.AccountID == customer.AccountId).FirstOrDefaultAsync();
                    if (customerAcc != null)
                    {
                        customerAcc.IsActive = false;
                    }
                }

                _context.Customers.Remove(customer);
                await _context.SaveChangesAsync();

                _logger.LogInformation("Customer with ID {Id} deleted successfully.", id);
                return NoContent();
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error occurred while deleting customer with ID {Id}.", id);
                return StatusCode(500, "An error occurred while deleting the customer.");
            }
        }

        private bool CustomerExists(int id)
        {
            return _context.Customers.Any(e => e.Id == id);
        }
    }
}
