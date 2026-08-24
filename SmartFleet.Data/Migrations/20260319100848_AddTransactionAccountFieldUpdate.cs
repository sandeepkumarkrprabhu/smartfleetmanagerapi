using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SmartFleet.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddTransactionAccountFieldUpdate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "DocumentRefId",
                table: "AccountTransactions",
                type: "int",
                nullable: true);

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DocumentRefId",
                table: "AccountTransactions");

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2026, 3, 19, 13, 44, 5, 126, DateTimeKind.Local).AddTicks(9595));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2026, 3, 19, 13, 44, 5, 127, DateTimeKind.Local).AddTicks(284));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2026, 3, 19, 13, 44, 5, 127, DateTimeKind.Local).AddTicks(286));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2026, 3, 19, 13, 44, 5, 127, DateTimeKind.Local).AddTicks(288));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2026, 3, 19, 13, 44, 5, 127, DateTimeKind.Local).AddTicks(289));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2026, 3, 19, 13, 44, 5, 127, DateTimeKind.Local).AddTicks(291));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2026, 3, 19, 13, 44, 5, 127, DateTimeKind.Local).AddTicks(353));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2026, 3, 19, 13, 44, 5, 127, DateTimeKind.Local).AddTicks(355));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2026, 3, 19, 13, 44, 5, 127, DateTimeKind.Local).AddTicks(357));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2026, 3, 19, 13, 44, 5, 127, DateTimeKind.Local).AddTicks(365));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2026, 3, 19, 13, 44, 5, 127, DateTimeKind.Local).AddTicks(366));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2026, 3, 19, 13, 44, 5, 127, DateTimeKind.Local).AddTicks(367));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2026, 3, 19, 13, 44, 5, 127, DateTimeKind.Local).AddTicks(369));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 14,
                column: "CreatedAt",
                value: new DateTime(2026, 3, 19, 13, 44, 5, 127, DateTimeKind.Local).AddTicks(370));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 15,
                column: "CreatedAt",
                value: new DateTime(2026, 3, 19, 13, 44, 5, 127, DateTimeKind.Local).AddTicks(371));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 16,
                column: "CreatedAt",
                value: new DateTime(2026, 3, 19, 13, 44, 5, 127, DateTimeKind.Local).AddTicks(372));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 17,
                column: "CreatedAt",
                value: new DateTime(2026, 3, 19, 13, 44, 5, 127, DateTimeKind.Local).AddTicks(374));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 18,
                column: "CreatedAt",
                value: new DateTime(2026, 3, 19, 13, 44, 5, 127, DateTimeKind.Local).AddTicks(375));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 19,
                column: "CreatedAt",
                value: new DateTime(2026, 3, 19, 13, 44, 5, 127, DateTimeKind.Local).AddTicks(410));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 20,
                column: "CreatedAt",
                value: new DateTime(2026, 3, 19, 13, 44, 5, 127, DateTimeKind.Local).AddTicks(411));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 21,
                column: "CreatedAt",
                value: new DateTime(2026, 3, 19, 13, 44, 5, 127, DateTimeKind.Local).AddTicks(413));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 22,
                column: "CreatedAt",
                value: new DateTime(2026, 3, 19, 13, 44, 5, 127, DateTimeKind.Local).AddTicks(414));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 23,
                column: "CreatedAt",
                value: new DateTime(2026, 3, 19, 13, 44, 5, 127, DateTimeKind.Local).AddTicks(415));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 24,
                column: "CreatedAt",
                value: new DateTime(2026, 3, 19, 13, 44, 5, 127, DateTimeKind.Local).AddTicks(417));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 25,
                column: "CreatedAt",
                value: new DateTime(2026, 3, 19, 13, 44, 5, 127, DateTimeKind.Local).AddTicks(418));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 26,
                column: "CreatedAt",
                value: new DateTime(2026, 3, 19, 13, 44, 5, 127, DateTimeKind.Local).AddTicks(419));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 27,
                column: "CreatedAt",
                value: new DateTime(2026, 3, 19, 13, 44, 5, 127, DateTimeKind.Local).AddTicks(421));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 28,
                column: "CreatedAt",
                value: new DateTime(2026, 3, 19, 13, 44, 5, 127, DateTimeKind.Local).AddTicks(422));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 29,
                column: "CreatedAt",
                value: new DateTime(2026, 3, 19, 13, 44, 5, 127, DateTimeKind.Local).AddTicks(423));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 30,
                column: "CreatedAt",
                value: new DateTime(2026, 3, 19, 13, 44, 5, 127, DateTimeKind.Local).AddTicks(425));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 31,
                column: "CreatedAt",
                value: new DateTime(2026, 3, 19, 13, 44, 5, 127, DateTimeKind.Local).AddTicks(426));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 32,
                column: "CreatedAt",
                value: new DateTime(2026, 3, 19, 13, 44, 5, 127, DateTimeKind.Local).AddTicks(427));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 33,
                column: "CreatedAt",
                value: new DateTime(2026, 3, 19, 13, 44, 5, 127, DateTimeKind.Local).AddTicks(428));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 34,
                column: "CreatedAt",
                value: new DateTime(2026, 3, 19, 13, 44, 5, 127, DateTimeKind.Local).AddTicks(430));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 35,
                column: "CreatedAt",
                value: new DateTime(2026, 3, 19, 13, 44, 5, 127, DateTimeKind.Local).AddTicks(431));

            migrationBuilder.UpdateData(
                table: "Branches",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 3, 19, 13, 44, 5, 125, DateTimeKind.Local).AddTicks(4549), new DateTime(2026, 3, 19, 13, 44, 5, 125, DateTimeKind.Local).AddTicks(4628) });

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "LastUpdatedAt", "LicensedValidTill" },
                values: new object[] { new DateTime(2026, 3, 19, 13, 44, 5, 125, DateTimeKind.Local).AddTicks(2287), new DateTime(2026, 3, 19, 13, 44, 5, 125, DateTimeKind.Local).AddTicks(2371), new DateTime(2026, 9, 15, 13, 44, 5, 125, DateTimeKind.Local).AddTicks(2577) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2026, 3, 19, 13, 44, 5, 128, DateTimeKind.Local).AddTicks(2650));

            migrationBuilder.UpdateData(
                table: "FinancialYears",
                keyColumn: "Code",
                keyValue: "2026",
                column: "FinStartDate",
                value: new DateTime(2026, 3, 19, 13, 44, 5, 124, DateTimeKind.Local).AddTicks(4138));

            migrationBuilder.UpdateData(
                table: "UserAuths",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2026, 3, 19, 13, 44, 5, 128, DateTimeKind.Local).AddTicks(4553));

            migrationBuilder.UpdateData(
                table: "UserRole",
                keyColumn: "RoleID",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 3, 19, 13, 44, 5, 127, DateTimeKind.Local).AddTicks(1900), new DateTime(2026, 3, 19, 13, 44, 5, 127, DateTimeKind.Local).AddTicks(2011) });

            migrationBuilder.UpdateData(
                table: "UserRole",
                keyColumn: "RoleID",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 3, 19, 13, 44, 5, 127, DateTimeKind.Local).AddTicks(2083), new DateTime(2026, 3, 19, 13, 44, 5, 127, DateTimeKind.Local).AddTicks(2083) });
        }
    }
}
