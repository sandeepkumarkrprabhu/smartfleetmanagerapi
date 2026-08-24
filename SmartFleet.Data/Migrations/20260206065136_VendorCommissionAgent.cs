using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SmartFleet.Data.Migrations
{
    /// <inheritdoc />
    public partial class VendorCommissionAgent : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Agentname",
                table: "Vendors",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<decimal>(
                name: "commissionPer",
                table: "Vendors",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 6, 12, 21, 33, 504, DateTimeKind.Local).AddTicks(1370));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 6, 12, 21, 33, 504, DateTimeKind.Local).AddTicks(2083));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 6, 12, 21, 33, 504, DateTimeKind.Local).AddTicks(2086));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 6, 12, 21, 33, 504, DateTimeKind.Local).AddTicks(2087));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 6, 12, 21, 33, 504, DateTimeKind.Local).AddTicks(2088));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 6, 12, 21, 33, 504, DateTimeKind.Local).AddTicks(2090));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 6, 12, 21, 33, 504, DateTimeKind.Local).AddTicks(2156));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 6, 12, 21, 33, 504, DateTimeKind.Local).AddTicks(2158));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 6, 12, 21, 33, 504, DateTimeKind.Local).AddTicks(2159));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 6, 12, 21, 33, 504, DateTimeKind.Local).AddTicks(2160));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 6, 12, 21, 33, 504, DateTimeKind.Local).AddTicks(2162));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 6, 12, 21, 33, 504, DateTimeKind.Local).AddTicks(2163));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 6, 12, 21, 33, 504, DateTimeKind.Local).AddTicks(2164));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 14,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 6, 12, 21, 33, 504, DateTimeKind.Local).AddTicks(2166));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 15,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 6, 12, 21, 33, 504, DateTimeKind.Local).AddTicks(2167));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 16,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 6, 12, 21, 33, 504, DateTimeKind.Local).AddTicks(2175));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 17,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 6, 12, 21, 33, 504, DateTimeKind.Local).AddTicks(2177));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 18,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 6, 12, 21, 33, 504, DateTimeKind.Local).AddTicks(2178));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 19,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 6, 12, 21, 33, 504, DateTimeKind.Local).AddTicks(2179));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 20,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 6, 12, 21, 33, 504, DateTimeKind.Local).AddTicks(2181));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 21,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 6, 12, 21, 33, 504, DateTimeKind.Local).AddTicks(2182));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 22,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 6, 12, 21, 33, 504, DateTimeKind.Local).AddTicks(2184));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 23,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 6, 12, 21, 33, 504, DateTimeKind.Local).AddTicks(2185));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 24,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 6, 12, 21, 33, 504, DateTimeKind.Local).AddTicks(2186));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 25,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 6, 12, 21, 33, 504, DateTimeKind.Local).AddTicks(2188));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 26,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 6, 12, 21, 33, 504, DateTimeKind.Local).AddTicks(2189));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 27,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 6, 12, 21, 33, 504, DateTimeKind.Local).AddTicks(2190));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 28,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 6, 12, 21, 33, 504, DateTimeKind.Local).AddTicks(2192));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 29,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 6, 12, 21, 33, 504, DateTimeKind.Local).AddTicks(2193));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 30,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 6, 12, 21, 33, 504, DateTimeKind.Local).AddTicks(2194));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 31,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 6, 12, 21, 33, 504, DateTimeKind.Local).AddTicks(2196));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 32,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 6, 12, 21, 33, 504, DateTimeKind.Local).AddTicks(2197));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 33,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 6, 12, 21, 33, 504, DateTimeKind.Local).AddTicks(2198));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 34,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 6, 12, 21, 33, 504, DateTimeKind.Local).AddTicks(2200));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 35,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 6, 12, 21, 33, 504, DateTimeKind.Local).AddTicks(2201));

            migrationBuilder.UpdateData(
                table: "Branches",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 6, 12, 21, 33, 502, DateTimeKind.Local).AddTicks(2180), new DateTime(2026, 2, 6, 12, 21, 33, 502, DateTimeKind.Local).AddTicks(2253) });

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "LastUpdatedAt", "LicensedValidTill" },
                values: new object[] { new DateTime(2026, 2, 6, 12, 21, 33, 502, DateTimeKind.Local).AddTicks(325), new DateTime(2026, 2, 6, 12, 21, 33, 502, DateTimeKind.Local).AddTicks(406), new DateTime(2026, 8, 5, 12, 21, 33, 502, DateTimeKind.Local).AddTicks(614) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 6, 12, 21, 33, 505, DateTimeKind.Local).AddTicks(197));

            migrationBuilder.UpdateData(
                table: "FinancialYears",
                keyColumn: "Code",
                keyValue: "2026",
                column: "FinStartDate",
                value: new DateTime(2026, 2, 6, 12, 21, 33, 501, DateTimeKind.Local).AddTicks(4744));

            migrationBuilder.UpdateData(
                table: "UserAuths",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 6, 12, 21, 33, 505, DateTimeKind.Local).AddTicks(1761));

            migrationBuilder.UpdateData(
                table: "UserRole",
                keyColumn: "RoleID",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 6, 12, 21, 33, 504, DateTimeKind.Local).AddTicks(3785), new DateTime(2026, 2, 6, 12, 21, 33, 504, DateTimeKind.Local).AddTicks(3872) });

            migrationBuilder.UpdateData(
                table: "UserRole",
                keyColumn: "RoleID",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 6, 12, 21, 33, 504, DateTimeKind.Local).AddTicks(3942), new DateTime(2026, 2, 6, 12, 21, 33, 504, DateTimeKind.Local).AddTicks(3942) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Agentname",
                table: "Vendors");

            migrationBuilder.DropColumn(
                name: "commissionPer",
                table: "Vendors");

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 5, 21, 22, 40, 741, DateTimeKind.Local).AddTicks(4083));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 5, 21, 22, 40, 741, DateTimeKind.Local).AddTicks(4953));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 5, 21, 22, 40, 741, DateTimeKind.Local).AddTicks(4965));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 5, 21, 22, 40, 741, DateTimeKind.Local).AddTicks(4967));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 5, 21, 22, 40, 741, DateTimeKind.Local).AddTicks(4968));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 5, 21, 22, 40, 741, DateTimeKind.Local).AddTicks(4970));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 5, 21, 22, 40, 741, DateTimeKind.Local).AddTicks(5039));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 5, 21, 22, 40, 741, DateTimeKind.Local).AddTicks(5040));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 5, 21, 22, 40, 741, DateTimeKind.Local).AddTicks(5042));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 5, 21, 22, 40, 741, DateTimeKind.Local).AddTicks(5043));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 5, 21, 22, 40, 741, DateTimeKind.Local).AddTicks(5044));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 5, 21, 22, 40, 741, DateTimeKind.Local).AddTicks(5046));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 5, 21, 22, 40, 741, DateTimeKind.Local).AddTicks(5047));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 14,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 5, 21, 22, 40, 741, DateTimeKind.Local).AddTicks(5048));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 15,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 5, 21, 22, 40, 741, DateTimeKind.Local).AddTicks(5050));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 16,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 5, 21, 22, 40, 741, DateTimeKind.Local).AddTicks(5051));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 17,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 5, 21, 22, 40, 741, DateTimeKind.Local).AddTicks(5052));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 18,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 5, 21, 22, 40, 741, DateTimeKind.Local).AddTicks(5062));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 19,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 5, 21, 22, 40, 741, DateTimeKind.Local).AddTicks(5063));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 20,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 5, 21, 22, 40, 741, DateTimeKind.Local).AddTicks(5065));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 21,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 5, 21, 22, 40, 741, DateTimeKind.Local).AddTicks(5066));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 22,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 5, 21, 22, 40, 741, DateTimeKind.Local).AddTicks(5067));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 23,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 5, 21, 22, 40, 741, DateTimeKind.Local).AddTicks(5069));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 24,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 5, 21, 22, 40, 741, DateTimeKind.Local).AddTicks(5070));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 25,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 5, 21, 22, 40, 741, DateTimeKind.Local).AddTicks(5072));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 26,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 5, 21, 22, 40, 741, DateTimeKind.Local).AddTicks(5073));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 27,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 5, 21, 22, 40, 741, DateTimeKind.Local).AddTicks(5075));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 28,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 5, 21, 22, 40, 741, DateTimeKind.Local).AddTicks(5142));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 29,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 5, 21, 22, 40, 741, DateTimeKind.Local).AddTicks(5144));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 30,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 5, 21, 22, 40, 741, DateTimeKind.Local).AddTicks(5145));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 31,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 5, 21, 22, 40, 741, DateTimeKind.Local).AddTicks(5147));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 32,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 5, 21, 22, 40, 741, DateTimeKind.Local).AddTicks(5148));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 33,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 5, 21, 22, 40, 741, DateTimeKind.Local).AddTicks(5150));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 34,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 5, 21, 22, 40, 741, DateTimeKind.Local).AddTicks(5151));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 35,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 5, 21, 22, 40, 741, DateTimeKind.Local).AddTicks(5152));

            migrationBuilder.UpdateData(
                table: "Branches",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 5, 21, 22, 40, 739, DateTimeKind.Local).AddTicks(3648), new DateTime(2026, 2, 5, 21, 22, 40, 739, DateTimeKind.Local).AddTicks(3738) });

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "LastUpdatedAt", "LicensedValidTill" },
                values: new object[] { new DateTime(2026, 2, 5, 21, 22, 40, 739, DateTimeKind.Local).AddTicks(1474), new DateTime(2026, 2, 5, 21, 22, 40, 739, DateTimeKind.Local).AddTicks(1572), new DateTime(2026, 8, 4, 21, 22, 40, 739, DateTimeKind.Local).AddTicks(1774) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 5, 21, 22, 40, 742, DateTimeKind.Local).AddTicks(5069));

            migrationBuilder.UpdateData(
                table: "FinancialYears",
                keyColumn: "Code",
                keyValue: "2026",
                column: "FinStartDate",
                value: new DateTime(2026, 2, 5, 21, 22, 40, 738, DateTimeKind.Local).AddTicks(5790));

            migrationBuilder.UpdateData(
                table: "UserAuths",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 5, 21, 22, 40, 742, DateTimeKind.Local).AddTicks(6954));

            migrationBuilder.UpdateData(
                table: "UserRole",
                keyColumn: "RoleID",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 5, 21, 22, 40, 741, DateTimeKind.Local).AddTicks(7460), new DateTime(2026, 2, 5, 21, 22, 40, 741, DateTimeKind.Local).AddTicks(7570) });

            migrationBuilder.UpdateData(
                table: "UserRole",
                keyColumn: "RoleID",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 5, 21, 22, 40, 741, DateTimeKind.Local).AddTicks(7643), new DateTime(2026, 2, 5, 21, 22, 40, 741, DateTimeKind.Local).AddTicks(7644) });
        }
    }
}
