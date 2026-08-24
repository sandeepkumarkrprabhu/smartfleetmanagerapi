using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SmartFleet.Data.Migrations
{
    /// <inheritdoc />
    public partial class TripTransactionReceiptStatusUpdate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsReceiptReceived",
                table: "TripTransaction",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 5, 21, 22, 40, 741, DateTimeKind.Local).AddTicks(4083));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 5, 21, 22, 40, 741, DateTimeKind.Local).AddTicks(4953));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 5, 21, 22, 40, 741, DateTimeKind.Local).AddTicks(4965));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 5, 21, 22, 40, 741, DateTimeKind.Local).AddTicks(4967));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 5, 21, 22, 40, 741, DateTimeKind.Local).AddTicks(4968));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 5, 21, 22, 40, 741, DateTimeKind.Local).AddTicks(4970));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 5, 21, 22, 40, 741, DateTimeKind.Local).AddTicks(5039));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 5, 21, 22, 40, 741, DateTimeKind.Local).AddTicks(5040));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 5, 21, 22, 40, 741, DateTimeKind.Local).AddTicks(5042));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 5, 21, 22, 40, 741, DateTimeKind.Local).AddTicks(5043));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 5, 21, 22, 40, 741, DateTimeKind.Local).AddTicks(5044));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 5, 21, 22, 40, 741, DateTimeKind.Local).AddTicks(5046));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 5, 21, 22, 40, 741, DateTimeKind.Local).AddTicks(5047));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 14,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 5, 21, 22, 40, 741, DateTimeKind.Local).AddTicks(5048));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 15,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 5, 21, 22, 40, 741, DateTimeKind.Local).AddTicks(5050));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 16,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 5, 21, 22, 40, 741, DateTimeKind.Local).AddTicks(5051));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 17,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 5, 21, 22, 40, 741, DateTimeKind.Local).AddTicks(5052));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 18,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 5, 21, 22, 40, 741, DateTimeKind.Local).AddTicks(5062));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 19,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 5, 21, 22, 40, 741, DateTimeKind.Local).AddTicks(5063));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 20,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 5, 21, 22, 40, 741, DateTimeKind.Local).AddTicks(5065));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 21,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 5, 21, 22, 40, 741, DateTimeKind.Local).AddTicks(5066));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 22,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 5, 21, 22, 40, 741, DateTimeKind.Local).AddTicks(5067));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 23,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 5, 21, 22, 40, 741, DateTimeKind.Local).AddTicks(5069));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 24,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 5, 21, 22, 40, 741, DateTimeKind.Local).AddTicks(5070));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 25,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 5, 21, 22, 40, 741, DateTimeKind.Local).AddTicks(5072));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 26,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 5, 21, 22, 40, 741, DateTimeKind.Local).AddTicks(5073));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 27,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 5, 21, 22, 40, 741, DateTimeKind.Local).AddTicks(5075));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 28,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 5, 21, 22, 40, 741, DateTimeKind.Local).AddTicks(5142));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 29,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 5, 21, 22, 40, 741, DateTimeKind.Local).AddTicks(5144));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 30,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 5, 21, 22, 40, 741, DateTimeKind.Local).AddTicks(5145));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 31,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 5, 21, 22, 40, 741, DateTimeKind.Local).AddTicks(5147));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 32,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 5, 21, 22, 40, 741, DateTimeKind.Local).AddTicks(5148));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 33,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 5, 21, 22, 40, 741, DateTimeKind.Local).AddTicks(5150));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 34,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 5, 21, 22, 40, 741, DateTimeKind.Local).AddTicks(5151));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 35,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 5, 21, 22, 40, 741, DateTimeKind.Local).AddTicks(5152));

            migrationBuilder.UpdateData(
                table: "Branches",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 5, 21, 22, 40, 739, DateTimeKind.Local).AddTicks(3648), new DateTime(2026, 2, 5, 21, 22, 40, 739, DateTimeKind.Local).AddTicks(3738) });

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "LastUpdatedAt", "LicensedValidTill" },
                values: new object[] { new DateTime(2026, 2, 5, 21, 22, 40, 739, DateTimeKind.Local).AddTicks(1474), new DateTime(2026, 2, 5, 21, 22, 40, 739, DateTimeKind.Local).AddTicks(1572), new DateTime(2026, 8, 4, 21, 22, 40, 739, DateTimeKind.Local).AddTicks(1774) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 5, 21, 22, 40, 742, DateTimeKind.Local).AddTicks(5069));

            migrationBuilder.UpdateData(
                table: "FinancialYears",
                keyColumn: "Code",
                keyValue: "2026",
                column: "FinStartDate",
                value: new DateTime(2026, 2, 5, 21, 22, 40, 738, DateTimeKind.Local).AddTicks(5790));

            migrationBuilder.UpdateData(
                table: "UserAuths",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 5, 21, 22, 40, 742, DateTimeKind.Local).AddTicks(6954));

            migrationBuilder.UpdateData(
                table: "UserRole",
                keyColumn: "RoleID",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 5, 21, 22, 40, 741, DateTimeKind.Local).AddTicks(7460), new DateTime(2026, 2, 5, 21, 22, 40, 741, DateTimeKind.Local).AddTicks(7570) });

            migrationBuilder.UpdateData(
                table: "UserRole",
                keyColumn: "RoleID",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 5, 21, 22, 40, 741, DateTimeKind.Local).AddTicks(7643), new DateTime(2026, 2, 5, 21, 22, 40, 741, DateTimeKind.Local).AddTicks(7644) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsReceiptReceived",
                table: "TripTransaction");

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 1, 9, 6, 45, 491, DateTimeKind.Local).AddTicks(4953));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 1, 9, 6, 45, 491, DateTimeKind.Local).AddTicks(6227));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 1, 9, 6, 45, 491, DateTimeKind.Local).AddTicks(6232));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 1, 9, 6, 45, 491, DateTimeKind.Local).AddTicks(6234));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 1, 9, 6, 45, 491, DateTimeKind.Local).AddTicks(6236));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 1, 9, 6, 45, 491, DateTimeKind.Local).AddTicks(6238));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 1, 9, 6, 45, 491, DateTimeKind.Local).AddTicks(6347));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 1, 9, 6, 45, 491, DateTimeKind.Local).AddTicks(6350));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 1, 9, 6, 45, 491, DateTimeKind.Local).AddTicks(6352));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 1, 9, 6, 45, 491, DateTimeKind.Local).AddTicks(6353));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 1, 9, 6, 45, 491, DateTimeKind.Local).AddTicks(6366));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 1, 9, 6, 45, 491, DateTimeKind.Local).AddTicks(6368));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 1, 9, 6, 45, 491, DateTimeKind.Local).AddTicks(6370));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 14,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 1, 9, 6, 45, 491, DateTimeKind.Local).AddTicks(6371));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 15,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 1, 9, 6, 45, 491, DateTimeKind.Local).AddTicks(6373));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 16,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 1, 9, 6, 45, 491, DateTimeKind.Local).AddTicks(6375));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 17,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 1, 9, 6, 45, 491, DateTimeKind.Local).AddTicks(6376));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 18,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 1, 9, 6, 45, 491, DateTimeKind.Local).AddTicks(6378));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 19,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 1, 9, 6, 45, 491, DateTimeKind.Local).AddTicks(6380));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 20,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 1, 9, 6, 45, 491, DateTimeKind.Local).AddTicks(6382));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 21,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 1, 9, 6, 45, 491, DateTimeKind.Local).AddTicks(6383));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 22,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 1, 9, 6, 45, 491, DateTimeKind.Local).AddTicks(6385));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 23,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 1, 9, 6, 45, 491, DateTimeKind.Local).AddTicks(6387));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 24,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 1, 9, 6, 45, 491, DateTimeKind.Local).AddTicks(6388));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 25,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 1, 9, 6, 45, 491, DateTimeKind.Local).AddTicks(6390));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 26,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 1, 9, 6, 45, 491, DateTimeKind.Local).AddTicks(6392));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 27,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 1, 9, 6, 45, 491, DateTimeKind.Local).AddTicks(6394));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 28,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 1, 9, 6, 45, 491, DateTimeKind.Local).AddTicks(6396));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 29,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 1, 9, 6, 45, 491, DateTimeKind.Local).AddTicks(6397));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 30,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 1, 9, 6, 45, 491, DateTimeKind.Local).AddTicks(6399));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 31,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 1, 9, 6, 45, 491, DateTimeKind.Local).AddTicks(6401));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 32,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 1, 9, 6, 45, 491, DateTimeKind.Local).AddTicks(6402));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 33,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 1, 9, 6, 45, 491, DateTimeKind.Local).AddTicks(6404));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 34,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 1, 9, 6, 45, 491, DateTimeKind.Local).AddTicks(6406));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 35,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 1, 9, 6, 45, 491, DateTimeKind.Local).AddTicks(6472));

            migrationBuilder.UpdateData(
                table: "Branches",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 1, 9, 6, 45, 489, DateTimeKind.Local).AddTicks(1888), new DateTime(2026, 2, 1, 9, 6, 45, 489, DateTimeKind.Local).AddTicks(1980) });

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "LastUpdatedAt", "LicensedValidTill" },
                values: new object[] { new DateTime(2026, 2, 1, 9, 6, 45, 488, DateTimeKind.Local).AddTicks(9558), new DateTime(2026, 2, 1, 9, 6, 45, 488, DateTimeKind.Local).AddTicks(9647), new DateTime(2026, 7, 31, 9, 6, 45, 488, DateTimeKind.Local).AddTicks(9866) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 1, 9, 6, 45, 492, DateTimeKind.Local).AddTicks(8088));

            migrationBuilder.UpdateData(
                table: "FinancialYears",
                keyColumn: "Code",
                keyValue: "2026",
                column: "FinStartDate",
                value: new DateTime(2026, 2, 1, 9, 6, 45, 488, DateTimeKind.Local).AddTicks(3915));

            migrationBuilder.UpdateData(
                table: "UserAuths",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 1, 9, 6, 45, 493, DateTimeKind.Local).AddTicks(649));

            migrationBuilder.UpdateData(
                table: "UserRole",
                keyColumn: "RoleID",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 1, 9, 6, 45, 491, DateTimeKind.Local).AddTicks(9006), new DateTime(2026, 2, 1, 9, 6, 45, 491, DateTimeKind.Local).AddTicks(9143) });

            migrationBuilder.UpdateData(
                table: "UserRole",
                keyColumn: "RoleID",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 1, 9, 6, 45, 491, DateTimeKind.Local).AddTicks(9257), new DateTime(2026, 2, 1, 9, 6, 45, 491, DateTimeKind.Local).AddTicks(9258) });
        }
    }
}
