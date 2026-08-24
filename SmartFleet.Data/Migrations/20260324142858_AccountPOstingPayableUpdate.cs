using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SmartFleet.Data.Migrations
{
    /// <inheritdoc />
    public partial class AccountPOstingPayableUpdate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsTripExpensePaidAlready",
                table: "accountPostingSettings",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2026, 3, 24, 19, 58, 55, 279, DateTimeKind.Local).AddTicks(5464));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2026, 3, 24, 19, 58, 55, 279, DateTimeKind.Local).AddTicks(6186));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2026, 3, 24, 19, 58, 55, 279, DateTimeKind.Local).AddTicks(6188));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2026, 3, 24, 19, 58, 55, 279, DateTimeKind.Local).AddTicks(6190));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2026, 3, 24, 19, 58, 55, 279, DateTimeKind.Local).AddTicks(6191));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2026, 3, 24, 19, 58, 55, 279, DateTimeKind.Local).AddTicks(6193));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2026, 3, 24, 19, 58, 55, 279, DateTimeKind.Local).AddTicks(6266));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2026, 3, 24, 19, 58, 55, 279, DateTimeKind.Local).AddTicks(6268));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2026, 3, 24, 19, 58, 55, 279, DateTimeKind.Local).AddTicks(6269));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2026, 3, 24, 19, 58, 55, 279, DateTimeKind.Local).AddTicks(6270));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2026, 3, 24, 19, 58, 55, 279, DateTimeKind.Local).AddTicks(6272));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2026, 3, 24, 19, 58, 55, 279, DateTimeKind.Local).AddTicks(6273));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2026, 3, 24, 19, 58, 55, 279, DateTimeKind.Local).AddTicks(6274));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 14,
                column: "CreatedAt",
                value: new DateTime(2026, 3, 24, 19, 58, 55, 279, DateTimeKind.Local).AddTicks(6275));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 15,
                column: "CreatedAt",
                value: new DateTime(2026, 3, 24, 19, 58, 55, 279, DateTimeKind.Local).AddTicks(6277));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 16,
                column: "CreatedAt",
                value: new DateTime(2026, 3, 24, 19, 58, 55, 279, DateTimeKind.Local).AddTicks(6278));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 17,
                column: "CreatedAt",
                value: new DateTime(2026, 3, 24, 19, 58, 55, 279, DateTimeKind.Local).AddTicks(6279));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 18,
                column: "CreatedAt",
                value: new DateTime(2026, 3, 24, 19, 58, 55, 279, DateTimeKind.Local).AddTicks(6280));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 19,
                column: "CreatedAt",
                value: new DateTime(2026, 3, 24, 19, 58, 55, 279, DateTimeKind.Local).AddTicks(6282));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 20,
                column: "CreatedAt",
                value: new DateTime(2026, 3, 24, 19, 58, 55, 279, DateTimeKind.Local).AddTicks(6283));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 21,
                column: "CreatedAt",
                value: new DateTime(2026, 3, 24, 19, 58, 55, 279, DateTimeKind.Local).AddTicks(6290));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 22,
                column: "CreatedAt",
                value: new DateTime(2026, 3, 24, 19, 58, 55, 279, DateTimeKind.Local).AddTicks(6292));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 23,
                column: "CreatedAt",
                value: new DateTime(2026, 3, 24, 19, 58, 55, 279, DateTimeKind.Local).AddTicks(6293));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 24,
                column: "CreatedAt",
                value: new DateTime(2026, 3, 24, 19, 58, 55, 279, DateTimeKind.Local).AddTicks(6294));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 25,
                column: "CreatedAt",
                value: new DateTime(2026, 3, 24, 19, 58, 55, 279, DateTimeKind.Local).AddTicks(6296));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 26,
                column: "CreatedAt",
                value: new DateTime(2026, 3, 24, 19, 58, 55, 279, DateTimeKind.Local).AddTicks(6297));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 27,
                column: "CreatedAt",
                value: new DateTime(2026, 3, 24, 19, 58, 55, 279, DateTimeKind.Local).AddTicks(6298));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 28,
                column: "CreatedAt",
                value: new DateTime(2026, 3, 24, 19, 58, 55, 279, DateTimeKind.Local).AddTicks(6300));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 29,
                column: "CreatedAt",
                value: new DateTime(2026, 3, 24, 19, 58, 55, 279, DateTimeKind.Local).AddTicks(6301));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 30,
                column: "CreatedAt",
                value: new DateTime(2026, 3, 24, 19, 58, 55, 279, DateTimeKind.Local).AddTicks(6302));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 31,
                column: "CreatedAt",
                value: new DateTime(2026, 3, 24, 19, 58, 55, 279, DateTimeKind.Local).AddTicks(6304));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 32,
                column: "CreatedAt",
                value: new DateTime(2026, 3, 24, 19, 58, 55, 279, DateTimeKind.Local).AddTicks(6345));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 33,
                column: "CreatedAt",
                value: new DateTime(2026, 3, 24, 19, 58, 55, 279, DateTimeKind.Local).AddTicks(6346));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 34,
                column: "CreatedAt",
                value: new DateTime(2026, 3, 24, 19, 58, 55, 279, DateTimeKind.Local).AddTicks(6348));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 35,
                column: "CreatedAt",
                value: new DateTime(2026, 3, 24, 19, 58, 55, 279, DateTimeKind.Local).AddTicks(6349));

            migrationBuilder.UpdateData(
                table: "Branches",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 3, 24, 19, 58, 55, 277, DateTimeKind.Local).AddTicks(8751), new DateTime(2026, 3, 24, 19, 58, 55, 277, DateTimeKind.Local).AddTicks(8829) });

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "LastUpdatedAt", "LicensedValidTill" },
                values: new object[] { new DateTime(2026, 3, 24, 19, 58, 55, 277, DateTimeKind.Local).AddTicks(6485), new DateTime(2026, 3, 24, 19, 58, 55, 277, DateTimeKind.Local).AddTicks(6572), new DateTime(2026, 9, 20, 19, 58, 55, 277, DateTimeKind.Local).AddTicks(6794) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2026, 3, 24, 19, 58, 55, 280, DateTimeKind.Local).AddTicks(3994));

            migrationBuilder.UpdateData(
                table: "FinancialYears",
                keyColumn: "Code",
                keyValue: "2026",
                column: "FinStartDate",
                value: new DateTime(2026, 3, 24, 19, 58, 55, 276, DateTimeKind.Local).AddTicks(8037));

            migrationBuilder.UpdateData(
                table: "UserAuths",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2026, 3, 24, 19, 58, 55, 280, DateTimeKind.Local).AddTicks(5460));

            migrationBuilder.UpdateData(
                table: "UserRole",
                keyColumn: "RoleID",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 3, 24, 19, 58, 55, 279, DateTimeKind.Local).AddTicks(7926), new DateTime(2026, 3, 24, 19, 58, 55, 279, DateTimeKind.Local).AddTicks(8044) });

            migrationBuilder.UpdateData(
                table: "UserRole",
                keyColumn: "RoleID",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 3, 24, 19, 58, 55, 279, DateTimeKind.Local).AddTicks(8116), new DateTime(2026, 3, 24, 19, 58, 55, 279, DateTimeKind.Local).AddTicks(8117) });

            migrationBuilder.UpdateData(
                table: "accountPostingSettings",
                keyColumn: "Id",
                keyValue: 16,
                column: "IsTripExpensePaidAlready",
                value: false);

            migrationBuilder.UpdateData(
                table: "accountPostingSettings",
                keyColumn: "Id",
                keyValue: 17,
                column: "IsTripExpensePaidAlready",
                value: false);

            migrationBuilder.UpdateData(
                table: "accountPostingSettings",
                keyColumn: "Id",
                keyValue: 18,
                column: "IsTripExpensePaidAlready",
                value: false);

            migrationBuilder.UpdateData(
                table: "accountPostingSettings",
                keyColumn: "Id",
                keyValue: 19,
                column: "IsTripExpensePaidAlready",
                value: false);

            migrationBuilder.UpdateData(
                table: "accountPostingSettings",
                keyColumn: "Id",
                keyValue: 20,
                column: "IsTripExpensePaidAlready",
                value: false);

            migrationBuilder.UpdateData(
                table: "accountPostingSettings",
                keyColumn: "Id",
                keyValue: 21,
                column: "IsTripExpensePaidAlready",
                value: false);

            migrationBuilder.UpdateData(
                table: "accountPostingSettings",
                keyColumn: "Id",
                keyValue: 22,
                column: "IsTripExpensePaidAlready",
                value: false);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsTripExpensePaidAlready",
                table: "accountPostingSettings");

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
    }
}
