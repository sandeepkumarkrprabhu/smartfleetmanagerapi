
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SmartFleet.Data.Models;

namespace SmartFleet.Data.Data.Seeds
{
    public class ModuleMasterSeed : IEntityTypeConfiguration<ModuleMaster>
    {
        public void Configure(EntityTypeBuilder<ModuleMaster> builder)
        {
            builder.HasData(
                // --- Assets ---
                new ModuleMaster { ModuleID =1, ModuleName ="Fleet", ModuleVersion ="1.0", IsActive = true},
                new ModuleMaster { ModuleID =2, ModuleName ="Accounts", ModuleVersion ="1.0", IsActive = true},
                new ModuleMaster { ModuleID =3, ModuleName ="Inventory", ModuleVersion ="1.0", IsActive = false}
            );
        }
    }
}
