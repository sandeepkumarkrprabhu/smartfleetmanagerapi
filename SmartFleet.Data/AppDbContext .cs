using Azure.Core;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Diagnostics;
using Microsoft.EntityFrameworkCore.Migrations;
using SmartFleet.Data.Data.Seeds;
using SmartFleet.Data.Models;
using SmartFleet.Utility;
using System.Text.Json;

namespace SmartFleet.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<TripTransaction>()
                .HasOne(t => t.FromCustomer)
                .WithMany()
                .HasForeignKey(t => t.FromCustomerId)
                .OnDelete(DeleteBehavior.Restrict); // or NoAction

            modelBuilder.Entity<TripTransaction>()
                .HasOne(t => t.Origin)
                .WithMany()
                .HasForeignKey(t => t.OriginId)
                .OnDelete(DeleteBehavior.Restrict); // or NoAction

            modelBuilder.Entity<TripTransaction>()
                .HasOne(t => t.Destination)
                .WithMany()
                .HasForeignKey(t => t.DestinationId)
                .OnDelete(DeleteBehavior.Restrict); // or NoAction

            modelBuilder.Entity<AuditLog>()
                .Property(a => a.ActionType)
                .HasConversion<string>();

            modelBuilder.Entity<Employee>()
                .HasOne(e => e.AccountMaster)
                .WithMany(a => a.Employees)
                .HasForeignKey(e => e.EmpAccountID)
                .OnDelete(DeleteBehavior.Restrict); // or NoAction


            //Apply Finaincial Year
            modelBuilder.ApplyConfiguration(new FinYearSeed());
            // Apply Company
            modelBuilder.ApplyConfiguration(new CompanySeed());

            // Apply Branch Location
            modelBuilder.ApplyConfiguration(new BranchSeed());

            // Apply Module seeder
            modelBuilder.ApplyConfiguration(new ModuleMasterSeed());

            // Apply Menu seeder
            modelBuilder.ApplyConfiguration(new ModuleMenuSeed());

            // Apply Account seeder
            modelBuilder.ApplyConfiguration(new AccountSeed());

            modelBuilder.ApplyConfiguration(new UserRoleSeed());
            modelBuilder.ApplyConfiguration(new UserRoleMenusSeed());

            modelBuilder.ApplyConfiguration(new EmployeeSeed());

            modelBuilder.ApplyConfiguration(new UserSeed());

            modelBuilder.ApplyConfiguration(new AccountPostingSeed());


        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.ConfigureWarnings(w => w.Ignore(RelationalEventId.PendingModelChangesWarning));
        }

        public override async Task<int> SaveChangesAsync(
    CancellationToken cancellationToken = default)
        {
            var auditEntries = ChangeTracker.Entries()
                .Where(e => e.State == EntityState.Added ||
                            e.State == EntityState.Modified ||
                            e.State == EntityState.Deleted)
                .ToList();

            foreach (var entry in auditEntries)
            {
                var actionType = MapEntityStateToAction(entry.State);
                var log = new AuditLog
                {
                    UserId = 1,
                    ActionType = actionType,
                    EntityName = entry.Entity.GetType().Name,
                    Changes = JsonSerializer.Serialize(entry.Entity),
                    CreatedAt = DateTime.UtcNow
                };

                AuditLogs.Add(log);
            }

            return await base.SaveChangesAsync(cancellationToken);
        }

        private AuditActionType MapEntityStateToAction(EntityState state)
        {
            return state switch
            {
                EntityState.Added => AuditActionType.Create,
                EntityState.Modified => AuditActionType.Update,
                EntityState.Deleted => AuditActionType.Delete,
                _ => AuditActionType.View
            };
        }

        /// <summary>
        /// Product & Company Settings
        /// </summary>
        public DbSet<ModuleMaster> ModuleMasters { get; set; }
        public DbSet<MenuMaster> MenuMasters { get; set; }
        public DbSet<Company> Companies { get; set; }

        public DbSet<BrachLocation> Branches { get; set; }
        public DbSet<FinancialYear> FinancialYears { get; set; }

        /// <summary>
        /// Masters
        /// </summary>
        public DbSet<AccountMaster> AccountMasters { get; set; }
        public DbSet<Customer> Customers { get; set; }

        public DbSet<Employee> Employees { get; set; }
        public DbSet<UserAuth> UserAuths { get; set; }

        public DbSet<Vehicle> Vehilces { get; set; }

        public DbSet<Location> Locations { get; set; }

        public DbSet<TripAcknoledgement> Units { get; set; }

        public DbSet<Product> Products { get; set; }

        public DbSet<Vendor> Vendors { get; set; }

        public DbSet<VehicleVendorRents> vehicleVendorRents { get; set; }
        public DbSet<UserPreferences> UserPreferences { get; set; }

        public DbSet<AuditLog> AuditLogs { get; set; }

        /// <summary>
        /// Company Transaction 
        /// </summary>
        public DbSet<TripTransaction> TripTransaction { get; set; }
        public DbSet<TripProductDetail> TripProductDetails { get; set; }
        public DbSet<TripConsigneeDetails> TripConsigneeDetails { get; set; }
        public DbSet<FuelLog> FuelLog { get; set; }

        public DbSet<Payment> payments { get; set; }
        public DbSet<PaymentDetail> paymentsDetail { get; set; }

        public DbSet<Receipt> Receipts { get; set; }
        public DbSet<ReceiptDetail> ReceiptsDetail { get; set; }

        public DbSet<JournalEntry> JournalEntries { get; set; }
        public DbSet<JournalEntryLine> JournalEntriesLine { get; set; }

        public DbSet<Bill> BillTransaction { get; set; }
        public DbSet<BillItemDetails> BillItemDetails { get; set; }

        public DbSet<UserRole> UserRole { get; set; }
        public DbSet<UserRoleMenu> UserRoleMenus { get; set; }

        public DbSet<TripReceiptAcknoledgementsInfo> TripReceiptAcknoledgementsInfos { get; set; }

        public DbSet<SmartLorryReceipt> LorryReceipts { get; set; }

        public DbSet<ReceiptAllocation> ReceiptAllocations { get; set; }

        public DbSet<AccountTransaction> AccountTransactions { get; set; }

        public DbSet<AccountTransactionDetail> AccountTransactionDetails { get; set; }
        public DbSet<PaymentAllocation> PaymentAllocations { get; set; }

        public DbSet<Tax> Taxes { get; set; }

        public DbSet<AccountPostingSettings> accountPostingSettings { get; set; }

        public DbSet<ApplicationModuleSetting> applicationModuleSettings { get; set; }

        public DbSet<ApplicationModuleSettingValue> applicationModuleSettingValues { get; set; }

        public DbSet<PartyTypeSetting> partyTypeSettings { get; set; }

    }
}
