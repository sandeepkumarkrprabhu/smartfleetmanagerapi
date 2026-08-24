using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SmartFleet.Data.Models;


namespace SmartFleet.Data.Data.Seeds
{
    public class FinYearSeed: IEntityTypeConfiguration<FinancialYear>
    {
        public void Configure(EntityTypeBuilder<FinancialYear> builder)
        {
            builder.HasData(
                // --- Assets ---
                new FinancialYear { Code = DateTime.Now.Year.ToString(), Name = string.Concat(DateTime.Now.Year.ToString(), "-" , (DateTime.Now.Year+1).ToString()), IsActive= true, Description = string.Concat(DateTime.Now.Year.ToString(), "-" , (DateTime.Now.Year+1).ToString()), FinStartDate = DateTime.Now, FinEndDate = new DateTime((DateTime.Now.Year+1),03,31)}
            );
        }
    }
}
