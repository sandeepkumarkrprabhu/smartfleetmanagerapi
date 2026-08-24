
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SmartFleet.Data.Models;

namespace SmartFleet.Data.Data.Seeds
{
    public class CompanySeed: IEntityTypeConfiguration<Company>
    {
        public void Configure(EntityTypeBuilder<Company> builder)
        {
            builder.HasData(
                // --- Assets ---
                new Company { Id = 1, Name = "Default Company", IsActive= true, Address = string.Empty, CreatedAt = DateTime.Now, LastUpdatedAt = DateTime.Now, ContactNo = "", ContactPhone="", LicensedValidTill = DateTime.Now.AddDays(180) }
            );
        }
    }
}
