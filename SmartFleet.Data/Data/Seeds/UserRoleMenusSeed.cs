using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SmartFleet.Data.Models;

namespace SmartFleet.Data.Data.Seeds
{
    public class UserRoleMenusSeed: IEntityTypeConfiguration<UserRoleMenu>
    {
        public void Configure(EntityTypeBuilder<UserRoleMenu> builder)
        {
            builder.HasData(
                // --- user Role Menus ---
                new UserRoleMenu{ Id = 1, RoleId = 1,  MenuId = 1, OrderId = 1, IsActive = true},
                new UserRoleMenu{ Id = 2, RoleId = 1, MenuId = 2, OrderId = 1, IsActive = true},
                new UserRoleMenu{ Id = 3, RoleId = 1, MenuId = 3, OrderId = 2, IsActive = true},
                new UserRoleMenu{ Id = 4, RoleId = 1, MenuId = 4, OrderId = 3, IsActive = true},
                new UserRoleMenu{ Id = 5, RoleId = 1, MenuId = 5, OrderId = 4, IsActive = true},
                new UserRoleMenu{ Id = 6, RoleId = 1, MenuId = 6, OrderId = 5, IsActive = true},
                new UserRoleMenu{ Id = 7, RoleId = 1, MenuId = 7, OrderId = 6, IsActive = true},
                new UserRoleMenu{ Id = 8, RoleId = 1, MenuId = 8, OrderId = 1, IsActive = true},
                new UserRoleMenu{ Id = 9, RoleId = 1, MenuId = 9, OrderId = 1, IsActive = true},
                new UserRoleMenu{ Id = 10, RoleId = 1, MenuId = 10, OrderId = 1, IsActive = true},
                new UserRoleMenu{ Id = 11, RoleId = 1, MenuId = 11, OrderId = 1, IsActive = true},
                new UserRoleMenu{ Id = 12, RoleId = 1, MenuId = 12, OrderId = 1, IsActive = true},
                new UserRoleMenu{ Id = 13, RoleId = 1, MenuId = 13, OrderId = 1, IsActive = true},
                new UserRoleMenu{ Id = 14, RoleId = 1, MenuId = 14, OrderId = 1, IsActive = true},
                new UserRoleMenu{ Id = 15, RoleId = 1, MenuId = 15, OrderId = 1, IsActive = true},
                new UserRoleMenu{ Id = 16, RoleId = 2,  MenuId = 1, OrderId = 1, IsActive = true},
                new UserRoleMenu{ Id = 17, RoleId = 1, MenuId = 16, OrderId = 1, IsActive = true},
                new UserRoleMenu{ Id = 18, RoleId = 1, MenuId = 17, OrderId = 1, IsActive = true},
                new UserRoleMenu{ Id = 19, RoleId = 1, MenuId = 18, OrderId = 1, IsActive = true},
                new UserRoleMenu{ Id = 20, RoleId = 1, MenuId = 19, OrderId = 1, IsActive = true},
                new UserRoleMenu{ Id = 21, RoleId = 2,  MenuId = 20, OrderId = 1, IsActive = true},
                new UserRoleMenu{ Id = 22, RoleId = 1, MenuId = 21, OrderId = 2, IsActive = true},
                new UserRoleMenu{ Id = 23, RoleId = 1, MenuId = 32, OrderId = 3, IsActive = true},
                new UserRoleMenu{ Id = 24, RoleId = 1, MenuId = 33, OrderId = 4, IsActive = true},
                new UserRoleMenu{ Id = 25, RoleId = 1, MenuId = 34, OrderId = 5, IsActive = true},
                new UserRoleMenu{ Id = 26, RoleId = 1, MenuId = 35, OrderId = 6, IsActive = true}
            );
        }
    }
}
