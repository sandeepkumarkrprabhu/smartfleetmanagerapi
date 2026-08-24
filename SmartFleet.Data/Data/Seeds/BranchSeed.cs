
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SmartFleet.Data.Models;

namespace SmartFleet.Data.Data.Seeds
{
    public class BranchSeed: IEntityTypeConfiguration<BrachLocation>
    {
        public void Configure(EntityTypeBuilder<BrachLocation> builder)
        {
            builder.HasData(
                // --- Assets ---
                new BrachLocation { Id =1, Name = "Main Branch", Address = "", ContactNo = "", ContactPhone = "", CreatedAt = DateTime.Now, LastUpdatedAt = DateTime.Now, IsActive = true, CompanyId = "1" }
            );
        }
    }
}
