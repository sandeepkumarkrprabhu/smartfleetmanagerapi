using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SmartFleet.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddTripAccountFieldUpdate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "TransactionReferenceId",
                table: "TripTransaction",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "TransactionStatus",
                table: "TripTransaction",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "TransactionReferenceId",
                table: "TripTransaction");

            migrationBuilder.DropColumn(
                name: "TransactionStatus",
                table: "TripTransaction");

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2026, 3, 19, 10, 45, 56, 290, DateTimeKind.Local).AddTicks(360));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2026, 3, 19, 10, 45, 56, 290, DateTimeKind.Local).AddTicks(1226));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2026, 3, 19, 10, 45, 56, 290, DateTimeKind.Local).AddTicks(1229));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2026, 3, 19, 10, 45, 56, 290, DateTimeKind.Local).AddTicks(1231));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2026, 3, 19, 10, 45, 56, 290, DateTimeKind.Local).AddTicks(1232));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2026, 3, 19, 10, 45, 56, 290, DateTimeKind.Local).AddTicks(1234));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2026, 3, 19, 10, 45, 56, 290, DateTimeKind.Local).AddTicks(1341));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2026, 3, 19, 10, 45, 56, 290, DateTimeKind.Local).AddTicks(1343));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2026, 3, 19, 10, 45, 56, 290, DateTimeKind.Local).AddTicks(1345));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2026, 3, 19, 10, 45, 56, 290, DateTimeKind.Local).AddTicks(1346));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2026, 3, 19, 10, 45, 56, 290, DateTimeKind.Local).AddTicks(1356));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2026, 3, 19, 10, 45, 56, 290, DateTimeKind.Local).AddTicks(1358));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2026, 3, 19, 10, 45, 56, 290, DateTimeKind.Local).AddTicks(1359));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 14,
                column: "CreatedAt",
                value: new DateTime(2026, 3, 19, 10, 45, 56, 290, DateTimeKind.Local).AddTicks(1360));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 15,
                column: "CreatedAt",
                value: new DateTime(2026, 3, 19, 10, 45, 56, 290, DateTimeKind.Local).AddTicks(1361));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 16,
                column: "CreatedAt",
                value: new DateTime(2026, 3, 19, 10, 45, 56, 290, DateTimeKind.Local).AddTicks(1363));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 17,
                column: "CreatedAt",
                value: new DateTime(2026, 3, 19, 10, 45, 56, 290, DateTimeKind.Local).AddTicks(1364));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 18,
                column: "CreatedAt",
                value: new DateTime(2026, 3, 19, 10, 45, 56, 290, DateTimeKind.Local).AddTicks(1366));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 19,
                column: "CreatedAt",
                value: new DateTime(2026, 3, 19, 10, 45, 56, 290, DateTimeKind.Local).AddTicks(1367));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 20,
                column: "CreatedAt",
                value: new DateTime(2026, 3, 19, 10, 45, 56, 290, DateTimeKind.Local).AddTicks(1369));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 21,
                column: "CreatedAt",
                value: new DateTime(2026, 3, 19, 10, 45, 56, 290, DateTimeKind.Local).AddTicks(1370));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 22,
                column: "CreatedAt",
                value: new DateTime(2026, 3, 19, 10, 45, 56, 290, DateTimeKind.Local).AddTicks(1371));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 23,
                column: "CreatedAt",
                value: new DateTime(2026, 3, 19, 10, 45, 56, 290, DateTimeKind.Local).AddTicks(1373));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 24,
                column: "CreatedAt",
                value: new DateTime(2026, 3, 19, 10, 45, 56, 290, DateTimeKind.Local).AddTicks(1374));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 25,
                column: "CreatedAt",
                value: new DateTime(2026, 3, 19, 10, 45, 56, 290, DateTimeKind.Local).AddTicks(1376));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 26,
                column: "CreatedAt",
                value: new DateTime(2026, 3, 19, 10, 45, 56, 290, DateTimeKind.Local).AddTicks(1377));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 27,
                column: "CreatedAt",
                value: new DateTime(2026, 3, 19, 10, 45, 56, 290, DateTimeKind.Local).AddTicks(1379));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 28,
                column: "CreatedAt",
                value: new DateTime(2026, 3, 19, 10, 45, 56, 290, DateTimeKind.Local).AddTicks(1380));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 29,
                column: "CreatedAt",
                value: new DateTime(2026, 3, 19, 10, 45, 56, 290, DateTimeKind.Local).AddTicks(1381));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 30,
                column: "CreatedAt",
                value: new DateTime(2026, 3, 19, 10, 45, 56, 290, DateTimeKind.Local).AddTicks(1383));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 31,
                column: "CreatedAt",
                value: new DateTime(2026, 3, 19, 10, 45, 56, 290, DateTimeKind.Local).AddTicks(1384));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 32,
                column: "CreatedAt",
                value: new DateTime(2026, 3, 19, 10, 45, 56, 290, DateTimeKind.Local).AddTicks(1386));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 33,
                column: "CreatedAt",
                value: new DateTime(2026, 3, 19, 10, 45, 56, 290, DateTimeKind.Local).AddTicks(1387));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 34,
                column: "CreatedAt",
                value: new DateTime(2026, 3, 19, 10, 45, 56, 290, DateTimeKind.Local).AddTicks(1388));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 35,
                column: "CreatedAt",
                value: new DateTime(2026, 3, 19, 10, 45, 56, 290, DateTimeKind.Local).AddTicks(1390));

            migrationBuilder.UpdateData(
                table: "Branches",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 3, 19, 10, 45, 56, 288, DateTimeKind.Local).AddTicks(3765), new DateTime(2026, 3, 19, 10, 45, 56, 288, DateTimeKind.Local).AddTicks(3851) });

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "LastUpdatedAt", "LicensedValidTill" },
                values: new object[] { new DateTime(2026, 3, 19, 10, 45, 56, 288, DateTimeKind.Local).AddTicks(1425), new DateTime(2026, 3, 19, 10, 45, 56, 288, DateTimeKind.Local).AddTicks(1522), new DateTime(2026, 9, 15, 10, 45, 56, 288, DateTimeKind.Local).AddTicks(1746) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2026, 3, 19, 10, 45, 56, 290, DateTimeKind.Local).AddTicks(9648));

            migrationBuilder.UpdateData(
                table: "FinancialYears",
                keyColumn: "Code",
                keyValue: "2026",
                column: "FinStartDate",
                value: new DateTime(2026, 3, 19, 10, 45, 56, 287, DateTimeKind.Local).AddTicks(4770));

            migrationBuilder.UpdateData(
                table: "UserAuths",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2026, 3, 19, 10, 45, 56, 291, DateTimeKind.Local).AddTicks(1461));

            migrationBuilder.UpdateData(
                table: "UserRole",
                keyColumn: "RoleID",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 3, 19, 10, 45, 56, 290, DateTimeKind.Local).AddTicks(3139), new DateTime(2026, 3, 19, 10, 45, 56, 290, DateTimeKind.Local).AddTicks(3236) });

            migrationBuilder.UpdateData(
                table: "UserRole",
                keyColumn: "RoleID",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 3, 19, 10, 45, 56, 290, DateTimeKind.Local).AddTicks(3311), new DateTime(2026, 3, 19, 10, 45, 56, 290, DateTimeKind.Local).AddTicks(3312) });
        }
    }
}
