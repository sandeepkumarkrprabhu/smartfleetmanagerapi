using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SmartFleet.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddTaxFieldsForBill : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<decimal>(
                name: "CGST",
                table: "BillTransaction",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "IGST",
                table: "BillTransaction",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "SGST",
                table: "BillTransaction",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2026, 3, 20, 14, 50, 20, 712, DateTimeKind.Local).AddTicks(1490));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2026, 3, 20, 14, 50, 20, 712, DateTimeKind.Local).AddTicks(2334));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2026, 3, 20, 14, 50, 20, 712, DateTimeKind.Local).AddTicks(2337));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2026, 3, 20, 14, 50, 20, 712, DateTimeKind.Local).AddTicks(2339));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2026, 3, 20, 14, 50, 20, 712, DateTimeKind.Local).AddTicks(2341));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2026, 3, 20, 14, 50, 20, 712, DateTimeKind.Local).AddTicks(2343));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2026, 3, 20, 14, 50, 20, 712, DateTimeKind.Local).AddTicks(2426));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2026, 3, 20, 14, 50, 20, 712, DateTimeKind.Local).AddTicks(2428));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2026, 3, 20, 14, 50, 20, 712, DateTimeKind.Local).AddTicks(2430));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2026, 3, 20, 14, 50, 20, 712, DateTimeKind.Local).AddTicks(2431));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2026, 3, 20, 14, 50, 20, 712, DateTimeKind.Local).AddTicks(2433));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2026, 3, 20, 14, 50, 20, 712, DateTimeKind.Local).AddTicks(2435));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2026, 3, 20, 14, 50, 20, 712, DateTimeKind.Local).AddTicks(2436));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 14,
                column: "CreatedAt",
                value: new DateTime(2026, 3, 20, 14, 50, 20, 712, DateTimeKind.Local).AddTicks(2438));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 15,
                column: "CreatedAt",
                value: new DateTime(2026, 3, 20, 14, 50, 20, 712, DateTimeKind.Local).AddTicks(2439));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 16,
                column: "CreatedAt",
                value: new DateTime(2026, 3, 20, 14, 50, 20, 712, DateTimeKind.Local).AddTicks(2441));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 17,
                column: "CreatedAt",
                value: new DateTime(2026, 3, 20, 14, 50, 20, 712, DateTimeKind.Local).AddTicks(2442));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 18,
                column: "CreatedAt",
                value: new DateTime(2026, 3, 20, 14, 50, 20, 712, DateTimeKind.Local).AddTicks(2444));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 19,
                column: "CreatedAt",
                value: new DateTime(2026, 3, 20, 14, 50, 20, 712, DateTimeKind.Local).AddTicks(2446));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 20,
                column: "CreatedAt",
                value: new DateTime(2026, 3, 20, 14, 50, 20, 712, DateTimeKind.Local).AddTicks(2447));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 21,
                column: "CreatedAt",
                value: new DateTime(2026, 3, 20, 14, 50, 20, 712, DateTimeKind.Local).AddTicks(2457));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 22,
                column: "CreatedAt",
                value: new DateTime(2026, 3, 20, 14, 50, 20, 712, DateTimeKind.Local).AddTicks(2458));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 23,
                column: "CreatedAt",
                value: new DateTime(2026, 3, 20, 14, 50, 20, 712, DateTimeKind.Local).AddTicks(2460));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 24,
                column: "CreatedAt",
                value: new DateTime(2026, 3, 20, 14, 50, 20, 712, DateTimeKind.Local).AddTicks(2462));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 25,
                column: "CreatedAt",
                value: new DateTime(2026, 3, 20, 14, 50, 20, 712, DateTimeKind.Local).AddTicks(2464));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 26,
                column: "CreatedAt",
                value: new DateTime(2026, 3, 20, 14, 50, 20, 712, DateTimeKind.Local).AddTicks(2465));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 27,
                column: "CreatedAt",
                value: new DateTime(2026, 3, 20, 14, 50, 20, 712, DateTimeKind.Local).AddTicks(2467));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 28,
                column: "CreatedAt",
                value: new DateTime(2026, 3, 20, 14, 50, 20, 712, DateTimeKind.Local).AddTicks(2469));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 29,
                column: "CreatedAt",
                value: new DateTime(2026, 3, 20, 14, 50, 20, 712, DateTimeKind.Local).AddTicks(2470));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 30,
                column: "CreatedAt",
                value: new DateTime(2026, 3, 20, 14, 50, 20, 712, DateTimeKind.Local).AddTicks(2472));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 31,
                column: "CreatedAt",
                value: new DateTime(2026, 3, 20, 14, 50, 20, 712, DateTimeKind.Local).AddTicks(2474));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 32,
                column: "CreatedAt",
                value: new DateTime(2026, 3, 20, 14, 50, 20, 712, DateTimeKind.Local).AddTicks(2475));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 33,
                column: "CreatedAt",
                value: new DateTime(2026, 3, 20, 14, 50, 20, 712, DateTimeKind.Local).AddTicks(2477));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 34,
                column: "CreatedAt",
                value: new DateTime(2026, 3, 20, 14, 50, 20, 712, DateTimeKind.Local).AddTicks(2479));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 35,
                column: "CreatedAt",
                value: new DateTime(2026, 3, 20, 14, 50, 20, 712, DateTimeKind.Local).AddTicks(2480));

            migrationBuilder.UpdateData(
                table: "Branches",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 3, 20, 14, 50, 20, 709, DateTimeKind.Local).AddTicks(8857), new DateTime(2026, 3, 20, 14, 50, 20, 709, DateTimeKind.Local).AddTicks(8944) });

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "LastUpdatedAt", "LicensedValidTill" },
                values: new object[] { new DateTime(2026, 3, 20, 14, 50, 20, 709, DateTimeKind.Local).AddTicks(6424), new DateTime(2026, 3, 20, 14, 50, 20, 709, DateTimeKind.Local).AddTicks(6520), new DateTime(2026, 9, 16, 14, 50, 20, 709, DateTimeKind.Local).AddTicks(6755) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2026, 3, 20, 14, 50, 20, 713, DateTimeKind.Local).AddTicks(2791));

            migrationBuilder.UpdateData(
                table: "FinancialYears",
                keyColumn: "Code",
                keyValue: "2026",
                column: "FinStartDate",
                value: new DateTime(2026, 3, 20, 14, 50, 20, 708, DateTimeKind.Local).AddTicks(9324));

            migrationBuilder.UpdateData(
                table: "UserAuths",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2026, 3, 20, 14, 50, 20, 713, DateTimeKind.Local).AddTicks(4501));

            migrationBuilder.UpdateData(
                table: "UserRole",
                keyColumn: "RoleID",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 3, 20, 14, 50, 20, 712, DateTimeKind.Local).AddTicks(4521), new DateTime(2026, 3, 20, 14, 50, 20, 712, DateTimeKind.Local).AddTicks(4658) });

            migrationBuilder.UpdateData(
                table: "UserRole",
                keyColumn: "RoleID",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 3, 20, 14, 50, 20, 712, DateTimeKind.Local).AddTicks(4743), new DateTime(2026, 3, 20, 14, 50, 20, 712, DateTimeKind.Local).AddTicks(4744) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CGST",
                table: "BillTransaction");

            migrationBuilder.DropColumn(
                name: "IGST",
                table: "BillTransaction");

            migrationBuilder.DropColumn(
                name: "SGST",
                table: "BillTransaction");

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2026, 3, 19, 15, 38, 44, 944, DateTimeKind.Local).AddTicks(1810));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2026, 3, 19, 15, 38, 44, 944, DateTimeKind.Local).AddTicks(2515));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2026, 3, 19, 15, 38, 44, 944, DateTimeKind.Local).AddTicks(2517));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2026, 3, 19, 15, 38, 44, 944, DateTimeKind.Local).AddTicks(2519));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2026, 3, 19, 15, 38, 44, 944, DateTimeKind.Local).AddTicks(2520));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2026, 3, 19, 15, 38, 44, 944, DateTimeKind.Local).AddTicks(2521));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2026, 3, 19, 15, 38, 44, 944, DateTimeKind.Local).AddTicks(2587));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2026, 3, 19, 15, 38, 44, 944, DateTimeKind.Local).AddTicks(2589));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2026, 3, 19, 15, 38, 44, 944, DateTimeKind.Local).AddTicks(2590));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2026, 3, 19, 15, 38, 44, 944, DateTimeKind.Local).AddTicks(2591));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2026, 3, 19, 15, 38, 44, 944, DateTimeKind.Local).AddTicks(2593));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2026, 3, 19, 15, 38, 44, 944, DateTimeKind.Local).AddTicks(2594));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2026, 3, 19, 15, 38, 44, 944, DateTimeKind.Local).AddTicks(2642));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 14,
                column: "CreatedAt",
                value: new DateTime(2026, 3, 19, 15, 38, 44, 944, DateTimeKind.Local).AddTicks(2644));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 15,
                column: "CreatedAt",
                value: new DateTime(2026, 3, 19, 15, 38, 44, 944, DateTimeKind.Local).AddTicks(2646));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 16,
                column: "CreatedAt",
                value: new DateTime(2026, 3, 19, 15, 38, 44, 944, DateTimeKind.Local).AddTicks(2654));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 17,
                column: "CreatedAt",
                value: new DateTime(2026, 3, 19, 15, 38, 44, 944, DateTimeKind.Local).AddTicks(2656));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 18,
                column: "CreatedAt",
                value: new DateTime(2026, 3, 19, 15, 38, 44, 944, DateTimeKind.Local).AddTicks(2657));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 19,
                column: "CreatedAt",
                value: new DateTime(2026, 3, 19, 15, 38, 44, 944, DateTimeKind.Local).AddTicks(2658));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 20,
                column: "CreatedAt",
                value: new DateTime(2026, 3, 19, 15, 38, 44, 944, DateTimeKind.Local).AddTicks(2660));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 21,
                column: "CreatedAt",
                value: new DateTime(2026, 3, 19, 15, 38, 44, 944, DateTimeKind.Local).AddTicks(2661));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 22,
                column: "CreatedAt",
                value: new DateTime(2026, 3, 19, 15, 38, 44, 944, DateTimeKind.Local).AddTicks(2662));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 23,
                column: "CreatedAt",
                value: new DateTime(2026, 3, 19, 15, 38, 44, 944, DateTimeKind.Local).AddTicks(2664));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 24,
                column: "CreatedAt",
                value: new DateTime(2026, 3, 19, 15, 38, 44, 944, DateTimeKind.Local).AddTicks(2665));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 25,
                column: "CreatedAt",
                value: new DateTime(2026, 3, 19, 15, 38, 44, 944, DateTimeKind.Local).AddTicks(2666));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 26,
                column: "CreatedAt",
                value: new DateTime(2026, 3, 19, 15, 38, 44, 944, DateTimeKind.Local).AddTicks(2668));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 27,
                column: "CreatedAt",
                value: new DateTime(2026, 3, 19, 15, 38, 44, 944, DateTimeKind.Local).AddTicks(2669));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 28,
                column: "CreatedAt",
                value: new DateTime(2026, 3, 19, 15, 38, 44, 944, DateTimeKind.Local).AddTicks(2670));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 29,
                column: "CreatedAt",
                value: new DateTime(2026, 3, 19, 15, 38, 44, 944, DateTimeKind.Local).AddTicks(2672));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 30,
                column: "CreatedAt",
                value: new DateTime(2026, 3, 19, 15, 38, 44, 944, DateTimeKind.Local).AddTicks(2673));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 31,
                column: "CreatedAt",
                value: new DateTime(2026, 3, 19, 15, 38, 44, 944, DateTimeKind.Local).AddTicks(2674));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 32,
                column: "CreatedAt",
                value: new DateTime(2026, 3, 19, 15, 38, 44, 944, DateTimeKind.Local).AddTicks(2675));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 33,
                column: "CreatedAt",
                value: new DateTime(2026, 3, 19, 15, 38, 44, 944, DateTimeKind.Local).AddTicks(2677));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 34,
                column: "CreatedAt",
                value: new DateTime(2026, 3, 19, 15, 38, 44, 944, DateTimeKind.Local).AddTicks(2678));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 35,
                column: "CreatedAt",
                value: new DateTime(2026, 3, 19, 15, 38, 44, 944, DateTimeKind.Local).AddTicks(2679));

            migrationBuilder.UpdateData(
                table: "Branches",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 3, 19, 15, 38, 44, 942, DateTimeKind.Local).AddTicks(5906), new DateTime(2026, 3, 19, 15, 38, 44, 942, DateTimeKind.Local).AddTicks(5988) });

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "LastUpdatedAt", "LicensedValidTill" },
                values: new object[] { new DateTime(2026, 3, 19, 15, 38, 44, 942, DateTimeKind.Local).AddTicks(3907), new DateTime(2026, 3, 19, 15, 38, 44, 942, DateTimeKind.Local).AddTicks(3991), new DateTime(2026, 9, 15, 15, 38, 44, 942, DateTimeKind.Local).AddTicks(4199) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2026, 3, 19, 15, 38, 44, 945, DateTimeKind.Local).AddTicks(292));

            migrationBuilder.UpdateData(
                table: "FinancialYears",
                keyColumn: "Code",
                keyValue: "2026",
                column: "FinStartDate",
                value: new DateTime(2026, 3, 19, 15, 38, 44, 941, DateTimeKind.Local).AddTicks(5656));

            migrationBuilder.UpdateData(
                table: "UserAuths",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2026, 3, 19, 15, 38, 44, 945, DateTimeKind.Local).AddTicks(1795));

            migrationBuilder.UpdateData(
                table: "UserRole",
                keyColumn: "RoleID",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 3, 19, 15, 38, 44, 944, DateTimeKind.Local).AddTicks(4255), new DateTime(2026, 3, 19, 15, 38, 44, 944, DateTimeKind.Local).AddTicks(4343) });

            migrationBuilder.UpdateData(
                table: "UserRole",
                keyColumn: "RoleID",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 3, 19, 15, 38, 44, 944, DateTimeKind.Local).AddTicks(4413), new DateTime(2026, 3, 19, 15, 38, 44, 944, DateTimeKind.Local).AddTicks(4414) });
        }
    }
}
