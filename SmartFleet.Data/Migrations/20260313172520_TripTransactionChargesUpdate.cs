using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SmartFleet.Data.Migrations
{
    /// <inheritdoc />
    public partial class TripTransactionChargesUpdate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<decimal>(
                name: "DriverBata",
                table: "TripTransaction",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "FuelCharges",
                table: "TripTransaction",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "InsuranceAmount",
                table: "TripTransaction",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "PackagingCharges",
                table: "TripTransaction",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "TollCharges",
                table: "TripTransaction",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DriverBata",
                table: "TripTransaction");

            migrationBuilder.DropColumn(
                name: "FuelCharges",
                table: "TripTransaction");

            migrationBuilder.DropColumn(
                name: "InsuranceAmount",
                table: "TripTransaction");

            migrationBuilder.DropColumn(
                name: "PackagingCharges",
                table: "TripTransaction");

            migrationBuilder.DropColumn(
                name: "TollCharges",
                table: "TripTransaction");

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2026, 3, 12, 8, 22, 27, 118, DateTimeKind.Local).AddTicks(7850));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2026, 3, 12, 8, 22, 27, 118, DateTimeKind.Local).AddTicks(8604));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2026, 3, 12, 8, 22, 27, 118, DateTimeKind.Local).AddTicks(8606));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2026, 3, 12, 8, 22, 27, 118, DateTimeKind.Local).AddTicks(8608));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2026, 3, 12, 8, 22, 27, 118, DateTimeKind.Local).AddTicks(8609));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2026, 3, 12, 8, 22, 27, 118, DateTimeKind.Local).AddTicks(8611));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2026, 3, 12, 8, 22, 27, 118, DateTimeKind.Local).AddTicks(8743));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2026, 3, 12, 8, 22, 27, 118, DateTimeKind.Local).AddTicks(8745));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2026, 3, 12, 8, 22, 27, 118, DateTimeKind.Local).AddTicks(8746));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2026, 3, 12, 8, 22, 27, 118, DateTimeKind.Local).AddTicks(8747));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2026, 3, 12, 8, 22, 27, 118, DateTimeKind.Local).AddTicks(8749));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2026, 3, 12, 8, 22, 27, 118, DateTimeKind.Local).AddTicks(8750));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2026, 3, 12, 8, 22, 27, 118, DateTimeKind.Local).AddTicks(8751));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 14,
                column: "CreatedAt",
                value: new DateTime(2026, 3, 12, 8, 22, 27, 118, DateTimeKind.Local).AddTicks(8753));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 15,
                column: "CreatedAt",
                value: new DateTime(2026, 3, 12, 8, 22, 27, 118, DateTimeKind.Local).AddTicks(8754));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 16,
                column: "CreatedAt",
                value: new DateTime(2026, 3, 12, 8, 22, 27, 118, DateTimeKind.Local).AddTicks(8755));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 17,
                column: "CreatedAt",
                value: new DateTime(2026, 3, 12, 8, 22, 27, 118, DateTimeKind.Local).AddTicks(8757));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 18,
                column: "CreatedAt",
                value: new DateTime(2026, 3, 12, 8, 22, 27, 118, DateTimeKind.Local).AddTicks(8758));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 19,
                column: "CreatedAt",
                value: new DateTime(2026, 3, 12, 8, 22, 27, 118, DateTimeKind.Local).AddTicks(8760));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 20,
                column: "CreatedAt",
                value: new DateTime(2026, 3, 12, 8, 22, 27, 118, DateTimeKind.Local).AddTicks(8761));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 21,
                column: "CreatedAt",
                value: new DateTime(2026, 3, 12, 8, 22, 27, 118, DateTimeKind.Local).AddTicks(8772));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 22,
                column: "CreatedAt",
                value: new DateTime(2026, 3, 12, 8, 22, 27, 118, DateTimeKind.Local).AddTicks(8773));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 23,
                column: "CreatedAt",
                value: new DateTime(2026, 3, 12, 8, 22, 27, 118, DateTimeKind.Local).AddTicks(8774));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 24,
                column: "CreatedAt",
                value: new DateTime(2026, 3, 12, 8, 22, 27, 118, DateTimeKind.Local).AddTicks(8776));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 25,
                column: "CreatedAt",
                value: new DateTime(2026, 3, 12, 8, 22, 27, 118, DateTimeKind.Local).AddTicks(8777));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 26,
                column: "CreatedAt",
                value: new DateTime(2026, 3, 12, 8, 22, 27, 118, DateTimeKind.Local).AddTicks(8779));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 27,
                column: "CreatedAt",
                value: new DateTime(2026, 3, 12, 8, 22, 27, 118, DateTimeKind.Local).AddTicks(8780));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 28,
                column: "CreatedAt",
                value: new DateTime(2026, 3, 12, 8, 22, 27, 118, DateTimeKind.Local).AddTicks(8782));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 29,
                column: "CreatedAt",
                value: new DateTime(2026, 3, 12, 8, 22, 27, 118, DateTimeKind.Local).AddTicks(8783));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 30,
                column: "CreatedAt",
                value: new DateTime(2026, 3, 12, 8, 22, 27, 118, DateTimeKind.Local).AddTicks(8784));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 31,
                column: "CreatedAt",
                value: new DateTime(2026, 3, 12, 8, 22, 27, 118, DateTimeKind.Local).AddTicks(8786));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 32,
                column: "CreatedAt",
                value: new DateTime(2026, 3, 12, 8, 22, 27, 118, DateTimeKind.Local).AddTicks(8787));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 33,
                column: "CreatedAt",
                value: new DateTime(2026, 3, 12, 8, 22, 27, 118, DateTimeKind.Local).AddTicks(8789));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 34,
                column: "CreatedAt",
                value: new DateTime(2026, 3, 12, 8, 22, 27, 118, DateTimeKind.Local).AddTicks(8790));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 35,
                column: "CreatedAt",
                value: new DateTime(2026, 3, 12, 8, 22, 27, 118, DateTimeKind.Local).AddTicks(8791));

            migrationBuilder.UpdateData(
                table: "Branches",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 3, 12, 8, 22, 27, 116, DateTimeKind.Local).AddTicks(9823), new DateTime(2026, 3, 12, 8, 22, 27, 116, DateTimeKind.Local).AddTicks(9901) });

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "LastUpdatedAt", "LicensedValidTill" },
                values: new object[] { new DateTime(2026, 3, 12, 8, 22, 27, 116, DateTimeKind.Local).AddTicks(7523), new DateTime(2026, 3, 12, 8, 22, 27, 116, DateTimeKind.Local).AddTicks(7611), new DateTime(2026, 9, 8, 8, 22, 27, 116, DateTimeKind.Local).AddTicks(7832) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2026, 3, 12, 8, 22, 27, 119, DateTimeKind.Local).AddTicks(7071));

            migrationBuilder.UpdateData(
                table: "FinancialYears",
                keyColumn: "Code",
                keyValue: "2026",
                column: "FinStartDate",
                value: new DateTime(2026, 3, 12, 8, 22, 27, 116, DateTimeKind.Local).AddTicks(1269));

            migrationBuilder.UpdateData(
                table: "UserAuths",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2026, 3, 12, 8, 22, 27, 119, DateTimeKind.Local).AddTicks(8824));

            migrationBuilder.UpdateData(
                table: "UserRole",
                keyColumn: "RoleID",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 3, 12, 8, 22, 27, 119, DateTimeKind.Local).AddTicks(526), new DateTime(2026, 3, 12, 8, 22, 27, 119, DateTimeKind.Local).AddTicks(620) });

            migrationBuilder.UpdateData(
                table: "UserRole",
                keyColumn: "RoleID",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 3, 12, 8, 22, 27, 119, DateTimeKind.Local).AddTicks(720), new DateTime(2026, 3, 12, 8, 22, 27, 119, DateTimeKind.Local).AddTicks(721) });
        }
    }
}
