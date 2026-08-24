using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SmartFleet.Data.Migrations
{
    /// <inheritdoc />
    public partial class ReceiptAllocationTablepropertyUpdate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "InvoiceNo",
                table: "ReceiptAllocations",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 20, 20, 11, 47, 418, DateTimeKind.Local).AddTicks(741));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 20, 20, 11, 47, 418, DateTimeKind.Local).AddTicks(1467));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 20, 20, 11, 47, 418, DateTimeKind.Local).AddTicks(1469));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 20, 20, 11, 47, 418, DateTimeKind.Local).AddTicks(1471));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 20, 20, 11, 47, 418, DateTimeKind.Local).AddTicks(1472));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 20, 20, 11, 47, 418, DateTimeKind.Local).AddTicks(1473));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 20, 20, 11, 47, 418, DateTimeKind.Local).AddTicks(1538));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 20, 20, 11, 47, 418, DateTimeKind.Local).AddTicks(1539));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 20, 20, 11, 47, 418, DateTimeKind.Local).AddTicks(1541));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 20, 20, 11, 47, 418, DateTimeKind.Local).AddTicks(1542));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 20, 20, 11, 47, 418, DateTimeKind.Local).AddTicks(1543));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 20, 20, 11, 47, 418, DateTimeKind.Local).AddTicks(1544));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 20, 20, 11, 47, 418, DateTimeKind.Local).AddTicks(1546));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 14,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 20, 20, 11, 47, 418, DateTimeKind.Local).AddTicks(1547));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 15,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 20, 20, 11, 47, 418, DateTimeKind.Local).AddTicks(1548));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 16,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 20, 20, 11, 47, 418, DateTimeKind.Local).AddTicks(1549));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 17,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 20, 20, 11, 47, 418, DateTimeKind.Local).AddTicks(1558));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 18,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 20, 20, 11, 47, 418, DateTimeKind.Local).AddTicks(1559));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 19,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 20, 20, 11, 47, 418, DateTimeKind.Local).AddTicks(1560));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 20,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 20, 20, 11, 47, 418, DateTimeKind.Local).AddTicks(1562));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 21,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 20, 20, 11, 47, 418, DateTimeKind.Local).AddTicks(1563));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 22,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 20, 20, 11, 47, 418, DateTimeKind.Local).AddTicks(1564));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 23,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 20, 20, 11, 47, 418, DateTimeKind.Local).AddTicks(1566));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 24,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 20, 20, 11, 47, 418, DateTimeKind.Local).AddTicks(1567));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 25,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 20, 20, 11, 47, 418, DateTimeKind.Local).AddTicks(1568));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 26,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 20, 20, 11, 47, 418, DateTimeKind.Local).AddTicks(1570));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 27,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 20, 20, 11, 47, 418, DateTimeKind.Local).AddTicks(1616));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 28,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 20, 20, 11, 47, 418, DateTimeKind.Local).AddTicks(1618));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 29,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 20, 20, 11, 47, 418, DateTimeKind.Local).AddTicks(1620));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 30,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 20, 20, 11, 47, 418, DateTimeKind.Local).AddTicks(1622));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 31,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 20, 20, 11, 47, 418, DateTimeKind.Local).AddTicks(1623));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 32,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 20, 20, 11, 47, 418, DateTimeKind.Local).AddTicks(1625));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 33,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 20, 20, 11, 47, 418, DateTimeKind.Local).AddTicks(1626));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 34,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 20, 20, 11, 47, 418, DateTimeKind.Local).AddTicks(1627));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 35,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 20, 20, 11, 47, 418, DateTimeKind.Local).AddTicks(1629));

            migrationBuilder.UpdateData(
                table: "Branches",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 20, 20, 11, 47, 416, DateTimeKind.Local).AddTicks(5627), new DateTime(2026, 2, 20, 20, 11, 47, 416, DateTimeKind.Local).AddTicks(5866) });

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "LastUpdatedAt", "LicensedValidTill" },
                values: new object[] { new DateTime(2026, 2, 20, 20, 11, 47, 416, DateTimeKind.Local).AddTicks(3680), new DateTime(2026, 2, 20, 20, 11, 47, 416, DateTimeKind.Local).AddTicks(3765), new DateTime(2026, 8, 19, 20, 11, 47, 416, DateTimeKind.Local).AddTicks(3967) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 20, 20, 11, 47, 418, DateTimeKind.Local).AddTicks(8753));

            migrationBuilder.UpdateData(
                table: "FinancialYears",
                keyColumn: "Code",
                keyValue: "2026",
                column: "FinStartDate",
                value: new DateTime(2026, 2, 20, 20, 11, 47, 415, DateTimeKind.Local).AddTicks(5890));

            migrationBuilder.UpdateData(
                table: "UserAuths",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 20, 20, 11, 47, 419, DateTimeKind.Local).AddTicks(196));

            migrationBuilder.UpdateData(
                table: "UserRole",
                keyColumn: "RoleID",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 20, 20, 11, 47, 418, DateTimeKind.Local).AddTicks(3196), new DateTime(2026, 2, 20, 20, 11, 47, 418, DateTimeKind.Local).AddTicks(3331) });

            migrationBuilder.UpdateData(
                table: "UserRole",
                keyColumn: "RoleID",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 20, 20, 11, 47, 418, DateTimeKind.Local).AddTicks(3403), new DateTime(2026, 2, 20, 20, 11, 47, 418, DateTimeKind.Local).AddTicks(3403) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "InvoiceNo",
                table: "ReceiptAllocations",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

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
    }
}
