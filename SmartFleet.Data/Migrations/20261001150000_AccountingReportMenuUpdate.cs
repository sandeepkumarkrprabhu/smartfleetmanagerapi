using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SmartFleet.Data.Migrations
{
    public partial class AccountingReportMenuUpdate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "MenuMasters",
                columns: new[] { "MenuID", "GroupId", "IconName", "ModuleID", "Name", "isActive", "orderNo", "url" },
                values: new object[,]
                {
                    { 36, 4, "Landmark", 2, "Cash & Bank Reports", true, 2, "/accounts/CashBankReports" },
                    { 37, 4, "ArrowLeftRight", 2, "Receivables & Payable Reports", true, 3, "/accounts/ReceivablePayableReports" },
                    { 38, 4, "ReceiptText", 2, "Tax Reports", true, 4, "/accounts/TaxReports" },
                    { 39, 4, "ChartNoAxesCombined", 2, "Management Analysis", true, 5, "/accounts/ManagementAnalysis" }
                });

            migrationBuilder.InsertData(
                table: "UserRoleMenus",
                columns: new[] { "Id", "HasAddPermission", "HasDeletePermission", "HasEditPermission", "HasPostingPermission", "HasPrintPermission", "IsActive", "MenuId", "OrderId", "RoleId" },
                values: new object[,]
                {
                    { 22, false, false, false, false, false, true, 21, 2, 1 },
                    { 23, false, false, false, false, false, true, 32, 3, 1 },
                    { 24, false, false, false, false, false, true, 33, 4, 1 },
                    { 25, false, false, false, false, false, true, 34, 5, 1 },
                    { 26, false, false, false, false, false, true, 35, 6, 1 },
                    { 27, false, false, false, false, false, true, 36, 7, 1 },
                    { 28, false, false, false, false, false, true, 37, 8, 1 },
                    { 29, false, false, false, false, false, true, 38, 9, 1 },
                    { 30, false, false, false, false, false, true, 39, 10, 1 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            for (var id = 22; id <= 30; id++)
                migrationBuilder.DeleteData(table: "UserRoleMenus", keyColumn: "Id", keyValue: id);

            for (var menuId = 36; menuId <= 39; menuId++)
                migrationBuilder.DeleteData(table: "MenuMasters", keyColumn: "MenuID", keyValue: menuId);
        }
    }
}