using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SmartFleet.Data.Migrations
{
    /// <inheritdoc />
    public partial class JournalEntryPostingProperties : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "AccountStatus",
                table: "JournalEntries",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "AccountTransactionId",
                table: "JournalEntries",
                type: "int",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2026, 9, 3, 16, 2, 44, 928, DateTimeKind.Local).AddTicks(6092));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2026, 9, 3, 16, 2, 44, 928, DateTimeKind.Local).AddTicks(6784));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2026, 9, 3, 16, 2, 44, 928, DateTimeKind.Local).AddTicks(6787));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2026, 9, 3, 16, 2, 44, 928, DateTimeKind.Local).AddTicks(6788));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2026, 9, 3, 16, 2, 44, 928, DateTimeKind.Local).AddTicks(6790));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2026, 9, 3, 16, 2, 44, 928, DateTimeKind.Local).AddTicks(6791));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2026, 9, 3, 16, 2, 44, 928, DateTimeKind.Local).AddTicks(6855));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2026, 9, 3, 16, 2, 44, 928, DateTimeKind.Local).AddTicks(6857));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2026, 9, 3, 16, 2, 44, 928, DateTimeKind.Local).AddTicks(6858));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2026, 9, 3, 16, 2, 44, 928, DateTimeKind.Local).AddTicks(6859));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2026, 9, 3, 16, 2, 44, 928, DateTimeKind.Local).AddTicks(6861));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2026, 9, 3, 16, 2, 44, 928, DateTimeKind.Local).AddTicks(6862));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2026, 9, 3, 16, 2, 44, 928, DateTimeKind.Local).AddTicks(6863));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 14,
                column: "CreatedAt",
                value: new DateTime(2026, 9, 3, 16, 2, 44, 928, DateTimeKind.Local).AddTicks(6864));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 15,
                column: "CreatedAt",
                value: new DateTime(2026, 9, 3, 16, 2, 44, 928, DateTimeKind.Local).AddTicks(6873));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 16,
                column: "CreatedAt",
                value: new DateTime(2026, 9, 3, 16, 2, 44, 928, DateTimeKind.Local).AddTicks(6874));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 17,
                column: "CreatedAt",
                value: new DateTime(2026, 9, 3, 16, 2, 44, 928, DateTimeKind.Local).AddTicks(6876));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 18,
                column: "CreatedAt",
                value: new DateTime(2026, 9, 3, 16, 2, 44, 928, DateTimeKind.Local).AddTicks(6877));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 19,
                column: "CreatedAt",
                value: new DateTime(2026, 9, 3, 16, 2, 44, 928, DateTimeKind.Local).AddTicks(6878));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 20,
                column: "CreatedAt",
                value: new DateTime(2026, 9, 3, 16, 2, 44, 928, DateTimeKind.Local).AddTicks(6880));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 21,
                column: "CreatedAt",
                value: new DateTime(2026, 9, 3, 16, 2, 44, 928, DateTimeKind.Local).AddTicks(6881));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 22,
                column: "CreatedAt",
                value: new DateTime(2026, 9, 3, 16, 2, 44, 928, DateTimeKind.Local).AddTicks(6882));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 23,
                column: "CreatedAt",
                value: new DateTime(2026, 9, 3, 16, 2, 44, 928, DateTimeKind.Local).AddTicks(6884));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 24,
                column: "CreatedAt",
                value: new DateTime(2026, 9, 3, 16, 2, 44, 928, DateTimeKind.Local).AddTicks(6885));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 25,
                column: "CreatedAt",
                value: new DateTime(2026, 9, 3, 16, 2, 44, 928, DateTimeKind.Local).AddTicks(6886));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 26,
                column: "CreatedAt",
                value: new DateTime(2026, 9, 3, 16, 2, 44, 928, DateTimeKind.Local).AddTicks(6888));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 27,
                column: "CreatedAt",
                value: new DateTime(2026, 9, 3, 16, 2, 44, 928, DateTimeKind.Local).AddTicks(6889));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 28,
                column: "CreatedAt",
                value: new DateTime(2026, 9, 3, 16, 2, 44, 928, DateTimeKind.Local).AddTicks(6890));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 29,
                column: "CreatedAt",
                value: new DateTime(2026, 9, 3, 16, 2, 44, 928, DateTimeKind.Local).AddTicks(6892));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 30,
                column: "CreatedAt",
                value: new DateTime(2026, 9, 3, 16, 2, 44, 928, DateTimeKind.Local).AddTicks(6927));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 31,
                column: "CreatedAt",
                value: new DateTime(2026, 9, 3, 16, 2, 44, 928, DateTimeKind.Local).AddTicks(6929));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 32,
                column: "CreatedAt",
                value: new DateTime(2026, 9, 3, 16, 2, 44, 928, DateTimeKind.Local).AddTicks(6930));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 33,
                column: "CreatedAt",
                value: new DateTime(2026, 9, 3, 16, 2, 44, 928, DateTimeKind.Local).AddTicks(6931));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 34,
                column: "CreatedAt",
                value: new DateTime(2026, 9, 3, 16, 2, 44, 928, DateTimeKind.Local).AddTicks(6933));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 35,
                column: "CreatedAt",
                value: new DateTime(2026, 9, 3, 16, 2, 44, 928, DateTimeKind.Local).AddTicks(6934));

            migrationBuilder.UpdateData(
                table: "Branches",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 9, 3, 16, 2, 44, 925, DateTimeKind.Local).AddTicks(9424), new DateTime(2026, 9, 3, 16, 2, 44, 925, DateTimeKind.Local).AddTicks(9500) });

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "LastUpdatedAt", "LicensedValidTill" },
                values: new object[] { new DateTime(2026, 9, 3, 16, 2, 44, 925, DateTimeKind.Local).AddTicks(7457), new DateTime(2026, 9, 3, 16, 2, 44, 925, DateTimeKind.Local).AddTicks(7542), new DateTime(2027, 3, 2, 16, 2, 44, 925, DateTimeKind.Local).AddTicks(7788) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2026, 9, 3, 16, 2, 44, 929, DateTimeKind.Local).AddTicks(7030));

            migrationBuilder.UpdateData(
                table: "FinancialYears",
                keyColumn: "Code",
                keyValue: "2026",
                column: "FinStartDate",
                value: new DateTime(2026, 9, 3, 16, 2, 44, 925, DateTimeKind.Local).AddTicks(586));

            migrationBuilder.UpdateData(
                table: "UserAuths",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2026, 9, 3, 16, 2, 44, 929, DateTimeKind.Local).AddTicks(8723));

            migrationBuilder.UpdateData(
                table: "UserRole",
                keyColumn: "RoleID",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 9, 3, 16, 2, 44, 928, DateTimeKind.Local).AddTicks(9197), new DateTime(2026, 9, 3, 16, 2, 44, 928, DateTimeKind.Local).AddTicks(9292) });

            migrationBuilder.UpdateData(
                table: "UserRole",
                keyColumn: "RoleID",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 9, 3, 16, 2, 44, 928, DateTimeKind.Local).AddTicks(9359), new DateTime(2026, 9, 3, 16, 2, 44, 928, DateTimeKind.Local).AddTicks(9359) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AccountStatus",
                table: "JournalEntries");

            migrationBuilder.DropColumn(
                name: "AccountTransactionId",
                table: "JournalEntries");

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2026, 8, 31, 16, 41, 15, 560, DateTimeKind.Local).AddTicks(5447));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2026, 8, 31, 16, 41, 15, 561, DateTimeKind.Local).AddTicks(2252));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2026, 8, 31, 16, 41, 15, 561, DateTimeKind.Local).AddTicks(2274));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2026, 8, 31, 16, 41, 15, 561, DateTimeKind.Local).AddTicks(2280));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2026, 8, 31, 16, 41, 15, 561, DateTimeKind.Local).AddTicks(2284));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2026, 8, 31, 16, 41, 15, 561, DateTimeKind.Local).AddTicks(2289));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2026, 8, 31, 16, 41, 15, 561, DateTimeKind.Local).AddTicks(2507));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2026, 8, 31, 16, 41, 15, 561, DateTimeKind.Local).AddTicks(2512));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2026, 8, 31, 16, 41, 15, 561, DateTimeKind.Local).AddTicks(2517));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2026, 8, 31, 16, 41, 15, 561, DateTimeKind.Local).AddTicks(2521));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2026, 8, 31, 16, 41, 15, 561, DateTimeKind.Local).AddTicks(2526));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2026, 8, 31, 16, 41, 15, 561, DateTimeKind.Local).AddTicks(2530));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2026, 8, 31, 16, 41, 15, 561, DateTimeKind.Local).AddTicks(2561));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 14,
                column: "CreatedAt",
                value: new DateTime(2026, 8, 31, 16, 41, 15, 561, DateTimeKind.Local).AddTicks(2565));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 15,
                column: "CreatedAt",
                value: new DateTime(2026, 8, 31, 16, 41, 15, 561, DateTimeKind.Local).AddTicks(2570));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 16,
                column: "CreatedAt",
                value: new DateTime(2026, 8, 31, 16, 41, 15, 561, DateTimeKind.Local).AddTicks(2574));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 17,
                column: "CreatedAt",
                value: new DateTime(2026, 8, 31, 16, 41, 15, 561, DateTimeKind.Local).AddTicks(2578));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 18,
                column: "CreatedAt",
                value: new DateTime(2026, 8, 31, 16, 41, 15, 561, DateTimeKind.Local).AddTicks(2583));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 19,
                column: "CreatedAt",
                value: new DateTime(2026, 8, 31, 16, 41, 15, 561, DateTimeKind.Local).AddTicks(2588));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 20,
                column: "CreatedAt",
                value: new DateTime(2026, 8, 31, 16, 41, 15, 561, DateTimeKind.Local).AddTicks(2592));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 21,
                column: "CreatedAt",
                value: new DateTime(2026, 8, 31, 16, 41, 15, 561, DateTimeKind.Local).AddTicks(2597));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 22,
                column: "CreatedAt",
                value: new DateTime(2026, 8, 31, 16, 41, 15, 561, DateTimeKind.Local).AddTicks(2601));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 23,
                column: "CreatedAt",
                value: new DateTime(2026, 8, 31, 16, 41, 15, 561, DateTimeKind.Local).AddTicks(2647));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 24,
                column: "CreatedAt",
                value: new DateTime(2026, 8, 31, 16, 41, 15, 561, DateTimeKind.Local).AddTicks(2652));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 25,
                column: "CreatedAt",
                value: new DateTime(2026, 8, 31, 16, 41, 15, 561, DateTimeKind.Local).AddTicks(2657));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 26,
                column: "CreatedAt",
                value: new DateTime(2026, 8, 31, 16, 41, 15, 561, DateTimeKind.Local).AddTicks(2661));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 27,
                column: "CreatedAt",
                value: new DateTime(2026, 8, 31, 16, 41, 15, 561, DateTimeKind.Local).AddTicks(2666));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 28,
                column: "CreatedAt",
                value: new DateTime(2026, 8, 31, 16, 41, 15, 561, DateTimeKind.Local).AddTicks(2670));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 29,
                column: "CreatedAt",
                value: new DateTime(2026, 8, 31, 16, 41, 15, 561, DateTimeKind.Local).AddTicks(2675));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 30,
                column: "CreatedAt",
                value: new DateTime(2026, 8, 31, 16, 41, 15, 561, DateTimeKind.Local).AddTicks(2679));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 31,
                column: "CreatedAt",
                value: new DateTime(2026, 8, 31, 16, 41, 15, 561, DateTimeKind.Local).AddTicks(2684));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 32,
                column: "CreatedAt",
                value: new DateTime(2026, 8, 31, 16, 41, 15, 561, DateTimeKind.Local).AddTicks(2688));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 33,
                column: "CreatedAt",
                value: new DateTime(2026, 8, 31, 16, 41, 15, 561, DateTimeKind.Local).AddTicks(2693));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 34,
                column: "CreatedAt",
                value: new DateTime(2026, 8, 31, 16, 41, 15, 561, DateTimeKind.Local).AddTicks(2697));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 35,
                column: "CreatedAt",
                value: new DateTime(2026, 8, 31, 16, 41, 15, 561, DateTimeKind.Local).AddTicks(2702));

            migrationBuilder.UpdateData(
                table: "Branches",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 8, 31, 16, 41, 15, 556, DateTimeKind.Local).AddTicks(1804), new DateTime(2026, 8, 31, 16, 41, 15, 556, DateTimeKind.Local).AddTicks(2056) });

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "LastUpdatedAt", "LicensedValidTill" },
                values: new object[] { new DateTime(2026, 8, 31, 16, 41, 15, 555, DateTimeKind.Local).AddTicks(3813), new DateTime(2026, 8, 31, 16, 41, 15, 555, DateTimeKind.Local).AddTicks(4094), new DateTime(2027, 2, 27, 16, 41, 15, 555, DateTimeKind.Local).AddTicks(4805) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2026, 8, 31, 16, 41, 15, 564, DateTimeKind.Local).AddTicks(4161));

            migrationBuilder.UpdateData(
                table: "FinancialYears",
                keyColumn: "Code",
                keyValue: "2026",
                column: "FinStartDate",
                value: new DateTime(2026, 8, 31, 16, 41, 15, 552, DateTimeKind.Local).AddTicks(4451));

            migrationBuilder.UpdateData(
                table: "UserAuths",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2026, 8, 31, 16, 41, 15, 565, DateTimeKind.Local).AddTicks(675));

            migrationBuilder.UpdateData(
                table: "UserRole",
                keyColumn: "RoleID",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 8, 31, 16, 41, 15, 561, DateTimeKind.Local).AddTicks(8674), new DateTime(2026, 8, 31, 16, 41, 15, 561, DateTimeKind.Local).AddTicks(8987) });

            migrationBuilder.UpdateData(
                table: "UserRole",
                keyColumn: "RoleID",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 8, 31, 16, 41, 15, 561, DateTimeKind.Local).AddTicks(9212), new DateTime(2026, 8, 31, 16, 41, 15, 561, DateTimeKind.Local).AddTicks(9214) });
        }
    }
}
