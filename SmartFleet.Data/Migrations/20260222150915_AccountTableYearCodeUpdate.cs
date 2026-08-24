using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SmartFleet.Data.Migrations
{
    /// <inheritdoc />
    public partial class AccountTableYearCodeUpdate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "YearCode",
                table: "Receipts",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "YearCode",
                table: "payments",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "YearCode",
                table: "JournalEntries",
                type: "nvarchar(max)",
                nullable: true);

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "YearCode",
                table: "Receipts");

            migrationBuilder.DropColumn(
                name: "YearCode",
                table: "payments");

            migrationBuilder.DropColumn(
                name: "YearCode",
                table: "JournalEntries");

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 22, 20, 22, 50, 976, DateTimeKind.Local).AddTicks(9274));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 22, 20, 22, 50, 976, DateTimeKind.Local).AddTicks(9981));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 22, 20, 22, 50, 976, DateTimeKind.Local).AddTicks(9984));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 22, 20, 22, 50, 976, DateTimeKind.Local).AddTicks(9985));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 22, 20, 22, 50, 977, DateTimeKind.Local).AddTicks(24));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 22, 20, 22, 50, 977, DateTimeKind.Local).AddTicks(26));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 22, 20, 22, 50, 977, DateTimeKind.Local).AddTicks(93));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 22, 20, 22, 50, 977, DateTimeKind.Local).AddTicks(94));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 22, 20, 22, 50, 977, DateTimeKind.Local).AddTicks(96));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 22, 20, 22, 50, 977, DateTimeKind.Local).AddTicks(97));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 22, 20, 22, 50, 977, DateTimeKind.Local).AddTicks(98));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 22, 20, 22, 50, 977, DateTimeKind.Local).AddTicks(100));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 22, 20, 22, 50, 977, DateTimeKind.Local).AddTicks(101));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 14,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 22, 20, 22, 50, 977, DateTimeKind.Local).AddTicks(102));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 15,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 22, 20, 22, 50, 977, DateTimeKind.Local).AddTicks(104));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 16,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 22, 20, 22, 50, 977, DateTimeKind.Local).AddTicks(113));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 17,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 22, 20, 22, 50, 977, DateTimeKind.Local).AddTicks(114));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 18,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 22, 20, 22, 50, 977, DateTimeKind.Local).AddTicks(116));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 19,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 22, 20, 22, 50, 977, DateTimeKind.Local).AddTicks(117));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 20,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 22, 20, 22, 50, 977, DateTimeKind.Local).AddTicks(119));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 21,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 22, 20, 22, 50, 977, DateTimeKind.Local).AddTicks(120));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 22,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 22, 20, 22, 50, 977, DateTimeKind.Local).AddTicks(121));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 23,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 22, 20, 22, 50, 977, DateTimeKind.Local).AddTicks(123));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 24,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 22, 20, 22, 50, 977, DateTimeKind.Local).AddTicks(124));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 25,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 22, 20, 22, 50, 977, DateTimeKind.Local).AddTicks(126));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 26,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 22, 20, 22, 50, 977, DateTimeKind.Local).AddTicks(127));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 27,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 22, 20, 22, 50, 977, DateTimeKind.Local).AddTicks(128));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 28,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 22, 20, 22, 50, 977, DateTimeKind.Local).AddTicks(130));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 29,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 22, 20, 22, 50, 977, DateTimeKind.Local).AddTicks(131));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 30,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 22, 20, 22, 50, 977, DateTimeKind.Local).AddTicks(132));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 31,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 22, 20, 22, 50, 977, DateTimeKind.Local).AddTicks(134));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 32,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 22, 20, 22, 50, 977, DateTimeKind.Local).AddTicks(135));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 33,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 22, 20, 22, 50, 977, DateTimeKind.Local).AddTicks(136));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 34,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 22, 20, 22, 50, 977, DateTimeKind.Local).AddTicks(138));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 35,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 22, 20, 22, 50, 977, DateTimeKind.Local).AddTicks(139));

            migrationBuilder.UpdateData(
                table: "Branches",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 22, 20, 22, 50, 975, DateTimeKind.Local).AddTicks(4628), new DateTime(2026, 2, 22, 20, 22, 50, 975, DateTimeKind.Local).AddTicks(4706) });

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "LastUpdatedAt", "LicensedValidTill" },
                values: new object[] { new DateTime(2026, 2, 22, 20, 22, 50, 975, DateTimeKind.Local).AddTicks(2470), new DateTime(2026, 2, 22, 20, 22, 50, 975, DateTimeKind.Local).AddTicks(2552), new DateTime(2026, 8, 21, 20, 22, 50, 975, DateTimeKind.Local).AddTicks(2756) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 22, 20, 22, 50, 977, DateTimeKind.Local).AddTicks(7432));

            migrationBuilder.UpdateData(
                table: "FinancialYears",
                keyColumn: "Code",
                keyValue: "2026",
                column: "FinStartDate",
                value: new DateTime(2026, 2, 22, 20, 22, 50, 974, DateTimeKind.Local).AddTicks(6561));

            migrationBuilder.UpdateData(
                table: "UserAuths",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 22, 20, 22, 50, 977, DateTimeKind.Local).AddTicks(8936));

            migrationBuilder.UpdateData(
                table: "UserRole",
                keyColumn: "RoleID",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 22, 20, 22, 50, 977, DateTimeKind.Local).AddTicks(1709), new DateTime(2026, 2, 22, 20, 22, 50, 977, DateTimeKind.Local).AddTicks(1795) });

            migrationBuilder.UpdateData(
                table: "UserRole",
                keyColumn: "RoleID",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 22, 20, 22, 50, 977, DateTimeKind.Local).AddTicks(1863), new DateTime(2026, 2, 22, 20, 22, 50, 977, DateTimeKind.Local).AddTicks(1864) });
        }
    }
}
