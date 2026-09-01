using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SmartFleet.Data.Migrations
{
    /// <inheritdoc />
    public partial class PartyManageSettingsAccountModeUpdate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "AccountMode",
                table: "partyTypeSettings",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2026, 8, 31, 8, 18, 42, 107, DateTimeKind.Local).AddTicks(996));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2026, 8, 31, 8, 18, 42, 107, DateTimeKind.Local).AddTicks(2480));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2026, 8, 31, 8, 18, 42, 107, DateTimeKind.Local).AddTicks(2486));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2026, 8, 31, 8, 18, 42, 107, DateTimeKind.Local).AddTicks(2488));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2026, 8, 31, 8, 18, 42, 107, DateTimeKind.Local).AddTicks(2490));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2026, 8, 31, 8, 18, 42, 107, DateTimeKind.Local).AddTicks(2492));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2026, 8, 31, 8, 18, 42, 107, DateTimeKind.Local).AddTicks(2616));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2026, 8, 31, 8, 18, 42, 107, DateTimeKind.Local).AddTicks(2619));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2026, 8, 31, 8, 18, 42, 107, DateTimeKind.Local).AddTicks(2621));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2026, 8, 31, 8, 18, 42, 107, DateTimeKind.Local).AddTicks(2623));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2026, 8, 31, 8, 18, 42, 107, DateTimeKind.Local).AddTicks(2625));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2026, 8, 31, 8, 18, 42, 107, DateTimeKind.Local).AddTicks(2627));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2026, 8, 31, 8, 18, 42, 107, DateTimeKind.Local).AddTicks(2629));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 14,
                column: "CreatedAt",
                value: new DateTime(2026, 8, 31, 8, 18, 42, 107, DateTimeKind.Local).AddTicks(2631));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 15,
                column: "CreatedAt",
                value: new DateTime(2026, 8, 31, 8, 18, 42, 107, DateTimeKind.Local).AddTicks(2654));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 16,
                column: "CreatedAt",
                value: new DateTime(2026, 8, 31, 8, 18, 42, 107, DateTimeKind.Local).AddTicks(2656));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 17,
                column: "CreatedAt",
                value: new DateTime(2026, 8, 31, 8, 18, 42, 107, DateTimeKind.Local).AddTicks(2658));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 18,
                column: "CreatedAt",
                value: new DateTime(2026, 8, 31, 8, 18, 42, 107, DateTimeKind.Local).AddTicks(2660));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 19,
                column: "CreatedAt",
                value: new DateTime(2026, 8, 31, 8, 18, 42, 107, DateTimeKind.Local).AddTicks(2662));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 20,
                column: "CreatedAt",
                value: new DateTime(2026, 8, 31, 8, 18, 42, 107, DateTimeKind.Local).AddTicks(2664));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 21,
                column: "CreatedAt",
                value: new DateTime(2026, 8, 31, 8, 18, 42, 107, DateTimeKind.Local).AddTicks(2666));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 22,
                column: "CreatedAt",
                value: new DateTime(2026, 8, 31, 8, 18, 42, 107, DateTimeKind.Local).AddTicks(2668));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 23,
                column: "CreatedAt",
                value: new DateTime(2026, 8, 31, 8, 18, 42, 107, DateTimeKind.Local).AddTicks(2669));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 24,
                column: "CreatedAt",
                value: new DateTime(2026, 8, 31, 8, 18, 42, 107, DateTimeKind.Local).AddTicks(2671));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 25,
                column: "CreatedAt",
                value: new DateTime(2026, 8, 31, 8, 18, 42, 107, DateTimeKind.Local).AddTicks(2673));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 26,
                column: "CreatedAt",
                value: new DateTime(2026, 8, 31, 8, 18, 42, 107, DateTimeKind.Local).AddTicks(2730));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 27,
                column: "CreatedAt",
                value: new DateTime(2026, 8, 31, 8, 18, 42, 107, DateTimeKind.Local).AddTicks(2733));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 28,
                column: "CreatedAt",
                value: new DateTime(2026, 8, 31, 8, 18, 42, 107, DateTimeKind.Local).AddTicks(2736));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 29,
                column: "CreatedAt",
                value: new DateTime(2026, 8, 31, 8, 18, 42, 107, DateTimeKind.Local).AddTicks(2738));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 30,
                column: "CreatedAt",
                value: new DateTime(2026, 8, 31, 8, 18, 42, 107, DateTimeKind.Local).AddTicks(2740));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 31,
                column: "CreatedAt",
                value: new DateTime(2026, 8, 31, 8, 18, 42, 107, DateTimeKind.Local).AddTicks(2742));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 32,
                column: "CreatedAt",
                value: new DateTime(2026, 8, 31, 8, 18, 42, 107, DateTimeKind.Local).AddTicks(2744));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 33,
                column: "CreatedAt",
                value: new DateTime(2026, 8, 31, 8, 18, 42, 107, DateTimeKind.Local).AddTicks(2746));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 34,
                column: "CreatedAt",
                value: new DateTime(2026, 8, 31, 8, 18, 42, 107, DateTimeKind.Local).AddTicks(2748));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 35,
                column: "CreatedAt",
                value: new DateTime(2026, 8, 31, 8, 18, 42, 107, DateTimeKind.Local).AddTicks(2749));

            migrationBuilder.UpdateData(
                table: "Branches",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 8, 31, 8, 18, 42, 104, DateTimeKind.Local).AddTicks(1760), new DateTime(2026, 8, 31, 8, 18, 42, 104, DateTimeKind.Local).AddTicks(1899) });

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "LastUpdatedAt", "LicensedValidTill" },
                values: new object[] { new DateTime(2026, 8, 31, 8, 18, 42, 103, DateTimeKind.Local).AddTicks(8052), new DateTime(2026, 8, 31, 8, 18, 42, 103, DateTimeKind.Local).AddTicks(8194), new DateTime(2027, 2, 27, 8, 18, 42, 103, DateTimeKind.Local).AddTicks(8622) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2026, 8, 31, 8, 18, 42, 108, DateTimeKind.Local).AddTicks(9785));

            migrationBuilder.UpdateData(
                table: "FinancialYears",
                keyColumn: "Code",
                keyValue: "2026",
                column: "FinStartDate",
                value: new DateTime(2026, 8, 31, 8, 18, 42, 102, DateTimeKind.Local).AddTicks(8634));

            migrationBuilder.UpdateData(
                table: "UserAuths",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2026, 8, 31, 8, 18, 42, 109, DateTimeKind.Local).AddTicks(3330));

            migrationBuilder.UpdateData(
                table: "UserRole",
                keyColumn: "RoleID",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 8, 31, 8, 18, 42, 107, DateTimeKind.Local).AddTicks(6098), new DateTime(2026, 8, 31, 8, 18, 42, 107, DateTimeKind.Local).AddTicks(6285) });

            migrationBuilder.UpdateData(
                table: "UserRole",
                keyColumn: "RoleID",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 8, 31, 8, 18, 42, 107, DateTimeKind.Local).AddTicks(6418), new DateTime(2026, 8, 31, 8, 18, 42, 107, DateTimeKind.Local).AddTicks(6419) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AccountMode",
                table: "partyTypeSettings");

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2026, 8, 31, 8, 11, 14, 313, DateTimeKind.Local).AddTicks(715));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2026, 8, 31, 8, 11, 14, 313, DateTimeKind.Local).AddTicks(1532));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2026, 8, 31, 8, 11, 14, 313, DateTimeKind.Local).AddTicks(1534));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2026, 8, 31, 8, 11, 14, 313, DateTimeKind.Local).AddTicks(1546));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2026, 8, 31, 8, 11, 14, 313, DateTimeKind.Local).AddTicks(1547));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2026, 8, 31, 8, 11, 14, 313, DateTimeKind.Local).AddTicks(1549));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2026, 8, 31, 8, 11, 14, 313, DateTimeKind.Local).AddTicks(1620));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2026, 8, 31, 8, 11, 14, 313, DateTimeKind.Local).AddTicks(1622));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2026, 8, 31, 8, 11, 14, 313, DateTimeKind.Local).AddTicks(1624));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2026, 8, 31, 8, 11, 14, 313, DateTimeKind.Local).AddTicks(1625));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2026, 8, 31, 8, 11, 14, 313, DateTimeKind.Local).AddTicks(1626));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2026, 8, 31, 8, 11, 14, 313, DateTimeKind.Local).AddTicks(1628));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2026, 8, 31, 8, 11, 14, 313, DateTimeKind.Local).AddTicks(1685));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 14,
                column: "CreatedAt",
                value: new DateTime(2026, 8, 31, 8, 11, 14, 313, DateTimeKind.Local).AddTicks(1687));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 15,
                column: "CreatedAt",
                value: new DateTime(2026, 8, 31, 8, 11, 14, 313, DateTimeKind.Local).AddTicks(1688));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 16,
                column: "CreatedAt",
                value: new DateTime(2026, 8, 31, 8, 11, 14, 313, DateTimeKind.Local).AddTicks(1689));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 17,
                column: "CreatedAt",
                value: new DateTime(2026, 8, 31, 8, 11, 14, 313, DateTimeKind.Local).AddTicks(1691));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 18,
                column: "CreatedAt",
                value: new DateTime(2026, 8, 31, 8, 11, 14, 313, DateTimeKind.Local).AddTicks(1701));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 19,
                column: "CreatedAt",
                value: new DateTime(2026, 8, 31, 8, 11, 14, 313, DateTimeKind.Local).AddTicks(1702));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 20,
                column: "CreatedAt",
                value: new DateTime(2026, 8, 31, 8, 11, 14, 313, DateTimeKind.Local).AddTicks(1703));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 21,
                column: "CreatedAt",
                value: new DateTime(2026, 8, 31, 8, 11, 14, 313, DateTimeKind.Local).AddTicks(1705));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 22,
                column: "CreatedAt",
                value: new DateTime(2026, 8, 31, 8, 11, 14, 313, DateTimeKind.Local).AddTicks(1706));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 23,
                column: "CreatedAt",
                value: new DateTime(2026, 8, 31, 8, 11, 14, 313, DateTimeKind.Local).AddTicks(1708));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 24,
                column: "CreatedAt",
                value: new DateTime(2026, 8, 31, 8, 11, 14, 313, DateTimeKind.Local).AddTicks(1709));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 25,
                column: "CreatedAt",
                value: new DateTime(2026, 8, 31, 8, 11, 14, 313, DateTimeKind.Local).AddTicks(1711));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 26,
                column: "CreatedAt",
                value: new DateTime(2026, 8, 31, 8, 11, 14, 313, DateTimeKind.Local).AddTicks(1712));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 27,
                column: "CreatedAt",
                value: new DateTime(2026, 8, 31, 8, 11, 14, 313, DateTimeKind.Local).AddTicks(1713));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 28,
                column: "CreatedAt",
                value: new DateTime(2026, 8, 31, 8, 11, 14, 313, DateTimeKind.Local).AddTicks(1715));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 29,
                column: "CreatedAt",
                value: new DateTime(2026, 8, 31, 8, 11, 14, 313, DateTimeKind.Local).AddTicks(1716));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 30,
                column: "CreatedAt",
                value: new DateTime(2026, 8, 31, 8, 11, 14, 313, DateTimeKind.Local).AddTicks(1718));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 31,
                column: "CreatedAt",
                value: new DateTime(2026, 8, 31, 8, 11, 14, 313, DateTimeKind.Local).AddTicks(1719));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 32,
                column: "CreatedAt",
                value: new DateTime(2026, 8, 31, 8, 11, 14, 313, DateTimeKind.Local).AddTicks(1721));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 33,
                column: "CreatedAt",
                value: new DateTime(2026, 8, 31, 8, 11, 14, 313, DateTimeKind.Local).AddTicks(1722));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 34,
                column: "CreatedAt",
                value: new DateTime(2026, 8, 31, 8, 11, 14, 313, DateTimeKind.Local).AddTicks(1723));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 35,
                column: "CreatedAt",
                value: new DateTime(2026, 8, 31, 8, 11, 14, 313, DateTimeKind.Local).AddTicks(1725));

            migrationBuilder.UpdateData(
                table: "Branches",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 8, 31, 8, 11, 14, 311, DateTimeKind.Local).AddTicks(2998), new DateTime(2026, 8, 31, 8, 11, 14, 311, DateTimeKind.Local).AddTicks(3105) });

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "LastUpdatedAt", "LicensedValidTill" },
                values: new object[] { new DateTime(2026, 8, 31, 8, 11, 14, 311, DateTimeKind.Local).AddTicks(417), new DateTime(2026, 8, 31, 8, 11, 14, 311, DateTimeKind.Local).AddTicks(523), new DateTime(2027, 2, 27, 8, 11, 14, 311, DateTimeKind.Local).AddTicks(759) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2026, 8, 31, 8, 11, 14, 314, DateTimeKind.Local).AddTicks(401));

            migrationBuilder.UpdateData(
                table: "FinancialYears",
                keyColumn: "Code",
                keyValue: "2026",
                column: "FinStartDate",
                value: new DateTime(2026, 8, 31, 8, 11, 14, 309, DateTimeKind.Local).AddTicks(8847));

            migrationBuilder.UpdateData(
                table: "UserAuths",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2026, 8, 31, 8, 11, 14, 314, DateTimeKind.Local).AddTicks(2320));

            migrationBuilder.UpdateData(
                table: "UserRole",
                keyColumn: "RoleID",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 8, 31, 8, 11, 14, 313, DateTimeKind.Local).AddTicks(3608), new DateTime(2026, 8, 31, 8, 11, 14, 313, DateTimeKind.Local).AddTicks(3708) });

            migrationBuilder.UpdateData(
                table: "UserRole",
                keyColumn: "RoleID",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 8, 31, 8, 11, 14, 313, DateTimeKind.Local).AddTicks(3785), new DateTime(2026, 8, 31, 8, 11, 14, 313, DateTimeKind.Local).AddTicks(3786) });
        }
    }
}
