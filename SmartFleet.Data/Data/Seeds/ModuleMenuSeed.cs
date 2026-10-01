using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SmartFleet.Data.Models;

namespace SmartFleet.Data.Data.Seeds
{
    public class ModuleMenuSeed : IEntityTypeConfiguration<MenuMaster>
    {
        public void Configure(EntityTypeBuilder<MenuMaster> builder)
        {
            builder.HasData(
                // --- Assets ---
                new MenuMaster { MenuID = 1, ModuleID = 1, Name = "Dashboard", orderNo = 1, isActive = true, url= "/fleet/dashboard", GroupId=1, IconName = "LayoutDashboard" },
                new MenuMaster { MenuID = 2, ModuleID = 1, Name = "Employees", orderNo = 2, isActive = true, url= "/admin/users", GroupId=2, IconName = "Users" },
                new MenuMaster { MenuID = 3, ModuleID = 1, Name = "Locations", orderNo = 3, isActive = true, url= "/fleet/locations", GroupId = 2, IconName= "MapPin" },
                new MenuMaster { MenuID = 4, ModuleID = 1, Name = "Units", orderNo = 4, isActive = true, url= "/fleet/units" , GroupId = 2, IconName ="Scale" },
                new MenuMaster { MenuID = 5, ModuleID = 1, Name = "Vehicles", orderNo = 5, isActive = true, url= "/fleet/vehicle" , GroupId = 2, IconName ="Car" },
                new MenuMaster { MenuID = 6, ModuleID = 1, Name = "Vendors", orderNo = 6, isActive = true, url= "/fleet/vendors" , GroupId = 2, IconName = "Store" },
                new MenuMaster { MenuID = 7, ModuleID = 1, Name = "Products", orderNo = 7, isActive = true, url= "/fleet/products" , GroupId = 2, IconName ="Package" },
                new MenuMaster { MenuID = 8, ModuleID = 1, Name = "Customers", orderNo = 8, isActive = true, url= "/fleet/customers" , GroupId = 2, IconName ="User" },
                new MenuMaster { MenuID = 9, ModuleID = 1, Name = "Trips", orderNo = 9, isActive = true, url= "/fleet/trips" , GroupId = 3, IconName ="Route" },
                new MenuMaster { MenuID = 10, ModuleID = 1, Name = "Billing", orderNo = 10, isActive = true, url= "/fleet/Invoice" , GroupId = 3, IconName ="CreditCard" },
                new MenuMaster { MenuID = 11, ModuleID = 1, Name = "Fuel", orderNo = 11, isActive = true, url= "/fleet/fuels" , GroupId = 2, IconName= "Droplet" },
                new MenuMaster { MenuID = 12, ModuleID = 2, Name = "Payments", orderNo = 12, isActive = true, url= "/accounts/payments" , GroupId = 3, IconName ="Wallet" },
                new MenuMaster { MenuID = 13, ModuleID = 2, Name = "Receipts", orderNo = 13, isActive = true, url= "/accounts/Receipts" , GroupId = 3, IconName= "Wallet" },
                new MenuMaster { MenuID = 14, ModuleID = 1, Name = "Trips", orderNo = 14, isActive = true, url= "/fleet/trips/report/" , GroupId = 4, IconName ="Truck" },
                new MenuMaster { MenuID = 15, ModuleID = 1, Name = "Customer Bills", orderNo = 15, isActive = true, url= "/fleet/Invoice/report/" , GroupId = 4, IconName= "Receipt" },
                new MenuMaster { MenuID = 16, ModuleID = 1, Name = "Company", orderNo = 16, isActive = true, url= "/company" , GroupId = 2, IconName= "Menu" },
                new MenuMaster { MenuID = 17, ModuleID = 1, Name = "Vehicle Rent", orderNo = 17, isActive = false, url= "/fleet/VehicleRent" , GroupId = 3, IconName= "FileSignature" },

                new MenuMaster { MenuID = 18, ModuleID = 2, Name = "Dashboard", orderNo = 1, isActive = false, url= "/accounts/dashboard" , GroupId = 1, IconName= "LayoutDashboard" },
                new MenuMaster { MenuID = 19, ModuleID = 2, Name = "Chart of Accounts", orderNo = 1, isActive = false, url= "/accounts/ChartofAccounts" , GroupId = 2, IconName= "LayoutDashboard" },
                new MenuMaster { MenuID = 20, ModuleID = 2, Name = "Journal", orderNo = 1, isActive = true, url= "/accounts/Journal" , GroupId = 3, IconName= "Receipt" },
                new MenuMaster { MenuID = 21, ModuleID = 2, Name = "Trail Balance", orderNo = 1, isActive = true, url = "/accounts/TrialBalance", GroupId = 4, IconName = "TrendingUp" },

                new MenuMaster { MenuID = 32, ModuleID = 2, Name = "Profit & Loss A/c", orderNo = 1, isActive = true, url = "/accounts/ProfitLossAcc", GroupId = 4, IconName = "LineChart" },
                new MenuMaster { MenuID = 33, ModuleID = 2, Name = "Balance Sheet", orderNo = 1, isActive = true, url = "/accounts/BalanceSheet", GroupId = 4, IconName = "Landmark" },
                new MenuMaster { MenuID = 34, ModuleID = 2, Name = "Posting", orderNo = 1, isActive = true, url = "/accounts/BulkPosting", GroupId = 4, IconName = "ClipboardCheck" },
                new MenuMaster { MenuID = 35, ModuleID = 2, Name = "Account Statement", orderNo = 1, isActive = true, url = "/accounts/AccountsStatement", GroupId = 4, IconName = "FileText" }
            );
        }

    }
}
