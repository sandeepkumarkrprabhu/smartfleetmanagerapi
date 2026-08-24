using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SmartFleet.Data.Migrations
{
    /// <inheritdoc />
    public partial class AccounttransactionNavigationUpdate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AccountTransactions_AccountTransactions_AccountTransactionId",
                table: "AccountTransactions");

            migrationBuilder.DropIndex(
                name: "IX_AccountTransactions_AccountTransactionId",
                table: "AccountTransactions");

            migrationBuilder.DropColumn(
                name: "AccountTransactionId",
                table: "AccountTransactions");

            migrationBuilder.AddColumn<string>(
                name: "AccountStatus",
                table: "Receipts",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "AccountTransactionId",
                table: "Receipts",
                type: "int",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2026, 3, 1, 20, 54, 16, 283, DateTimeKind.Local).AddTicks(7144));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2026, 3, 1, 20, 54, 16, 283, DateTimeKind.Local).AddTicks(7921));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2026, 3, 1, 20, 54, 16, 283, DateTimeKind.Local).AddTicks(7924));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2026, 3, 1, 20, 54, 16, 283, DateTimeKind.Local).AddTicks(7934));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2026, 3, 1, 20, 54, 16, 283, DateTimeKind.Local).AddTicks(7935));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2026, 3, 1, 20, 54, 16, 283, DateTimeKind.Local).AddTicks(7937));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2026, 3, 1, 20, 54, 16, 283, DateTimeKind.Local).AddTicks(8006));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2026, 3, 1, 20, 54, 16, 283, DateTimeKind.Local).AddTicks(8008));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2026, 3, 1, 20, 54, 16, 283, DateTimeKind.Local).AddTicks(8009));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2026, 3, 1, 20, 54, 16, 283, DateTimeKind.Local).AddTicks(8011));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2026, 3, 1, 20, 54, 16, 283, DateTimeKind.Local).AddTicks(8012));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2026, 3, 1, 20, 54, 16, 283, DateTimeKind.Local).AddTicks(8013));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2026, 3, 1, 20, 54, 16, 283, DateTimeKind.Local).AddTicks(8015));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 14,
                column: "CreatedAt",
                value: new DateTime(2026, 3, 1, 20, 54, 16, 283, DateTimeKind.Local).AddTicks(8016));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 15,
                column: "CreatedAt",
                value: new DateTime(2026, 3, 1, 20, 54, 16, 283, DateTimeKind.Local).AddTicks(8017));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 16,
                column: "CreatedAt",
                value: new DateTime(2026, 3, 1, 20, 54, 16, 283, DateTimeKind.Local).AddTicks(8019));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 17,
                column: "CreatedAt",
                value: new DateTime(2026, 3, 1, 20, 54, 16, 283, DateTimeKind.Local).AddTicks(8020));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 18,
                column: "CreatedAt",
                value: new DateTime(2026, 3, 1, 20, 54, 16, 283, DateTimeKind.Local).AddTicks(8029));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 19,
                column: "CreatedAt",
                value: new DateTime(2026, 3, 1, 20, 54, 16, 283, DateTimeKind.Local).AddTicks(8030));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 20,
                column: "CreatedAt",
                value: new DateTime(2026, 3, 1, 20, 54, 16, 283, DateTimeKind.Local).AddTicks(8032));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 21,
                column: "CreatedAt",
                value: new DateTime(2026, 3, 1, 20, 54, 16, 283, DateTimeKind.Local).AddTicks(8034));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 22,
                column: "CreatedAt",
                value: new DateTime(2026, 3, 1, 20, 54, 16, 283, DateTimeKind.Local).AddTicks(8035));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 23,
                column: "CreatedAt",
                value: new DateTime(2026, 3, 1, 20, 54, 16, 283, DateTimeKind.Local).AddTicks(8036));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 24,
                column: "CreatedAt",
                value: new DateTime(2026, 3, 1, 20, 54, 16, 283, DateTimeKind.Local).AddTicks(8038));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 25,
                column: "CreatedAt",
                value: new DateTime(2026, 3, 1, 20, 54, 16, 283, DateTimeKind.Local).AddTicks(8039));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 26,
                column: "CreatedAt",
                value: new DateTime(2026, 3, 1, 20, 54, 16, 283, DateTimeKind.Local).AddTicks(8040));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 27,
                column: "CreatedAt",
                value: new DateTime(2026, 3, 1, 20, 54, 16, 283, DateTimeKind.Local).AddTicks(8042));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 28,
                column: "CreatedAt",
                value: new DateTime(2026, 3, 1, 20, 54, 16, 283, DateTimeKind.Local).AddTicks(8043));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 29,
                column: "CreatedAt",
                value: new DateTime(2026, 3, 1, 20, 54, 16, 283, DateTimeKind.Local).AddTicks(8045));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 30,
                column: "CreatedAt",
                value: new DateTime(2026, 3, 1, 20, 54, 16, 283, DateTimeKind.Local).AddTicks(8046));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 31,
                column: "CreatedAt",
                value: new DateTime(2026, 3, 1, 20, 54, 16, 283, DateTimeKind.Local).AddTicks(8047));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 32,
                column: "CreatedAt",
                value: new DateTime(2026, 3, 1, 20, 54, 16, 283, DateTimeKind.Local).AddTicks(8049));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 33,
                column: "CreatedAt",
                value: new DateTime(2026, 3, 1, 20, 54, 16, 283, DateTimeKind.Local).AddTicks(8050));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 34,
                column: "CreatedAt",
                value: new DateTime(2026, 3, 1, 20, 54, 16, 283, DateTimeKind.Local).AddTicks(8052));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 35,
                column: "CreatedAt",
                value: new DateTime(2026, 3, 1, 20, 54, 16, 283, DateTimeKind.Local).AddTicks(8053));

            migrationBuilder.UpdateData(
                table: "Branches",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 3, 1, 20, 54, 16, 282, DateTimeKind.Local).AddTicks(349), new DateTime(2026, 3, 1, 20, 54, 16, 282, DateTimeKind.Local).AddTicks(435) });

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "LastUpdatedAt", "LicensedValidTill" },
                values: new object[] { new DateTime(2026, 3, 1, 20, 54, 16, 281, DateTimeKind.Local).AddTicks(7704), new DateTime(2026, 3, 1, 20, 54, 16, 281, DateTimeKind.Local).AddTicks(7804), new DateTime(2026, 8, 28, 20, 54, 16, 281, DateTimeKind.Local).AddTicks(8026) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2026, 3, 1, 20, 54, 16, 284, DateTimeKind.Local).AddTicks(6282));

            migrationBuilder.UpdateData(
                table: "FinancialYears",
                keyColumn: "Code",
                keyValue: "2026",
                column: "FinStartDate",
                value: new DateTime(2026, 3, 1, 20, 54, 16, 280, DateTimeKind.Local).AddTicks(7736));

            migrationBuilder.UpdateData(
                table: "UserAuths",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2026, 3, 1, 20, 54, 16, 284, DateTimeKind.Local).AddTicks(8026));

            migrationBuilder.UpdateData(
                table: "UserRole",
                keyColumn: "RoleID",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 3, 1, 20, 54, 16, 283, DateTimeKind.Local).AddTicks(9610), new DateTime(2026, 3, 1, 20, 54, 16, 283, DateTimeKind.Local).AddTicks(9704) });

            migrationBuilder.UpdateData(
                table: "UserRole",
                keyColumn: "RoleID",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 3, 1, 20, 54, 16, 283, DateTimeKind.Local).AddTicks(9780), new DateTime(2026, 3, 1, 20, 54, 16, 283, DateTimeKind.Local).AddTicks(9781) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AccountStatus",
                table: "Receipts");

            migrationBuilder.DropColumn(
                name: "AccountTransactionId",
                table: "Receipts");

            migrationBuilder.AddColumn<int>(
                name: "AccountTransactionId",
                table: "AccountTransactions",
                type: "int",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2026, 3, 1, 10, 26, 40, 897, DateTimeKind.Local).AddTicks(5058));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2026, 3, 1, 10, 26, 40, 897, DateTimeKind.Local).AddTicks(8799));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2026, 3, 1, 10, 26, 40, 897, DateTimeKind.Local).AddTicks(8821));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2026, 3, 1, 10, 26, 40, 897, DateTimeKind.Local).AddTicks(8827));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2026, 3, 1, 10, 26, 40, 897, DateTimeKind.Local).AddTicks(8833));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2026, 3, 1, 10, 26, 40, 897, DateTimeKind.Local).AddTicks(8838));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2026, 3, 1, 10, 26, 40, 897, DateTimeKind.Local).AddTicks(9198));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2026, 3, 1, 10, 26, 40, 897, DateTimeKind.Local).AddTicks(9205));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2026, 3, 1, 10, 26, 40, 897, DateTimeKind.Local).AddTicks(9211));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2026, 3, 1, 10, 26, 40, 897, DateTimeKind.Local).AddTicks(9217));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2026, 3, 1, 10, 26, 40, 897, DateTimeKind.Local).AddTicks(9223));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2026, 3, 1, 10, 26, 40, 897, DateTimeKind.Local).AddTicks(9228));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2026, 3, 1, 10, 26, 40, 897, DateTimeKind.Local).AddTicks(9233));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 14,
                column: "CreatedAt",
                value: new DateTime(2026, 3, 1, 10, 26, 40, 897, DateTimeKind.Local).AddTicks(9239));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 15,
                column: "CreatedAt",
                value: new DateTime(2026, 3, 1, 10, 26, 40, 897, DateTimeKind.Local).AddTicks(9244));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 16,
                column: "CreatedAt",
                value: new DateTime(2026, 3, 1, 10, 26, 40, 897, DateTimeKind.Local).AddTicks(9296));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 17,
                column: "CreatedAt",
                value: new DateTime(2026, 3, 1, 10, 26, 40, 897, DateTimeKind.Local).AddTicks(9303));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 18,
                column: "CreatedAt",
                value: new DateTime(2026, 3, 1, 10, 26, 40, 897, DateTimeKind.Local).AddTicks(9309));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 19,
                column: "CreatedAt",
                value: new DateTime(2026, 3, 1, 10, 26, 40, 897, DateTimeKind.Local).AddTicks(9315));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 20,
                column: "CreatedAt",
                value: new DateTime(2026, 3, 1, 10, 26, 40, 897, DateTimeKind.Local).AddTicks(9322));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 21,
                column: "CreatedAt",
                value: new DateTime(2026, 3, 1, 10, 26, 40, 897, DateTimeKind.Local).AddTicks(9328));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 22,
                column: "CreatedAt",
                value: new DateTime(2026, 3, 1, 10, 26, 40, 897, DateTimeKind.Local).AddTicks(9335));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 23,
                column: "CreatedAt",
                value: new DateTime(2026, 3, 1, 10, 26, 40, 897, DateTimeKind.Local).AddTicks(9341));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 24,
                column: "CreatedAt",
                value: new DateTime(2026, 3, 1, 10, 26, 40, 897, DateTimeKind.Local).AddTicks(9347));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 25,
                column: "CreatedAt",
                value: new DateTime(2026, 3, 1, 10, 26, 40, 897, DateTimeKind.Local).AddTicks(9354));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 26,
                column: "CreatedAt",
                value: new DateTime(2026, 3, 1, 10, 26, 40, 897, DateTimeKind.Local).AddTicks(9360));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 27,
                column: "CreatedAt",
                value: new DateTime(2026, 3, 1, 10, 26, 40, 897, DateTimeKind.Local).AddTicks(9365));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 28,
                column: "CreatedAt",
                value: new DateTime(2026, 3, 1, 10, 26, 40, 897, DateTimeKind.Local).AddTicks(9371));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 29,
                column: "CreatedAt",
                value: new DateTime(2026, 3, 1, 10, 26, 40, 897, DateTimeKind.Local).AddTicks(9377));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 30,
                column: "CreatedAt",
                value: new DateTime(2026, 3, 1, 10, 26, 40, 897, DateTimeKind.Local).AddTicks(9383));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 31,
                column: "CreatedAt",
                value: new DateTime(2026, 3, 1, 10, 26, 40, 897, DateTimeKind.Local).AddTicks(9389));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 32,
                column: "CreatedAt",
                value: new DateTime(2026, 3, 1, 10, 26, 40, 897, DateTimeKind.Local).AddTicks(9394));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 33,
                column: "CreatedAt",
                value: new DateTime(2026, 3, 1, 10, 26, 40, 897, DateTimeKind.Local).AddTicks(9400));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 34,
                column: "CreatedAt",
                value: new DateTime(2026, 3, 1, 10, 26, 40, 897, DateTimeKind.Local).AddTicks(9405));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 35,
                column: "CreatedAt",
                value: new DateTime(2026, 3, 1, 10, 26, 40, 897, DateTimeKind.Local).AddTicks(9411));

            migrationBuilder.UpdateData(
                table: "Branches",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 3, 1, 10, 26, 40, 893, DateTimeKind.Local).AddTicks(4998), new DateTime(2026, 3, 1, 10, 26, 40, 893, DateTimeKind.Local).AddTicks(5331) });

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "LastUpdatedAt", "LicensedValidTill" },
                values: new object[] { new DateTime(2026, 3, 1, 10, 26, 40, 892, DateTimeKind.Local).AddTicks(8669), new DateTime(2026, 3, 1, 10, 26, 40, 892, DateTimeKind.Local).AddTicks(8886), new DateTime(2026, 8, 28, 10, 26, 40, 892, DateTimeKind.Local).AddTicks(9183) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2026, 3, 1, 10, 26, 40, 900, DateTimeKind.Local).AddTicks(8350));

            migrationBuilder.UpdateData(
                table: "FinancialYears",
                keyColumn: "Code",
                keyValue: "2026",
                column: "FinStartDate",
                value: new DateTime(2026, 3, 1, 10, 26, 40, 891, DateTimeKind.Local).AddTicks(2351));

            migrationBuilder.UpdateData(
                table: "UserAuths",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2026, 3, 1, 10, 26, 40, 901, DateTimeKind.Local).AddTicks(5998));

            migrationBuilder.UpdateData(
                table: "UserRole",
                keyColumn: "RoleID",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 3, 1, 10, 26, 40, 898, DateTimeKind.Local).AddTicks(8141), new DateTime(2026, 3, 1, 10, 26, 40, 898, DateTimeKind.Local).AddTicks(8601) });

            migrationBuilder.UpdateData(
                table: "UserRole",
                keyColumn: "RoleID",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 3, 1, 10, 26, 40, 898, DateTimeKind.Local).AddTicks(8981), new DateTime(2026, 3, 1, 10, 26, 40, 898, DateTimeKind.Local).AddTicks(8983) });

            migrationBuilder.CreateIndex(
                name: "IX_AccountTransactions_AccountTransactionId",
                table: "AccountTransactions",
                column: "AccountTransactionId");

            migrationBuilder.AddForeignKey(
                name: "FK_AccountTransactions_AccountTransactions_AccountTransactionId",
                table: "AccountTransactions",
                column: "AccountTransactionId",
                principalTable: "AccountTransactions",
                principalColumn: "Id");
        }
    }
}
