using Azure.Core;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SmartFleet.Data;
using SmartFleet.Data.Models;
using SmartFleetManager.API.Models;
using System;

namespace SmartFleetManager.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserAuthController : ControllerBase
    {
        private readonly AppDbContext _context;
        private readonly ILogger<UserAuthController> _logger;

        public UserAuthController(AppDbContext context, ILogger<UserAuthController> logger)
        {
            _context = context;
            _logger = logger;
        }

        [HttpPost("login")]
        public async Task<ActionResult<UserAuth>> Login([FromBody] LoginRequest request)
        {
            _logger.LogInformation("Attempting login for user {0}", request.UserName);

            try
            {
                var loggedInUser = await (
                        from ua in _context.UserAuths
                        join e in _context.Employees
                            on ua.UserName equals e.Email
                        where ua.UserName == request.UserName
                              && ua.Password == request.Password
                              && ua.IsActive
                        select new
                        {
                            id = ua.Id,
                            email = ua.UserName,
                            userCode = ua.UserCode,
                            Password = ua.Password,
                            EmployeeName = e.Name,
                            FirstName = e.FirstName,
                            LastName = e.LastName,
                            Gender = e.Gender,
                        }
                    ).FirstOrDefaultAsync();

                if (loggedInUser == null)
                {
                    return Unauthorized("Invalid username or password");
                }

                return Ok(loggedInUser);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error occurred while logging in");
                return StatusCode(500, "Error occurred while logging in");
            }
        }

        [HttpGet("GetUserMenus/{id}")]
        public async Task<ActionResult<IEnumerable<MenuMaster>>> GetUserMenus(int id)
        {
            _logger.LogInformation("Fetching the user menu permission for user Id , {0}", id);

            try
            {
                var menus = await (from u in _context.UserAuths
                                   join r in _context.UserRole on u.RoleId equals r.RoleID
                                   join rm in _context.UserRoleMenus on r.RoleID equals rm.RoleId
                                   join m in _context.MenuMasters on rm.MenuId equals m.MenuID
                                   where u.Id == id && m.isActive == true && rm.IsActive == true && m.ModuleID == 1
                                   select new UserMenu
                                   {
                                       MenuId = rm.MenuId.ToString(),
                                       label = m.Name,
                                       href = m.url,
                                       icon = m.IconName,
                                       order = m.orderNo,
                                       groupName = (m.GroupId == 1 ? m.Name : (m.GroupId == 2 ? "Masters" : (m.GroupId == 3 ? "Transaction" : (m.GroupId == 4 ? "Reports" : "Accounts"))))
                                   }).ToListAsync();

                if (menus == null)
                {
                    return Unauthorized("Invalid username or password");
                }

                return Ok(menus);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error occurred while fetching user menus.");
                return StatusCode(500, "Error occurred while fetching the user menus");
            }
        }

        [HttpGet("GetUserModules/{userId}")]
        public async Task<ActionResult<IEnumerable<UserModules>>> GetUserModules(int userId)
        {
            _logger.LogInformation("Fetching the user module for user Id , {0}", userId);
            try
            {
                var userModules = await (from u in _context.UserAuths
                                  join rm in _context.UserRoleMenus on u.RoleId equals rm.RoleId
                                  join m in _context.MenuMasters on rm.MenuId equals m.MenuID
                                  join ms in _context.ModuleMasters on m.ModuleID equals ms.ModuleID
                                  where u.Id == userId && m.isActive == true && rm.IsActive == true && m.url.Contains("dashboard") 
                                  select new UserModules
                                  {
                                      Id = ms.ModuleID,
                                      ModuleName = ms.ModuleName,
                                      NavigationPath = m.url
                                  }).ToListAsync();

                if (userModules == null)
                {
                    return Unauthorized("Invalid username or password");
                }
                return Ok(userModules);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error occurred while fetching user module.");
                return StatusCode(500, "Error occurred while fetching the user module");
            }
        }
       
        [HttpPost("GetUserMenus")]
        public async Task<ActionResult<IEnumerable<MenuMaster>>> GetUserMenus(LoggedUserDto userDetail)
        {
            _logger.LogInformation("Fetching the user menu permission for user Id , {0}", userDetail.id);

            try
            {
                var menus = await (from u in _context.UserAuths
                                   join r in _context.UserRole on u.RoleId equals r.RoleID
                                   join rm in _context.UserRoleMenus on r.RoleID equals rm.RoleId
                                   join m in _context.MenuMasters on rm.MenuId equals m.MenuID
                                   where u.Id == userDetail.id && m.isActive == true && rm.IsActive == true && m.ModuleID == userDetail.ModuleId
                                   select new UserMenu
                                   {
                                       MenuId = rm.MenuId.ToString(),
                                       label = m.Name,
                                       href = m.url,
                                       icon = m.IconName,
                                       order = m.orderNo,
                                       groupName = (m.GroupId == 1 ? m.Name : (m.GroupId == 2 ? "Masters" : (m.GroupId == 3 ? "Transaction" : (m.GroupId == 4 ? "Reports" : "Accounts"))))
                                   }).ToListAsync();

                if (menus == null)
                {
                    return Unauthorized("Invalid username or password");
                }

                return Ok(menus);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error occurred while fetching user menus.");
                return StatusCode(500, "Error occurred while fetching the user menus");
            }
        }

    }

}
