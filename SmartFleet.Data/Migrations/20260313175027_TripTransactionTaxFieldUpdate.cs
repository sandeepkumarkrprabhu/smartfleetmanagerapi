using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SmartFleet.Data.Migrations
{
    /// <inheritdoc />
    public partial class TripTransactionTaxFieldUpdate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<decimal>(
                name: "CGSTAmount",
                table: "TripTransaction",
                type: "decimal(18,2)",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "IGSTAmount",
                table: "TripTransaction",
                type: "decimal(18,2)",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "SGSTAmount",
                table: "TripTransaction",
                type: "decimal(18,2)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "TaxId",
                table: "TripTransaction",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "TaxPercentage",
                table: "TripTransaction",
                type: "decimal(18,2)",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "finalAmount",
                table: "TripTransaction",
                type: "decimal(18,2)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2026, 3, 13, 23, 20, 26, 489, DateTimeKind.Local).AddTicks(4125));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2026, 3, 13, 23, 20, 26, 489, DateTimeKind.Local).AddTicks(4869));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2026, 3, 13, 23, 20, 26, 489, DateTimeKind.Local).AddTicks(4871));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2026, 3, 13, 23, 20, 26, 489, DateTimeKind.Local).AddTicks(4873));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2026, 3, 13, 23, 20, 26, 489, DateTimeKind.Local).AddTicks(4874));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2026, 3, 13, 23, 20, 26, 489, DateTimeKind.Local).AddTicks(4876));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2026, 3, 13, 23, 20, 26, 489, DateTimeKind.Local).AddTicks(4943));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2026, 3, 13, 23, 20, 26, 489, DateTimeKind.Local).AddTicks(4945));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2026, 3, 13, 23, 20, 26, 489, DateTimeKind.Local).AddTicks(5004));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2026, 3, 13, 23, 20, 26, 489, DateTimeKind.Local).AddTicks(5006));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2026, 3, 13, 23, 20, 26, 489, DateTimeKind.Local).AddTicks(5007));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2026, 3, 13, 23, 20, 26, 489, DateTimeKind.Local).AddTicks(5009));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2026, 3, 13, 23, 20, 26, 489, DateTimeKind.Local).AddTicks(5010));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 14,
                column: "CreatedAt",
                value: new DateTime(2026, 3, 13, 23, 20, 26, 489, DateTimeKind.Local).AddTicks(5012));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 15,
                column: "CreatedAt",
                value: new DateTime(2026, 3, 13, 23, 20, 26, 489, DateTimeKind.Local).AddTicks(5013));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 16,
                column: "CreatedAt",
                value: new DateTime(2026, 3, 13, 23, 20, 26, 489, DateTimeKind.Local).AddTicks(5022));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 17,
                column: "CreatedAt",
                value: new DateTime(2026, 3, 13, 23, 20, 26, 489, DateTimeKind.Local).AddTicks(5024));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 18,
                column: "CreatedAt",
                value: new DateTime(2026, 3, 13, 23, 20, 26, 489, DateTimeKind.Local).AddTicks(5025));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 19,
                column: "CreatedAt",
                value: new DateTime(2026, 3, 13, 23, 20, 26, 489, DateTimeKind.Local).AddTicks(5027));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 20,
                column: "CreatedAt",
                value: new DateTime(2026, 3, 13, 23, 20, 26, 489, DateTimeKind.Local).AddTicks(5028));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 21,
                column: "CreatedAt",
                value: new DateTime(2026, 3, 13, 23, 20, 26, 489, DateTimeKind.Local).AddTicks(5029));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 22,
                column: "CreatedAt",
                value: new DateTime(2026, 3, 13, 23, 20, 26, 489, DateTimeKind.Local).AddTicks(5031));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 23,
                column: "CreatedAt",
                value: new DateTime(2026, 3, 13, 23, 20, 26, 489, DateTimeKind.Local).AddTicks(5032));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 24,
                column: "CreatedAt",
                value: new DateTime(2026, 3, 13, 23, 20, 26, 489, DateTimeKind.Local).AddTicks(5034));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 25,
                column: "CreatedAt",
                value: new DateTime(2026, 3, 13, 23, 20, 26, 489, DateTimeKind.Local).AddTicks(5035));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 26,
                column: "CreatedAt",
                value: new DateTime(2026, 3, 13, 23, 20, 26, 489, DateTimeKind.Local).AddTicks(5036));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 27,
                column: "CreatedAt",
                value: new DateTime(2026, 3, 13, 23, 20, 26, 489, DateTimeKind.Local).AddTicks(5038));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 28,
                column: "CreatedAt",
                value: new DateTime(2026, 3, 13, 23, 20, 26, 489, DateTimeKind.Local).AddTicks(5039));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 29,
                column: "CreatedAt",
                value: new DateTime(2026, 3, 13, 23, 20, 26, 489, DateTimeKind.Local).AddTicks(5041));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 30,
                column: "CreatedAt",
                value: new DateTime(2026, 3, 13, 23, 20, 26, 489, DateTimeKind.Local).AddTicks(5042));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 31,
                column: "CreatedAt",
                value: new DateTime(2026, 3, 13, 23, 20, 26, 489, DateTimeKind.Local).AddTicks(5044));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 32,
                column: "CreatedAt",
                value: new DateTime(2026, 3, 13, 23, 20, 26, 489, DateTimeKind.Local).AddTicks(5045));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 33,
                column: "CreatedAt",
                value: new DateTime(2026, 3, 13, 23, 20, 26, 489, DateTimeKind.Local).AddTicks(5046));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 34,
                column: "CreatedAt",
                value: new DateTime(2026, 3, 13, 23, 20, 26, 489, DateTimeKind.Local).AddTicks(5048));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 35,
                column: "CreatedAt",
                value: new DateTime(2026, 3, 13, 23, 20, 26, 489, DateTimeKind.Local).AddTicks(5049));

            migrationBuilder.UpdateData(
                table: "Branches",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 3, 13, 23, 20, 26, 487, DateTimeKind.Local).AddTicks(3523), new DateTime(2026, 3, 13, 23, 20, 26, 487, DateTimeKind.Local).AddTicks(3607) });

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "LastUpdatedAt", "LicensedValidTill" },
                values: new object[] { new DateTime(2026, 3, 13, 23, 20, 26, 487, DateTimeKind.Local).AddTicks(1378), new DateTime(2026, 3, 13, 23, 20, 26, 487, DateTimeKind.Local).AddTicks(1462), new DateTime(2026, 9, 9, 23, 20, 26, 487, DateTimeKind.Local).AddTicks(1667) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2026, 3, 13, 23, 20, 26, 490, DateTimeKind.Local).AddTicks(3402));

            migrationBuilder.UpdateData(
                table: "FinancialYears",
                keyColumn: "Code",
                keyValue: "2026",
                column: "FinStartDate",
                value: new DateTime(2026, 3, 13, 23, 20, 26, 486, DateTimeKind.Local).AddTicks(5044));

            migrationBuilder.UpdateData(
                table: "UserAuths",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2026, 3, 13, 23, 20, 26, 491, DateTimeKind.Local).AddTicks(854));

            migrationBuilder.UpdateData(
                table: "UserRole",
                keyColumn: "RoleID",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 3, 13, 23, 20, 26, 489, DateTimeKind.Local).AddTicks(6696), new DateTime(2026, 3, 13, 23, 20, 26, 489, DateTimeKind.Local).AddTicks(6787) });

            migrationBuilder.UpdateData(
                table: "UserRole",
                keyColumn: "RoleID",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 3, 13, 23, 20, 26, 489, DateTimeKind.Local).AddTicks(6859), new DateTime(2026, 3, 13, 23, 20, 26, 489, DateTimeKind.Local).AddTicks(6860) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CGSTAmount",
                table: "TripTransaction");

            migrationBuilder.DropColumn(
                name: "IGSTAmount",
                table: "TripTransaction");

            migrationBuilder.DropColumn(
                name: "SGSTAmount",
                table: "TripTransaction");

            migrationBuilder.DropColumn(
                name: "TaxId",
                table: "TripTransaction");

            migrationBuilder.DropColumn(
                name: "TaxPercentage",
                table: "TripTransaction");

            migrationBuilder.DropColumn(
                name: "finalAmount",
                table: "TripTransaction");

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2026, 3, 13, 22, 55, 16, 769, DateTimeKind.Local).AddTicks(5176));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2026, 3, 13, 22, 55, 16, 769, DateTimeKind.Local).AddTicks(5928));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2026, 3, 13, 22, 55, 16, 769, DateTimeKind.Local).AddTicks(5931));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2026, 3, 13, 22, 55, 16, 769, DateTimeKind.Local).AddTicks(5932));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2026, 3, 13, 22, 55, 16, 769, DateTimeKind.Local).AddTicks(5934));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2026, 3, 13, 22, 55, 16, 769, DateTimeKind.Local).AddTicks(5935));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2026, 3, 13, 22, 55, 16, 769, DateTimeKind.Local).AddTicks(6008));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2026, 3, 13, 22, 55, 16, 769, DateTimeKind.Local).AddTicks(6010));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2026, 3, 13, 22, 55, 16, 769, DateTimeKind.Local).AddTicks(6011));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2026, 3, 13, 22, 55, 16, 769, DateTimeKind.Local).AddTicks(6012));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2026, 3, 13, 22, 55, 16, 769, DateTimeKind.Local).AddTicks(6014));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2026, 3, 13, 22, 55, 16, 769, DateTimeKind.Local).AddTicks(6015));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2026, 3, 13, 22, 55, 16, 769, DateTimeKind.Local).AddTicks(6101));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 14,
                column: "CreatedAt",
                value: new DateTime(2026, 3, 13, 22, 55, 16, 769, DateTimeKind.Local).AddTicks(6103));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 15,
                column: "CreatedAt",
                value: new DateTime(2026, 3, 13, 22, 55, 16, 769, DateTimeKind.Local).AddTicks(6104));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 16,
                column: "CreatedAt",
                value: new DateTime(2026, 3, 13, 22, 55, 16, 769, DateTimeKind.Local).AddTicks(6105));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 17,
                column: "CreatedAt",
                value: new DateTime(2026, 3, 13, 22, 55, 16, 769, DateTimeKind.Local).AddTicks(6106));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 18,
                column: "CreatedAt",
                value: new DateTime(2026, 3, 13, 22, 55, 16, 769, DateTimeKind.Local).AddTicks(6108));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 19,
                column: "CreatedAt",
                value: new DateTime(2026, 3, 13, 22, 55, 16, 769, DateTimeKind.Local).AddTicks(6109));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 20,
                column: "CreatedAt",
                value: new DateTime(2026, 3, 13, 22, 55, 16, 769, DateTimeKind.Local).AddTicks(6111));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 21,
                column: "CreatedAt",
                value: new DateTime(2026, 3, 13, 22, 55, 16, 769, DateTimeKind.Local).AddTicks(6123));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 22,
                column: "CreatedAt",
                value: new DateTime(2026, 3, 13, 22, 55, 16, 769, DateTimeKind.Local).AddTicks(6125));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 23,
                column: "CreatedAt",
                value: new DateTime(2026, 3, 13, 22, 55, 16, 769, DateTimeKind.Local).AddTicks(6126));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 24,
                column: "CreatedAt",
                value: new DateTime(2026, 3, 13, 22, 55, 16, 769, DateTimeKind.Local).AddTicks(6127));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 25,
                column: "CreatedAt",
                value: new DateTime(2026, 3, 13, 22, 55, 16, 769, DateTimeKind.Local).AddTicks(6129));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 26,
                column: "CreatedAt",
                value: new DateTime(2026, 3, 13, 22, 55, 16, 769, DateTimeKind.Local).AddTicks(6130));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 27,
                column: "CreatedAt",
                value: new DateTime(2026, 3, 13, 22, 55, 16, 769, DateTimeKind.Local).AddTicks(6131));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 28,
                column: "CreatedAt",
                value: new DateTime(2026, 3, 13, 22, 55, 16, 769, DateTimeKind.Local).AddTicks(6133));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 29,
                column: "CreatedAt",
                value: new DateTime(2026, 3, 13, 22, 55, 16, 769, DateTimeKind.Local).AddTicks(6134));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 30,
                column: "CreatedAt",
                value: new DateTime(2026, 3, 13, 22, 55, 16, 769, DateTimeKind.Local).AddTicks(6135));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 31,
                column: "CreatedAt",
                value: new DateTime(2026, 3, 13, 22, 55, 16, 769, DateTimeKind.Local).AddTicks(6137));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 32,
                column: "CreatedAt",
                value: new DateTime(2026, 3, 13, 22, 55, 16, 769, DateTimeKind.Local).AddTicks(6138));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 33,
                column: "CreatedAt",
                value: new DateTime(2026, 3, 13, 22, 55, 16, 769, DateTimeKind.Local).AddTicks(6139));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 34,
                column: "CreatedAt",
                value: new DateTime(2026, 3, 13, 22, 55, 16, 769, DateTimeKind.Local).AddTicks(6141));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 35,
                column: "CreatedAt",
                value: new DateTime(2026, 3, 13, 22, 55, 16, 769, DateTimeKind.Local).AddTicks(6142));

            migrationBuilder.UpdateData(
                table: "Branches",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 3, 13, 22, 55, 16, 767, DateTimeKind.Local).AddTicks(9518), new DateTime(2026, 3, 13, 22, 55, 16, 767, DateTimeKind.Local).AddTicks(9604) });

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "LastUpdatedAt", "LicensedValidTill" },
                values: new object[] { new DateTime(2026, 3, 13, 22, 55, 16, 767, DateTimeKind.Local).AddTicks(5712), new DateTime(2026, 3, 13, 22, 55, 16, 767, DateTimeKind.Local).AddTicks(5795), new DateTime(2026, 9, 9, 22, 55, 16, 767, DateTimeKind.Local).AddTicks(5999) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2026, 3, 13, 22, 55, 16, 770, DateTimeKind.Local).AddTicks(4126));

            migrationBuilder.UpdateData(
                table: "FinancialYears",
                keyColumn: "Code",
                keyValue: "2026",
                column: "FinStartDate",
                value: new DateTime(2026, 3, 13, 22, 55, 16, 766, DateTimeKind.Local).AddTicks(9540));

            migrationBuilder.UpdateData(
                table: "UserAuths",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2026, 3, 13, 22, 55, 16, 770, DateTimeKind.Local).AddTicks(5685));

            migrationBuilder.UpdateData(
                table: "UserRole",
                keyColumn: "RoleID",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 3, 13, 22, 55, 16, 769, DateTimeKind.Local).AddTicks(7817), new DateTime(2026, 3, 13, 22, 55, 16, 769, DateTimeKind.Local).AddTicks(7911) });

            migrationBuilder.UpdateData(
                table: "UserRole",
                keyColumn: "RoleID",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 3, 13, 22, 55, 16, 769, DateTimeKind.Local).AddTicks(8001), new DateTime(2026, 3, 13, 22, 55, 16, 769, DateTimeKind.Local).AddTicks(8001) });
        }
    }
}
