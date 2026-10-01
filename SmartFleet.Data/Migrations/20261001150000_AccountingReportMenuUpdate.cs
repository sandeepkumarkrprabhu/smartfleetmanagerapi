using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SmartFleet.Data.Migrations
{
    /// <inheritdoc />
    public partial class AccountingReportMenuUpdate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "MenuMasters",
                columns: new[] { "MenuID", "GroupId", "IconName", "ModuleID", "Name", "isActive", "orderNo", "url" },
                values: new object[] { 36, 4, "WalletCards", 2, "Cash Book", true, 2, "/accounts/CashBook" });

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
                    { 27, false, false, false, false, false, true, 36, 7, 1 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(table: "UserRoleMenus", keyColumn: "Id", keyValue: 22);
            migrationBuilder.DeleteData(table: "UserRoleMenus", keyColumn: "Id", keyValue: 23);
            migrationBuilder.DeleteData(table: "UserRoleMenus", keyColumn: "Id", keyValue: 24);
            migrationBuilder.DeleteData(table: "UserRoleMenus", keyColumn: "Id", keyValue: 25);
            migrationBuilder.DeleteData(table: "UserRoleMenus", keyColumn: "Id", keyValue: 26);
            migrationBuilder.DeleteData(table: "UserRoleMenus", keyColumn: "Id", keyValue: 27);
            migrationBuilder.DeleteData(table: "MenuMasters", keyColumn: "MenuID", keyValue: 36);
        }
    }
}