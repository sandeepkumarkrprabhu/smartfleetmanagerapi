using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SmartFleet.Data.Migrations
{
    /// <inheritdoc />
    public partial class PaymentTableNavigationUpdate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "PaymentDetailId",
                table: "PaymentAllocations",
                type: "int",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 21, 20, 48, 41, 647, DateTimeKind.Local).AddTicks(6770));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 21, 20, 48, 41, 647, DateTimeKind.Local).AddTicks(7519));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 21, 20, 48, 41, 647, DateTimeKind.Local).AddTicks(7521));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 21, 20, 48, 41, 647, DateTimeKind.Local).AddTicks(7523));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 21, 20, 48, 41, 647, DateTimeKind.Local).AddTicks(7524));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 21, 20, 48, 41, 647, DateTimeKind.Local).AddTicks(7525));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 21, 20, 48, 41, 647, DateTimeKind.Local).AddTicks(7599));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 21, 20, 48, 41, 647, DateTimeKind.Local).AddTicks(7600));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 21, 20, 48, 41, 647, DateTimeKind.Local).AddTicks(7602));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 21, 20, 48, 41, 647, DateTimeKind.Local).AddTicks(7603));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 21, 20, 48, 41, 647, DateTimeKind.Local).AddTicks(7604));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 21, 20, 48, 41, 647, DateTimeKind.Local).AddTicks(7605));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 21, 20, 48, 41, 647, DateTimeKind.Local).AddTicks(7607));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 14,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 21, 20, 48, 41, 647, DateTimeKind.Local).AddTicks(7608));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 15,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 21, 20, 48, 41, 647, DateTimeKind.Local).AddTicks(7609));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 16,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 21, 20, 48, 41, 647, DateTimeKind.Local).AddTicks(7610));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 17,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 21, 20, 48, 41, 647, DateTimeKind.Local).AddTicks(7611));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 18,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 21, 20, 48, 41, 647, DateTimeKind.Local).AddTicks(7613));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 19,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 21, 20, 48, 41, 647, DateTimeKind.Local).AddTicks(7614));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 20,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 21, 20, 48, 41, 647, DateTimeKind.Local).AddTicks(7615));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 21,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 21, 20, 48, 41, 647, DateTimeKind.Local).AddTicks(7625));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 22,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 21, 20, 48, 41, 647, DateTimeKind.Local).AddTicks(7626));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 23,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 21, 20, 48, 41, 647, DateTimeKind.Local).AddTicks(7628));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 24,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 21, 20, 48, 41, 647, DateTimeKind.Local).AddTicks(7629));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 25,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 21, 20, 48, 41, 647, DateTimeKind.Local).AddTicks(7630));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 26,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 21, 20, 48, 41, 647, DateTimeKind.Local).AddTicks(7632));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 27,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 21, 20, 48, 41, 647, DateTimeKind.Local).AddTicks(7633));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 28,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 21, 20, 48, 41, 647, DateTimeKind.Local).AddTicks(7634));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 29,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 21, 20, 48, 41, 647, DateTimeKind.Local).AddTicks(7636));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 30,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 21, 20, 48, 41, 647, DateTimeKind.Local).AddTicks(7697));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 31,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 21, 20, 48, 41, 647, DateTimeKind.Local).AddTicks(7699));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 32,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 21, 20, 48, 41, 647, DateTimeKind.Local).AddTicks(7700));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 33,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 21, 20, 48, 41, 647, DateTimeKind.Local).AddTicks(7702));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 34,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 21, 20, 48, 41, 647, DateTimeKind.Local).AddTicks(7703));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 35,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 21, 20, 48, 41, 647, DateTimeKind.Local).AddTicks(7704));

            migrationBuilder.UpdateData(
                table: "Branches",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 21, 20, 48, 41, 645, DateTimeKind.Local).AddTicks(2530), new DateTime(2026, 2, 21, 20, 48, 41, 645, DateTimeKind.Local).AddTicks(2607) });

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "LastUpdatedAt", "LicensedValidTill" },
                values: new object[] { new DateTime(2026, 2, 21, 20, 48, 41, 645, DateTimeKind.Local).AddTicks(551), new DateTime(2026, 2, 21, 20, 48, 41, 645, DateTimeKind.Local).AddTicks(635), new DateTime(2026, 8, 20, 20, 48, 41, 645, DateTimeKind.Local).AddTicks(836) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 21, 20, 48, 41, 648, DateTimeKind.Local).AddTicks(4949));

            migrationBuilder.UpdateData(
                table: "FinancialYears",
                keyColumn: "Code",
                keyValue: "2026",
                column: "FinStartDate",
                value: new DateTime(2026, 2, 21, 20, 48, 41, 644, DateTimeKind.Local).AddTicks(5037));

            migrationBuilder.UpdateData(
                table: "UserAuths",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 21, 20, 48, 41, 648, DateTimeKind.Local).AddTicks(6643));

            migrationBuilder.UpdateData(
                table: "UserRole",
                keyColumn: "RoleID",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 21, 20, 48, 41, 647, DateTimeKind.Local).AddTicks(9365), new DateTime(2026, 2, 21, 20, 48, 41, 647, DateTimeKind.Local).AddTicks(9455) });

            migrationBuilder.UpdateData(
                table: "UserRole",
                keyColumn: "RoleID",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 21, 20, 48, 41, 647, DateTimeKind.Local).AddTicks(9524), new DateTime(2026, 2, 21, 20, 48, 41, 647, DateTimeKind.Local).AddTicks(9525) });

            migrationBuilder.CreateIndex(
                name: "IX_PaymentAllocations_PaymentDetailId",
                table: "PaymentAllocations",
                column: "PaymentDetailId");

            migrationBuilder.AddForeignKey(
                name: "FK_PaymentAllocations_paymentsDetail_PaymentDetailId",
                table: "PaymentAllocations",
                column: "PaymentDetailId",
                principalTable: "paymentsDetail",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PaymentAllocations_paymentsDetail_PaymentDetailId",
                table: "PaymentAllocations");

            migrationBuilder.DropIndex(
                name: "IX_PaymentAllocations_PaymentDetailId",
                table: "PaymentAllocations");

            migrationBuilder.DropColumn(
                name: "PaymentDetailId",
                table: "PaymentAllocations");

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 21, 20, 14, 19, 143, DateTimeKind.Local).AddTicks(6070));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 21, 20, 14, 19, 143, DateTimeKind.Local).AddTicks(6856));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 21, 20, 14, 19, 143, DateTimeKind.Local).AddTicks(6858));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 21, 20, 14, 19, 143, DateTimeKind.Local).AddTicks(6860));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 21, 20, 14, 19, 143, DateTimeKind.Local).AddTicks(6861));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 21, 20, 14, 19, 143, DateTimeKind.Local).AddTicks(6862));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 21, 20, 14, 19, 143, DateTimeKind.Local).AddTicks(6926));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 21, 20, 14, 19, 143, DateTimeKind.Local).AddTicks(6927));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 21, 20, 14, 19, 143, DateTimeKind.Local).AddTicks(6929));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 21, 20, 14, 19, 143, DateTimeKind.Local).AddTicks(6938));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 21, 20, 14, 19, 143, DateTimeKind.Local).AddTicks(6939));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 21, 20, 14, 19, 143, DateTimeKind.Local).AddTicks(6941));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 21, 20, 14, 19, 143, DateTimeKind.Local).AddTicks(6942));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 14,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 21, 20, 14, 19, 143, DateTimeKind.Local).AddTicks(6943));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 15,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 21, 20, 14, 19, 143, DateTimeKind.Local).AddTicks(6944));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 16,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 21, 20, 14, 19, 143, DateTimeKind.Local).AddTicks(6946));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 17,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 21, 20, 14, 19, 143, DateTimeKind.Local).AddTicks(6947));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 18,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 21, 20, 14, 19, 143, DateTimeKind.Local).AddTicks(6948));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 19,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 21, 20, 14, 19, 143, DateTimeKind.Local).AddTicks(6949));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 20,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 21, 20, 14, 19, 143, DateTimeKind.Local).AddTicks(6951));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 21,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 21, 20, 14, 19, 143, DateTimeKind.Local).AddTicks(6952));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 22,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 21, 20, 14, 19, 143, DateTimeKind.Local).AddTicks(6953));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 23,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 21, 20, 14, 19, 143, DateTimeKind.Local).AddTicks(6954));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 24,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 21, 20, 14, 19, 143, DateTimeKind.Local).AddTicks(6956));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 25,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 21, 20, 14, 19, 143, DateTimeKind.Local).AddTicks(6957));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 26,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 21, 20, 14, 19, 143, DateTimeKind.Local).AddTicks(6958));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 27,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 21, 20, 14, 19, 143, DateTimeKind.Local).AddTicks(6960));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 28,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 21, 20, 14, 19, 143, DateTimeKind.Local).AddTicks(7031));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 29,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 21, 20, 14, 19, 143, DateTimeKind.Local).AddTicks(7034));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 30,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 21, 20, 14, 19, 143, DateTimeKind.Local).AddTicks(7035));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 31,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 21, 20, 14, 19, 143, DateTimeKind.Local).AddTicks(7036));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 32,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 21, 20, 14, 19, 143, DateTimeKind.Local).AddTicks(7038));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 33,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 21, 20, 14, 19, 143, DateTimeKind.Local).AddTicks(7039));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 34,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 21, 20, 14, 19, 143, DateTimeKind.Local).AddTicks(7040));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 35,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 21, 20, 14, 19, 143, DateTimeKind.Local).AddTicks(7042));

            migrationBuilder.UpdateData(
                table: "Branches",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 21, 20, 14, 19, 141, DateTimeKind.Local).AddTicks(8324), new DateTime(2026, 2, 21, 20, 14, 19, 141, DateTimeKind.Local).AddTicks(8401) });

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "LastUpdatedAt", "LicensedValidTill" },
                values: new object[] { new DateTime(2026, 2, 21, 20, 14, 19, 141, DateTimeKind.Local).AddTicks(6084), new DateTime(2026, 2, 21, 20, 14, 19, 141, DateTimeKind.Local).AddTicks(6168), new DateTime(2026, 8, 20, 20, 14, 19, 141, DateTimeKind.Local).AddTicks(6404) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 21, 20, 14, 19, 144, DateTimeKind.Local).AddTicks(4654));

            migrationBuilder.UpdateData(
                table: "FinancialYears",
                keyColumn: "Code",
                keyValue: "2026",
                column: "FinStartDate",
                value: new DateTime(2026, 2, 21, 20, 14, 19, 140, DateTimeKind.Local).AddTicks(8233));

            migrationBuilder.UpdateData(
                table: "UserAuths",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 21, 20, 14, 19, 144, DateTimeKind.Local).AddTicks(6410));

            migrationBuilder.UpdateData(
                table: "UserRole",
                keyColumn: "RoleID",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 21, 20, 14, 19, 143, DateTimeKind.Local).AddTicks(8794), new DateTime(2026, 2, 21, 20, 14, 19, 143, DateTimeKind.Local).AddTicks(8885) });

            migrationBuilder.UpdateData(
                table: "UserRole",
                keyColumn: "RoleID",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 21, 20, 14, 19, 143, DateTimeKind.Local).AddTicks(8956), new DateTime(2026, 2, 21, 20, 14, 19, 143, DateTimeKind.Local).AddTicks(8957) });
        }
    }
}
