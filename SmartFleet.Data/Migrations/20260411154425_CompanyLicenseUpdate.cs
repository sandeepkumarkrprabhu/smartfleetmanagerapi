using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace SmartFleet.Data.Migrations
{
    /// <inheritdoc />
    public partial class CompanyLicenseUpdate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "LicenseCode",
                table: "Companies",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2026, 4, 11, 21, 14, 24, 626, DateTimeKind.Local).AddTicks(909));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2026, 4, 11, 21, 14, 24, 626, DateTimeKind.Local).AddTicks(1763));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2026, 4, 11, 21, 14, 24, 626, DateTimeKind.Local).AddTicks(1767));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2026, 4, 11, 21, 14, 24, 626, DateTimeKind.Local).AddTicks(1768));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2026, 4, 11, 21, 14, 24, 626, DateTimeKind.Local).AddTicks(1770));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2026, 4, 11, 21, 14, 24, 626, DateTimeKind.Local).AddTicks(1771));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2026, 4, 11, 21, 14, 24, 626, DateTimeKind.Local).AddTicks(1851));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2026, 4, 11, 21, 14, 24, 626, DateTimeKind.Local).AddTicks(1853));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2026, 4, 11, 21, 14, 24, 626, DateTimeKind.Local).AddTicks(1854));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2026, 4, 11, 21, 14, 24, 626, DateTimeKind.Local).AddTicks(1856));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2026, 4, 11, 21, 14, 24, 626, DateTimeKind.Local).AddTicks(1866));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2026, 4, 11, 21, 14, 24, 626, DateTimeKind.Local).AddTicks(1867));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2026, 4, 11, 21, 14, 24, 626, DateTimeKind.Local).AddTicks(1869));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 14,
                column: "CreatedAt",
                value: new DateTime(2026, 4, 11, 21, 14, 24, 626, DateTimeKind.Local).AddTicks(1870));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 15,
                column: "CreatedAt",
                value: new DateTime(2026, 4, 11, 21, 14, 24, 626, DateTimeKind.Local).AddTicks(1872));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 16,
                column: "CreatedAt",
                value: new DateTime(2026, 4, 11, 21, 14, 24, 626, DateTimeKind.Local).AddTicks(1873));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 17,
                column: "CreatedAt",
                value: new DateTime(2026, 4, 11, 21, 14, 24, 626, DateTimeKind.Local).AddTicks(1875));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 18,
                column: "CreatedAt",
                value: new DateTime(2026, 4, 11, 21, 14, 24, 626, DateTimeKind.Local).AddTicks(1876));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 19,
                column: "CreatedAt",
                value: new DateTime(2026, 4, 11, 21, 14, 24, 626, DateTimeKind.Local).AddTicks(1878));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 20,
                column: "CreatedAt",
                value: new DateTime(2026, 4, 11, 21, 14, 24, 626, DateTimeKind.Local).AddTicks(1879));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 21,
                column: "CreatedAt",
                value: new DateTime(2026, 4, 11, 21, 14, 24, 626, DateTimeKind.Local).AddTicks(1881));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 22,
                column: "CreatedAt",
                value: new DateTime(2026, 4, 11, 21, 14, 24, 626, DateTimeKind.Local).AddTicks(1882));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 23,
                column: "CreatedAt",
                value: new DateTime(2026, 4, 11, 21, 14, 24, 626, DateTimeKind.Local).AddTicks(1884));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 24,
                column: "CreatedAt",
                value: new DateTime(2026, 4, 11, 21, 14, 24, 626, DateTimeKind.Local).AddTicks(1885));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 25,
                column: "CreatedAt",
                value: new DateTime(2026, 4, 11, 21, 14, 24, 626, DateTimeKind.Local).AddTicks(1887));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 26,
                column: "CreatedAt",
                value: new DateTime(2026, 4, 11, 21, 14, 24, 626, DateTimeKind.Local).AddTicks(1888));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 27,
                column: "CreatedAt",
                value: new DateTime(2026, 4, 11, 21, 14, 24, 626, DateTimeKind.Local).AddTicks(1890));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 28,
                column: "CreatedAt",
                value: new DateTime(2026, 4, 11, 21, 14, 24, 626, DateTimeKind.Local).AddTicks(1891));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 29,
                column: "CreatedAt",
                value: new DateTime(2026, 4, 11, 21, 14, 24, 626, DateTimeKind.Local).AddTicks(1893));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 30,
                column: "CreatedAt",
                value: new DateTime(2026, 4, 11, 21, 14, 24, 626, DateTimeKind.Local).AddTicks(1894));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 31,
                column: "CreatedAt",
                value: new DateTime(2026, 4, 11, 21, 14, 24, 626, DateTimeKind.Local).AddTicks(1896));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 32,
                column: "CreatedAt",
                value: new DateTime(2026, 4, 11, 21, 14, 24, 626, DateTimeKind.Local).AddTicks(1897));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 33,
                column: "CreatedAt",
                value: new DateTime(2026, 4, 11, 21, 14, 24, 626, DateTimeKind.Local).AddTicks(1899));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 34,
                column: "CreatedAt",
                value: new DateTime(2026, 4, 11, 21, 14, 24, 626, DateTimeKind.Local).AddTicks(1900));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 35,
                column: "CreatedAt",
                value: new DateTime(2026, 4, 11, 21, 14, 24, 626, DateTimeKind.Local).AddTicks(1902));

            migrationBuilder.UpdateData(
                table: "Branches",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 4, 11, 21, 14, 24, 624, DateTimeKind.Local).AddTicks(1535), new DateTime(2026, 4, 11, 21, 14, 24, 624, DateTimeKind.Local).AddTicks(1626) });

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "LastUpdatedAt", "LicenseCode", "LicensedValidTill" },
                values: new object[] { new DateTime(2026, 4, 11, 21, 14, 24, 623, DateTimeKind.Local).AddTicks(9176), new DateTime(2026, 4, 11, 21, 14, 24, 623, DateTimeKind.Local).AddTicks(9275), null, new DateTime(2026, 10, 8, 21, 14, 24, 623, DateTimeKind.Local).AddTicks(9520) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2026, 4, 11, 21, 14, 24, 627, DateTimeKind.Local).AddTicks(798));

            migrationBuilder.UpdateData(
                table: "FinancialYears",
                keyColumn: "Code",
                keyValue: "2026",
                column: "FinStartDate",
                value: new DateTime(2026, 4, 11, 21, 14, 24, 623, DateTimeKind.Local).AddTicks(2847));

            migrationBuilder.InsertData(
                table: "MenuMasters",
                columns: new[] { "MenuID", "GroupId", "IconName", "ModuleID", "Name", "isActive", "orderNo", "url" },
                values: new object[,]
                {
                    { 21, 4, "TrendingUp", 2, "Trail Balance", true, 1, "/accounts/TrialBalance" },
                    { 32, 4, "LineChart", 2, "Profit & Loss A/c", true, 1, "/accounts/ProfitLossAcc" },
                    { 33, 4, "Landmark", 2, "Balance Sheet", true, 1, "/accounts/BalanceSheet" },
                    { 34, 4, "ClipboardCheck", 2, "Posting", true, 1, "/accounts/BulkPosting" },
                    { 35, 4, "FileText", 2, "Account Statement", true, 1, "/accounts/AccountsStatement" }
                });

            migrationBuilder.UpdateData(
                table: "UserAuths",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2026, 4, 11, 21, 14, 24, 627, DateTimeKind.Local).AddTicks(2636));

            migrationBuilder.UpdateData(
                table: "UserRole",
                keyColumn: "RoleID",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 4, 11, 21, 14, 24, 626, DateTimeKind.Local).AddTicks(3628), new DateTime(2026, 4, 11, 21, 14, 24, 626, DateTimeKind.Local).AddTicks(3729) });

            migrationBuilder.UpdateData(
                table: "UserRole",
                keyColumn: "RoleID",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 4, 11, 21, 14, 24, 626, DateTimeKind.Local).AddTicks(3813), new DateTime(2026, 4, 11, 21, 14, 24, 626, DateTimeKind.Local).AddTicks(3813) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "MenuMasters",
                keyColumn: "MenuID",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "MenuMasters",
                keyColumn: "MenuID",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "MenuMasters",
                keyColumn: "MenuID",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "MenuMasters",
                keyColumn: "MenuID",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "MenuMasters",
                keyColumn: "MenuID",
                keyValue: 35);

            migrationBuilder.DropColumn(
                name: "LicenseCode",
                table: "Companies");

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2026, 4, 11, 14, 43, 48, 555, DateTimeKind.Local).AddTicks(2996));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2026, 4, 11, 14, 43, 48, 555, DateTimeKind.Local).AddTicks(3845));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2026, 4, 11, 14, 43, 48, 555, DateTimeKind.Local).AddTicks(3848));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2026, 4, 11, 14, 43, 48, 555, DateTimeKind.Local).AddTicks(3850));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2026, 4, 11, 14, 43, 48, 555, DateTimeKind.Local).AddTicks(3851));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2026, 4, 11, 14, 43, 48, 555, DateTimeKind.Local).AddTicks(3853));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2026, 4, 11, 14, 43, 48, 555, DateTimeKind.Local).AddTicks(3934));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2026, 4, 11, 14, 43, 48, 555, DateTimeKind.Local).AddTicks(3936));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2026, 4, 11, 14, 43, 48, 555, DateTimeKind.Local).AddTicks(3990));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2026, 4, 11, 14, 43, 48, 555, DateTimeKind.Local).AddTicks(3992));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2026, 4, 11, 14, 43, 48, 555, DateTimeKind.Local).AddTicks(3993));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2026, 4, 11, 14, 43, 48, 555, DateTimeKind.Local).AddTicks(3995));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2026, 4, 11, 14, 43, 48, 555, DateTimeKind.Local).AddTicks(3996));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 14,
                column: "CreatedAt",
                value: new DateTime(2026, 4, 11, 14, 43, 48, 555, DateTimeKind.Local).AddTicks(3998));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 15,
                column: "CreatedAt",
                value: new DateTime(2026, 4, 11, 14, 43, 48, 555, DateTimeKind.Local).AddTicks(3999));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 16,
                column: "CreatedAt",
                value: new DateTime(2026, 4, 11, 14, 43, 48, 555, DateTimeKind.Local).AddTicks(4010));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 17,
                column: "CreatedAt",
                value: new DateTime(2026, 4, 11, 14, 43, 48, 555, DateTimeKind.Local).AddTicks(4012));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 18,
                column: "CreatedAt",
                value: new DateTime(2026, 4, 11, 14, 43, 48, 555, DateTimeKind.Local).AddTicks(4013));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 19,
                column: "CreatedAt",
                value: new DateTime(2026, 4, 11, 14, 43, 48, 555, DateTimeKind.Local).AddTicks(4015));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 20,
                column: "CreatedAt",
                value: new DateTime(2026, 4, 11, 14, 43, 48, 555, DateTimeKind.Local).AddTicks(4016));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 21,
                column: "CreatedAt",
                value: new DateTime(2026, 4, 11, 14, 43, 48, 555, DateTimeKind.Local).AddTicks(4018));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 22,
                column: "CreatedAt",
                value: new DateTime(2026, 4, 11, 14, 43, 48, 555, DateTimeKind.Local).AddTicks(4019));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 23,
                column: "CreatedAt",
                value: new DateTime(2026, 4, 11, 14, 43, 48, 555, DateTimeKind.Local).AddTicks(4021));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 24,
                column: "CreatedAt",
                value: new DateTime(2026, 4, 11, 14, 43, 48, 555, DateTimeKind.Local).AddTicks(4022));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 25,
                column: "CreatedAt",
                value: new DateTime(2026, 4, 11, 14, 43, 48, 555, DateTimeKind.Local).AddTicks(4024));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 26,
                column: "CreatedAt",
                value: new DateTime(2026, 4, 11, 14, 43, 48, 555, DateTimeKind.Local).AddTicks(4025));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 27,
                column: "CreatedAt",
                value: new DateTime(2026, 4, 11, 14, 43, 48, 555, DateTimeKind.Local).AddTicks(4027));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 28,
                column: "CreatedAt",
                value: new DateTime(2026, 4, 11, 14, 43, 48, 555, DateTimeKind.Local).AddTicks(4028));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 29,
                column: "CreatedAt",
                value: new DateTime(2026, 4, 11, 14, 43, 48, 555, DateTimeKind.Local).AddTicks(4030));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 30,
                column: "CreatedAt",
                value: new DateTime(2026, 4, 11, 14, 43, 48, 555, DateTimeKind.Local).AddTicks(4031));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 31,
                column: "CreatedAt",
                value: new DateTime(2026, 4, 11, 14, 43, 48, 555, DateTimeKind.Local).AddTicks(4033));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 32,
                column: "CreatedAt",
                value: new DateTime(2026, 4, 11, 14, 43, 48, 555, DateTimeKind.Local).AddTicks(4034));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 33,
                column: "CreatedAt",
                value: new DateTime(2026, 4, 11, 14, 43, 48, 555, DateTimeKind.Local).AddTicks(4036));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 34,
                column: "CreatedAt",
                value: new DateTime(2026, 4, 11, 14, 43, 48, 555, DateTimeKind.Local).AddTicks(4037));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 35,
                column: "CreatedAt",
                value: new DateTime(2026, 4, 11, 14, 43, 48, 555, DateTimeKind.Local).AddTicks(4039));

            migrationBuilder.UpdateData(
                table: "Branches",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 4, 11, 14, 43, 48, 553, DateTimeKind.Local).AddTicks(3184), new DateTime(2026, 4, 11, 14, 43, 48, 553, DateTimeKind.Local).AddTicks(3279) });

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "LastUpdatedAt", "LicensedValidTill" },
                values: new object[] { new DateTime(2026, 4, 11, 14, 43, 48, 553, DateTimeKind.Local).AddTicks(787), new DateTime(2026, 4, 11, 14, 43, 48, 553, DateTimeKind.Local).AddTicks(886), new DateTime(2026, 10, 8, 14, 43, 48, 553, DateTimeKind.Local).AddTicks(1144) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2026, 4, 11, 14, 43, 48, 556, DateTimeKind.Local).AddTicks(3204));

            migrationBuilder.UpdateData(
                table: "FinancialYears",
                keyColumn: "Code",
                keyValue: "2026",
                column: "FinStartDate",
                value: new DateTime(2026, 4, 11, 14, 43, 48, 552, DateTimeKind.Local).AddTicks(4552));

            migrationBuilder.UpdateData(
                table: "UserAuths",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2026, 4, 11, 14, 43, 48, 556, DateTimeKind.Local).AddTicks(5144));

            migrationBuilder.UpdateData(
                table: "UserRole",
                keyColumn: "RoleID",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 4, 11, 14, 43, 48, 555, DateTimeKind.Local).AddTicks(5939), new DateTime(2026, 4, 11, 14, 43, 48, 555, DateTimeKind.Local).AddTicks(6046) });

            migrationBuilder.UpdateData(
                table: "UserRole",
                keyColumn: "RoleID",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 4, 11, 14, 43, 48, 555, DateTimeKind.Local).AddTicks(6128), new DateTime(2026, 4, 11, 14, 43, 48, 555, DateTimeKind.Local).AddTicks(6129) });
        }
    }
}
