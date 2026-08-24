using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SmartFleet.Data;
using SmartFleet.Data.Models;
using SmartFleet.Utility;
using System.Net;
using static Azure.Core.HttpHeader;

namespace SmartFleetManager.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VendorController : ControllerBase
    {
        private readonly AppDbContext _context;
        private readonly ILogger<VendorController> _logger;
        private const string VendorAccountCode = "2000";
        public const string GroupName = "Payables";

        public VendorController(AppDbContext context, ILogger<VendorController> logger)
        {
            _context = context;
            _logger = logger;
        }

        // GET: api/<VendorController>
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Vendor>>> GetVendors()
        {
            _logger.LogInformation("Fetching all vendors from database.");
            try
            {
                var vendors = await _context.Vendors.ToListAsync();
                _logger.LogInformation("Fetched {Count} vendors.", vendors.Count);
                return Ok(vendors);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error occurred while fetching venodrs.");
                return StatusCode(500, "An error occurred while retrieving data.");
            }
        }

        // GET: api/<UnitController>
        [HttpGet("CurrentCode")]
        public async Task<ActionResult<IEnumerable<int>>> GetCurrentCode()
        {
            _logger.LogInformation("Fetching current/last vendor code from database.");
            try
            {
                var currentCode = await _context.Vendors.OrderByDescending(p => p.Id).Select(s => s.VendorCode).FirstOrDefaultAsync();
                _logger.LogInformation("Fetched {currentCode} for vendor.", currentCode);
                return Ok(new { CurrentCode = currentCode });
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error occurred while fetching current vendor Code.");
                return StatusCode(500, "An error occurred while retrieving data.");
            }
        }

        // GET api/<VendorController>/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Vendor>> GetVendor(int id)
        {
            _logger.LogInformation("Fetching vendor with ID {Id}.", id);
            try
            {
                var vendor = await _context.Vendors.FindAsync(id);

                if (vendor == null)
                {
                    _logger.LogWarning("Vendor with ID {Id} not found.", id);
                    return NotFound();
                }

                return Ok(vendor);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error occurred while fetching vendor with ID {Id}.", id);
                return StatusCode(500, "An error occurred while retrieving the vendor.");
            }
        }

        // POST api/<VendorController>
        [HttpPost]
        public async Task<ActionResult<Vendor>> PostVendor(Vendor vendor)
        {
            ArgumentNullException.ThrowIfNull(vendor);
            _logger.LogInformation("Creating a new customer.");
            try
            {
                if (vendor == null)
                    return BadRequest("Invalid request data.");

                // Trim name
                var name = vendor.Name?.Trim();

                // 1️⃣ Validation - Empty Name
                if (string.IsNullOrWhiteSpace(name))
                {
                    return BadRequest("vendor name is required.");
                }

                // 2️⃣ Check if already exists (case insensitive)
                bool isAlreadyExists = await _context.Vendors
                    .AnyAsync(c => c.Name.ToLower() == name);

                if (isAlreadyExists)
                {
                    return Conflict("vendor already exists.");
                }

                var parentAccount = await _context.AccountMasters.Where(f => f.AccountCode == VendorAccountCode).FirstOrDefaultAsync();
                var parentAccountId = parentAccount?.AccountID;
                var accountGroup = parentAccount?.AccountGroupCode ?? "";
                var accountType = parentAccount?.AccountType ?? "";
                var accounts = await _context.AccountMasters.Where(f => f.AccountCode == VendorAccountCode).OrderBy(o => o.AccountID).ToListAsync();
                var nextAccountCode = accounts.Select(a => int.Parse(a.AccountCode)).Max() + 1;
                AccountMaster newCustomerAccount = new AccountMaster
                {
                    AccountCode = nextAccountCode.ToString(),
                    AccountName = vendor.Name,
                    AccountType = accountType,
                    AccountGroupCode = accountGroup,
                    Address = vendor.Address,
                    BranchID = vendor.BranchID,
                    CreatedAt = DateTime.UtcNow,
                    IsActive = vendor.IsActive,
                    GroupName = GroupName,
                    LastUpdatedAt = vendor.LastUpdatedAt,
                    Notes = string.Empty,
                    ParentAccountID = parentAccountId??0,
                    AccountMode = "Vendors"
                };

                _context.AccountMasters.Add(newCustomerAccount);
                await _context.SaveChangesAsync();
                var newAccountId = newCustomerAccount.AccountID;

                vendor.AccountId = newAccountId;

                _context.Vendors.Add(vendor);
                await _context.SaveChangesAsync();

                _logger.LogInformation("Customer created with ID {Id}.", vendor.Id);
                return CreatedAtAction(nameof(GetVendor), new { id = vendor.Id }, vendor);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error occurred while creating a new vendor.");
                return StatusCode(500, "An error occurred while creating the vendor.");
            }
        }

        // PUT api/<VendorController>/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutVendor(int id, Vendor vendor)
        {
            _logger.LogInformation("Updating vendor with ID {Id}.", id);

            if (id != vendor.Id)
            {
                _logger.LogWarning("Vendor ID mismatch for PUT request. Route ID: {RouteId}, Body ID: {BodyId}", id, vendor.Id);
                return BadRequest("Vendor ID mismatch");
            }

            // Load existing vendor from DB
            var dbVendor = await _context.Vendors
                .Include(v => v.AccountMaster) // Include navigation if needed
                .FirstOrDefaultAsync(v => v.Id == id);

            if (dbVendor == null)
            {
                _logger.LogWarning("Attempted to update non-existent vendor with ID {Id}.", id);
                return NotFound(new { message = "Vendor not found" });
            }

            // Update scalar properties manually
            dbVendor.VendorCode = vendor.VendorCode;
            dbVendor.Name = vendor.Name;
            dbVendor.ContactPerson = vendor.ContactPerson;
            dbVendor.Email = vendor.Email;
            dbVendor.Phone = vendor.Phone;
            dbVendor.Address = vendor.Address;
            dbVendor.TaxNumber = vendor.TaxNumber;
            dbVendor.PaymentTerms = vendor.PaymentTerms;
            dbVendor.CustomerType = vendor.CustomerType;
            dbVendor.BillingMode = vendor.BillingMode;
            dbVendor.IsActive = vendor.IsActive;
            dbVendor.BranchID = vendor.BranchID;
            dbVendor.LastUpdatedAt = DateTime.Now;
            dbVendor.Agentname = vendor.Agentname;
            dbVendor.commissionPer = vendor.commissionPer;

            // Update AccountId only if provided
            if (vendor.AccountId.HasValue)
            {
                var accountRec = await _context.AccountMasters
                    .FirstOrDefaultAsync(a => a.AccountID == vendor.AccountId.Value);

                if (accountRec != null)
                {
                    accountRec.AccountName = vendor.Name;
                    accountRec.Address = vendor.Address;
                    accountRec.BranchID = vendor.BranchID;
                    accountRec.IsActive = vendor.IsActive;
                    accountRec.GroupName = GroupName;
                    accountRec.LastUpdatedAt = DateTime.Now;
                    accountRec.Notes = string.Empty;
                    accountRec.AccountMode = "Vendors";
                }
            }

            try
            {
                await _context.SaveChangesAsync();
                _logger.LogInformation("Vendor with ID {Id} updated successfully.", id);
                return Ok(dbVendor);
            }
            catch (DbUpdateConcurrencyException ex)
            {
                if (!VendorExists(id))
                {
                    _logger.LogWarning("Attempted to update non-existent vendor with ID {Id}.", id);
                    return NotFound();
                }
                else
                {
                    _logger.LogError(ex, "Concurrency error while updating vendor with ID {Id}.", id);
                    throw;
                }
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error occurred while updating vendor with ID {Id}.", id);
                return StatusCode(500, "An error occurred while updating the vendor.");
            }
        }




        // DELETE api/<VendorController>/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteVendor(int id)
        {
            _logger.LogInformation("Deleting vendor with ID {Id}.", id);
            try
            {
                var vendor = await _context.Vendors.FindAsync(id);
                if (vendor == null)
                {
                    _logger.LogWarning("Attempted to delete non-existent vendor with ID {Id}.", id);
                    return NotFound();
                }

                if (!string.IsNullOrEmpty(vendor.AccountId.ToString()))
                {
                    var vendorAcc = await _context.AccountMasters.Where(p => p.AccountID == vendor.AccountId).FirstOrDefaultAsync();
                    if (vendorAcc != null)
                    {
                        vendorAcc.IsActive = false;  
                    }
                }
                _context.Vendors.Remove(vendor);
                await _context.SaveChangesAsync();

                _logger.LogInformation("Vendor with ID {Id} deleted successfully.", id);
                return NoContent();
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error occurred while deleting vendor with ID {Id}.", id);
                return StatusCode(500, "An error occurred while deleting the vendor.");
            }
        }

        private bool VendorExists(int id)
        {
            return _context.Vendors.Any(e => e.Id == id);
        }
    }
}
