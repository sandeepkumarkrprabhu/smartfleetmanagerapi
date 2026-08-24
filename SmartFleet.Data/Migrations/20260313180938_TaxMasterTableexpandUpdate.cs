using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SmartFleet.Data.Migrations
{
    /// <inheritdoc />
    public partial class TaxMasterTableexpandUpdate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "EffectiveFrom",
                table: "Taxes",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<bool>(
                name: "IsActive",
                table: "Taxes",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2026, 3, 13, 23, 39, 34, 769, DateTimeKind.Local).AddTicks(4556));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2026, 3, 13, 23, 39, 34, 769, DateTimeKind.Local).AddTicks(5306));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2026, 3, 13, 23, 39, 34, 769, DateTimeKind.Local).AddTicks(5309));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2026, 3, 13, 23, 39, 34, 769, DateTimeKind.Local).AddTicks(5311));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2026, 3, 13, 23, 39, 34, 769, DateTimeKind.Local).AddTicks(5312));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2026, 3, 13, 23, 39, 34, 769, DateTimeKind.Local).AddTicks(5313));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2026, 3, 13, 23, 39, 34, 769, DateTimeKind.Local).AddTicks(5389));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2026, 3, 13, 23, 39, 34, 769, DateTimeKind.Local).AddTicks(5391));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2026, 3, 13, 23, 39, 34, 769, DateTimeKind.Local).AddTicks(5393));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2026, 3, 13, 23, 39, 34, 769, DateTimeKind.Local).AddTicks(5394));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2026, 3, 13, 23, 39, 34, 769, DateTimeKind.Local).AddTicks(5395));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2026, 3, 13, 23, 39, 34, 769, DateTimeKind.Local).AddTicks(5397));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2026, 3, 13, 23, 39, 34, 769, DateTimeKind.Local).AddTicks(5398));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 14,
                column: "CreatedAt",
                value: new DateTime(2026, 3, 13, 23, 39, 34, 769, DateTimeKind.Local).AddTicks(5399));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 15,
                column: "CreatedAt",
                value: new DateTime(2026, 3, 13, 23, 39, 34, 769, DateTimeKind.Local).AddTicks(5401));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 16,
                column: "CreatedAt",
                value: new DateTime(2026, 3, 13, 23, 39, 34, 769, DateTimeKind.Local).AddTicks(5402));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 17,
                column: "CreatedAt",
                value: new DateTime(2026, 3, 13, 23, 39, 34, 769, DateTimeKind.Local).AddTicks(5403));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 18,
                column: "CreatedAt",
                value: new DateTime(2026, 3, 13, 23, 39, 34, 769, DateTimeKind.Local).AddTicks(5405));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 19,
                column: "CreatedAt",
                value: new DateTime(2026, 3, 13, 23, 39, 34, 769, DateTimeKind.Local).AddTicks(5406));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 20,
                column: "CreatedAt",
                value: new DateTime(2026, 3, 13, 23, 39, 34, 769, DateTimeKind.Local).AddTicks(5408));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 21,
                column: "CreatedAt",
                value: new DateTime(2026, 3, 13, 23, 39, 34, 769, DateTimeKind.Local).AddTicks(5415));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 22,
                column: "CreatedAt",
                value: new DateTime(2026, 3, 13, 23, 39, 34, 769, DateTimeKind.Local).AddTicks(5417));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 23,
                column: "CreatedAt",
                value: new DateTime(2026, 3, 13, 23, 39, 34, 769, DateTimeKind.Local).AddTicks(5418));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 24,
                column: "CreatedAt",
                value: new DateTime(2026, 3, 13, 23, 39, 34, 769, DateTimeKind.Local).AddTicks(5420));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 25,
                column: "CreatedAt",
                value: new DateTime(2026, 3, 13, 23, 39, 34, 769, DateTimeKind.Local).AddTicks(5421));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 26,
                column: "CreatedAt",
                value: new DateTime(2026, 3, 13, 23, 39, 34, 769, DateTimeKind.Local).AddTicks(5422));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 27,
                column: "CreatedAt",
                value: new DateTime(2026, 3, 13, 23, 39, 34, 769, DateTimeKind.Local).AddTicks(5424));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 28,
                column: "CreatedAt",
                value: new DateTime(2026, 3, 13, 23, 39, 34, 769, DateTimeKind.Local).AddTicks(5425));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 29,
                column: "CreatedAt",
                value: new DateTime(2026, 3, 13, 23, 39, 34, 769, DateTimeKind.Local).AddTicks(5426));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 30,
                column: "CreatedAt",
                value: new DateTime(2026, 3, 13, 23, 39, 34, 769, DateTimeKind.Local).AddTicks(5428));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 31,
                column: "CreatedAt",
                value: new DateTime(2026, 3, 13, 23, 39, 34, 769, DateTimeKind.Local).AddTicks(5429));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 32,
                column: "CreatedAt",
                value: new DateTime(2026, 3, 13, 23, 39, 34, 769, DateTimeKind.Local).AddTicks(5431));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 33,
                column: "CreatedAt",
                value: new DateTime(2026, 3, 13, 23, 39, 34, 769, DateTimeKind.Local).AddTicks(5432));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 34,
                column: "CreatedAt",
                value: new DateTime(2026, 3, 13, 23, 39, 34, 769, DateTimeKind.Local).AddTicks(5433));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 35,
                column: "CreatedAt",
                value: new DateTime(2026, 3, 13, 23, 39, 34, 769, DateTimeKind.Local).AddTicks(5435));

            migrationBuilder.UpdateData(
                table: "Branches",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 3, 13, 23, 39, 34, 767, DateTimeKind.Local).AddTicks(4176), new DateTime(2026, 3, 13, 23, 39, 34, 767, DateTimeKind.Local).AddTicks(4253) });

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "LastUpdatedAt", "LicensedValidTill" },
                values: new object[] { new DateTime(2026, 3, 13, 23, 39, 34, 767, DateTimeKind.Local).AddTicks(2086), new DateTime(2026, 3, 13, 23, 39, 34, 767, DateTimeKind.Local).AddTicks(2168), new DateTime(2026, 9, 9, 23, 39, 34, 767, DateTimeKind.Local).AddTicks(2373) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2026, 3, 13, 23, 39, 34, 770, DateTimeKind.Local).AddTicks(3269));

            migrationBuilder.UpdateData(
                table: "FinancialYears",
                keyColumn: "Code",
                keyValue: "2026",
                column: "FinStartDate",
                value: new DateTime(2026, 3, 13, 23, 39, 34, 766, DateTimeKind.Local).AddTicks(6489));

            migrationBuilder.UpdateData(
                table: "UserAuths",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2026, 3, 13, 23, 39, 34, 770, DateTimeKind.Local).AddTicks(4763));

            migrationBuilder.UpdateData(
                table: "UserRole",
                keyColumn: "RoleID",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 3, 13, 23, 39, 34, 769, DateTimeKind.Local).AddTicks(7136), new DateTime(2026, 3, 13, 23, 39, 34, 769, DateTimeKind.Local).AddTicks(7223) });

            migrationBuilder.UpdateData(
                table: "UserRole",
                keyColumn: "RoleID",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 3, 13, 23, 39, 34, 769, DateTimeKind.Local).AddTicks(7306), new DateTime(2026, 3, 13, 23, 39, 34, 769, DateTimeKind.Local).AddTicks(7307) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "EffectiveFrom",
                table: "Taxes");

            migrationBuilder.DropColumn(
                name: "IsActive",
                table: "Taxes");

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2026, 3, 13, 23, 35, 16, 997, DateTimeKind.Local).AddTicks(6366));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2026, 3, 13, 23, 35, 16, 997, DateTimeKind.Local).AddTicks(7055));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2026, 3, 13, 23, 35, 16, 997, DateTimeKind.Local).AddTicks(7057));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2026, 3, 13, 23, 35, 16, 997, DateTimeKind.Local).AddTicks(7059));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2026, 3, 13, 23, 35, 16, 997, DateTimeKind.Local).AddTicks(7060));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2026, 3, 13, 23, 35, 16, 997, DateTimeKind.Local).AddTicks(7062));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2026, 3, 13, 23, 35, 16, 997, DateTimeKind.Local).AddTicks(7127));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2026, 3, 13, 23, 35, 16, 997, DateTimeKind.Local).AddTicks(7128));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2026, 3, 13, 23, 35, 16, 997, DateTimeKind.Local).AddTicks(7130));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2026, 3, 13, 23, 35, 16, 997, DateTimeKind.Local).AddTicks(7131));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2026, 3, 13, 23, 35, 16, 997, DateTimeKind.Local).AddTicks(7132));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2026, 3, 13, 23, 35, 16, 997, DateTimeKind.Local).AddTicks(7133));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2026, 3, 13, 23, 35, 16, 997, DateTimeKind.Local).AddTicks(7135));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 14,
                column: "CreatedAt",
                value: new DateTime(2026, 3, 13, 23, 35, 16, 997, DateTimeKind.Local).AddTicks(7136));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 15,
                column: "CreatedAt",
                value: new DateTime(2026, 3, 13, 23, 35, 16, 997, DateTimeKind.Local).AddTicks(7137));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 16,
                column: "CreatedAt",
                value: new DateTime(2026, 3, 13, 23, 35, 16, 997, DateTimeKind.Local).AddTicks(7146));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 17,
                column: "CreatedAt",
                value: new DateTime(2026, 3, 13, 23, 35, 16, 997, DateTimeKind.Local).AddTicks(7148));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 18,
                column: "CreatedAt",
                value: new DateTime(2026, 3, 13, 23, 35, 16, 997, DateTimeKind.Local).AddTicks(7149));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 19,
                column: "CreatedAt",
                value: new DateTime(2026, 3, 13, 23, 35, 16, 997, DateTimeKind.Local).AddTicks(7151));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 20,
                column: "CreatedAt",
                value: new DateTime(2026, 3, 13, 23, 35, 16, 997, DateTimeKind.Local).AddTicks(7152));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 21,
                column: "CreatedAt",
                value: new DateTime(2026, 3, 13, 23, 35, 16, 997, DateTimeKind.Local).AddTicks(7154));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 22,
                column: "CreatedAt",
                value: new DateTime(2026, 3, 13, 23, 35, 16, 997, DateTimeKind.Local).AddTicks(7155));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 23,
                column: "CreatedAt",
                value: new DateTime(2026, 3, 13, 23, 35, 16, 997, DateTimeKind.Local).AddTicks(7156));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 24,
                column: "CreatedAt",
                value: new DateTime(2026, 3, 13, 23, 35, 16, 997, DateTimeKind.Local).AddTicks(7158));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 25,
                column: "CreatedAt",
                value: new DateTime(2026, 3, 13, 23, 35, 16, 997, DateTimeKind.Local).AddTicks(7159));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 26,
                column: "CreatedAt",
                value: new DateTime(2026, 3, 13, 23, 35, 16, 997, DateTimeKind.Local).AddTicks(7189));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 27,
                column: "CreatedAt",
                value: new DateTime(2026, 3, 13, 23, 35, 16, 997, DateTimeKind.Local).AddTicks(7191));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 28,
                column: "CreatedAt",
                value: new DateTime(2026, 3, 13, 23, 35, 16, 997, DateTimeKind.Local).AddTicks(7193));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 29,
                column: "CreatedAt",
                value: new DateTime(2026, 3, 13, 23, 35, 16, 997, DateTimeKind.Local).AddTicks(7194));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 30,
                column: "CreatedAt",
                value: new DateTime(2026, 3, 13, 23, 35, 16, 997, DateTimeKind.Local).AddTicks(7195));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 31,
                column: "CreatedAt",
                value: new DateTime(2026, 3, 13, 23, 35, 16, 997, DateTimeKind.Local).AddTicks(7197));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 32,
                column: "CreatedAt",
                value: new DateTime(2026, 3, 13, 23, 35, 16, 997, DateTimeKind.Local).AddTicks(7198));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 33,
                column: "CreatedAt",
                value: new DateTime(2026, 3, 13, 23, 35, 16, 997, DateTimeKind.Local).AddTicks(7199));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 34,
                column: "CreatedAt",
                value: new DateTime(2026, 3, 13, 23, 35, 16, 997, DateTimeKind.Local).AddTicks(7201));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 35,
                column: "CreatedAt",
                value: new DateTime(2026, 3, 13, 23, 35, 16, 997, DateTimeKind.Local).AddTicks(7202));

            migrationBuilder.UpdateData(
                table: "Branches",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 3, 13, 23, 35, 16, 996, DateTimeKind.Local).AddTicks(711), new DateTime(2026, 3, 13, 23, 35, 16, 996, DateTimeKind.Local).AddTicks(791) });

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "LastUpdatedAt", "LicensedValidTill" },
                values: new object[] { new DateTime(2026, 3, 13, 23, 35, 16, 995, DateTimeKind.Local).AddTicks(8671), new DateTime(2026, 3, 13, 23, 35, 16, 995, DateTimeKind.Local).AddTicks(8756), new DateTime(2026, 9, 9, 23, 35, 16, 995, DateTimeKind.Local).AddTicks(8964) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2026, 3, 13, 23, 35, 16, 998, DateTimeKind.Local).AddTicks(4699));

            migrationBuilder.UpdateData(
                table: "FinancialYears",
                keyColumn: "Code",
                keyValue: "2026",
                column: "FinStartDate",
                value: new DateTime(2026, 3, 13, 23, 35, 16, 995, DateTimeKind.Local).AddTicks(2737));

            migrationBuilder.UpdateData(
                table: "UserAuths",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2026, 3, 13, 23, 35, 16, 998, DateTimeKind.Local).AddTicks(6472));

            migrationBuilder.UpdateData(
                table: "UserRole",
                keyColumn: "RoleID",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 3, 13, 23, 35, 16, 997, DateTimeKind.Local).AddTicks(8779), new DateTime(2026, 3, 13, 23, 35, 16, 997, DateTimeKind.Local).AddTicks(8863) });

            migrationBuilder.UpdateData(
                table: "UserRole",
                keyColumn: "RoleID",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 3, 13, 23, 35, 16, 997, DateTimeKind.Local).AddTicks(8933), new DateTime(2026, 3, 13, 23, 35, 16, 997, DateTimeKind.Local).AddTicks(8934) });
        }
    }
}
