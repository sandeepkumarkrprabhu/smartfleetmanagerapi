using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SmartFleet.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddReceiptAllocationMissingFields : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "ReceiptAllocations",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "ReceiptDetailId",
                table: "ReceiptAllocations",
                type: "int",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 20, 18, 0, 4, 676, DateTimeKind.Local).AddTicks(8764));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 20, 18, 0, 4, 676, DateTimeKind.Local).AddTicks(9505));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 20, 18, 0, 4, 676, DateTimeKind.Local).AddTicks(9508));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 20, 18, 0, 4, 676, DateTimeKind.Local).AddTicks(9509));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 20, 18, 0, 4, 676, DateTimeKind.Local).AddTicks(9511));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 20, 18, 0, 4, 676, DateTimeKind.Local).AddTicks(9512));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 20, 18, 0, 4, 676, DateTimeKind.Local).AddTicks(9594));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 20, 18, 0, 4, 676, DateTimeKind.Local).AddTicks(9604));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 20, 18, 0, 4, 676, DateTimeKind.Local).AddTicks(9606));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 20, 18, 0, 4, 676, DateTimeKind.Local).AddTicks(9607));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 20, 18, 0, 4, 676, DateTimeKind.Local).AddTicks(9609));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 20, 18, 0, 4, 676, DateTimeKind.Local).AddTicks(9610));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 20, 18, 0, 4, 676, DateTimeKind.Local).AddTicks(9612));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 14,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 20, 18, 0, 4, 676, DateTimeKind.Local).AddTicks(9613));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 15,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 20, 18, 0, 4, 676, DateTimeKind.Local).AddTicks(9614));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 16,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 20, 18, 0, 4, 676, DateTimeKind.Local).AddTicks(9616));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 17,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 20, 18, 0, 4, 676, DateTimeKind.Local).AddTicks(9617));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 18,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 20, 18, 0, 4, 676, DateTimeKind.Local).AddTicks(9619));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 19,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 20, 18, 0, 4, 676, DateTimeKind.Local).AddTicks(9620));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 20,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 20, 18, 0, 4, 676, DateTimeKind.Local).AddTicks(9622));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 21,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 20, 18, 0, 4, 676, DateTimeKind.Local).AddTicks(9623));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 22,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 20, 18, 0, 4, 676, DateTimeKind.Local).AddTicks(9632));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 23,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 20, 18, 0, 4, 676, DateTimeKind.Local).AddTicks(9634));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 24,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 20, 18, 0, 4, 676, DateTimeKind.Local).AddTicks(9635));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 25,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 20, 18, 0, 4, 676, DateTimeKind.Local).AddTicks(9637));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 26,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 20, 18, 0, 4, 676, DateTimeKind.Local).AddTicks(9638));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 27,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 20, 18, 0, 4, 676, DateTimeKind.Local).AddTicks(9640));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 28,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 20, 18, 0, 4, 676, DateTimeKind.Local).AddTicks(9641));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 29,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 20, 18, 0, 4, 676, DateTimeKind.Local).AddTicks(9642));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 30,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 20, 18, 0, 4, 676, DateTimeKind.Local).AddTicks(9644));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 31,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 20, 18, 0, 4, 676, DateTimeKind.Local).AddTicks(9645));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 32,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 20, 18, 0, 4, 676, DateTimeKind.Local).AddTicks(9647));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 33,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 20, 18, 0, 4, 676, DateTimeKind.Local).AddTicks(9648));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 34,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 20, 18, 0, 4, 676, DateTimeKind.Local).AddTicks(9649));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 35,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 20, 18, 0, 4, 676, DateTimeKind.Local).AddTicks(9651));

            migrationBuilder.UpdateData(
                table: "Branches",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 20, 18, 0, 4, 675, DateTimeKind.Local).AddTicks(2116), new DateTime(2026, 2, 20, 18, 0, 4, 675, DateTimeKind.Local).AddTicks(2200) });

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "LastUpdatedAt", "LicensedValidTill" },
                values: new object[] { new DateTime(2026, 2, 20, 18, 0, 4, 674, DateTimeKind.Local).AddTicks(9964), new DateTime(2026, 2, 20, 18, 0, 4, 675, DateTimeKind.Local).AddTicks(49), new DateTime(2026, 8, 19, 18, 0, 4, 675, DateTimeKind.Local).AddTicks(278) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 20, 18, 0, 4, 678, DateTimeKind.Local).AddTicks(5173));

            migrationBuilder.UpdateData(
                table: "FinancialYears",
                keyColumn: "Code",
                keyValue: "2026",
                column: "FinStartDate",
                value: new DateTime(2026, 2, 20, 18, 0, 4, 674, DateTimeKind.Local).AddTicks(4572));

            migrationBuilder.UpdateData(
                table: "UserAuths",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 20, 18, 0, 4, 678, DateTimeKind.Local).AddTicks(7056));

            migrationBuilder.UpdateData(
                table: "UserRole",
                keyColumn: "RoleID",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 20, 18, 0, 4, 677, DateTimeKind.Local).AddTicks(5070), new DateTime(2026, 2, 20, 18, 0, 4, 677, DateTimeKind.Local).AddTicks(5225) });

            migrationBuilder.UpdateData(
                table: "UserRole",
                keyColumn: "RoleID",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 20, 18, 0, 4, 677, DateTimeKind.Local).AddTicks(5330), new DateTime(2026, 2, 20, 18, 0, 4, 677, DateTimeKind.Local).AddTicks(5330) });

            migrationBuilder.CreateIndex(
                name: "IX_ReceiptAllocations_ReceiptDetailId",
                table: "ReceiptAllocations",
                column: "ReceiptDetailId");

            migrationBuilder.AddForeignKey(
                name: "FK_ReceiptAllocations_ReceiptsDetail_ReceiptDetailId",
                table: "ReceiptAllocations",
                column: "ReceiptDetailId",
                principalTable: "ReceiptsDetail",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ReceiptAllocations_ReceiptsDetail_ReceiptDetailId",
                table: "ReceiptAllocations");

            migrationBuilder.DropIndex(
                name: "IX_ReceiptAllocations_ReceiptDetailId",
                table: "ReceiptAllocations");

            migrationBuilder.DropColumn(
                name: "Name",
                table: "ReceiptAllocations");

            migrationBuilder.DropColumn(
                name: "ReceiptDetailId",
                table: "ReceiptAllocations");

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 20, 17, 22, 30, 371, DateTimeKind.Local).AddTicks(9565));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 20, 17, 22, 30, 372, DateTimeKind.Local).AddTicks(323));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 20, 17, 22, 30, 372, DateTimeKind.Local).AddTicks(326));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 20, 17, 22, 30, 372, DateTimeKind.Local).AddTicks(327));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 20, 17, 22, 30, 372, DateTimeKind.Local).AddTicks(328));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 20, 17, 22, 30, 372, DateTimeKind.Local).AddTicks(337));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 20, 17, 22, 30, 372, DateTimeKind.Local).AddTicks(404));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 20, 17, 22, 30, 372, DateTimeKind.Local).AddTicks(405));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 20, 17, 22, 30, 372, DateTimeKind.Local).AddTicks(407));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 20, 17, 22, 30, 372, DateTimeKind.Local).AddTicks(408));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 20, 17, 22, 30, 372, DateTimeKind.Local).AddTicks(409));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 20, 17, 22, 30, 372, DateTimeKind.Local).AddTicks(450));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 20, 17, 22, 30, 372, DateTimeKind.Local).AddTicks(452));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 14,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 20, 17, 22, 30, 372, DateTimeKind.Local).AddTicks(453));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 15,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 20, 17, 22, 30, 372, DateTimeKind.Local).AddTicks(454));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 16,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 20, 17, 22, 30, 372, DateTimeKind.Local).AddTicks(455));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 17,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 20, 17, 22, 30, 372, DateTimeKind.Local).AddTicks(457));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 18,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 20, 17, 22, 30, 372, DateTimeKind.Local).AddTicks(458));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 19,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 20, 17, 22, 30, 372, DateTimeKind.Local).AddTicks(459));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 20,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 20, 17, 22, 30, 372, DateTimeKind.Local).AddTicks(468));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 21,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 20, 17, 22, 30, 372, DateTimeKind.Local).AddTicks(469));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 22,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 20, 17, 22, 30, 372, DateTimeKind.Local).AddTicks(471));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 23,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 20, 17, 22, 30, 372, DateTimeKind.Local).AddTicks(472));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 24,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 20, 17, 22, 30, 372, DateTimeKind.Local).AddTicks(473));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 25,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 20, 17, 22, 30, 372, DateTimeKind.Local).AddTicks(475));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 26,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 20, 17, 22, 30, 372, DateTimeKind.Local).AddTicks(476));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 27,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 20, 17, 22, 30, 372, DateTimeKind.Local).AddTicks(477));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 28,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 20, 17, 22, 30, 372, DateTimeKind.Local).AddTicks(479));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 29,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 20, 17, 22, 30, 372, DateTimeKind.Local).AddTicks(480));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 30,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 20, 17, 22, 30, 372, DateTimeKind.Local).AddTicks(481));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 31,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 20, 17, 22, 30, 372, DateTimeKind.Local).AddTicks(482));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 32,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 20, 17, 22, 30, 372, DateTimeKind.Local).AddTicks(484));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 33,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 20, 17, 22, 30, 372, DateTimeKind.Local).AddTicks(485));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 34,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 20, 17, 22, 30, 372, DateTimeKind.Local).AddTicks(486));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 35,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 20, 17, 22, 30, 372, DateTimeKind.Local).AddTicks(488));

            migrationBuilder.UpdateData(
                table: "Branches",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 20, 17, 22, 30, 370, DateTimeKind.Local).AddTicks(4219), new DateTime(2026, 2, 20, 17, 22, 30, 370, DateTimeKind.Local).AddTicks(4310) });

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "LastUpdatedAt", "LicensedValidTill" },
                values: new object[] { new DateTime(2026, 2, 20, 17, 22, 30, 370, DateTimeKind.Local).AddTicks(1912), new DateTime(2026, 2, 20, 17, 22, 30, 370, DateTimeKind.Local).AddTicks(2006), new DateTime(2026, 8, 19, 17, 22, 30, 370, DateTimeKind.Local).AddTicks(2214) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 20, 17, 22, 30, 372, DateTimeKind.Local).AddTicks(8083));

            migrationBuilder.UpdateData(
                table: "FinancialYears",
                keyColumn: "Code",
                keyValue: "2026",
                column: "FinStartDate",
                value: new DateTime(2026, 2, 20, 17, 22, 30, 369, DateTimeKind.Local).AddTicks(6208));

            migrationBuilder.UpdateData(
                table: "UserAuths",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 20, 17, 22, 30, 372, DateTimeKind.Local).AddTicks(9714));

            migrationBuilder.UpdateData(
                table: "UserRole",
                keyColumn: "RoleID",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 20, 17, 22, 30, 372, DateTimeKind.Local).AddTicks(2139), new DateTime(2026, 2, 20, 17, 22, 30, 372, DateTimeKind.Local).AddTicks(2237) });

            migrationBuilder.UpdateData(
                table: "UserRole",
                keyColumn: "RoleID",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 20, 17, 22, 30, 372, DateTimeKind.Local).AddTicks(2310), new DateTime(2026, 2, 20, 17, 22, 30, 372, DateTimeKind.Local).AddTicks(2310) });
        }
    }
}
