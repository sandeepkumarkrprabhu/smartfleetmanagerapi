using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SmartFleet.Data.Models;

namespace SmartFleet.Data.Data.Seeds
{
    public class UserRoleSeed : IEntityTypeConfiguration<UserRole>
    {
        public void Configure(EntityTypeBuilder<UserRole> builder)
        {
            builder.HasData(
                // --- user Role ---
                new UserRole{ RoleID = 1, Name= "Admin", isActive = true, CreatedAt = DateTime.Now, UpdatedAt = DateTime.Now},
                new UserRole{ RoleID = 2, Name= "General", isActive = true, CreatedAt = DateTime.Now, UpdatedAt = DateTime.Now}
            );
        }
    }
}
