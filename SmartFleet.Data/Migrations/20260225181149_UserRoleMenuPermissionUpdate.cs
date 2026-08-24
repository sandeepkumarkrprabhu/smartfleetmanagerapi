using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SmartFleet.Data.Migrations
{
    /// <inheritdoc />
    public partial class UserRoleMenuPermissionUpdate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "HasAddPermission",
                table: "UserRoleMenus",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "HasDeletePermission",
                table: "UserRoleMenus",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "HasEditPermission",
                table: "UserRoleMenus",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "HasPostingPermission",
                table: "UserRoleMenus",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "HasPrintPermission",
                table: "UserRoleMenus",
                type: "bit",
                nullable: false,
                defaultValue: false);

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

            migrationBuilder.UpdateData(
                table: "UserRoleMenus",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "HasAddPermission", "HasDeletePermission", "HasEditPermission", "HasPostingPermission", "HasPrintPermission" },
                values: new object[] { false, false, false, false, false });

            migrationBuilder.UpdateData(
                table: "UserRoleMenus",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "HasAddPermission", "HasDeletePermission", "HasEditPermission", "HasPostingPermission", "HasPrintPermission" },
                values: new object[] { false, false, false, false, false });

            migrationBuilder.UpdateData(
                table: "UserRoleMenus",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "HasAddPermission", "HasDeletePermission", "HasEditPermission", "HasPostingPermission", "HasPrintPermission" },
                values: new object[] { false, false, false, false, false });

            migrationBuilder.UpdateData(
                table: "UserRoleMenus",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "HasAddPermission", "HasDeletePermission", "HasEditPermission", "HasPostingPermission", "HasPrintPermission" },
                values: new object[] { false, false, false, false, false });

            migrationBuilder.UpdateData(
                table: "UserRoleMenus",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "HasAddPermission", "HasDeletePermission", "HasEditPermission", "HasPostingPermission", "HasPrintPermission" },
                values: new object[] { false, false, false, false, false });

            migrationBuilder.UpdateData(
                table: "UserRoleMenus",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "HasAddPermission", "HasDeletePermission", "HasEditPermission", "HasPostingPermission", "HasPrintPermission" },
                values: new object[] { false, false, false, false, false });

            migrationBuilder.UpdateData(
                table: "UserRoleMenus",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "HasAddPermission", "HasDeletePermission", "HasEditPermission", "HasPostingPermission", "HasPrintPermission" },
                values: new object[] { false, false, false, false, false });

            migrationBuilder.UpdateData(
                table: "UserRoleMenus",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "HasAddPermission", "HasDeletePermission", "HasEditPermission", "HasPostingPermission", "HasPrintPermission" },
                values: new object[] { false, false, false, false, false });

            migrationBuilder.UpdateData(
                table: "UserRoleMenus",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "HasAddPermission", "HasDeletePermission", "HasEditPermission", "HasPostingPermission", "HasPrintPermission" },
                values: new object[] { false, false, false, false, false });

            migrationBuilder.UpdateData(
                table: "UserRoleMenus",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "HasAddPermission", "HasDeletePermission", "HasEditPermission", "HasPostingPermission", "HasPrintPermission" },
                values: new object[] { false, false, false, false, false });

            migrationBuilder.UpdateData(
                table: "UserRoleMenus",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "HasAddPermission", "HasDeletePermission", "HasEditPermission", "HasPostingPermission", "HasPrintPermission" },
                values: new object[] { false, false, false, false, false });

            migrationBuilder.UpdateData(
                table: "UserRoleMenus",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "HasAddPermission", "HasDeletePermission", "HasEditPermission", "HasPostingPermission", "HasPrintPermission" },
                values: new object[] { false, false, false, false, false });

            migrationBuilder.UpdateData(
                table: "UserRoleMenus",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "HasAddPermission", "HasDeletePermission", "HasEditPermission", "HasPostingPermission", "HasPrintPermission" },
                values: new object[] { false, false, false, false, false });

            migrationBuilder.UpdateData(
                table: "UserRoleMenus",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "HasAddPermission", "HasDeletePermission", "HasEditPermission", "HasPostingPermission", "HasPrintPermission" },
                values: new object[] { false, false, false, false, false });

            migrationBuilder.UpdateData(
                table: "UserRoleMenus",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "HasAddPermission", "HasDeletePermission", "HasEditPermission", "HasPostingPermission", "HasPrintPermission" },
                values: new object[] { false, false, false, false, false });

            migrationBuilder.UpdateData(
                table: "UserRoleMenus",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "HasAddPermission", "HasDeletePermission", "HasEditPermission", "HasPostingPermission", "HasPrintPermission" },
                values: new object[] { false, false, false, false, false });

            migrationBuilder.UpdateData(
                table: "UserRoleMenus",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "HasAddPermission", "HasDeletePermission", "HasEditPermission", "HasPostingPermission", "HasPrintPermission" },
                values: new object[] { false, false, false, false, false });

            migrationBuilder.UpdateData(
                table: "UserRoleMenus",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "HasAddPermission", "HasDeletePermission", "HasEditPermission", "HasPostingPermission", "HasPrintPermission" },
                values: new object[] { false, false, false, false, false });

            migrationBuilder.UpdateData(
                table: "UserRoleMenus",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "HasAddPermission", "HasDeletePermission", "HasEditPermission", "HasPostingPermission", "HasPrintPermission" },
                values: new object[] { false, false, false, false, false });

            migrationBuilder.UpdateData(
                table: "UserRoleMenus",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "HasAddPermission", "HasDeletePermission", "HasEditPermission", "HasPostingPermission", "HasPrintPermission" },
                values: new object[] { false, false, false, false, false });

            migrationBuilder.UpdateData(
                table: "UserRoleMenus",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "HasAddPermission", "HasDeletePermission", "HasEditPermission", "HasPostingPermission", "HasPrintPermission" },
                values: new object[] { false, false, false, false, false });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "HasAddPermission",
                table: "UserRoleMenus");

            migrationBuilder.DropColumn(
                name: "HasDeletePermission",
                table: "UserRoleMenus");

            migrationBuilder.DropColumn(
                name: "HasEditPermission",
                table: "UserRoleMenus");

            migrationBuilder.DropColumn(
                name: "HasPostingPermission",
                table: "UserRoleMenus");

            migrationBuilder.DropColumn(
                name: "HasPrintPermission",
                table: "UserRoleMenus");

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 25, 22, 57, 18, 206, DateTimeKind.Local).AddTicks(3759));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 25, 22, 57, 18, 206, DateTimeKind.Local).AddTicks(4474));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 25, 22, 57, 18, 206, DateTimeKind.Local).AddTicks(4477));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 25, 22, 57, 18, 206, DateTimeKind.Local).AddTicks(4478));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 25, 22, 57, 18, 206, DateTimeKind.Local).AddTicks(4480));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 25, 22, 57, 18, 206, DateTimeKind.Local).AddTicks(4488));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 25, 22, 57, 18, 206, DateTimeKind.Local).AddTicks(4554));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 25, 22, 57, 18, 206, DateTimeKind.Local).AddTicks(4555));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 25, 22, 57, 18, 206, DateTimeKind.Local).AddTicks(4557));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 25, 22, 57, 18, 206, DateTimeKind.Local).AddTicks(4558));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 25, 22, 57, 18, 206, DateTimeKind.Local).AddTicks(4594));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 25, 22, 57, 18, 206, DateTimeKind.Local).AddTicks(4596));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 25, 22, 57, 18, 206, DateTimeKind.Local).AddTicks(4597));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 14,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 25, 22, 57, 18, 206, DateTimeKind.Local).AddTicks(4598));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 15,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 25, 22, 57, 18, 206, DateTimeKind.Local).AddTicks(4599));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 16,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 25, 22, 57, 18, 206, DateTimeKind.Local).AddTicks(4601));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 17,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 25, 22, 57, 18, 206, DateTimeKind.Local).AddTicks(4602));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 18,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 25, 22, 57, 18, 206, DateTimeKind.Local).AddTicks(4603));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 19,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 25, 22, 57, 18, 206, DateTimeKind.Local).AddTicks(4605));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 20,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 25, 22, 57, 18, 206, DateTimeKind.Local).AddTicks(4614));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 21,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 25, 22, 57, 18, 206, DateTimeKind.Local).AddTicks(4615));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 22,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 25, 22, 57, 18, 206, DateTimeKind.Local).AddTicks(4616));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 23,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 25, 22, 57, 18, 206, DateTimeKind.Local).AddTicks(4618));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 24,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 25, 22, 57, 18, 206, DateTimeKind.Local).AddTicks(4619));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 25,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 25, 22, 57, 18, 206, DateTimeKind.Local).AddTicks(4620));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 26,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 25, 22, 57, 18, 206, DateTimeKind.Local).AddTicks(4622));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 27,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 25, 22, 57, 18, 206, DateTimeKind.Local).AddTicks(4623));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 28,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 25, 22, 57, 18, 206, DateTimeKind.Local).AddTicks(4624));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 29,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 25, 22, 57, 18, 206, DateTimeKind.Local).AddTicks(4626));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 30,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 25, 22, 57, 18, 206, DateTimeKind.Local).AddTicks(4627));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 31,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 25, 22, 57, 18, 206, DateTimeKind.Local).AddTicks(4628));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 32,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 25, 22, 57, 18, 206, DateTimeKind.Local).AddTicks(4630));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 33,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 25, 22, 57, 18, 206, DateTimeKind.Local).AddTicks(4631));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 34,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 25, 22, 57, 18, 206, DateTimeKind.Local).AddTicks(4632));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 35,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 25, 22, 57, 18, 206, DateTimeKind.Local).AddTicks(4634));

            migrationBuilder.UpdateData(
                table: "Branches",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 22, 57, 18, 204, DateTimeKind.Local).AddTicks(7974), new DateTime(2026, 2, 25, 22, 57, 18, 204, DateTimeKind.Local).AddTicks(8051) });

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "LastUpdatedAt", "LicensedValidTill" },
                values: new object[] { new DateTime(2026, 2, 25, 22, 57, 18, 204, DateTimeKind.Local).AddTicks(5798), new DateTime(2026, 2, 25, 22, 57, 18, 204, DateTimeKind.Local).AddTicks(5881), new DateTime(2026, 8, 24, 22, 57, 18, 204, DateTimeKind.Local).AddTicks(6084) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 25, 22, 57, 18, 207, DateTimeKind.Local).AddTicks(1690));

            migrationBuilder.UpdateData(
                table: "FinancialYears",
                keyColumn: "Code",
                keyValue: "2026",
                column: "FinStartDate",
                value: new DateTime(2026, 2, 25, 22, 57, 18, 203, DateTimeKind.Local).AddTicks(8516));

            migrationBuilder.UpdateData(
                table: "UserAuths",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 25, 22, 57, 18, 207, DateTimeKind.Local).AddTicks(3315));

            migrationBuilder.UpdateData(
                table: "UserRole",
                keyColumn: "RoleID",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 22, 57, 18, 206, DateTimeKind.Local).AddTicks(6190), new DateTime(2026, 2, 25, 22, 57, 18, 206, DateTimeKind.Local).AddTicks(6277) });

            migrationBuilder.UpdateData(
                table: "UserRole",
                keyColumn: "RoleID",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 25, 22, 57, 18, 206, DateTimeKind.Local).AddTicks(6347), new DateTime(2026, 2, 25, 22, 57, 18, 206, DateTimeKind.Local).AddTicks(6347) });
        }
    }
}
