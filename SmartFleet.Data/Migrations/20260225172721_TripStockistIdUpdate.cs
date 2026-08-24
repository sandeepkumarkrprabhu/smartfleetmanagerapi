using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SmartFleet.Data.Migrations
{
    /// <inheritdoc />
    public partial class TripStockistIdUpdate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "StockistID",
                table: "TripTransaction",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 25, 22, 57, 18, 206, DateTimeKind.Local).AddTicks(3759));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 25, 22, 57, 18, 206, DateTimeKind.Local).AddTicks(4474));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 25, 22, 57, 18, 206, DateTimeKind.Local).AddTicks(4477));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 25, 22, 57, 18, 206, DateTimeKind.Local).AddTicks(4478));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 25, 22, 57, 18, 206, DateTimeKind.Local).AddTicks(4480));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 25, 22, 57, 18, 206, DateTimeKind.Local).AddTicks(4488));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 25, 22, 57, 18, 206, DateTimeKind.Local).AddTicks(4554));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 25, 22, 57, 18, 206, DateTimeKind.Local).AddTicks(4555));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 25, 22, 57, 18, 206, DateTimeKind.Local).AddTicks(4557));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 25, 22, 57, 18, 206, DateTimeKind.Local).AddTicks(4558));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 25, 22, 57, 18, 206, DateTimeKind.Local).AddTicks(4594));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 25, 22, 57, 18, 206, DateTimeKind.Local).AddTicks(4596));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 25, 22, 57, 18, 206, DateTimeKind.Local).AddTicks(4597));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 14,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 25, 22, 57, 18, 206, DateTimeKind.Local).AddTicks(4598));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 15,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 25, 22, 57, 18, 206, DateTimeKind.Local).AddTicks(4599));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 16,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 25, 22, 57, 18, 206, DateTimeKind.Local).AddTicks(4601));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 17,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 25, 22, 57, 18, 206, DateTimeKind.Local).AddTicks(4602));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 18,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 25, 22, 57, 18, 206, DateTimeKind.Local).AddTicks(4603));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 19,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 25, 22, 57, 18, 206, DateTimeKind.Local).AddTicks(4605));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 20,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 25, 22, 57, 18, 206, DateTimeKind.Local).AddTicks(4614));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 21,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 25, 22, 57, 18, 206, DateTimeKind.Local).AddTicks(4615));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 22,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 25, 22, 57, 18, 206, DateTimeKind.Local).AddTicks(4616));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 23,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 25, 22, 57, 18, 206, DateTimeKind.Local).AddTicks(4618));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 24,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 25, 22, 57, 18, 206, DateTimeKind.Local).AddTicks(4619));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 25,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 25, 22, 57, 18, 206, DateTimeKind.Local).AddTicks(4620));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 26,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 25, 22, 57, 18, 206, DateTimeKind.Local).AddTicks(4622));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 27,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 25, 22, 57, 18, 206, DateTimeKind.Local).AddTicks(4623));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 28,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 25, 22, 57, 18, 206, DateTimeKind.Local).AddTicks(4624));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 29,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 25, 22, 57, 18, 206, DateTimeKind.Local).AddTicks(4626));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 30,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 25, 22, 57, 18, 206, DateTimeKind.Local).AddTicks(4627));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 31,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 25, 22, 57, 18, 206, DateTimeKind.Local).AddTicks(4628));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 32,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 25, 22, 57, 18, 206, DateTimeKind.Local).AddTicks(4630));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 33,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 25, 22, 57, 18, 206, DateTimeKind.Local).AddTicks(4631));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 34,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 25, 22, 57, 18, 206, DateTimeKind.Local).AddTicks(4632));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 35,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 25, 22, 57, 18, 206, DateTimeKind.Local).AddTicks(4634));

            migrationBuilder.UpdateData(
                table: "Branches",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 22, 57, 18, 204, DateTimeKind.Local).AddTicks(7974), new DateTime(2026, 2, 25, 22, 57, 18, 204, DateTimeKind.Local).AddTicks(8051) });

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "LastUpdatedAt", "LicensedValidTill" },
                values: new object[] { new DateTime(2026, 2, 25, 22, 57, 18, 204, DateTimeKind.Local).AddTicks(5798), new DateTime(2026, 2, 25, 22, 57, 18, 204, DateTimeKind.Local).AddTicks(5881), new DateTime(2026, 8, 24, 22, 57, 18, 204, DateTimeKind.Local).AddTicks(6084) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 25, 22, 57, 18, 207, DateTimeKind.Local).AddTicks(1690));

            migrationBuilder.UpdateData(
                table: "FinancialYears",
                keyColumn: "Code",
                keyValue: "2026",
                column: "FinStartDate",
                value: new DateTime(2026, 2, 25, 22, 57, 18, 203, DateTimeKind.Local).AddTicks(8516));

            migrationBuilder.UpdateData(
                table: "UserAuths",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 25, 22, 57, 18, 207, DateTimeKind.Local).AddTicks(3315));

            migrationBuilder.UpdateData(
                table: "UserRole",
                keyColumn: "RoleID",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 22, 57, 18, 206, DateTimeKind.Local).AddTicks(6190), new DateTime(2026, 2, 25, 22, 57, 18, 206, DateTimeKind.Local).AddTicks(6277) });

            migrationBuilder.UpdateData(
                table: "UserRole",
                keyColumn: "RoleID",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 22, 57, 18, 206, DateTimeKind.Local).AddTicks(6347), new DateTime(2026, 2, 25, 22, 57, 18, 206, DateTimeKind.Local).AddTicks(6347) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "StockistID",
                table: "TripTransaction");

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 22, 20, 39, 11, 283, DateTimeKind.Local).AddTicks(1793));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 22, 20, 39, 11, 283, DateTimeKind.Local).AddTicks(2541));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 22, 20, 39, 11, 283, DateTimeKind.Local).AddTicks(2543));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 22, 20, 39, 11, 283, DateTimeKind.Local).AddTicks(2545));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 22, 20, 39, 11, 283, DateTimeKind.Local).AddTicks(2546));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 22, 20, 39, 11, 283, DateTimeKind.Local).AddTicks(2548));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 22, 20, 39, 11, 283, DateTimeKind.Local).AddTicks(2613));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 22, 20, 39, 11, 283, DateTimeKind.Local).AddTicks(2615));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 22, 20, 39, 11, 283, DateTimeKind.Local).AddTicks(2616));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 22, 20, 39, 11, 283, DateTimeKind.Local).AddTicks(2618));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 22, 20, 39, 11, 283, DateTimeKind.Local).AddTicks(2619));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 22, 20, 39, 11, 283, DateTimeKind.Local).AddTicks(2627));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 22, 20, 39, 11, 283, DateTimeKind.Local).AddTicks(2629));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 14,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 22, 20, 39, 11, 283, DateTimeKind.Local).AddTicks(2630));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 15,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 22, 20, 39, 11, 283, DateTimeKind.Local).AddTicks(2632));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 16,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 22, 20, 39, 11, 283, DateTimeKind.Local).AddTicks(2633));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 17,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 22, 20, 39, 11, 283, DateTimeKind.Local).AddTicks(2634));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 18,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 22, 20, 39, 11, 283, DateTimeKind.Local).AddTicks(2636));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 19,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 22, 20, 39, 11, 283, DateTimeKind.Local).AddTicks(2638));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 20,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 22, 20, 39, 11, 283, DateTimeKind.Local).AddTicks(2639));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 21,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 22, 20, 39, 11, 283, DateTimeKind.Local).AddTicks(2640));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 22,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 22, 20, 39, 11, 283, DateTimeKind.Local).AddTicks(2642));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 23,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 22, 20, 39, 11, 283, DateTimeKind.Local).AddTicks(2643));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 24,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 22, 20, 39, 11, 283, DateTimeKind.Local).AddTicks(2644));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 25,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 22, 20, 39, 11, 283, DateTimeKind.Local).AddTicks(2646));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 26,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 22, 20, 39, 11, 283, DateTimeKind.Local).AddTicks(2647));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 27,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 22, 20, 39, 11, 283, DateTimeKind.Local).AddTicks(2648));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 28,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 22, 20, 39, 11, 283, DateTimeKind.Local).AddTicks(2685));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 29,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 22, 20, 39, 11, 283, DateTimeKind.Local).AddTicks(2687));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 30,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 22, 20, 39, 11, 283, DateTimeKind.Local).AddTicks(2688));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 31,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 22, 20, 39, 11, 283, DateTimeKind.Local).AddTicks(2689));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 32,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 22, 20, 39, 11, 283, DateTimeKind.Local).AddTicks(2691));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 33,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 22, 20, 39, 11, 283, DateTimeKind.Local).AddTicks(2692));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 34,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 22, 20, 39, 11, 283, DateTimeKind.Local).AddTicks(2693));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 35,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 22, 20, 39, 11, 283, DateTimeKind.Local).AddTicks(2695));

            migrationBuilder.UpdateData(
                table: "Branches",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 22, 20, 39, 11, 281, DateTimeKind.Local).AddTicks(6148), new DateTime(2026, 2, 22, 20, 39, 11, 281, DateTimeKind.Local).AddTicks(6228) });

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "LastUpdatedAt", "LicensedValidTill" },
                values: new object[] { new DateTime(2026, 2, 22, 20, 39, 11, 281, DateTimeKind.Local).AddTicks(3980), new DateTime(2026, 2, 22, 20, 39, 11, 281, DateTimeKind.Local).AddTicks(4066), new DateTime(2026, 8, 21, 20, 39, 11, 281, DateTimeKind.Local).AddTicks(4311) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 22, 20, 39, 11, 284, DateTimeKind.Local).AddTicks(362));

            migrationBuilder.UpdateData(
                table: "FinancialYears",
                keyColumn: "Code",
                keyValue: "2026",
                column: "FinStartDate",
                value: new DateTime(2026, 2, 22, 20, 39, 11, 280, DateTimeKind.Local).AddTicks(8120));

            migrationBuilder.UpdateData(
                table: "UserAuths",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 22, 20, 39, 11, 284, DateTimeKind.Local).AddTicks(2162));

            migrationBuilder.UpdateData(
                table: "UserRole",
                keyColumn: "RoleID",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 22, 20, 39, 11, 283, DateTimeKind.Local).AddTicks(4250), new DateTime(2026, 2, 22, 20, 39, 11, 283, DateTimeKind.Local).AddTicks(4335) });

            migrationBuilder.UpdateData(
                table: "UserRole",
                keyColumn: "RoleID",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 22, 20, 39, 11, 283, DateTimeKind.Local).AddTicks(4403), new DateTime(2026, 2, 22, 20, 39, 11, 283, DateTimeKind.Local).AddTicks(4404) });
        }
    }
}
