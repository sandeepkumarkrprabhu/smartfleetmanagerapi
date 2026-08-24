
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SmartFleet.Data.Models;

namespace SmartFleet.Data.Data.Seeds
{
    public class EmployeeSeed: IEntityTypeConfiguration<Employee>
    {
        public void Configure(EntityTypeBuilder<Employee> builder)
        {
            builder.HasData(
                // --- Assets ---
                new Employee{ Id = 1, EmpAccountID= 23, BranchID =1, Email="admin@user.com", FirstName ="ADMIN", LastName = "USER", IsActive = true, Name = "ADMIN USER", Phone = "8547325650", Password = "Password@321", Role = "ADMIN", UserCode = "ADM", CreatedAt = DateTime.Now, Gender ="Male" }
            );
        }
    }
}
