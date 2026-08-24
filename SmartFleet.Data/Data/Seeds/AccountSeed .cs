using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SmartFleet.Data.Models;
using SmartFleet.Utility;

namespace SmartFleet.Data.Data.Seeds
{
    public class AccountSeed : IEntityTypeConfiguration<AccountMaster>
    {
        public void Configure(EntityTypeBuilder<AccountMaster> builder)
        {
            builder.HasData(
                // --- Assets ---
                new AccountMaster { AccountID = 1, AccountCode = "1000", AccountName = "Cash", GroupName="CASH", AccountType = FleetConstants.ASSET_TYPE_NAME, AccountGroupCode = FleetConstants.ASSET_GROUP_NAME, IsActive = true, Address="", BranchID = 1 },
                new AccountMaster { AccountID = 2, AccountCode = "1100", AccountName = "Bank Accounts", GroupName="BANK", AccountType = FleetConstants.ASSET_TYPE_NAME, AccountGroupCode = FleetConstants.ASSET_GROUP_NAME, IsActive = true,  Address="", BranchID = 1 },
                new AccountMaster { AccountID = 3, AccountCode = "1200", AccountName = "Accounts Receivable", GroupName="Receivables", AccountType = FleetConstants.ASSET_TYPE_NAME, AccountGroupCode = FleetConstants.ASSET_GROUP_NAME, IsActive = true , Address = "", BranchID = 1 },
                new AccountMaster { AccountID = 4, AccountCode = "1300", AccountName = "Inventory", GroupName="Inventory", AccountType = FleetConstants.ASSET_TYPE_NAME, AccountGroupCode = FleetConstants.ASSET_GROUP_NAME , IsActive = true , Address = "", BranchID = 1 },

                // Fleet-specific Assets
                new AccountMaster { AccountID = 5, AccountCode = "1400", AccountName = "Fleet Vehicles", GroupName="Vehicles", AccountType = FleetConstants.ASSET_TYPE_NAME, AccountGroupCode = FleetConstants.ASSET_GROUP_NAME , IsActive = true , Address = "", BranchID = 1 },
                new AccountMaster { AccountID = 6, AccountCode = "1410", AccountName = "Accumulated Depreciation - Vehicles", GroupName="Depreciation", AccountType = FleetConstants.ASSET_TYPE_NAME, AccountGroupCode = FleetConstants.ASSET_GROUP_NAME, ParentAccountID = 5 , IsActive = true , Address="", BranchID = 1 },
                new AccountMaster { AccountID = 7, AccountCode = "1420", AccountName = "Fuel Stock", GroupName="Fuel", AccountType = FleetConstants.ASSET_TYPE_NAME, AccountGroupCode = FleetConstants.ASSET_GROUP_NAME, ParentAccountID = 5 , IsActive = true , Address = "", BranchID = 1 },
                new AccountMaster { AccountID = 8, AccountCode = "1430", AccountName = "Spare Parts & Tyres Inventory", GroupName="Spare & Inventory", AccountType = FleetConstants.ASSET_TYPE_NAME, AccountGroupCode = FleetConstants.ASSET_GROUP_NAME, ParentAccountID = 5 , IsActive = true , Address = "", BranchID = 1 },

                // --- Liabilities ---
                new AccountMaster { AccountID = 9, AccountCode = "2000", AccountName = "Accounts Payable", GroupName="Payables", AccountType = FleetConstants.LIABILITY_TYPE_NAME, AccountGroupCode = FleetConstants.LIABILITY_GROUP_NAME, IsActive = true ,  Address="", BranchID = 1 },
                new AccountMaster { AccountID = 10, AccountCode = "2100", AccountName = "Accrued Expenses", GroupName="Expenses", AccountType = FleetConstants.LIABILITY_TYPE_NAME, AccountGroupCode = FleetConstants.LIABILITY_GROUP_NAME , IsActive = true , Address="", BranchID = 1 },
                new AccountMaster { AccountID = 11, AccountCode = "2200", AccountName = "Loans Payable", GroupName="Loans", AccountType = FleetConstants.LIABILITY_TYPE_NAME, AccountGroupCode = FleetConstants.LIABILITY_GROUP_NAME , IsActive = true , Address = "", BranchID = 1 },

                // Fleet-specific Liabilities
                new AccountMaster { AccountID = 12, AccountCode = "2210", AccountName = "Driver Advances Payable", GroupName="Payable", AccountType = FleetConstants.LIABILITY_TYPE_NAME, AccountGroupCode = FleetConstants.LIABILITY_GROUP_NAME , IsActive = true , Address = "", BranchID = 1 },
                new AccountMaster { AccountID = 13, AccountCode = "2220", AccountName = "Vehicle Lease Obligations", GroupName="Lease", AccountType = FleetConstants.LIABILITY_TYPE_NAME, AccountGroupCode = FleetConstants.LIABILITY_GROUP_NAME , IsActive = true , Address = "", BranchID = 1 },

                // --- Equity ---
                new AccountMaster { AccountID = 14, AccountCode = "3000", AccountName = "Owner’s Equity", GroupName="Equity", AccountType = FleetConstants.EQUITY_TYPE_NAME, AccountGroupCode = FleetConstants.EQUITY_GROUP_NAME , IsActive = true , Address = "", BranchID = 1 },
                new AccountMaster { AccountID = 15, AccountCode = "3100", AccountName = "Retained Earnings", GroupName="Earnings", AccountType = FleetConstants.EQUITY_TYPE_NAME, AccountGroupCode = FleetConstants.EQUITY_GROUP_NAME , IsActive = true , Address = "", BranchID = 1 },

                // --- Income ---
                new AccountMaster { AccountID = 16, AccountCode = "4000", AccountName = "Income", GroupName="Income", AccountType = FleetConstants.INCOME_TYPE_NAME, AccountGroupCode = FleetConstants.INCOME_GROUP_NAME , IsActive = true , Address = "", BranchID = 1 },
                new AccountMaster { AccountID = 17, AccountCode = "4100", AccountName = "Trip Income", GroupName="Incone", AccountType = FleetConstants.INCOME_TYPE_NAME, AccountGroupCode = FleetConstants.INCOME_GROUP_NAME, ParentAccountID = 16 , IsActive = true , Address = "", BranchID = 1 },
                new AccountMaster { AccountID = 18, AccountCode = "4110", AccountName = "Freight Charges", GroupName="Incone", AccountType = FleetConstants.INCOME_TYPE_NAME, AccountGroupCode = FleetConstants.INCOME_GROUP_NAME, ParentAccountID = 17 , IsActive = true , Address = "", BranchID = 1 },
                new AccountMaster { AccountID = 19, AccountCode = "4120", AccountName = "Rental Income - Vehicles", GroupName="Incone", AccountType = FleetConstants.INCOME_TYPE_NAME, AccountGroupCode = FleetConstants.INCOME_GROUP_NAME, ParentAccountID = 17 , IsActive = true , Address = "", BranchID = 1 },
                new AccountMaster { AccountID = 20, AccountCode = "4130", AccountName = "Fuel Surcharge Income", GroupName="Incone", AccountType = FleetConstants.INCOME_TYPE_NAME, AccountGroupCode = FleetConstants.INCOME_GROUP_NAME, ParentAccountID = 17 , IsActive = true , Address = "", BranchID = 1 },
                new AccountMaster { AccountID = 21, AccountCode = "4200", AccountName = "Other Service Income", GroupName="Incone", AccountType = FleetConstants.INCOME_TYPE_NAME, AccountGroupCode = FleetConstants.INCOME_GROUP_NAME, ParentAccountID = 16 , IsActive = true , Address = "", BranchID = 1 },

                // --- Expenses ---
                new AccountMaster { AccountID = 22, AccountCode = "5000", AccountName = "Expenses", GroupName="Expenses", AccountType = FleetConstants.EXPENSE_TYPE_NAME, AccountGroupCode = FleetConstants.EXPENSE_GROUP_NAME , IsActive = true , Address = "", BranchID = 1 },
                new AccountMaster { AccountID = 23, AccountCode = "5001", AccountName = "ADMIN", GroupName="Expenses", AccountType = FleetConstants.EXPENSE_TYPE_NAME, AccountGroupCode = FleetConstants.EXPENSE_GROUP_NAME , IsActive = true , Address = "", BranchID = 1, ParentAccountID= 22 },
    
                // Fleet-specific Expenses
                new AccountMaster { AccountID = 24, AccountCode = "5100", AccountName = "Fuel Expense", GroupName="Expenses", AccountType = FleetConstants.EXPENSE_TYPE_NAME, AccountGroupCode = FleetConstants.EXPENSE_GROUP_NAME, ParentAccountID = 22 , IsActive = true , Address = "", BranchID = 1 },
                new AccountMaster { AccountID = 25, AccountCode = "5110", AccountName = "Driver Wages & Allowances", GroupName="Expenses", AccountType = FleetConstants.EXPENSE_TYPE_NAME, AccountGroupCode = FleetConstants.EXPENSE_GROUP_NAME, ParentAccountID = 22 , IsActive = true , Address = "", BranchID = 1 },
                new AccountMaster { AccountID = 26, AccountCode = "5120", AccountName = "Trip Expenses (Tolls, Parking, Lodging)", GroupName="Expenses", AccountType = FleetConstants.EXPENSE_TYPE_NAME, AccountGroupCode = FleetConstants.EXPENSE_GROUP_NAME, ParentAccountID = 22 , IsActive = true , Address = "", BranchID = 1 },
                new AccountMaster { AccountID = 27, AccountCode = "5130", AccountName = "Vehicle Maintenance & Repairs", GroupName="Expenses", AccountType = FleetConstants.EXPENSE_TYPE_NAME, AccountGroupCode = FleetConstants.EXPENSE_GROUP_NAME, ParentAccountID = 22 , IsActive = true , Address = "", BranchID = 1 },
                new AccountMaster { AccountID = 28, AccountCode = "5140", AccountName = "Tyres & Spare Parts Replacement", GroupName="Expenses", AccountType = FleetConstants.EXPENSE_TYPE_NAME, AccountGroupCode = FleetConstants.EXPENSE_GROUP_NAME, ParentAccountID = 22 , IsActive = true , Address = "", BranchID = 1 },
                new AccountMaster { AccountID = 29, AccountCode = "5150", AccountName = "Vehicle Insurance", GroupName="Expenses", AccountType = FleetConstants.EXPENSE_TYPE_NAME, AccountGroupCode = FleetConstants.EXPENSE_GROUP_NAME, ParentAccountID = 22 , IsActive = true , Address = "", BranchID = 1 },
                new AccountMaster { AccountID = 30, AccountCode = "5160", AccountName = "Road Tax & Permits", GroupName="Expenses", AccountType = FleetConstants.EXPENSE_TYPE_NAME, AccountGroupCode = FleetConstants.EXPENSE_GROUP_NAME, ParentAccountID = 22 , IsActive = true , Address = "", BranchID = 1 },

                // Generic Admin Expenses
                new AccountMaster { AccountID = 31, AccountCode = "5200", AccountName = "General Admin Expense", GroupName="Expenses", AccountType = FleetConstants.EXPENSE_TYPE_NAME, AccountGroupCode = FleetConstants.EXPENSE_GROUP_NAME, ParentAccountID = 22 , IsActive = true , Address = "", BranchID = 1 },
                new AccountMaster { AccountID = 32, AccountCode = "5210", AccountName = "Office Rent", GroupName="Expenses", AccountType = FleetConstants.EXPENSE_TYPE_NAME, AccountGroupCode = FleetConstants.EXPENSE_GROUP_NAME, ParentAccountID = 22 , IsActive = true , Address = "", BranchID = 1 },
                new AccountMaster { AccountID = 33, AccountCode = "5220", AccountName = "Utilities", GroupName="Expenses", AccountType = FleetConstants.EXPENSE_TYPE_NAME, AccountGroupCode = FleetConstants.EXPENSE_GROUP_NAME, ParentAccountID = 22 , IsActive = true , Address = "", BranchID = 1 },
                new AccountMaster { AccountID = 34, AccountCode = "5230", AccountName = "Professional Fees", GroupName="Expenses", AccountType = FleetConstants.EXPENSE_TYPE_NAME, AccountGroupCode = FleetConstants.EXPENSE_GROUP_NAME, ParentAccountID = 22 , IsActive = true , Address = "", BranchID = 1 },
                new AccountMaster { AccountID = 35, AccountCode = "5240", AccountName = "Bank Charges & Interest", GroupName="Expenses", AccountType = FleetConstants.EXPENSE_TYPE_NAME, AccountGroupCode = FleetConstants.EXPENSE_GROUP_NAME, ParentAccountID = 22, IsActive = true , Address = "", BranchID = 1 }

                //new AccountMaster { AccountID = 36, AccountCode = "1001", AccountName = "Cash in Hand", GroupName="CASH", AccountType = FleetConstants.ASSET_TYPE_NAME, AccountGroupCode = FleetConstants.ASSET_GROUP_NAME, ParentAccountID=1, IsActive = true, Address="", BranchID = 1 }
            );
        }
    }
}
