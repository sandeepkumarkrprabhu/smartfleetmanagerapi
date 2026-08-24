using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SmartFleet.Data.Migrations
{
    /// <inheritdoc />
    public partial class PaymentTableUpdate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsCancelled",
                table: "payments",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<DateTime>(
                name: "PaymentCreateDate",
                table: "payments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "PaymentUpdateDate",
                table: "payments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<int>(
                name: "paymentNo",
                table: "payments",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 21, 10, 16, 13, 646, DateTimeKind.Local).AddTicks(7835));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 21, 10, 16, 13, 646, DateTimeKind.Local).AddTicks(8510));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 21, 10, 16, 13, 646, DateTimeKind.Local).AddTicks(8513));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 21, 10, 16, 13, 646, DateTimeKind.Local).AddTicks(8515));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 21, 10, 16, 13, 646, DateTimeKind.Local).AddTicks(8516));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 21, 10, 16, 13, 646, DateTimeKind.Local).AddTicks(8517));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 21, 10, 16, 13, 646, DateTimeKind.Local).AddTicks(8580));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 21, 10, 16, 13, 646, DateTimeKind.Local).AddTicks(8582));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 21, 10, 16, 13, 646, DateTimeKind.Local).AddTicks(8583));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 21, 10, 16, 13, 646, DateTimeKind.Local).AddTicks(8592));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 21, 10, 16, 13, 646, DateTimeKind.Local).AddTicks(8593));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 21, 10, 16, 13, 646, DateTimeKind.Local).AddTicks(8595));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 21, 10, 16, 13, 646, DateTimeKind.Local).AddTicks(8596));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 14,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 21, 10, 16, 13, 646, DateTimeKind.Local).AddTicks(8597));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 15,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 21, 10, 16, 13, 646, DateTimeKind.Local).AddTicks(8599));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 16,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 21, 10, 16, 13, 646, DateTimeKind.Local).AddTicks(8600));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 17,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 21, 10, 16, 13, 646, DateTimeKind.Local).AddTicks(8601));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 18,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 21, 10, 16, 13, 646, DateTimeKind.Local).AddTicks(8602));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 19,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 21, 10, 16, 13, 646, DateTimeKind.Local).AddTicks(8604));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 20,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 21, 10, 16, 13, 646, DateTimeKind.Local).AddTicks(8605));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 21,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 21, 10, 16, 13, 646, DateTimeKind.Local).AddTicks(8607));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 22,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 21, 10, 16, 13, 646, DateTimeKind.Local).AddTicks(8608));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 23,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 21, 10, 16, 13, 646, DateTimeKind.Local).AddTicks(8609));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 24,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 21, 10, 16, 13, 646, DateTimeKind.Local).AddTicks(8611));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 25,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 21, 10, 16, 13, 646, DateTimeKind.Local).AddTicks(8612));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 26,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 21, 10, 16, 13, 646, DateTimeKind.Local).AddTicks(8613));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 27,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 21, 10, 16, 13, 646, DateTimeKind.Local).AddTicks(8615));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 28,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 21, 10, 16, 13, 646, DateTimeKind.Local).AddTicks(8616));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 29,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 21, 10, 16, 13, 646, DateTimeKind.Local).AddTicks(8617));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 30,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 21, 10, 16, 13, 646, DateTimeKind.Local).AddTicks(8619));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 31,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 21, 10, 16, 13, 646, DateTimeKind.Local).AddTicks(8620));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 32,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 21, 10, 16, 13, 646, DateTimeKind.Local).AddTicks(8621));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 33,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 21, 10, 16, 13, 646, DateTimeKind.Local).AddTicks(8623));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 34,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 21, 10, 16, 13, 646, DateTimeKind.Local).AddTicks(8624));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 35,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 21, 10, 16, 13, 646, DateTimeKind.Local).AddTicks(8625));

            migrationBuilder.UpdateData(
                table: "Branches",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 21, 10, 16, 13, 645, DateTimeKind.Local).AddTicks(2539), new DateTime(2026, 2, 21, 10, 16, 13, 645, DateTimeKind.Local).AddTicks(2646) });

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "LastUpdatedAt", "LicensedValidTill" },
                values: new object[] { new DateTime(2026, 2, 21, 10, 16, 13, 645, DateTimeKind.Local).AddTicks(187), new DateTime(2026, 2, 21, 10, 16, 13, 645, DateTimeKind.Local).AddTicks(272), new DateTime(2026, 8, 20, 10, 16, 13, 645, DateTimeKind.Local).AddTicks(539) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 21, 10, 16, 13, 647, DateTimeKind.Local).AddTicks(6841));

            migrationBuilder.UpdateData(
                table: "FinancialYears",
                keyColumn: "Code",
                keyValue: "2026",
                column: "FinStartDate",
                value: new DateTime(2026, 2, 21, 10, 16, 13, 644, DateTimeKind.Local).AddTicks(4086));

            migrationBuilder.UpdateData(
                table: "UserAuths",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 21, 10, 16, 13, 647, DateTimeKind.Local).AddTicks(8382));

            migrationBuilder.UpdateData(
                table: "UserRole",
                keyColumn: "RoleID",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 21, 10, 16, 13, 647, DateTimeKind.Local).AddTicks(211), new DateTime(2026, 2, 21, 10, 16, 13, 647, DateTimeKind.Local).AddTicks(297) });

            migrationBuilder.UpdateData(
                table: "UserRole",
                keyColumn: "RoleID",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 21, 10, 16, 13, 647, DateTimeKind.Local).AddTicks(366), new DateTime(2026, 2, 21, 10, 16, 13, 647, DateTimeKind.Local).AddTicks(366) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsCancelled",
                table: "payments");

            migrationBuilder.DropColumn(
                name: "PaymentCreateDate",
                table: "payments");

            migrationBuilder.DropColumn(
                name: "PaymentUpdateDate",
                table: "payments");

            migrationBuilder.DropColumn(
                name: "paymentNo",
                table: "payments");

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 20, 23, 20, 34, 856, DateTimeKind.Local).AddTicks(9192));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 20, 23, 20, 34, 856, DateTimeKind.Local).AddTicks(9874));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 20, 23, 20, 34, 856, DateTimeKind.Local).AddTicks(9876));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 20, 23, 20, 34, 856, DateTimeKind.Local).AddTicks(9878));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 20, 23, 20, 34, 856, DateTimeKind.Local).AddTicks(9879));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 20, 23, 20, 34, 856, DateTimeKind.Local).AddTicks(9881));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 20, 23, 20, 34, 856, DateTimeKind.Local).AddTicks(9953));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 20, 23, 20, 34, 856, DateTimeKind.Local).AddTicks(9955));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 20, 23, 20, 34, 856, DateTimeKind.Local).AddTicks(9956));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 20, 23, 20, 34, 856, DateTimeKind.Local).AddTicks(9957));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 20, 23, 20, 34, 856, DateTimeKind.Local).AddTicks(9998));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 20, 23, 20, 34, 857, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 20, 23, 20, 34, 857, DateTimeKind.Local).AddTicks(1));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 14,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 20, 23, 20, 34, 857, DateTimeKind.Local).AddTicks(2));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 15,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 20, 23, 20, 34, 857, DateTimeKind.Local).AddTicks(4));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 16,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 20, 23, 20, 34, 857, DateTimeKind.Local).AddTicks(5));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 17,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 20, 23, 20, 34, 857, DateTimeKind.Local).AddTicks(6));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 18,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 20, 23, 20, 34, 857, DateTimeKind.Local).AddTicks(8));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 19,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 20, 23, 20, 34, 857, DateTimeKind.Local).AddTicks(9));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 20,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 20, 23, 20, 34, 857, DateTimeKind.Local).AddTicks(10));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 21,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 20, 23, 20, 34, 857, DateTimeKind.Local).AddTicks(19));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 22,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 20, 23, 20, 34, 857, DateTimeKind.Local).AddTicks(20));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 23,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 20, 23, 20, 34, 857, DateTimeKind.Local).AddTicks(21));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 24,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 20, 23, 20, 34, 857, DateTimeKind.Local).AddTicks(23));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 25,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 20, 23, 20, 34, 857, DateTimeKind.Local).AddTicks(24));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 26,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 20, 23, 20, 34, 857, DateTimeKind.Local).AddTicks(25));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 27,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 20, 23, 20, 34, 857, DateTimeKind.Local).AddTicks(27));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 28,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 20, 23, 20, 34, 857, DateTimeKind.Local).AddTicks(28));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 29,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 20, 23, 20, 34, 857, DateTimeKind.Local).AddTicks(29));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 30,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 20, 23, 20, 34, 857, DateTimeKind.Local).AddTicks(30));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 31,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 20, 23, 20, 34, 857, DateTimeKind.Local).AddTicks(32));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 32,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 20, 23, 20, 34, 857, DateTimeKind.Local).AddTicks(33));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 33,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 20, 23, 20, 34, 857, DateTimeKind.Local).AddTicks(35));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 34,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 20, 23, 20, 34, 857, DateTimeKind.Local).AddTicks(36));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 35,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 20, 23, 20, 34, 857, DateTimeKind.Local).AddTicks(37));

            migrationBuilder.UpdateData(
                table: "Branches",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 20, 23, 20, 34, 855, DateTimeKind.Local).AddTicks(300), new DateTime(2026, 2, 20, 23, 20, 34, 855, DateTimeKind.Local).AddTicks(375) });

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "LastUpdatedAt", "LicensedValidTill" },
                values: new object[] { new DateTime(2026, 2, 20, 23, 20, 34, 854, DateTimeKind.Local).AddTicks(8098), new DateTime(2026, 2, 20, 23, 20, 34, 854, DateTimeKind.Local).AddTicks(8182), new DateTime(2026, 8, 19, 23, 20, 34, 854, DateTimeKind.Local).AddTicks(8391) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 20, 23, 20, 34, 858, DateTimeKind.Local).AddTicks(767));

            migrationBuilder.UpdateData(
                table: "FinancialYears",
                keyColumn: "Code",
                keyValue: "2026",
                column: "FinStartDate",
                value: new DateTime(2026, 2, 20, 23, 20, 34, 854, DateTimeKind.Local).AddTicks(1946));

            migrationBuilder.UpdateData(
                table: "UserAuths",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 20, 23, 20, 34, 858, DateTimeKind.Local).AddTicks(3446));

            migrationBuilder.UpdateData(
                table: "UserRole",
                keyColumn: "RoleID",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 20, 23, 20, 34, 857, DateTimeKind.Local).AddTicks(1579), new DateTime(2026, 2, 20, 23, 20, 34, 857, DateTimeKind.Local).AddTicks(1665) });

            migrationBuilder.UpdateData(
                table: "UserRole",
                keyColumn: "RoleID",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 20, 23, 20, 34, 857, DateTimeKind.Local).AddTicks(1733), new DateTime(2026, 2, 20, 23, 20, 34, 857, DateTimeKind.Local).AddTicks(1734) });
        }
    }
}
