using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SmartFleet.Data.Migrations
{
    /// <inheritdoc />
    public partial class PaymentAllocationNavigationUpdate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PaymentAllocations_paymentsDetail_PaymentDetailId",
                table: "PaymentAllocations");

            migrationBuilder.AlterColumn<int>(
                name: "PaymentDetailId",
                table: "PaymentAllocations",
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
                value: new DateTime(2026, 2, 27, 20, 6, 7, 941, DateTimeKind.Local).AddTicks(7063));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 27, 20, 6, 7, 941, DateTimeKind.Local).AddTicks(7785));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 27, 20, 6, 7, 941, DateTimeKind.Local).AddTicks(7787));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 27, 20, 6, 7, 941, DateTimeKind.Local).AddTicks(7789));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 27, 20, 6, 7, 941, DateTimeKind.Local).AddTicks(7790));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 27, 20, 6, 7, 941, DateTimeKind.Local).AddTicks(7792));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 27, 20, 6, 7, 941, DateTimeKind.Local).AddTicks(7859));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 27, 20, 6, 7, 941, DateTimeKind.Local).AddTicks(7891));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 27, 20, 6, 7, 941, DateTimeKind.Local).AddTicks(7901));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 27, 20, 6, 7, 941, DateTimeKind.Local).AddTicks(7902));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 27, 20, 6, 7, 941, DateTimeKind.Local).AddTicks(7904));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 27, 20, 6, 7, 941, DateTimeKind.Local).AddTicks(7905));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 27, 20, 6, 7, 941, DateTimeKind.Local).AddTicks(7907));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 14,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 27, 20, 6, 7, 941, DateTimeKind.Local).AddTicks(7908));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 15,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 27, 20, 6, 7, 941, DateTimeKind.Local).AddTicks(7909));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 16,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 27, 20, 6, 7, 941, DateTimeKind.Local).AddTicks(7911));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 17,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 27, 20, 6, 7, 941, DateTimeKind.Local).AddTicks(7912));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 18,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 27, 20, 6, 7, 941, DateTimeKind.Local).AddTicks(7913));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 19,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 27, 20, 6, 7, 941, DateTimeKind.Local).AddTicks(7915));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 20,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 27, 20, 6, 7, 941, DateTimeKind.Local).AddTicks(7916));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 21,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 27, 20, 6, 7, 941, DateTimeKind.Local).AddTicks(7918));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 22,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 27, 20, 6, 7, 941, DateTimeKind.Local).AddTicks(7919));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 23,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 27, 20, 6, 7, 941, DateTimeKind.Local).AddTicks(7928));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 24,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 27, 20, 6, 7, 941, DateTimeKind.Local).AddTicks(7929));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 25,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 27, 20, 6, 7, 941, DateTimeKind.Local).AddTicks(7931));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 26,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 27, 20, 6, 7, 941, DateTimeKind.Local).AddTicks(7932));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 27,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 27, 20, 6, 7, 941, DateTimeKind.Local).AddTicks(7934));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 28,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 27, 20, 6, 7, 941, DateTimeKind.Local).AddTicks(7935));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 29,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 27, 20, 6, 7, 941, DateTimeKind.Local).AddTicks(7936));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 30,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 27, 20, 6, 7, 941, DateTimeKind.Local).AddTicks(7938));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 31,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 27, 20, 6, 7, 941, DateTimeKind.Local).AddTicks(7939));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 32,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 27, 20, 6, 7, 941, DateTimeKind.Local).AddTicks(7941));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 33,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 27, 20, 6, 7, 941, DateTimeKind.Local).AddTicks(7942));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 34,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 27, 20, 6, 7, 941, DateTimeKind.Local).AddTicks(7943));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 35,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 27, 20, 6, 7, 941, DateTimeKind.Local).AddTicks(7945));

            migrationBuilder.UpdateData(
                table: "Branches",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 27, 20, 6, 7, 940, DateTimeKind.Local).AddTicks(2129), new DateTime(2026, 2, 27, 20, 6, 7, 940, DateTimeKind.Local).AddTicks(2203) });

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "LastUpdatedAt", "LicensedValidTill" },
                values: new object[] { new DateTime(2026, 2, 27, 20, 6, 7, 940, DateTimeKind.Local).AddTicks(48), new DateTime(2026, 2, 27, 20, 6, 7, 940, DateTimeKind.Local).AddTicks(131), new DateTime(2026, 8, 26, 20, 6, 7, 940, DateTimeKind.Local).AddTicks(338) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 27, 20, 6, 7, 942, DateTimeKind.Local).AddTicks(5636));

            migrationBuilder.UpdateData(
                table: "FinancialYears",
                keyColumn: "Code",
                keyValue: "2026",
                column: "FinStartDate",
                value: new DateTime(2026, 2, 27, 20, 6, 7, 939, DateTimeKind.Local).AddTicks(4146));

            migrationBuilder.UpdateData(
                table: "UserAuths",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 27, 20, 6, 7, 942, DateTimeKind.Local).AddTicks(7143));

            migrationBuilder.UpdateData(
                table: "UserRole",
                keyColumn: "RoleID",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 27, 20, 6, 7, 941, DateTimeKind.Local).AddTicks(9534), new DateTime(2026, 2, 27, 20, 6, 7, 941, DateTimeKind.Local).AddTicks(9626) });

            migrationBuilder.UpdateData(
                table: "UserRole",
                keyColumn: "RoleID",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 27, 20, 6, 7, 941, DateTimeKind.Local).AddTicks(9702), new DateTime(2026, 2, 27, 20, 6, 7, 941, DateTimeKind.Local).AddTicks(9702) });

            migrationBuilder.AddForeignKey(
                name: "FK_PaymentAllocations_paymentsDetail_PaymentDetailId",
                table: "PaymentAllocations",
                column: "PaymentDetailId",
                principalTable: "paymentsDetail",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PaymentAllocations_paymentsDetail_PaymentDetailId",
                table: "PaymentAllocations");

            migrationBuilder.AlterColumn<int>(
                name: "PaymentDetailId",
                table: "PaymentAllocations",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

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
                name: "FK_PaymentAllocations_paymentsDetail_PaymentDetailId",
                table: "PaymentAllocations",
                column: "PaymentDetailId",
                principalTable: "paymentsDetail",
                principalColumn: "Id");
        }
    }
}
