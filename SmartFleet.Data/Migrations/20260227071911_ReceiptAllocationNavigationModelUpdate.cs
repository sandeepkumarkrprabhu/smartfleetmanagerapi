using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SmartFleet.Data.Migrations
{
    /// <inheritdoc />
    public partial class ReceiptAllocationNavigationModelUpdate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ReceiptAllocations_ReceiptsDetail_ReceiptDetailId",
                table: "ReceiptAllocations");

            migrationBuilder.AlterColumn<int>(
                name: "ReceiptDetailId",
                table: "ReceiptAllocations",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 27, 12, 49, 7, 972, DateTimeKind.Local).AddTicks(5526));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 27, 12, 49, 7, 972, DateTimeKind.Local).AddTicks(6265));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 27, 12, 49, 7, 972, DateTimeKind.Local).AddTicks(6268));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 27, 12, 49, 7, 972, DateTimeKind.Local).AddTicks(6269));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 27, 12, 49, 7, 972, DateTimeKind.Local).AddTicks(6270));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 27, 12, 49, 7, 972, DateTimeKind.Local).AddTicks(6343));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 27, 12, 49, 7, 972, DateTimeKind.Local).AddTicks(6408));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 27, 12, 49, 7, 972, DateTimeKind.Local).AddTicks(6410));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 27, 12, 49, 7, 972, DateTimeKind.Local).AddTicks(6411));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 27, 12, 49, 7, 972, DateTimeKind.Local).AddTicks(6420));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 27, 12, 49, 7, 972, DateTimeKind.Local).AddTicks(6422));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 27, 12, 49, 7, 972, DateTimeKind.Local).AddTicks(6423));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 27, 12, 49, 7, 972, DateTimeKind.Local).AddTicks(6424));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 14,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 27, 12, 49, 7, 972, DateTimeKind.Local).AddTicks(6425));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 15,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 27, 12, 49, 7, 972, DateTimeKind.Local).AddTicks(6427));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 16,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 27, 12, 49, 7, 972, DateTimeKind.Local).AddTicks(6428));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 17,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 27, 12, 49, 7, 972, DateTimeKind.Local).AddTicks(6429));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 18,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 27, 12, 49, 7, 972, DateTimeKind.Local).AddTicks(6430));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 19,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 27, 12, 49, 7, 972, DateTimeKind.Local).AddTicks(6432));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 20,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 27, 12, 49, 7, 972, DateTimeKind.Local).AddTicks(6433));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 21,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 27, 12, 49, 7, 972, DateTimeKind.Local).AddTicks(6434));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 22,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 27, 12, 49, 7, 972, DateTimeKind.Local).AddTicks(6436));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 23,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 27, 12, 49, 7, 972, DateTimeKind.Local).AddTicks(6437));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 24,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 27, 12, 49, 7, 972, DateTimeKind.Local).AddTicks(6438));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 25,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 27, 12, 49, 7, 972, DateTimeKind.Local).AddTicks(6439));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 26,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 27, 12, 49, 7, 972, DateTimeKind.Local).AddTicks(6441));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 27,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 27, 12, 49, 7, 972, DateTimeKind.Local).AddTicks(6442));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 28,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 27, 12, 49, 7, 972, DateTimeKind.Local).AddTicks(6444));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 29,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 27, 12, 49, 7, 972, DateTimeKind.Local).AddTicks(6445));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 30,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 27, 12, 49, 7, 972, DateTimeKind.Local).AddTicks(6446));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 31,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 27, 12, 49, 7, 972, DateTimeKind.Local).AddTicks(6448));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 32,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 27, 12, 49, 7, 972, DateTimeKind.Local).AddTicks(6449));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 33,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 27, 12, 49, 7, 972, DateTimeKind.Local).AddTicks(6450));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 34,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 27, 12, 49, 7, 972, DateTimeKind.Local).AddTicks(6452));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 35,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 27, 12, 49, 7, 972, DateTimeKind.Local).AddTicks(6453));

            migrationBuilder.UpdateData(
                table: "Branches",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 27, 12, 49, 7, 970, DateTimeKind.Local).AddTicks(6924), new DateTime(2026, 2, 27, 12, 49, 7, 970, DateTimeKind.Local).AddTicks(7005) });

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "LastUpdatedAt", "LicensedValidTill" },
                values: new object[] { new DateTime(2026, 2, 27, 12, 49, 7, 970, DateTimeKind.Local).AddTicks(4497), new DateTime(2026, 2, 27, 12, 49, 7, 970, DateTimeKind.Local).AddTicks(4588), new DateTime(2026, 8, 26, 12, 49, 7, 970, DateTimeKind.Local).AddTicks(4808) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 27, 12, 49, 7, 973, DateTimeKind.Local).AddTicks(5413));

            migrationBuilder.UpdateData(
                table: "FinancialYears",
                keyColumn: "Code",
                keyValue: "2026",
                column: "FinStartDate",
                value: new DateTime(2026, 2, 27, 12, 49, 7, 969, DateTimeKind.Local).AddTicks(6943));

            migrationBuilder.UpdateData(
                table: "UserAuths",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 27, 12, 49, 7, 973, DateTimeKind.Local).AddTicks(6944));

            migrationBuilder.UpdateData(
                table: "UserRole",
                keyColumn: "RoleID",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 27, 12, 49, 7, 972, DateTimeKind.Local).AddTicks(8034), new DateTime(2026, 2, 27, 12, 49, 7, 972, DateTimeKind.Local).AddTicks(8164) });

            migrationBuilder.UpdateData(
                table: "UserRole",
                keyColumn: "RoleID",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 27, 12, 49, 7, 972, DateTimeKind.Local).AddTicks(8248), new DateTime(2026, 2, 27, 12, 49, 7, 972, DateTimeKind.Local).AddTicks(8249) });

            migrationBuilder.AddForeignKey(
                name: "FK_ReceiptAllocations_ReceiptsDetail_ReceiptDetailId",
                table: "ReceiptAllocations",
                column: "ReceiptDetailId",
                principalTable: "ReceiptsDetail",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ReceiptAllocations_ReceiptsDetail_ReceiptDetailId",
                table: "ReceiptAllocations");

            migrationBuilder.AlterColumn<int>(
                name: "ReceiptDetailId",
                table: "ReceiptAllocations",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 26, 23, 1, 9, 77, DateTimeKind.Local).AddTicks(4773));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 26, 23, 1, 9, 77, DateTimeKind.Local).AddTicks(5464));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 26, 23, 1, 9, 77, DateTimeKind.Local).AddTicks(5467));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 26, 23, 1, 9, 77, DateTimeKind.Local).AddTicks(5468));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 26, 23, 1, 9, 77, DateTimeKind.Local).AddTicks(5470));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 26, 23, 1, 9, 77, DateTimeKind.Local).AddTicks(5471));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 26, 23, 1, 9, 77, DateTimeKind.Local).AddTicks(5539));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 26, 23, 1, 9, 77, DateTimeKind.Local).AddTicks(5540));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 26, 23, 1, 9, 77, DateTimeKind.Local).AddTicks(5542));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 26, 23, 1, 9, 77, DateTimeKind.Local).AddTicks(5543));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 26, 23, 1, 9, 77, DateTimeKind.Local).AddTicks(5544));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 26, 23, 1, 9, 77, DateTimeKind.Local).AddTicks(5545));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 26, 23, 1, 9, 77, DateTimeKind.Local).AddTicks(5547));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 14,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 26, 23, 1, 9, 77, DateTimeKind.Local).AddTicks(5548));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 15,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 26, 23, 1, 9, 77, DateTimeKind.Local).AddTicks(5556));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 16,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 26, 23, 1, 9, 77, DateTimeKind.Local).AddTicks(5558));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 17,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 26, 23, 1, 9, 77, DateTimeKind.Local).AddTicks(5559));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 18,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 26, 23, 1, 9, 77, DateTimeKind.Local).AddTicks(5560));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 19,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 26, 23, 1, 9, 77, DateTimeKind.Local).AddTicks(5562));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 20,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 26, 23, 1, 9, 77, DateTimeKind.Local).AddTicks(5563));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 21,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 26, 23, 1, 9, 77, DateTimeKind.Local).AddTicks(5564));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 22,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 26, 23, 1, 9, 77, DateTimeKind.Local).AddTicks(5566));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 23,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 26, 23, 1, 9, 77, DateTimeKind.Local).AddTicks(5567));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 24,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 26, 23, 1, 9, 77, DateTimeKind.Local).AddTicks(5568));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 25,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 26, 23, 1, 9, 77, DateTimeKind.Local).AddTicks(5569));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 26,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 26, 23, 1, 9, 77, DateTimeKind.Local).AddTicks(5571));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 27,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 26, 23, 1, 9, 77, DateTimeKind.Local).AddTicks(5572));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 28,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 26, 23, 1, 9, 77, DateTimeKind.Local).AddTicks(5573));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 29,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 26, 23, 1, 9, 77, DateTimeKind.Local).AddTicks(5575));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 30,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 26, 23, 1, 9, 77, DateTimeKind.Local).AddTicks(5576));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 31,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 26, 23, 1, 9, 77, DateTimeKind.Local).AddTicks(5577));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 32,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 26, 23, 1, 9, 77, DateTimeKind.Local).AddTicks(5579));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 33,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 26, 23, 1, 9, 77, DateTimeKind.Local).AddTicks(5580));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 34,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 26, 23, 1, 9, 77, DateTimeKind.Local).AddTicks(5581));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 35,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 26, 23, 1, 9, 77, DateTimeKind.Local).AddTicks(5582));

            migrationBuilder.UpdateData(
                table: "Branches",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 26, 23, 1, 9, 75, DateTimeKind.Local).AddTicks(9492), new DateTime(2026, 2, 26, 23, 1, 9, 75, DateTimeKind.Local).AddTicks(9570) });

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "LastUpdatedAt", "LicensedValidTill" },
                values: new object[] { new DateTime(2026, 2, 26, 23, 1, 9, 75, DateTimeKind.Local).AddTicks(7454), new DateTime(2026, 2, 26, 23, 1, 9, 75, DateTimeKind.Local).AddTicks(7534), new DateTime(2026, 8, 25, 23, 1, 9, 75, DateTimeKind.Local).AddTicks(7740) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 26, 23, 1, 9, 78, DateTimeKind.Local).AddTicks(3416));

            migrationBuilder.UpdateData(
                table: "FinancialYears",
                keyColumn: "Code",
                keyValue: "2026",
                column: "FinStartDate",
                value: new DateTime(2026, 2, 26, 23, 1, 9, 75, DateTimeKind.Local).AddTicks(1590));

            migrationBuilder.UpdateData(
                table: "UserAuths",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 26, 23, 1, 9, 78, DateTimeKind.Local).AddTicks(4925));

            migrationBuilder.UpdateData(
                table: "UserRole",
                keyColumn: "RoleID",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 26, 23, 1, 9, 77, DateTimeKind.Local).AddTicks(7254), new DateTime(2026, 2, 26, 23, 1, 9, 77, DateTimeKind.Local).AddTicks(7343) });

            migrationBuilder.UpdateData(
                table: "UserRole",
                keyColumn: "RoleID",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 26, 23, 1, 9, 77, DateTimeKind.Local).AddTicks(7414), new DateTime(2026, 2, 26, 23, 1, 9, 77, DateTimeKind.Local).AddTicks(7414) });

            migrationBuilder.AddForeignKey(
                name: "FK_ReceiptAllocations_ReceiptsDetail_ReceiptDetailId",
                table: "ReceiptAllocations",
                column: "ReceiptDetailId",
                principalTable: "ReceiptsDetail",
                principalColumn: "Id");
        }
    }
}
