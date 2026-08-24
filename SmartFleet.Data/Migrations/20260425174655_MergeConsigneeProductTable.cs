using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SmartFleet.Data.Migrations
{
    /// <inheritdoc />
    public partial class MergeConsigneeProductTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ProductId",
                table: "TripConsigneeDetails",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<decimal>(
                name: "Qty",
                table: "TripConsigneeDetails",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<int>(
                name: "UnitId",
                table: "TripConsigneeDetails",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2026, 4, 25, 23, 16, 54, 556, DateTimeKind.Local).AddTicks(8535));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2026, 4, 25, 23, 16, 54, 557, DateTimeKind.Local).AddTicks(1));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2026, 4, 25, 23, 16, 54, 557, DateTimeKind.Local).AddTicks(8));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2026, 4, 25, 23, 16, 54, 557, DateTimeKind.Local).AddTicks(11));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2026, 4, 25, 23, 16, 54, 557, DateTimeKind.Local).AddTicks(12));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2026, 4, 25, 23, 16, 54, 557, DateTimeKind.Local).AddTicks(14));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2026, 4, 25, 23, 16, 54, 557, DateTimeKind.Local).AddTicks(117));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2026, 4, 25, 23, 16, 54, 557, DateTimeKind.Local).AddTicks(120));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2026, 4, 25, 23, 16, 54, 557, DateTimeKind.Local).AddTicks(122));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2026, 4, 25, 23, 16, 54, 557, DateTimeKind.Local).AddTicks(125));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2026, 4, 25, 23, 16, 54, 557, DateTimeKind.Local).AddTicks(139));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2026, 4, 25, 23, 16, 54, 557, DateTimeKind.Local).AddTicks(141));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2026, 4, 25, 23, 16, 54, 557, DateTimeKind.Local).AddTicks(143));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 14,
                column: "CreatedAt",
                value: new DateTime(2026, 4, 25, 23, 16, 54, 557, DateTimeKind.Local).AddTicks(145));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 15,
                column: "CreatedAt",
                value: new DateTime(2026, 4, 25, 23, 16, 54, 557, DateTimeKind.Local).AddTicks(147));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 16,
                column: "CreatedAt",
                value: new DateTime(2026, 4, 25, 23, 16, 54, 557, DateTimeKind.Local).AddTicks(148));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 17,
                column: "CreatedAt",
                value: new DateTime(2026, 4, 25, 23, 16, 54, 557, DateTimeKind.Local).AddTicks(150));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 18,
                column: "CreatedAt",
                value: new DateTime(2026, 4, 25, 23, 16, 54, 557, DateTimeKind.Local).AddTicks(152));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 19,
                column: "CreatedAt",
                value: new DateTime(2026, 4, 25, 23, 16, 54, 557, DateTimeKind.Local).AddTicks(154));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 20,
                column: "CreatedAt",
                value: new DateTime(2026, 4, 25, 23, 16, 54, 557, DateTimeKind.Local).AddTicks(156));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 21,
                column: "CreatedAt",
                value: new DateTime(2026, 4, 25, 23, 16, 54, 557, DateTimeKind.Local).AddTicks(158));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 22,
                column: "CreatedAt",
                value: new DateTime(2026, 4, 25, 23, 16, 54, 557, DateTimeKind.Local).AddTicks(160));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 23,
                column: "CreatedAt",
                value: new DateTime(2026, 4, 25, 23, 16, 54, 557, DateTimeKind.Local).AddTicks(162));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 24,
                column: "CreatedAt",
                value: new DateTime(2026, 4, 25, 23, 16, 54, 557, DateTimeKind.Local).AddTicks(164));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 25,
                column: "CreatedAt",
                value: new DateTime(2026, 4, 25, 23, 16, 54, 557, DateTimeKind.Local).AddTicks(166));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 26,
                column: "CreatedAt",
                value: new DateTime(2026, 4, 25, 23, 16, 54, 557, DateTimeKind.Local).AddTicks(168));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 27,
                column: "CreatedAt",
                value: new DateTime(2026, 4, 25, 23, 16, 54, 557, DateTimeKind.Local).AddTicks(170));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 28,
                column: "CreatedAt",
                value: new DateTime(2026, 4, 25, 23, 16, 54, 557, DateTimeKind.Local).AddTicks(172));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 29,
                column: "CreatedAt",
                value: new DateTime(2026, 4, 25, 23, 16, 54, 557, DateTimeKind.Local).AddTicks(174));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 30,
                column: "CreatedAt",
                value: new DateTime(2026, 4, 25, 23, 16, 54, 557, DateTimeKind.Local).AddTicks(176));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 31,
                column: "CreatedAt",
                value: new DateTime(2026, 4, 25, 23, 16, 54, 557, DateTimeKind.Local).AddTicks(177));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 32,
                column: "CreatedAt",
                value: new DateTime(2026, 4, 25, 23, 16, 54, 557, DateTimeKind.Local).AddTicks(179));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 33,
                column: "CreatedAt",
                value: new DateTime(2026, 4, 25, 23, 16, 54, 557, DateTimeKind.Local).AddTicks(181));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 34,
                column: "CreatedAt",
                value: new DateTime(2026, 4, 25, 23, 16, 54, 557, DateTimeKind.Local).AddTicks(183));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 35,
                column: "CreatedAt",
                value: new DateTime(2026, 4, 25, 23, 16, 54, 557, DateTimeKind.Local).AddTicks(185));

            migrationBuilder.UpdateData(
                table: "Branches",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 4, 25, 23, 16, 54, 549, DateTimeKind.Local).AddTicks(9140), new DateTime(2026, 4, 25, 23, 16, 54, 549, DateTimeKind.Local).AddTicks(9264) });

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "LastUpdatedAt", "LicensedValidTill" },
                values: new object[] { new DateTime(2026, 4, 25, 23, 16, 54, 549, DateTimeKind.Local).AddTicks(6002), new DateTime(2026, 4, 25, 23, 16, 54, 549, DateTimeKind.Local).AddTicks(6134), new DateTime(2026, 10, 22, 23, 16, 54, 549, DateTimeKind.Local).AddTicks(6455) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2026, 4, 25, 23, 16, 54, 558, DateTimeKind.Local).AddTicks(3399));

            migrationBuilder.UpdateData(
                table: "FinancialYears",
                keyColumn: "Code",
                keyValue: "2026",
                column: "FinStartDate",
                value: new DateTime(2026, 4, 25, 23, 16, 54, 548, DateTimeKind.Local).AddTicks(7918));

            migrationBuilder.UpdateData(
                table: "UserAuths",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2026, 4, 25, 23, 16, 54, 558, DateTimeKind.Local).AddTicks(6212));

            migrationBuilder.UpdateData(
                table: "UserRole",
                keyColumn: "RoleID",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 4, 25, 23, 16, 54, 557, DateTimeKind.Local).AddTicks(3013), new DateTime(2026, 4, 25, 23, 16, 54, 557, DateTimeKind.Local).AddTicks(3160) });

            migrationBuilder.UpdateData(
                table: "UserRole",
                keyColumn: "RoleID",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 4, 25, 23, 16, 54, 557, DateTimeKind.Local).AddTicks(3273), new DateTime(2026, 4, 25, 23, 16, 54, 557, DateTimeKind.Local).AddTicks(3274) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ProductId",
                table: "TripConsigneeDetails");

            migrationBuilder.DropColumn(
                name: "Qty",
                table: "TripConsigneeDetails");

            migrationBuilder.DropColumn(
                name: "UnitId",
                table: "TripConsigneeDetails");

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2026, 4, 16, 12, 52, 12, 592, DateTimeKind.Local).AddTicks(2793));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2026, 4, 16, 12, 52, 12, 592, DateTimeKind.Local).AddTicks(3881));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2026, 4, 16, 12, 52, 12, 592, DateTimeKind.Local).AddTicks(3884));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2026, 4, 16, 12, 52, 12, 592, DateTimeKind.Local).AddTicks(3886));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2026, 4, 16, 12, 52, 12, 592, DateTimeKind.Local).AddTicks(3888));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2026, 4, 16, 12, 52, 12, 592, DateTimeKind.Local).AddTicks(3889));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2026, 4, 16, 12, 52, 12, 592, DateTimeKind.Local).AddTicks(3993));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2026, 4, 16, 12, 52, 12, 592, DateTimeKind.Local).AddTicks(3995));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2026, 4, 16, 12, 52, 12, 592, DateTimeKind.Local).AddTicks(3997));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2026, 4, 16, 12, 52, 12, 592, DateTimeKind.Local).AddTicks(3999));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2026, 4, 16, 12, 52, 12, 592, DateTimeKind.Local).AddTicks(4001));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2026, 4, 16, 12, 52, 12, 592, DateTimeKind.Local).AddTicks(4002));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2026, 4, 16, 12, 52, 12, 592, DateTimeKind.Local).AddTicks(4004));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 14,
                column: "CreatedAt",
                value: new DateTime(2026, 4, 16, 12, 52, 12, 592, DateTimeKind.Local).AddTicks(4006));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 15,
                column: "CreatedAt",
                value: new DateTime(2026, 4, 16, 12, 52, 12, 592, DateTimeKind.Local).AddTicks(4008));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 16,
                column: "CreatedAt",
                value: new DateTime(2026, 4, 16, 12, 52, 12, 592, DateTimeKind.Local).AddTicks(4010));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 17,
                column: "CreatedAt",
                value: new DateTime(2026, 4, 16, 12, 52, 12, 592, DateTimeKind.Local).AddTicks(4012));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 18,
                column: "CreatedAt",
                value: new DateTime(2026, 4, 16, 12, 52, 12, 592, DateTimeKind.Local).AddTicks(4013));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 19,
                column: "CreatedAt",
                value: new DateTime(2026, 4, 16, 12, 52, 12, 592, DateTimeKind.Local).AddTicks(4015));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 20,
                column: "CreatedAt",
                value: new DateTime(2026, 4, 16, 12, 52, 12, 592, DateTimeKind.Local).AddTicks(4017));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 21,
                column: "CreatedAt",
                value: new DateTime(2026, 4, 16, 12, 52, 12, 592, DateTimeKind.Local).AddTicks(4029));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 22,
                column: "CreatedAt",
                value: new DateTime(2026, 4, 16, 12, 52, 12, 592, DateTimeKind.Local).AddTicks(4101));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 23,
                column: "CreatedAt",
                value: new DateTime(2026, 4, 16, 12, 52, 12, 592, DateTimeKind.Local).AddTicks(4104));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 24,
                column: "CreatedAt",
                value: new DateTime(2026, 4, 16, 12, 52, 12, 592, DateTimeKind.Local).AddTicks(4106));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 25,
                column: "CreatedAt",
                value: new DateTime(2026, 4, 16, 12, 52, 12, 592, DateTimeKind.Local).AddTicks(4108));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 26,
                column: "CreatedAt",
                value: new DateTime(2026, 4, 16, 12, 52, 12, 592, DateTimeKind.Local).AddTicks(4110));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 27,
                column: "CreatedAt",
                value: new DateTime(2026, 4, 16, 12, 52, 12, 592, DateTimeKind.Local).AddTicks(4112));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 28,
                column: "CreatedAt",
                value: new DateTime(2026, 4, 16, 12, 52, 12, 592, DateTimeKind.Local).AddTicks(4113));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 29,
                column: "CreatedAt",
                value: new DateTime(2026, 4, 16, 12, 52, 12, 592, DateTimeKind.Local).AddTicks(4115));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 30,
                column: "CreatedAt",
                value: new DateTime(2026, 4, 16, 12, 52, 12, 592, DateTimeKind.Local).AddTicks(4117));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 31,
                column: "CreatedAt",
                value: new DateTime(2026, 4, 16, 12, 52, 12, 592, DateTimeKind.Local).AddTicks(4119));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 32,
                column: "CreatedAt",
                value: new DateTime(2026, 4, 16, 12, 52, 12, 592, DateTimeKind.Local).AddTicks(4121));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 33,
                column: "CreatedAt",
                value: new DateTime(2026, 4, 16, 12, 52, 12, 592, DateTimeKind.Local).AddTicks(4123));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 34,
                column: "CreatedAt",
                value: new DateTime(2026, 4, 16, 12, 52, 12, 592, DateTimeKind.Local).AddTicks(4125));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 35,
                column: "CreatedAt",
                value: new DateTime(2026, 4, 16, 12, 52, 12, 592, DateTimeKind.Local).AddTicks(4127));

            migrationBuilder.UpdateData(
                table: "Branches",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 4, 16, 12, 52, 12, 589, DateTimeKind.Local).AddTicks(5723), new DateTime(2026, 4, 16, 12, 52, 12, 589, DateTimeKind.Local).AddTicks(5831) });

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "LastUpdatedAt", "LicensedValidTill" },
                values: new object[] { new DateTime(2026, 4, 16, 12, 52, 12, 589, DateTimeKind.Local).AddTicks(2717), new DateTime(2026, 4, 16, 12, 52, 12, 589, DateTimeKind.Local).AddTicks(2941), new DateTime(2026, 10, 13, 12, 52, 12, 589, DateTimeKind.Local).AddTicks(3248) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2026, 4, 16, 12, 52, 12, 593, DateTimeKind.Local).AddTicks(5364));

            migrationBuilder.UpdateData(
                table: "FinancialYears",
                keyColumn: "Code",
                keyValue: "2026",
                column: "FinStartDate",
                value: new DateTime(2026, 4, 16, 12, 52, 12, 588, DateTimeKind.Local).AddTicks(5293));

            migrationBuilder.UpdateData(
                table: "UserAuths",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2026, 4, 16, 12, 52, 12, 593, DateTimeKind.Local).AddTicks(7592));

            migrationBuilder.UpdateData(
                table: "UserRole",
                keyColumn: "RoleID",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 4, 16, 12, 52, 12, 592, DateTimeKind.Local).AddTicks(6675), new DateTime(2026, 4, 16, 12, 52, 12, 592, DateTimeKind.Local).AddTicks(6809) });

            migrationBuilder.UpdateData(
                table: "UserRole",
                keyColumn: "RoleID",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 4, 16, 12, 52, 12, 592, DateTimeKind.Local).AddTicks(6906), new DateTime(2026, 4, 16, 12, 52, 12, 592, DateTimeKind.Local).AddTicks(6907) });
        }
    }
}
