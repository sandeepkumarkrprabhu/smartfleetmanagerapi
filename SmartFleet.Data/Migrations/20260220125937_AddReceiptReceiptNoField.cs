using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SmartFleet.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddReceiptReceiptNoField : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "receiptNo",
                table: "Receipts",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 20, 18, 29, 36, 804, DateTimeKind.Local).AddTicks(5252));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 20, 18, 29, 36, 804, DateTimeKind.Local).AddTicks(6185));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 20, 18, 29, 36, 804, DateTimeKind.Local).AddTicks(6188));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 20, 18, 29, 36, 804, DateTimeKind.Local).AddTicks(6189));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 20, 18, 29, 36, 804, DateTimeKind.Local).AddTicks(6191));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 20, 18, 29, 36, 804, DateTimeKind.Local).AddTicks(6192));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 20, 18, 29, 36, 804, DateTimeKind.Local).AddTicks(6263));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 20, 18, 29, 36, 804, DateTimeKind.Local).AddTicks(6265));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 20, 18, 29, 36, 804, DateTimeKind.Local).AddTicks(6266));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 20, 18, 29, 36, 804, DateTimeKind.Local).AddTicks(6268));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 20, 18, 29, 36, 804, DateTimeKind.Local).AddTicks(6269));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 20, 18, 29, 36, 804, DateTimeKind.Local).AddTicks(6271));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 20, 18, 29, 36, 804, DateTimeKind.Local).AddTicks(6272));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 14,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 20, 18, 29, 36, 804, DateTimeKind.Local).AddTicks(6273));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 15,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 20, 18, 29, 36, 804, DateTimeKind.Local).AddTicks(6275));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 16,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 20, 18, 29, 36, 804, DateTimeKind.Local).AddTicks(6338));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 17,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 20, 18, 29, 36, 804, DateTimeKind.Local).AddTicks(6348));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 18,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 20, 18, 29, 36, 804, DateTimeKind.Local).AddTicks(6350));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 19,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 20, 18, 29, 36, 804, DateTimeKind.Local).AddTicks(6351));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 20,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 20, 18, 29, 36, 804, DateTimeKind.Local).AddTicks(6353));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 21,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 20, 18, 29, 36, 804, DateTimeKind.Local).AddTicks(6354));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 22,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 20, 18, 29, 36, 804, DateTimeKind.Local).AddTicks(6356));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 23,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 20, 18, 29, 36, 804, DateTimeKind.Local).AddTicks(6357));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 24,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 20, 18, 29, 36, 804, DateTimeKind.Local).AddTicks(6359));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 25,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 20, 18, 29, 36, 804, DateTimeKind.Local).AddTicks(6360));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 26,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 20, 18, 29, 36, 804, DateTimeKind.Local).AddTicks(6362));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 27,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 20, 18, 29, 36, 804, DateTimeKind.Local).AddTicks(6363));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 28,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 20, 18, 29, 36, 804, DateTimeKind.Local).AddTicks(6365));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 29,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 20, 18, 29, 36, 804, DateTimeKind.Local).AddTicks(6366));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 30,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 20, 18, 29, 36, 804, DateTimeKind.Local).AddTicks(6368));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 31,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 20, 18, 29, 36, 804, DateTimeKind.Local).AddTicks(6369));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 32,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 20, 18, 29, 36, 804, DateTimeKind.Local).AddTicks(6371));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 33,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 20, 18, 29, 36, 804, DateTimeKind.Local).AddTicks(6372));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 34,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 20, 18, 29, 36, 804, DateTimeKind.Local).AddTicks(6374));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 35,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 20, 18, 29, 36, 804, DateTimeKind.Local).AddTicks(6375));

            migrationBuilder.UpdateData(
                table: "Branches",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 20, 18, 29, 36, 802, DateTimeKind.Local).AddTicks(6654), new DateTime(2026, 2, 20, 18, 29, 36, 802, DateTimeKind.Local).AddTicks(6804) });

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "LastUpdatedAt", "LicensedValidTill" },
                values: new object[] { new DateTime(2026, 2, 20, 18, 29, 36, 802, DateTimeKind.Local).AddTicks(4419), new DateTime(2026, 2, 20, 18, 29, 36, 802, DateTimeKind.Local).AddTicks(4503), new DateTime(2026, 8, 19, 18, 29, 36, 802, DateTimeKind.Local).AddTicks(4718) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 20, 18, 29, 36, 805, DateTimeKind.Local).AddTicks(5599));

            migrationBuilder.UpdateData(
                table: "FinancialYears",
                keyColumn: "Code",
                keyValue: "2026",
                column: "FinStartDate",
                value: new DateTime(2026, 2, 20, 18, 29, 36, 801, DateTimeKind.Local).AddTicks(8088));

            migrationBuilder.UpdateData(
                table: "UserAuths",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 20, 18, 29, 36, 805, DateTimeKind.Local).AddTicks(7398));

            migrationBuilder.UpdateData(
                table: "UserRole",
                keyColumn: "RoleID",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 20, 18, 29, 36, 804, DateTimeKind.Local).AddTicks(8313), new DateTime(2026, 2, 20, 18, 29, 36, 804, DateTimeKind.Local).AddTicks(8464) });

            migrationBuilder.UpdateData(
                table: "UserRole",
                keyColumn: "RoleID",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 20, 18, 29, 36, 804, DateTimeKind.Local).AddTicks(8545), new DateTime(2026, 2, 20, 18, 29, 36, 804, DateTimeKind.Local).AddTicks(8545) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "receiptNo",
                table: "Receipts");

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 20, 18, 25, 31, 169, DateTimeKind.Local).AddTicks(9601));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 20, 18, 25, 31, 170, DateTimeKind.Local).AddTicks(364));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 20, 18, 25, 31, 170, DateTimeKind.Local).AddTicks(366));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 20, 18, 25, 31, 170, DateTimeKind.Local).AddTicks(368));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 20, 18, 25, 31, 170, DateTimeKind.Local).AddTicks(369));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 20, 18, 25, 31, 170, DateTimeKind.Local).AddTicks(371));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 20, 18, 25, 31, 170, DateTimeKind.Local).AddTicks(446));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 20, 18, 25, 31, 170, DateTimeKind.Local).AddTicks(448));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 20, 18, 25, 31, 170, DateTimeKind.Local).AddTicks(449));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 20, 18, 25, 31, 170, DateTimeKind.Local).AddTicks(451));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 20, 18, 25, 31, 170, DateTimeKind.Local).AddTicks(452));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 20, 18, 25, 31, 170, DateTimeKind.Local).AddTicks(453));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 20, 18, 25, 31, 170, DateTimeKind.Local).AddTicks(494));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 14,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 20, 18, 25, 31, 170, DateTimeKind.Local).AddTicks(495));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 15,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 20, 18, 25, 31, 170, DateTimeKind.Local).AddTicks(497));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 16,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 20, 18, 25, 31, 170, DateTimeKind.Local).AddTicks(498));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 17,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 20, 18, 25, 31, 170, DateTimeKind.Local).AddTicks(499));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 18,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 20, 18, 25, 31, 170, DateTimeKind.Local).AddTicks(501));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 19,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 20, 18, 25, 31, 170, DateTimeKind.Local).AddTicks(502));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 20,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 20, 18, 25, 31, 170, DateTimeKind.Local).AddTicks(503));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 21,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 20, 18, 25, 31, 170, DateTimeKind.Local).AddTicks(512));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 22,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 20, 18, 25, 31, 170, DateTimeKind.Local).AddTicks(513));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 23,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 20, 18, 25, 31, 170, DateTimeKind.Local).AddTicks(514));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 24,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 20, 18, 25, 31, 170, DateTimeKind.Local).AddTicks(516));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 25,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 20, 18, 25, 31, 170, DateTimeKind.Local).AddTicks(517));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 26,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 20, 18, 25, 31, 170, DateTimeKind.Local).AddTicks(518));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 27,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 20, 18, 25, 31, 170, DateTimeKind.Local).AddTicks(520));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 28,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 20, 18, 25, 31, 170, DateTimeKind.Local).AddTicks(521));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 29,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 20, 18, 25, 31, 170, DateTimeKind.Local).AddTicks(522));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 30,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 20, 18, 25, 31, 170, DateTimeKind.Local).AddTicks(524));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 31,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 20, 18, 25, 31, 170, DateTimeKind.Local).AddTicks(525));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 32,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 20, 18, 25, 31, 170, DateTimeKind.Local).AddTicks(526));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 33,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 20, 18, 25, 31, 170, DateTimeKind.Local).AddTicks(528));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 34,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 20, 18, 25, 31, 170, DateTimeKind.Local).AddTicks(529));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 35,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 20, 18, 25, 31, 170, DateTimeKind.Local).AddTicks(530));

            migrationBuilder.UpdateData(
                table: "Branches",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 20, 18, 25, 31, 168, DateTimeKind.Local).AddTicks(1036), new DateTime(2026, 2, 20, 18, 25, 31, 168, DateTimeKind.Local).AddTicks(1121) });

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "LastUpdatedAt", "LicensedValidTill" },
                values: new object[] { new DateTime(2026, 2, 20, 18, 25, 31, 167, DateTimeKind.Local).AddTicks(8889), new DateTime(2026, 2, 20, 18, 25, 31, 167, DateTimeKind.Local).AddTicks(8977), new DateTime(2026, 8, 19, 18, 25, 31, 167, DateTimeKind.Local).AddTicks(9198) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 20, 18, 25, 31, 170, DateTimeKind.Local).AddTicks(9072));

            migrationBuilder.UpdateData(
                table: "FinancialYears",
                keyColumn: "Code",
                keyValue: "2026",
                column: "FinStartDate",
                value: new DateTime(2026, 2, 20, 18, 25, 31, 167, DateTimeKind.Local).AddTicks(3031));

            migrationBuilder.UpdateData(
                table: "UserAuths",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 20, 18, 25, 31, 171, DateTimeKind.Local).AddTicks(841));

            migrationBuilder.UpdateData(
                table: "UserRole",
                keyColumn: "RoleID",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 20, 18, 25, 31, 170, DateTimeKind.Local).AddTicks(2183), new DateTime(2026, 2, 20, 18, 25, 31, 170, DateTimeKind.Local).AddTicks(2280) });

            migrationBuilder.UpdateData(
                table: "UserRole",
                keyColumn: "RoleID",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 20, 18, 25, 31, 170, DateTimeKind.Local).AddTicks(2356), new DateTime(2026, 2, 20, 18, 25, 31, 170, DateTimeKind.Local).AddTicks(2356) });
        }
    }
}
