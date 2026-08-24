using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SmartFleet.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddAccountTransactionnavigationUpdate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "JournalType",
                table: "JournalEntries",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2026, 3, 4, 18, 25, 3, 284, DateTimeKind.Local).AddTicks(8279));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2026, 3, 4, 18, 25, 3, 284, DateTimeKind.Local).AddTicks(9056));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2026, 3, 4, 18, 25, 3, 284, DateTimeKind.Local).AddTicks(9059));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2026, 3, 4, 18, 25, 3, 284, DateTimeKind.Local).AddTicks(9061));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2026, 3, 4, 18, 25, 3, 284, DateTimeKind.Local).AddTicks(9062));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2026, 3, 4, 18, 25, 3, 284, DateTimeKind.Local).AddTicks(9063));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2026, 3, 4, 18, 25, 3, 284, DateTimeKind.Local).AddTicks(9129));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2026, 3, 4, 18, 25, 3, 284, DateTimeKind.Local).AddTicks(9131));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2026, 3, 4, 18, 25, 3, 284, DateTimeKind.Local).AddTicks(9132));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2026, 3, 4, 18, 25, 3, 284, DateTimeKind.Local).AddTicks(9134));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2026, 3, 4, 18, 25, 3, 284, DateTimeKind.Local).AddTicks(9135));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2026, 3, 4, 18, 25, 3, 284, DateTimeKind.Local).AddTicks(9144));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2026, 3, 4, 18, 25, 3, 284, DateTimeKind.Local).AddTicks(9145));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 14,
                column: "CreatedAt",
                value: new DateTime(2026, 3, 4, 18, 25, 3, 284, DateTimeKind.Local).AddTicks(9147));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 15,
                column: "CreatedAt",
                value: new DateTime(2026, 3, 4, 18, 25, 3, 284, DateTimeKind.Local).AddTicks(9148));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 16,
                column: "CreatedAt",
                value: new DateTime(2026, 3, 4, 18, 25, 3, 284, DateTimeKind.Local).AddTicks(9149));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 17,
                column: "CreatedAt",
                value: new DateTime(2026, 3, 4, 18, 25, 3, 284, DateTimeKind.Local).AddTicks(9150));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 18,
                column: "CreatedAt",
                value: new DateTime(2026, 3, 4, 18, 25, 3, 284, DateTimeKind.Local).AddTicks(9152));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 19,
                column: "CreatedAt",
                value: new DateTime(2026, 3, 4, 18, 25, 3, 284, DateTimeKind.Local).AddTicks(9153));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 20,
                column: "CreatedAt",
                value: new DateTime(2026, 3, 4, 18, 25, 3, 284, DateTimeKind.Local).AddTicks(9154));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 21,
                column: "CreatedAt",
                value: new DateTime(2026, 3, 4, 18, 25, 3, 284, DateTimeKind.Local).AddTicks(9156));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 22,
                column: "CreatedAt",
                value: new DateTime(2026, 3, 4, 18, 25, 3, 284, DateTimeKind.Local).AddTicks(9157));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 23,
                column: "CreatedAt",
                value: new DateTime(2026, 3, 4, 18, 25, 3, 284, DateTimeKind.Local).AddTicks(9158));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 24,
                column: "CreatedAt",
                value: new DateTime(2026, 3, 4, 18, 25, 3, 284, DateTimeKind.Local).AddTicks(9159));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 25,
                column: "CreatedAt",
                value: new DateTime(2026, 3, 4, 18, 25, 3, 284, DateTimeKind.Local).AddTicks(9161));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 26,
                column: "CreatedAt",
                value: new DateTime(2026, 3, 4, 18, 25, 3, 284, DateTimeKind.Local).AddTicks(9162));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 27,
                column: "CreatedAt",
                value: new DateTime(2026, 3, 4, 18, 25, 3, 284, DateTimeKind.Local).AddTicks(9163));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 28,
                column: "CreatedAt",
                value: new DateTime(2026, 3, 4, 18, 25, 3, 284, DateTimeKind.Local).AddTicks(9165));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 29,
                column: "CreatedAt",
                value: new DateTime(2026, 3, 4, 18, 25, 3, 284, DateTimeKind.Local).AddTicks(9166));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 30,
                column: "CreatedAt",
                value: new DateTime(2026, 3, 4, 18, 25, 3, 284, DateTimeKind.Local).AddTicks(9167));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 31,
                column: "CreatedAt",
                value: new DateTime(2026, 3, 4, 18, 25, 3, 284, DateTimeKind.Local).AddTicks(9169));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 32,
                column: "CreatedAt",
                value: new DateTime(2026, 3, 4, 18, 25, 3, 284, DateTimeKind.Local).AddTicks(9170));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 33,
                column: "CreatedAt",
                value: new DateTime(2026, 3, 4, 18, 25, 3, 284, DateTimeKind.Local).AddTicks(9171));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 34,
                column: "CreatedAt",
                value: new DateTime(2026, 3, 4, 18, 25, 3, 284, DateTimeKind.Local).AddTicks(9173));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 35,
                column: "CreatedAt",
                value: new DateTime(2026, 3, 4, 18, 25, 3, 284, DateTimeKind.Local).AddTicks(9174));

            migrationBuilder.UpdateData(
                table: "Branches",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 3, 4, 18, 25, 3, 283, DateTimeKind.Local).AddTicks(2133), new DateTime(2026, 3, 4, 18, 25, 3, 283, DateTimeKind.Local).AddTicks(2217) });

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "LastUpdatedAt", "LicensedValidTill" },
                values: new object[] { new DateTime(2026, 3, 4, 18, 25, 3, 282, DateTimeKind.Local).AddTicks(9965), new DateTime(2026, 3, 4, 18, 25, 3, 283, DateTimeKind.Local).AddTicks(55), new DateTime(2026, 8, 31, 18, 25, 3, 283, DateTimeKind.Local).AddTicks(351) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2026, 3, 4, 18, 25, 3, 285, DateTimeKind.Local).AddTicks(6487));

            migrationBuilder.UpdateData(
                table: "FinancialYears",
                keyColumn: "Code",
                keyValue: "2026",
                column: "FinStartDate",
                value: new DateTime(2026, 3, 4, 18, 25, 3, 282, DateTimeKind.Local).AddTicks(4198));

            migrationBuilder.UpdateData(
                table: "UserAuths",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2026, 3, 4, 18, 25, 3, 285, DateTimeKind.Local).AddTicks(7968));

            migrationBuilder.UpdateData(
                table: "UserRole",
                keyColumn: "RoleID",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 3, 4, 18, 25, 3, 285, DateTimeKind.Local).AddTicks(672), new DateTime(2026, 3, 4, 18, 25, 3, 285, DateTimeKind.Local).AddTicks(759) });

            migrationBuilder.UpdateData(
                table: "UserRole",
                keyColumn: "RoleID",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 3, 4, 18, 25, 3, 285, DateTimeKind.Local).AddTicks(826), new DateTime(2026, 3, 4, 18, 25, 3, 285, DateTimeKind.Local).AddTicks(827) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "JournalType",
                table: "JournalEntries");

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2026, 3, 4, 18, 23, 14, 230, DateTimeKind.Local).AddTicks(3501));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2026, 3, 4, 18, 23, 14, 230, DateTimeKind.Local).AddTicks(4241));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2026, 3, 4, 18, 23, 14, 230, DateTimeKind.Local).AddTicks(4243));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2026, 3, 4, 18, 23, 14, 230, DateTimeKind.Local).AddTicks(4245));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2026, 3, 4, 18, 23, 14, 230, DateTimeKind.Local).AddTicks(4247));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2026, 3, 4, 18, 23, 14, 230, DateTimeKind.Local).AddTicks(4248));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2026, 3, 4, 18, 23, 14, 230, DateTimeKind.Local).AddTicks(4347));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2026, 3, 4, 18, 23, 14, 230, DateTimeKind.Local).AddTicks(4349));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2026, 3, 4, 18, 23, 14, 230, DateTimeKind.Local).AddTicks(4350));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2026, 3, 4, 18, 23, 14, 230, DateTimeKind.Local).AddTicks(4352));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2026, 3, 4, 18, 23, 14, 230, DateTimeKind.Local).AddTicks(4353));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2026, 3, 4, 18, 23, 14, 230, DateTimeKind.Local).AddTicks(4354));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2026, 3, 4, 18, 23, 14, 230, DateTimeKind.Local).AddTicks(4356));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 14,
                column: "CreatedAt",
                value: new DateTime(2026, 3, 4, 18, 23, 14, 230, DateTimeKind.Local).AddTicks(4357));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 15,
                column: "CreatedAt",
                value: new DateTime(2026, 3, 4, 18, 23, 14, 230, DateTimeKind.Local).AddTicks(4358));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 16,
                column: "CreatedAt",
                value: new DateTime(2026, 3, 4, 18, 23, 14, 230, DateTimeKind.Local).AddTicks(4360));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 17,
                column: "CreatedAt",
                value: new DateTime(2026, 3, 4, 18, 23, 14, 230, DateTimeKind.Local).AddTicks(4361));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 18,
                column: "CreatedAt",
                value: new DateTime(2026, 3, 4, 18, 23, 14, 230, DateTimeKind.Local).AddTicks(4362));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 19,
                column: "CreatedAt",
                value: new DateTime(2026, 3, 4, 18, 23, 14, 230, DateTimeKind.Local).AddTicks(4364));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 20,
                column: "CreatedAt",
                value: new DateTime(2026, 3, 4, 18, 23, 14, 230, DateTimeKind.Local).AddTicks(4365));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 21,
                column: "CreatedAt",
                value: new DateTime(2026, 3, 4, 18, 23, 14, 230, DateTimeKind.Local).AddTicks(4374));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 22,
                column: "CreatedAt",
                value: new DateTime(2026, 3, 4, 18, 23, 14, 230, DateTimeKind.Local).AddTicks(4376));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 23,
                column: "CreatedAt",
                value: new DateTime(2026, 3, 4, 18, 23, 14, 230, DateTimeKind.Local).AddTicks(4377));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 24,
                column: "CreatedAt",
                value: new DateTime(2026, 3, 4, 18, 23, 14, 230, DateTimeKind.Local).AddTicks(4379));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 25,
                column: "CreatedAt",
                value: new DateTime(2026, 3, 4, 18, 23, 14, 230, DateTimeKind.Local).AddTicks(4380));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 26,
                column: "CreatedAt",
                value: new DateTime(2026, 3, 4, 18, 23, 14, 230, DateTimeKind.Local).AddTicks(4381));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 27,
                column: "CreatedAt",
                value: new DateTime(2026, 3, 4, 18, 23, 14, 230, DateTimeKind.Local).AddTicks(4383));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 28,
                column: "CreatedAt",
                value: new DateTime(2026, 3, 4, 18, 23, 14, 230, DateTimeKind.Local).AddTicks(4384));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 29,
                column: "CreatedAt",
                value: new DateTime(2026, 3, 4, 18, 23, 14, 230, DateTimeKind.Local).AddTicks(4386));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 30,
                column: "CreatedAt",
                value: new DateTime(2026, 3, 4, 18, 23, 14, 230, DateTimeKind.Local).AddTicks(4387));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 31,
                column: "CreatedAt",
                value: new DateTime(2026, 3, 4, 18, 23, 14, 230, DateTimeKind.Local).AddTicks(4389));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 32,
                column: "CreatedAt",
                value: new DateTime(2026, 3, 4, 18, 23, 14, 230, DateTimeKind.Local).AddTicks(4390));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 33,
                column: "CreatedAt",
                value: new DateTime(2026, 3, 4, 18, 23, 14, 230, DateTimeKind.Local).AddTicks(4391));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 34,
                column: "CreatedAt",
                value: new DateTime(2026, 3, 4, 18, 23, 14, 230, DateTimeKind.Local).AddTicks(4393));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 35,
                column: "CreatedAt",
                value: new DateTime(2026, 3, 4, 18, 23, 14, 230, DateTimeKind.Local).AddTicks(4394));

            migrationBuilder.UpdateData(
                table: "Branches",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 3, 4, 18, 23, 14, 228, DateTimeKind.Local).AddTicks(7050), new DateTime(2026, 3, 4, 18, 23, 14, 228, DateTimeKind.Local).AddTicks(7132) });

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "LastUpdatedAt", "LicensedValidTill" },
                values: new object[] { new DateTime(2026, 3, 4, 18, 23, 14, 228, DateTimeKind.Local).AddTicks(4948), new DateTime(2026, 3, 4, 18, 23, 14, 228, DateTimeKind.Local).AddTicks(5037), new DateTime(2026, 8, 31, 18, 23, 14, 228, DateTimeKind.Local).AddTicks(5262) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2026, 3, 4, 18, 23, 14, 231, DateTimeKind.Local).AddTicks(2873));

            migrationBuilder.UpdateData(
                table: "FinancialYears",
                keyColumn: "Code",
                keyValue: "2026",
                column: "FinStartDate",
                value: new DateTime(2026, 3, 4, 18, 23, 14, 227, DateTimeKind.Local).AddTicks(8712));

            migrationBuilder.UpdateData(
                table: "UserAuths",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2026, 3, 4, 18, 23, 14, 231, DateTimeKind.Local).AddTicks(4442));

            migrationBuilder.UpdateData(
                table: "UserRole",
                keyColumn: "RoleID",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 3, 4, 18, 23, 14, 230, DateTimeKind.Local).AddTicks(6367), new DateTime(2026, 3, 4, 18, 23, 14, 230, DateTimeKind.Local).AddTicks(6461) });

            migrationBuilder.UpdateData(
                table: "UserRole",
                keyColumn: "RoleID",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 3, 4, 18, 23, 14, 230, DateTimeKind.Local).AddTicks(6534), new DateTime(2026, 3, 4, 18, 23, 14, 230, DateTimeKind.Local).AddTicks(6535) });
        }
    }
}
