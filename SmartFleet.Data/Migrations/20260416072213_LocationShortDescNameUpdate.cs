using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SmartFleet.Data.Migrations
{
    /// <inheritdoc />
    public partial class LocationShortDescNameUpdate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ShortName",
                table: "Locations",
                type: "nvarchar(8)",
                maxLength: 8,
                nullable: true);

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2026, 4, 16, 12, 52, 12, 592, DateTimeKind.Local).AddTicks(2793));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2026, 4, 16, 12, 52, 12, 592, DateTimeKind.Local).AddTicks(3881));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2026, 4, 16, 12, 52, 12, 592, DateTimeKind.Local).AddTicks(3884));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2026, 4, 16, 12, 52, 12, 592, DateTimeKind.Local).AddTicks(3886));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2026, 4, 16, 12, 52, 12, 592, DateTimeKind.Local).AddTicks(3888));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2026, 4, 16, 12, 52, 12, 592, DateTimeKind.Local).AddTicks(3889));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2026, 4, 16, 12, 52, 12, 592, DateTimeKind.Local).AddTicks(3993));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2026, 4, 16, 12, 52, 12, 592, DateTimeKind.Local).AddTicks(3995));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2026, 4, 16, 12, 52, 12, 592, DateTimeKind.Local).AddTicks(3997));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2026, 4, 16, 12, 52, 12, 592, DateTimeKind.Local).AddTicks(3999));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2026, 4, 16, 12, 52, 12, 592, DateTimeKind.Local).AddTicks(4001));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2026, 4, 16, 12, 52, 12, 592, DateTimeKind.Local).AddTicks(4002));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2026, 4, 16, 12, 52, 12, 592, DateTimeKind.Local).AddTicks(4004));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 14,
                column: "CreatedAt",
                value: new DateTime(2026, 4, 16, 12, 52, 12, 592, DateTimeKind.Local).AddTicks(4006));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 15,
                column: "CreatedAt",
                value: new DateTime(2026, 4, 16, 12, 52, 12, 592, DateTimeKind.Local).AddTicks(4008));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 16,
                column: "CreatedAt",
                value: new DateTime(2026, 4, 16, 12, 52, 12, 592, DateTimeKind.Local).AddTicks(4010));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 17,
                column: "CreatedAt",
                value: new DateTime(2026, 4, 16, 12, 52, 12, 592, DateTimeKind.Local).AddTicks(4012));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 18,
                column: "CreatedAt",
                value: new DateTime(2026, 4, 16, 12, 52, 12, 592, DateTimeKind.Local).AddTicks(4013));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 19,
                column: "CreatedAt",
                value: new DateTime(2026, 4, 16, 12, 52, 12, 592, DateTimeKind.Local).AddTicks(4015));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 20,
                column: "CreatedAt",
                value: new DateTime(2026, 4, 16, 12, 52, 12, 592, DateTimeKind.Local).AddTicks(4017));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 21,
                column: "CreatedAt",
                value: new DateTime(2026, 4, 16, 12, 52, 12, 592, DateTimeKind.Local).AddTicks(4029));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 22,
                column: "CreatedAt",
                value: new DateTime(2026, 4, 16, 12, 52, 12, 592, DateTimeKind.Local).AddTicks(4101));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 23,
                column: "CreatedAt",
                value: new DateTime(2026, 4, 16, 12, 52, 12, 592, DateTimeKind.Local).AddTicks(4104));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 24,
                column: "CreatedAt",
                value: new DateTime(2026, 4, 16, 12, 52, 12, 592, DateTimeKind.Local).AddTicks(4106));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 25,
                column: "CreatedAt",
                value: new DateTime(2026, 4, 16, 12, 52, 12, 592, DateTimeKind.Local).AddTicks(4108));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 26,
                column: "CreatedAt",
                value: new DateTime(2026, 4, 16, 12, 52, 12, 592, DateTimeKind.Local).AddTicks(4110));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 27,
                column: "CreatedAt",
                value: new DateTime(2026, 4, 16, 12, 52, 12, 592, DateTimeKind.Local).AddTicks(4112));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 28,
                column: "CreatedAt",
                value: new DateTime(2026, 4, 16, 12, 52, 12, 592, DateTimeKind.Local).AddTicks(4113));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 29,
                column: "CreatedAt",
                value: new DateTime(2026, 4, 16, 12, 52, 12, 592, DateTimeKind.Local).AddTicks(4115));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 30,
                column: "CreatedAt",
                value: new DateTime(2026, 4, 16, 12, 52, 12, 592, DateTimeKind.Local).AddTicks(4117));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 31,
                column: "CreatedAt",
                value: new DateTime(2026, 4, 16, 12, 52, 12, 592, DateTimeKind.Local).AddTicks(4119));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 32,
                column: "CreatedAt",
                value: new DateTime(2026, 4, 16, 12, 52, 12, 592, DateTimeKind.Local).AddTicks(4121));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 33,
                column: "CreatedAt",
                value: new DateTime(2026, 4, 16, 12, 52, 12, 592, DateTimeKind.Local).AddTicks(4123));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 34,
                column: "CreatedAt",
                value: new DateTime(2026, 4, 16, 12, 52, 12, 592, DateTimeKind.Local).AddTicks(4125));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 35,
                column: "CreatedAt",
                value: new DateTime(2026, 4, 16, 12, 52, 12, 592, DateTimeKind.Local).AddTicks(4127));

            migrationBuilder.UpdateData(
                table: "Branches",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 4, 16, 12, 52, 12, 589, DateTimeKind.Local).AddTicks(5723), new DateTime(2026, 4, 16, 12, 52, 12, 589, DateTimeKind.Local).AddTicks(5831) });

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "LastUpdatedAt", "LicensedValidTill" },
                values: new object[] { new DateTime(2026, 4, 16, 12, 52, 12, 589, DateTimeKind.Local).AddTicks(2717), new DateTime(2026, 4, 16, 12, 52, 12, 589, DateTimeKind.Local).AddTicks(2941), new DateTime(2026, 10, 13, 12, 52, 12, 589, DateTimeKind.Local).AddTicks(3248) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2026, 4, 16, 12, 52, 12, 593, DateTimeKind.Local).AddTicks(5364));

            migrationBuilder.UpdateData(
                table: "FinancialYears",
                keyColumn: "Code",
                keyValue: "2026",
                column: "FinStartDate",
                value: new DateTime(2026, 4, 16, 12, 52, 12, 588, DateTimeKind.Local).AddTicks(5293));

            migrationBuilder.UpdateData(
                table: "UserAuths",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2026, 4, 16, 12, 52, 12, 593, DateTimeKind.Local).AddTicks(7592));

            migrationBuilder.UpdateData(
                table: "UserRole",
                keyColumn: "RoleID",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 4, 16, 12, 52, 12, 592, DateTimeKind.Local).AddTicks(6675), new DateTime(2026, 4, 16, 12, 52, 12, 592, DateTimeKind.Local).AddTicks(6809) });

            migrationBuilder.UpdateData(
                table: "UserRole",
                keyColumn: "RoleID",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 4, 16, 12, 52, 12, 592, DateTimeKind.Local).AddTicks(6906), new DateTime(2026, 4, 16, 12, 52, 12, 592, DateTimeKind.Local).AddTicks(6907) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ShortName",
                table: "Locations");

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
                columns: new[] { "CreatedAt", "LastUpdatedAt", "LicensedValidTill" },
                values: new object[] { new DateTime(2026, 4, 11, 21, 14, 24, 623, DateTimeKind.Local).AddTicks(9176), new DateTime(2026, 4, 11, 21, 14, 24, 623, DateTimeKind.Local).AddTicks(9275), new DateTime(2026, 10, 8, 21, 14, 24, 623, DateTimeKind.Local).AddTicks(9520) });

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
    }
}
