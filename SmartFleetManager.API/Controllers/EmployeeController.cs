using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Routing;
using Microsoft.EntityFrameworkCore;
using SmartFleet.Data;
using SmartFleet.Data.Models;
using System.Net;
using System.Numerics;
using static Azure.Core.HttpHeader;

namespace SmartFleetManager.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        private readonly AppDbContext _context;
        private readonly ILogger<EmployeeController> _logger;
        private const string employeeAccountCode = "5000";
        private const string GroupName = "Driver";

        public EmployeeController(AppDbContext context, ILogger<EmployeeController> logger)
        {
            _context = context;
            _logger = logger;
        }

        // GET: api/<EmployeeController>
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Employee>>> GetEmployees()
        {
            _logger.LogInformation("Fetching all employees/users from database.");
            try
            {
                var customers = await _context.Employees.ToListAsync();
                _logger.LogInformation("Fetched {Count} employees.", customers.Count);
                return Ok(customers);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error occurred while fetching employees.");
                return StatusCode(500, "An error occurred while retrieving data.");
            }
        }

        // GET: api/<EmployeeController>
        [HttpGet("CurrentCode")]
        public async Task<ActionResult<IEnumerable<int>>> GetCurrentCode()
        {
            _logger.LogInformation("Fetching current/last employee code from database.");
            try
            {
                var currentCode = await _context.Employees.OrderByDescending(p => p.Id).Select(s => s.UserCode).FirstOrDefaultAsync();
                _logger.LogInformation("Fetched {currentCode} for emoloyee.", currentCode);
                return Ok(new { CurrentCode = currentCode });
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error occurred while fetching current employee Code.");
                return StatusCode(500, "An error occurred while retrieving data.");
            }
        }

        // GET: api/<EmployeeController>
        [HttpGet("Drivers")]
        public async Task<ActionResult<IEnumerable<Employee>>> GetDrivers()
        {
            _logger.LogInformation("Fetching employee from database based on driver Role .");
            try
            {
                var driverEmployees = await _context.Employees.Where(f => f.Role.ToLower() == "driver").ToListAsync();
                _logger.LogInformation("Fetched {count} for driver.", driverEmployees);
                return Ok(driverEmployees);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error occurred while fetching drivers.");
                return StatusCode(500, "An error occurred while retrieving data.");
            }
        }

        // GET api/<EmployeeController>/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Employee>> GetEmployee(int id)
        {
            _logger.LogInformation("Fetching employee with ID {Id}.", id);
            try
            {
                var employee = await _context.Employees.FindAsync(id);

                if (employee == null)
                {
                    _logger.LogWarning("Employee with ID {Id} not found.", id);
                    return NotFound();
                }

                return Ok(employee);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error occurred while fetching employee with ID {Id}.", id);
                return StatusCode(500, "An error occurred while retrieving the employee.");
            }
        }

        // GET api/<EmployeeController>/5
        [HttpGet("GetEmployeeAccount/{id}")]
        public async Task<ActionResult<Employee>> GetEmployeeAccount(int id)
        {
            _logger.LogInformation("Fetching employee with Account ID {Id}.", id);
            try
            {
                var employee = await _context.Employees.Where(f => f.EmpAccountID == id).FirstOrDefaultAsync();

                if (employee == null)
                {
                    _logger.LogWarning("Employee with Account ID {Id} not found.", id);
                    return NotFound();
                }

                return Ok(employee);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error occurred while fetching employee with Account ID {Id}.", id);
                return StatusCode(500, "An error occurred while retrieving the employee.");
            }
        }

        // POST api/<EmployeeController>
        [HttpPost]
        public async Task<ActionResult<Employee>> PostEmployee(Employee employee)
        {
            ArgumentNullException.ThrowIfNull(employee);
            _logger.LogInformation("Creating a new employee.");
            try
            {
                if (employee == null)
                    return BadRequest("Invalid request data.");

                // Trim name
                var name = employee.Name?.Trim();

                // 1️⃣ Validation - Empty Name
                if (string.IsNullOrWhiteSpace(name))
                {
                    return BadRequest("employee name is required.");
                }

                // 2️⃣ Check if already exists (case insensitive)
                bool isAlreadyExists = await _context.Employees
                    .AnyAsync(c => c.Name.ToLower() == name);

                if (isAlreadyExists)
                {
                    return Conflict("employee already exists.");
                }


                var parentAccount = await _context.AccountMasters.Where(f => f.AccountCode == employeeAccountCode).FirstOrDefaultAsync();
                var parentAccountId = parentAccount?.AccountID;
                var accountGroup = parentAccount?.AccountGroupCode??"";
                var accountType = parentAccount?.AccountType?? "";
                var accounts = await _context.AccountMasters.Where(f => f.AccountCode == employeeAccountCode).OrderBy(o => o.AccountID).ToListAsync();
                var nextAccountCode = accounts.Select(a => int.Parse(a.AccountCode)).Max() + 1; 
                AccountMaster newCustomerAccount = new AccountMaster
                {
                    AccountCode = nextAccountCode.ToString(),
                    AccountName = employee.Name,
                    AccountType = accountType,
                    AccountGroupCode = accountGroup,
                    Address = string.Empty,
                    BranchID = employee.BranchID,
                    CreatedAt = DateTime.UtcNow,
                    IsActive = employee.IsActive,
                    LastUpdatedAt = employee.LastUpdatedAt,
                    GroupName = employee.Role ?? GroupName,
                    Notes = string.Empty,
                    ParentAccountID = int.Parse(employeeAccountCode),
                    AccountMode = "Employee",
                };
                

                _context.AccountMasters.Add(newCustomerAccount);
                await _context.SaveChangesAsync();
                var newAccountId = newCustomerAccount.AccountID;
                
                employee.Password = "userlogin";
                employee.EmpAccountID = newAccountId; 
                _context.Employees.Add(employee);
                await _context.SaveChangesAsync();

                
                var newUserAuth = new UserAuth
                {
                    UserName = employee.Email,
                    Password = employee.Password,
                    UserCode = newAccountId.ToString(),
                    RoleId = 2,
                    CreatedAt = DateTime.UtcNow,
                    LastUpdatedAt= DateTime.UtcNow,
                    IsActive= employee.IsActive,
                };

                _context.UserAuths.Add(newUserAuth);
                await _context.SaveChangesAsync();

                _logger.LogInformation("Employee created with ID {Id}.", employee.Id);
                return CreatedAtAction(nameof(GetEmployee), new { id = employee.Id }, employee);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error occurred while creating a new employee.");
                return StatusCode(500, "An error occurred while creating the employee.");
            }
        }

        // PUT api/<EmployeeController>/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutEmployee(int id, Employee employee)
        {
            _logger.LogInformation("Updating employee with ID {Id}.", id);

            if (id != employee.Id)
            {
                _logger.LogWarning("Employee ID mismatch for PUT request. Route ID: {RouteId}, Body ID: {BodyId}", id, employee.Id);
                return BadRequest("Employee ID mismatch");
            }

            // Load existing record from DB
            var dbEmployee = await _context.Employees
                .Include(v => v.AccountMaster)
                .FirstOrDefaultAsync(v => v.Id == id);

            if (dbEmployee == null)
            {
                _logger.LogWarning("Attempted to update non-existent employee with ID {Id}.", id);
                return NotFound(new { message = "Employee not found" });
            }

            // Update scalar properties manually
            dbEmployee.UserCode = employee.UserCode;
            dbEmployee.Name = employee.Name;
            dbEmployee.FirstName = employee.FirstName;
            dbEmployee.LastName = employee.LastName;
            dbEmployee.Gender= employee.Gender;
            dbEmployee.Email = employee.Email;
            dbEmployee.Phone = employee.Phone;
            dbEmployee.Role = employee.Role;
            dbEmployee.IsActive = employee.IsActive;
            dbEmployee.BranchID = employee.BranchID;
            dbEmployee.LastUpdatedAt = DateTime.Now;

            // Update AccountId only if provided
            if (dbEmployee.EmpAccountID.HasValue)
            {
                var accountRec = await _context.AccountMasters
                    .FirstOrDefaultAsync(a => a.AccountID == dbEmployee.EmpAccountID.Value);

                if (accountRec != null)
                {
                    accountRec.AccountName = employee.Name;
                    accountRec.Address = string.Empty;
                    accountRec.BranchID = employee.BranchID;
                    accountRec.IsActive = employee.IsActive;
                    accountRec.LastUpdatedAt = DateTime.Now;
                    accountRec.GroupName = employee.Role ?? GroupName;
                    accountRec.Notes = string.Empty;
                    accountRec.AccountMode = "Employee";
                }
            }

            try
            {
                await _context.SaveChangesAsync();
                _logger.LogInformation("Employee with ID {Id} updated successfully.", id);
                return Ok(employee);
            }
            catch (DbUpdateConcurrencyException ex)
            {
                if (!EmployeeExists(id))
                {
                    _logger.LogWarning("Attempted to update non-existent employee with ID {Id}.", id);
                    return NotFound();
                }
                else
                {
                    _logger.LogError(ex, "Concurrency error while updating employee with ID {Id}.", id);
                    throw;
                }
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error occurred while updating employee with ID {Id}.", id);
                return StatusCode(500, "An error occurred while updating the employee.");
            }

            return NoContent();
        }

        // DELETE api/<CompanyController>/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteEmployee(int id)
        {
            _logger.LogInformation("Deleting employee with ID {Id}.", id);
            try
            {
                var employee = await _context.Employees.FindAsync(id);
                if (employee == null)
                {
                    _logger.LogWarning("Attempted to delete non-existent employee with ID {Id}.", id);
                    return NotFound();
                }

                if (!string.IsNullOrEmpty(employee.EmpAccountID.ToString()))
                {
                    var empAccount = await _context.AccountMasters.Where(p => p.AccountID == employee.EmpAccountID).FirstOrDefaultAsync();
                    if (empAccount != null)
                    {
                        empAccount.IsActive = false;  
                    }
                }

                _context.Employees.Remove(employee);
                await _context.SaveChangesAsync();

                _logger.LogInformation("Employee with ID {Id} deleted successfully.", id);
                return NoContent();
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error occurred while deleting customer with ID {Id}.", id);
                return StatusCode(500, "An error occurred while deleting the customer.");
            }
        }

        private bool EmployeeExists(int id)
        {
            return _context.Employees.Any(e => e.Id == id);
        }
    }
}
