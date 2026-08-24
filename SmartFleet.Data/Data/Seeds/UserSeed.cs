using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SmartFleet.Data.Models;

namespace SmartFleet.Data.Data.Seeds
{
    public class UserSeed: IEntityTypeConfiguration<UserAuth>
    {
        public void Configure(EntityTypeBuilder<UserAuth> builder)
        {
            builder.HasData(
                // --- Assets ---
                new UserAuth{ Id = 1, UserCode = "ADM", UserName="admin@rmt.com", Password = "User",  IsActive = true, CreatedAt = DateTime.Now, RoleId = 1 }
            );
        }
    }
}
