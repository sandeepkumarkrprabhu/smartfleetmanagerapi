using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SmartFleet.Data.Migrations
{
    /// <inheritdoc />
    public partial class CdreatedUserTrackingUpdate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Createduser",
                table: "TripTransaction",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedAt",
                table: "Receipts",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "CreatedUser",
                table: "Receipts",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "LastUpdatedAt",
                table: "Receipts",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedAt",
                table: "payments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "CreatedUser",
                table: "payments",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "LastUpdatedAt",
                table: "payments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedAt",
                table: "JournalEntries",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "CreatedUser",
                table: "JournalEntries",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "LastUpdatedAt",
                table: "JournalEntries",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "CreatedUser",
                table: "BillTransaction",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 28, 0, 16, 33, 237, DateTimeKind.Local).AddTicks(4891));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 28, 0, 16, 33, 237, DateTimeKind.Local).AddTicks(7002));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 28, 0, 16, 33, 237, DateTimeKind.Local).AddTicks(7013));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 28, 0, 16, 33, 237, DateTimeKind.Local).AddTicks(7015));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 28, 0, 16, 33, 237, DateTimeKind.Local).AddTicks(7017));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 28, 0, 16, 33, 237, DateTimeKind.Local).AddTicks(7018));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 28, 0, 16, 33, 237, DateTimeKind.Local).AddTicks(7114));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 28, 0, 16, 33, 237, DateTimeKind.Local).AddTicks(7116));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 28, 0, 16, 33, 237, DateTimeKind.Local).AddTicks(7118));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 28, 0, 16, 33, 237, DateTimeKind.Local).AddTicks(7119));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 28, 0, 16, 33, 237, DateTimeKind.Local).AddTicks(7121));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 28, 0, 16, 33, 237, DateTimeKind.Local).AddTicks(7122));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 28, 0, 16, 33, 237, DateTimeKind.Local).AddTicks(7123));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 14,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 28, 0, 16, 33, 237, DateTimeKind.Local).AddTicks(7125));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 15,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 28, 0, 16, 33, 237, DateTimeKind.Local).AddTicks(7126));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 16,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 28, 0, 16, 33, 237, DateTimeKind.Local).AddTicks(7143));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 17,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 28, 0, 16, 33, 237, DateTimeKind.Local).AddTicks(7144));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 18,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 28, 0, 16, 33, 237, DateTimeKind.Local).AddTicks(7146));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 19,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 28, 0, 16, 33, 237, DateTimeKind.Local).AddTicks(7147));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 20,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 28, 0, 16, 33, 237, DateTimeKind.Local).AddTicks(7149));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 21,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 28, 0, 16, 33, 237, DateTimeKind.Local).AddTicks(7150));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 22,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 28, 0, 16, 33, 237, DateTimeKind.Local).AddTicks(7152));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 23,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 28, 0, 16, 33, 237, DateTimeKind.Local).AddTicks(7153));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 24,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 28, 0, 16, 33, 237, DateTimeKind.Local).AddTicks(7155));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 25,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 28, 0, 16, 33, 237, DateTimeKind.Local).AddTicks(7156));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 26,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 28, 0, 16, 33, 237, DateTimeKind.Local).AddTicks(7157));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 27,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 28, 0, 16, 33, 237, DateTimeKind.Local).AddTicks(7159));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 28,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 28, 0, 16, 33, 237, DateTimeKind.Local).AddTicks(7160));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 29,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 28, 0, 16, 33, 237, DateTimeKind.Local).AddTicks(7162));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 30,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 28, 0, 16, 33, 237, DateTimeKind.Local).AddTicks(7211));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 31,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 28, 0, 16, 33, 237, DateTimeKind.Local).AddTicks(7213));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 32,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 28, 0, 16, 33, 237, DateTimeKind.Local).AddTicks(7215));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 33,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 28, 0, 16, 33, 237, DateTimeKind.Local).AddTicks(7216));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 34,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 28, 0, 16, 33, 237, DateTimeKind.Local).AddTicks(7218));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 35,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 28, 0, 16, 33, 237, DateTimeKind.Local).AddTicks(7219));

            migrationBuilder.UpdateData(
                table: "Branches",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 28, 0, 16, 33, 235, DateTimeKind.Local).AddTicks(5525), new DateTime(2026, 2, 28, 0, 16, 33, 235, DateTimeKind.Local).AddTicks(5599) });

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "LastUpdatedAt", "LicensedValidTill" },
                values: new object[] { new DateTime(2026, 2, 28, 0, 16, 33, 235, DateTimeKind.Local).AddTicks(3171), new DateTime(2026, 2, 28, 0, 16, 33, 235, DateTimeKind.Local).AddTicks(3253), new DateTime(2026, 8, 27, 0, 16, 33, 235, DateTimeKind.Local).AddTicks(3456) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 28, 0, 16, 33, 239, DateTimeKind.Local).AddTicks(78));

            migrationBuilder.UpdateData(
                table: "FinancialYears",
                keyColumn: "Code",
                keyValue: "2026",
                column: "FinStartDate",
                value: new DateTime(2026, 2, 28, 0, 16, 33, 234, DateTimeKind.Local).AddTicks(7816));

            migrationBuilder.UpdateData(
                table: "UserAuths",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 28, 0, 16, 33, 239, DateTimeKind.Local).AddTicks(2454));

            migrationBuilder.UpdateData(
                table: "UserRole",
                keyColumn: "RoleID",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 28, 0, 16, 33, 238, DateTimeKind.Local).AddTicks(971), new DateTime(2026, 2, 28, 0, 16, 33, 238, DateTimeKind.Local).AddTicks(1156) });

            migrationBuilder.UpdateData(
                table: "UserRole",
                keyColumn: "RoleID",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 28, 0, 16, 33, 238, DateTimeKind.Local).AddTicks(1267), new DateTime(2026, 2, 28, 0, 16, 33, 238, DateTimeKind.Local).AddTicks(1267) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Createduser",
                table: "TripTransaction");

            migrationBuilder.DropColumn(
                name: "CreatedAt",
                table: "Receipts");

            migrationBuilder.DropColumn(
                name: "CreatedUser",
                table: "Receipts");

            migrationBuilder.DropColumn(
                name: "LastUpdatedAt",
                table: "Receipts");

            migrationBuilder.DropColumn(
                name: "CreatedAt",
                table: "payments");

            migrationBuilder.DropColumn(
                name: "CreatedUser",
                table: "payments");

            migrationBuilder.DropColumn(
                name: "LastUpdatedAt",
                table: "payments");

            migrationBuilder.DropColumn(
                name: "CreatedAt",
                table: "JournalEntries");

            migrationBuilder.DropColumn(
                name: "CreatedUser",
                table: "JournalEntries");

            migrationBuilder.DropColumn(
                name: "LastUpdatedAt",
                table: "JournalEntries");

            migrationBuilder.DropColumn(
                name: "CreatedUser",
                table: "BillTransaction");

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
        }
    }
}
