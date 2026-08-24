using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SmartFleet.Data.Migrations
{
    /// <inheritdoc />
    public partial class UserRoleMenuFunctionPermissionUpdate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<bool>(
                name: "HasPrintPermission",
                table: "UserRoleMenus",
                type: "bit",
                nullable: true,
                oldClrType: typeof(bool),
                oldType: "bit");

            migrationBuilder.AlterColumn<bool>(
                name: "HasPostingPermission",
                table: "UserRoleMenus",
                type: "bit",
                nullable: true,
                oldClrType: typeof(bool),
                oldType: "bit");

            migrationBuilder.AlterColumn<bool>(
                name: "HasEditPermission",
                table: "UserRoleMenus",
                type: "bit",
                nullable: true,
                oldClrType: typeof(bool),
                oldType: "bit");

            migrationBuilder.AlterColumn<bool>(
                name: "HasDeletePermission",
                table: "UserRoleMenus",
                type: "bit",
                nullable: true,
                oldClrType: typeof(bool),
                oldType: "bit");

            migrationBuilder.AlterColumn<bool>(
                name: "HasAddPermission",
                table: "UserRoleMenus",
                type: "bit",
                nullable: true,
                oldClrType: typeof(bool),
                oldType: "bit");

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 25, 23, 46, 18, 301, DateTimeKind.Local).AddTicks(856));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 25, 23, 46, 18, 301, DateTimeKind.Local).AddTicks(1635));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 25, 23, 46, 18, 301, DateTimeKind.Local).AddTicks(1638));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 25, 23, 46, 18, 301, DateTimeKind.Local).AddTicks(1640));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 25, 23, 46, 18, 301, DateTimeKind.Local).AddTicks(1641));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 25, 23, 46, 18, 301, DateTimeKind.Local).AddTicks(1649));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 25, 23, 46, 18, 301, DateTimeKind.Local).AddTicks(1725));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 25, 23, 46, 18, 301, DateTimeKind.Local).AddTicks(1727));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 25, 23, 46, 18, 301, DateTimeKind.Local).AddTicks(1728));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 25, 23, 46, 18, 301, DateTimeKind.Local).AddTicks(1729));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 25, 23, 46, 18, 301, DateTimeKind.Local).AddTicks(1731));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 25, 23, 46, 18, 301, DateTimeKind.Local).AddTicks(1732));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 25, 23, 46, 18, 301, DateTimeKind.Local).AddTicks(1733));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 14,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 25, 23, 46, 18, 301, DateTimeKind.Local).AddTicks(1734));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 15,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 25, 23, 46, 18, 301, DateTimeKind.Local).AddTicks(1735));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 16,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 25, 23, 46, 18, 301, DateTimeKind.Local).AddTicks(1737));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 17,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 25, 23, 46, 18, 301, DateTimeKind.Local).AddTicks(1738));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 18,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 25, 23, 46, 18, 301, DateTimeKind.Local).AddTicks(1739));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 19,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 25, 23, 46, 18, 301, DateTimeKind.Local).AddTicks(1740));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 20,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 25, 23, 46, 18, 301, DateTimeKind.Local).AddTicks(1749));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 21,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 25, 23, 46, 18, 301, DateTimeKind.Local).AddTicks(1750));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 22,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 25, 23, 46, 18, 301, DateTimeKind.Local).AddTicks(1751));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 23,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 25, 23, 46, 18, 301, DateTimeKind.Local).AddTicks(1753));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 24,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 25, 23, 46, 18, 301, DateTimeKind.Local).AddTicks(1754));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 25,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 25, 23, 46, 18, 301, DateTimeKind.Local).AddTicks(1755));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 26,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 25, 23, 46, 18, 301, DateTimeKind.Local).AddTicks(1757));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 27,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 25, 23, 46, 18, 301, DateTimeKind.Local).AddTicks(1791));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 28,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 25, 23, 46, 18, 301, DateTimeKind.Local).AddTicks(1792));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 29,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 25, 23, 46, 18, 301, DateTimeKind.Local).AddTicks(1794));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 30,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 25, 23, 46, 18, 301, DateTimeKind.Local).AddTicks(1795));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 31,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 25, 23, 46, 18, 301, DateTimeKind.Local).AddTicks(1796));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 32,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 25, 23, 46, 18, 301, DateTimeKind.Local).AddTicks(1798));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 33,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 25, 23, 46, 18, 301, DateTimeKind.Local).AddTicks(1799));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 34,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 25, 23, 46, 18, 301, DateTimeKind.Local).AddTicks(1800));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 35,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 25, 23, 46, 18, 301, DateTimeKind.Local).AddTicks(1802));

            migrationBuilder.UpdateData(
                table: "Branches",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 23, 46, 18, 299, DateTimeKind.Local).AddTicks(4582), new DateTime(2026, 2, 25, 23, 46, 18, 299, DateTimeKind.Local).AddTicks(4696) });

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "LastUpdatedAt", "LicensedValidTill" },
                values: new object[] { new DateTime(2026, 2, 25, 23, 46, 18, 299, DateTimeKind.Local).AddTicks(2105), new DateTime(2026, 2, 25, 23, 46, 18, 299, DateTimeKind.Local).AddTicks(2201), new DateTime(2026, 8, 24, 23, 46, 18, 299, DateTimeKind.Local).AddTicks(2452) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 25, 23, 46, 18, 301, DateTimeKind.Local).AddTicks(9693));

            migrationBuilder.UpdateData(
                table: "FinancialYears",
                keyColumn: "Code",
                keyValue: "2026",
                column: "FinStartDate",
                value: new DateTime(2026, 2, 25, 23, 46, 18, 298, DateTimeKind.Local).AddTicks(5786));

            migrationBuilder.UpdateData(
                table: "UserAuths",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 25, 23, 46, 18, 302, DateTimeKind.Local).AddTicks(1436));

            migrationBuilder.UpdateData(
                table: "UserRole",
                keyColumn: "RoleID",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 23, 46, 18, 301, DateTimeKind.Local).AddTicks(3410), new DateTime(2026, 2, 25, 23, 46, 18, 301, DateTimeKind.Local).AddTicks(3503) });

            migrationBuilder.UpdateData(
                table: "UserRole",
                keyColumn: "RoleID",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 23, 46, 18, 301, DateTimeKind.Local).AddTicks(3581), new DateTime(2026, 2, 25, 23, 46, 18, 301, DateTimeKind.Local).AddTicks(3581) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<bool>(
                name: "HasPrintPermission",
                table: "UserRoleMenus",
                type: "bit",
                nullable: false,
                defaultValue: false,
                oldClrType: typeof(bool),
                oldType: "bit",
                oldNullable: true);

            migrationBuilder.AlterColumn<bool>(
                name: "HasPostingPermission",
                table: "UserRoleMenus",
                type: "bit",
                nullable: false,
                defaultValue: false,
                oldClrType: typeof(bool),
                oldType: "bit",
                oldNullable: true);

            migrationBuilder.AlterColumn<bool>(
                name: "HasEditPermission",
                table: "UserRoleMenus",
                type: "bit",
                nullable: false,
                defaultValue: false,
                oldClrType: typeof(bool),
                oldType: "bit",
                oldNullable: true);

            migrationBuilder.AlterColumn<bool>(
                name: "HasDeletePermission",
                table: "UserRoleMenus",
                type: "bit",
                nullable: false,
                defaultValue: false,
                oldClrType: typeof(bool),
                oldType: "bit",
                oldNullable: true);

            migrationBuilder.AlterColumn<bool>(
                name: "HasAddPermission",
                table: "UserRoleMenus",
                type: "bit",
                nullable: false,
                defaultValue: false,
                oldClrType: typeof(bool),
                oldType: "bit",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 25, 23, 41, 45, 473, DateTimeKind.Local).AddTicks(7284));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 25, 23, 41, 45, 473, DateTimeKind.Local).AddTicks(8115));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 25, 23, 41, 45, 473, DateTimeKind.Local).AddTicks(8118));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 25, 23, 41, 45, 473, DateTimeKind.Local).AddTicks(8120));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 25, 23, 41, 45, 473, DateTimeKind.Local).AddTicks(8121));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 25, 23, 41, 45, 473, DateTimeKind.Local).AddTicks(8124));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 25, 23, 41, 45, 473, DateTimeKind.Local).AddTicks(8202));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 25, 23, 41, 45, 473, DateTimeKind.Local).AddTicks(8204));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 25, 23, 41, 45, 473, DateTimeKind.Local).AddTicks(8205));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 25, 23, 41, 45, 473, DateTimeKind.Local).AddTicks(8207));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 25, 23, 41, 45, 473, DateTimeKind.Local).AddTicks(8208));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 25, 23, 41, 45, 473, DateTimeKind.Local).AddTicks(8210));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 25, 23, 41, 45, 473, DateTimeKind.Local).AddTicks(8211));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 14,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 25, 23, 41, 45, 473, DateTimeKind.Local).AddTicks(8212));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 15,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 25, 23, 41, 45, 473, DateTimeKind.Local).AddTicks(8214));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 16,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 25, 23, 41, 45, 473, DateTimeKind.Local).AddTicks(8215));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 17,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 25, 23, 41, 45, 473, DateTimeKind.Local).AddTicks(8224));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 18,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 25, 23, 41, 45, 473, DateTimeKind.Local).AddTicks(8226));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 19,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 25, 23, 41, 45, 473, DateTimeKind.Local).AddTicks(8227));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 20,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 25, 23, 41, 45, 473, DateTimeKind.Local).AddTicks(8229));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 21,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 25, 23, 41, 45, 473, DateTimeKind.Local).AddTicks(8230));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 22,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 25, 23, 41, 45, 473, DateTimeKind.Local).AddTicks(8232));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 23,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 25, 23, 41, 45, 473, DateTimeKind.Local).AddTicks(8233));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 24,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 25, 23, 41, 45, 473, DateTimeKind.Local).AddTicks(8234));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 25,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 25, 23, 41, 45, 473, DateTimeKind.Local).AddTicks(8236));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 26,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 25, 23, 41, 45, 473, DateTimeKind.Local).AddTicks(8237));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 27,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 25, 23, 41, 45, 473, DateTimeKind.Local).AddTicks(8239));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 28,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 25, 23, 41, 45, 473, DateTimeKind.Local).AddTicks(8240));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 29,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 25, 23, 41, 45, 473, DateTimeKind.Local).AddTicks(8242));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 30,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 25, 23, 41, 45, 473, DateTimeKind.Local).AddTicks(8243));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 31,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 25, 23, 41, 45, 473, DateTimeKind.Local).AddTicks(8245));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 32,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 25, 23, 41, 45, 473, DateTimeKind.Local).AddTicks(8283));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 33,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 25, 23, 41, 45, 473, DateTimeKind.Local).AddTicks(8285));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 34,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 25, 23, 41, 45, 473, DateTimeKind.Local).AddTicks(8287));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 35,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 25, 23, 41, 45, 473, DateTimeKind.Local).AddTicks(8289));

            migrationBuilder.UpdateData(
                table: "Branches",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 23, 41, 45, 472, DateTimeKind.Local).AddTicks(1086), new DateTime(2026, 2, 25, 23, 41, 45, 472, DateTimeKind.Local).AddTicks(1172) });

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "LastUpdatedAt", "LicensedValidTill" },
                values: new object[] { new DateTime(2026, 2, 25, 23, 41, 45, 471, DateTimeKind.Local).AddTicks(8864), new DateTime(2026, 2, 25, 23, 41, 45, 471, DateTimeKind.Local).AddTicks(8963), new DateTime(2026, 8, 24, 23, 41, 45, 471, DateTimeKind.Local).AddTicks(9217) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 25, 23, 41, 45, 474, DateTimeKind.Local).AddTicks(6312));

            migrationBuilder.UpdateData(
                table: "FinancialYears",
                keyColumn: "Code",
                keyValue: "2026",
                column: "FinStartDate",
                value: new DateTime(2026, 2, 25, 23, 41, 45, 471, DateTimeKind.Local).AddTicks(2946));

            migrationBuilder.UpdateData(
                table: "UserAuths",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 25, 23, 41, 45, 474, DateTimeKind.Local).AddTicks(8147));

            migrationBuilder.UpdateData(
                table: "UserRole",
                keyColumn: "RoleID",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 23, 41, 45, 474, DateTimeKind.Local).AddTicks(25), new DateTime(2026, 2, 25, 23, 41, 45, 474, DateTimeKind.Local).AddTicks(130) });

            migrationBuilder.UpdateData(
                table: "UserRole",
                keyColumn: "RoleID",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 23, 41, 45, 474, DateTimeKind.Local).AddTicks(214), new DateTime(2026, 2, 25, 23, 41, 45, 474, DateTimeKind.Local).AddTicks(215) });
        }
    }
}
