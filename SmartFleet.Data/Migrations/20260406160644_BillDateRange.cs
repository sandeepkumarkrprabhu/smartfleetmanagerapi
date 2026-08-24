using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SmartFleet.Data.Migrations
{
    /// <inheritdoc />
    public partial class BillDateRange : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "BIllFromDate",
                table: "BillTransaction",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "BillToDate",
                table: "BillTransaction",
                type: "datetime2",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2026, 4, 6, 21, 36, 42, 965, DateTimeKind.Local).AddTicks(6461));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2026, 4, 6, 21, 36, 42, 965, DateTimeKind.Local).AddTicks(7536));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2026, 4, 6, 21, 36, 42, 965, DateTimeKind.Local).AddTicks(7540));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2026, 4, 6, 21, 36, 42, 965, DateTimeKind.Local).AddTicks(7543));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2026, 4, 6, 21, 36, 42, 965, DateTimeKind.Local).AddTicks(7545));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2026, 4, 6, 21, 36, 42, 965, DateTimeKind.Local).AddTicks(7546));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2026, 4, 6, 21, 36, 42, 965, DateTimeKind.Local).AddTicks(7645));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2026, 4, 6, 21, 36, 42, 965, DateTimeKind.Local).AddTicks(7648));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2026, 4, 6, 21, 36, 42, 965, DateTimeKind.Local).AddTicks(7650));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2026, 4, 6, 21, 36, 42, 965, DateTimeKind.Local).AddTicks(7652));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2026, 4, 6, 21, 36, 42, 965, DateTimeKind.Local).AddTicks(7654));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2026, 4, 6, 21, 36, 42, 965, DateTimeKind.Local).AddTicks(7655));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2026, 4, 6, 21, 36, 42, 965, DateTimeKind.Local).AddTicks(7657));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 14,
                column: "CreatedAt",
                value: new DateTime(2026, 4, 6, 21, 36, 42, 965, DateTimeKind.Local).AddTicks(7659));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 15,
                column: "CreatedAt",
                value: new DateTime(2026, 4, 6, 21, 36, 42, 965, DateTimeKind.Local).AddTicks(7661));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 16,
                column: "CreatedAt",
                value: new DateTime(2026, 4, 6, 21, 36, 42, 965, DateTimeKind.Local).AddTicks(7674));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 17,
                column: "CreatedAt",
                value: new DateTime(2026, 4, 6, 21, 36, 42, 965, DateTimeKind.Local).AddTicks(7676));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 18,
                column: "CreatedAt",
                value: new DateTime(2026, 4, 6, 21, 36, 42, 965, DateTimeKind.Local).AddTicks(7678));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 19,
                column: "CreatedAt",
                value: new DateTime(2026, 4, 6, 21, 36, 42, 965, DateTimeKind.Local).AddTicks(7680));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 20,
                column: "CreatedAt",
                value: new DateTime(2026, 4, 6, 21, 36, 42, 965, DateTimeKind.Local).AddTicks(7682));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 21,
                column: "CreatedAt",
                value: new DateTime(2026, 4, 6, 21, 36, 42, 965, DateTimeKind.Local).AddTicks(7684));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 22,
                column: "CreatedAt",
                value: new DateTime(2026, 4, 6, 21, 36, 42, 965, DateTimeKind.Local).AddTicks(7685));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 23,
                column: "CreatedAt",
                value: new DateTime(2026, 4, 6, 21, 36, 42, 965, DateTimeKind.Local).AddTicks(7687));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 24,
                column: "CreatedAt",
                value: new DateTime(2026, 4, 6, 21, 36, 42, 965, DateTimeKind.Local).AddTicks(7689));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 25,
                column: "CreatedAt",
                value: new DateTime(2026, 4, 6, 21, 36, 42, 965, DateTimeKind.Local).AddTicks(7691));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 26,
                column: "CreatedAt",
                value: new DateTime(2026, 4, 6, 21, 36, 42, 965, DateTimeKind.Local).AddTicks(7693));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 27,
                column: "CreatedAt",
                value: new DateTime(2026, 4, 6, 21, 36, 42, 965, DateTimeKind.Local).AddTicks(7695));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 28,
                column: "CreatedAt",
                value: new DateTime(2026, 4, 6, 21, 36, 42, 965, DateTimeKind.Local).AddTicks(7697));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 29,
                column: "CreatedAt",
                value: new DateTime(2026, 4, 6, 21, 36, 42, 965, DateTimeKind.Local).AddTicks(7698));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 30,
                column: "CreatedAt",
                value: new DateTime(2026, 4, 6, 21, 36, 42, 965, DateTimeKind.Local).AddTicks(7700));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 31,
                column: "CreatedAt",
                value: new DateTime(2026, 4, 6, 21, 36, 42, 965, DateTimeKind.Local).AddTicks(7702));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 32,
                column: "CreatedAt",
                value: new DateTime(2026, 4, 6, 21, 36, 42, 965, DateTimeKind.Local).AddTicks(7704));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 33,
                column: "CreatedAt",
                value: new DateTime(2026, 4, 6, 21, 36, 42, 965, DateTimeKind.Local).AddTicks(7706));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 34,
                column: "CreatedAt",
                value: new DateTime(2026, 4, 6, 21, 36, 42, 965, DateTimeKind.Local).AddTicks(7708));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 35,
                column: "CreatedAt",
                value: new DateTime(2026, 4, 6, 21, 36, 42, 965, DateTimeKind.Local).AddTicks(7710));

            migrationBuilder.UpdateData(
                table: "Branches",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 4, 6, 21, 36, 42, 963, DateTimeKind.Local).AddTicks(3533), new DateTime(2026, 4, 6, 21, 36, 42, 963, DateTimeKind.Local).AddTicks(3653) });

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "LastUpdatedAt", "LicensedValidTill" },
                values: new object[] { new DateTime(2026, 4, 6, 21, 36, 42, 963, DateTimeKind.Local).AddTicks(44), new DateTime(2026, 4, 6, 21, 36, 42, 963, DateTimeKind.Local).AddTicks(168), new DateTime(2026, 10, 3, 21, 36, 42, 963, DateTimeKind.Local).AddTicks(474) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2026, 4, 6, 21, 36, 42, 967, DateTimeKind.Local).AddTicks(6135));

            migrationBuilder.UpdateData(
                table: "FinancialYears",
                keyColumn: "Code",
                keyValue: "2026",
                column: "FinStartDate",
                value: new DateTime(2026, 4, 6, 21, 36, 42, 962, DateTimeKind.Local).AddTicks(1451));

            migrationBuilder.UpdateData(
                table: "UserAuths",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2026, 4, 6, 21, 36, 42, 967, DateTimeKind.Local).AddTicks(9788));

            migrationBuilder.UpdateData(
                table: "UserRole",
                keyColumn: "RoleID",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 4, 6, 21, 36, 42, 966, DateTimeKind.Local).AddTicks(226), new DateTime(2026, 4, 6, 21, 36, 42, 966, DateTimeKind.Local).AddTicks(366) });

            migrationBuilder.UpdateData(
                table: "UserRole",
                keyColumn: "RoleID",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 4, 6, 21, 36, 42, 966, DateTimeKind.Local).AddTicks(471), new DateTime(2026, 4, 6, 21, 36, 42, 966, DateTimeKind.Local).AddTicks(472) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "BIllFromDate",
                table: "BillTransaction");

            migrationBuilder.DropColumn(
                name: "BillToDate",
                table: "BillTransaction");

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2026, 3, 28, 10, 52, 22, 403, DateTimeKind.Local).AddTicks(463));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2026, 3, 28, 10, 52, 22, 403, DateTimeKind.Local).AddTicks(1921));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2026, 3, 28, 10, 52, 22, 403, DateTimeKind.Local).AddTicks(1926));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2026, 3, 28, 10, 52, 22, 403, DateTimeKind.Local).AddTicks(1946));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2026, 3, 28, 10, 52, 22, 403, DateTimeKind.Local).AddTicks(1949));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2026, 3, 28, 10, 52, 22, 403, DateTimeKind.Local).AddTicks(1951));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2026, 3, 28, 10, 52, 22, 403, DateTimeKind.Local).AddTicks(2067));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2026, 3, 28, 10, 52, 22, 403, DateTimeKind.Local).AddTicks(2069));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2026, 3, 28, 10, 52, 22, 403, DateTimeKind.Local).AddTicks(2071));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2026, 3, 28, 10, 52, 22, 403, DateTimeKind.Local).AddTicks(2073));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2026, 3, 28, 10, 52, 22, 403, DateTimeKind.Local).AddTicks(2074));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2026, 3, 28, 10, 52, 22, 403, DateTimeKind.Local).AddTicks(2076));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2026, 3, 28, 10, 52, 22, 403, DateTimeKind.Local).AddTicks(2078));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 14,
                column: "CreatedAt",
                value: new DateTime(2026, 3, 28, 10, 52, 22, 403, DateTimeKind.Local).AddTicks(2079));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 15,
                column: "CreatedAt",
                value: new DateTime(2026, 3, 28, 10, 52, 22, 403, DateTimeKind.Local).AddTicks(2081));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 16,
                column: "CreatedAt",
                value: new DateTime(2026, 3, 28, 10, 52, 22, 403, DateTimeKind.Local).AddTicks(2083));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 17,
                column: "CreatedAt",
                value: new DateTime(2026, 3, 28, 10, 52, 22, 403, DateTimeKind.Local).AddTicks(2085));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 18,
                column: "CreatedAt",
                value: new DateTime(2026, 3, 28, 10, 52, 22, 403, DateTimeKind.Local).AddTicks(2087));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 19,
                column: "CreatedAt",
                value: new DateTime(2026, 3, 28, 10, 52, 22, 403, DateTimeKind.Local).AddTicks(2100));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 20,
                column: "CreatedAt",
                value: new DateTime(2026, 3, 28, 10, 52, 22, 403, DateTimeKind.Local).AddTicks(2102));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 21,
                column: "CreatedAt",
                value: new DateTime(2026, 3, 28, 10, 52, 22, 403, DateTimeKind.Local).AddTicks(2104));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 22,
                column: "CreatedAt",
                value: new DateTime(2026, 3, 28, 10, 52, 22, 403, DateTimeKind.Local).AddTicks(2106));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 23,
                column: "CreatedAt",
                value: new DateTime(2026, 3, 28, 10, 52, 22, 403, DateTimeKind.Local).AddTicks(2108));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 24,
                column: "CreatedAt",
                value: new DateTime(2026, 3, 28, 10, 52, 22, 403, DateTimeKind.Local).AddTicks(2110));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 25,
                column: "CreatedAt",
                value: new DateTime(2026, 3, 28, 10, 52, 22, 403, DateTimeKind.Local).AddTicks(2112));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 26,
                column: "CreatedAt",
                value: new DateTime(2026, 3, 28, 10, 52, 22, 403, DateTimeKind.Local).AddTicks(2114));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 27,
                column: "CreatedAt",
                value: new DateTime(2026, 3, 28, 10, 52, 22, 403, DateTimeKind.Local).AddTicks(2115));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 28,
                column: "CreatedAt",
                value: new DateTime(2026, 3, 28, 10, 52, 22, 403, DateTimeKind.Local).AddTicks(2117));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 29,
                column: "CreatedAt",
                value: new DateTime(2026, 3, 28, 10, 52, 22, 403, DateTimeKind.Local).AddTicks(2119));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 30,
                column: "CreatedAt",
                value: new DateTime(2026, 3, 28, 10, 52, 22, 403, DateTimeKind.Local).AddTicks(2121));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 31,
                column: "CreatedAt",
                value: new DateTime(2026, 3, 28, 10, 52, 22, 403, DateTimeKind.Local).AddTicks(2123));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 32,
                column: "CreatedAt",
                value: new DateTime(2026, 3, 28, 10, 52, 22, 403, DateTimeKind.Local).AddTicks(2124));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 33,
                column: "CreatedAt",
                value: new DateTime(2026, 3, 28, 10, 52, 22, 403, DateTimeKind.Local).AddTicks(2126));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 34,
                column: "CreatedAt",
                value: new DateTime(2026, 3, 28, 10, 52, 22, 403, DateTimeKind.Local).AddTicks(2128));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 35,
                column: "CreatedAt",
                value: new DateTime(2026, 3, 28, 10, 52, 22, 403, DateTimeKind.Local).AddTicks(2129));

            migrationBuilder.UpdateData(
                table: "Branches",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 3, 28, 10, 52, 22, 399, DateTimeKind.Local).AddTicks(5481), new DateTime(2026, 3, 28, 10, 52, 22, 399, DateTimeKind.Local).AddTicks(5627) });

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "LastUpdatedAt", "LicensedValidTill" },
                values: new object[] { new DateTime(2026, 3, 28, 10, 52, 22, 399, DateTimeKind.Local).AddTicks(1370), new DateTime(2026, 3, 28, 10, 52, 22, 399, DateTimeKind.Local).AddTicks(1515), new DateTime(2026, 9, 24, 10, 52, 22, 399, DateTimeKind.Local).AddTicks(1891) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2026, 3, 28, 10, 52, 22, 404, DateTimeKind.Local).AddTicks(8344));

            migrationBuilder.UpdateData(
                table: "FinancialYears",
                keyColumn: "Code",
                keyValue: "2026",
                column: "FinStartDate",
                value: new DateTime(2026, 3, 28, 10, 52, 22, 398, DateTimeKind.Local).AddTicks(81));

            migrationBuilder.UpdateData(
                table: "UserAuths",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2026, 3, 28, 10, 52, 22, 405, DateTimeKind.Local).AddTicks(1107));

            migrationBuilder.UpdateData(
                table: "UserRole",
                keyColumn: "RoleID",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 3, 28, 10, 52, 22, 403, DateTimeKind.Local).AddTicks(5411), new DateTime(2026, 3, 28, 10, 52, 22, 403, DateTimeKind.Local).AddTicks(5575) });

            migrationBuilder.UpdateData(
                table: "UserRole",
                keyColumn: "RoleID",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 3, 28, 10, 52, 22, 403, DateTimeKind.Local).AddTicks(5804), new DateTime(2026, 3, 28, 10, 52, 22, 403, DateTimeKind.Local).AddTicks(5804) });
        }
    }
}
