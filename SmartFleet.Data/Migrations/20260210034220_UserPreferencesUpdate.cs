using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SmartFleet.Data.Migrations
{
    /// <inheritdoc />
    public partial class UserPreferencesUpdate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "AccountMode",
                table: "AccountMasters",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 1,
                columns: new[] { "AccountMode", "CreatedAt" },
                values: new object[] { null, new DateTime(2026, 2, 10, 9, 12, 17, 197, DateTimeKind.Local).AddTicks(3514) });

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 2,
                columns: new[] { "AccountMode", "CreatedAt" },
                values: new object[] { null, new DateTime(2026, 2, 10, 9, 12, 17, 197, DateTimeKind.Local).AddTicks(4188) });

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 3,
                columns: new[] { "AccountMode", "CreatedAt" },
                values: new object[] { null, new DateTime(2026, 2, 10, 9, 12, 17, 197, DateTimeKind.Local).AddTicks(4191) });

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 4,
                columns: new[] { "AccountMode", "CreatedAt" },
                values: new object[] { null, new DateTime(2026, 2, 10, 9, 12, 17, 197, DateTimeKind.Local).AddTicks(4192) });

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 5,
                columns: new[] { "AccountMode", "CreatedAt" },
                values: new object[] { null, new DateTime(2026, 2, 10, 9, 12, 17, 197, DateTimeKind.Local).AddTicks(4193) });

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 6,
                columns: new[] { "AccountMode", "CreatedAt" },
                values: new object[] { null, new DateTime(2026, 2, 10, 9, 12, 17, 197, DateTimeKind.Local).AddTicks(4202) });

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 7,
                columns: new[] { "AccountMode", "CreatedAt" },
                values: new object[] { null, new DateTime(2026, 2, 10, 9, 12, 17, 197, DateTimeKind.Local).AddTicks(4266) });

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 8,
                columns: new[] { "AccountMode", "CreatedAt" },
                values: new object[] { null, new DateTime(2026, 2, 10, 9, 12, 17, 197, DateTimeKind.Local).AddTicks(4267) });

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 9,
                columns: new[] { "AccountMode", "CreatedAt" },
                values: new object[] { null, new DateTime(2026, 2, 10, 9, 12, 17, 197, DateTimeKind.Local).AddTicks(4269) });

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 10,
                columns: new[] { "AccountMode", "CreatedAt" },
                values: new object[] { null, new DateTime(2026, 2, 10, 9, 12, 17, 197, DateTimeKind.Local).AddTicks(4270) });

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 11,
                columns: new[] { "AccountMode", "CreatedAt" },
                values: new object[] { null, new DateTime(2026, 2, 10, 9, 12, 17, 197, DateTimeKind.Local).AddTicks(4271) });

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 12,
                columns: new[] { "AccountMode", "CreatedAt" },
                values: new object[] { null, new DateTime(2026, 2, 10, 9, 12, 17, 197, DateTimeKind.Local).AddTicks(4273) });

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 13,
                columns: new[] { "AccountMode", "CreatedAt" },
                values: new object[] { null, new DateTime(2026, 2, 10, 9, 12, 17, 197, DateTimeKind.Local).AddTicks(4274) });

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 14,
                columns: new[] { "AccountMode", "CreatedAt" },
                values: new object[] { null, new DateTime(2026, 2, 10, 9, 12, 17, 197, DateTimeKind.Local).AddTicks(4275) });

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 15,
                columns: new[] { "AccountMode", "CreatedAt" },
                values: new object[] { null, new DateTime(2026, 2, 10, 9, 12, 17, 197, DateTimeKind.Local).AddTicks(4277) });

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 16,
                columns: new[] { "AccountMode", "CreatedAt" },
                values: new object[] { null, new DateTime(2026, 2, 10, 9, 12, 17, 197, DateTimeKind.Local).AddTicks(4278) });

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 17,
                columns: new[] { "AccountMode", "CreatedAt" },
                values: new object[] { null, new DateTime(2026, 2, 10, 9, 12, 17, 197, DateTimeKind.Local).AddTicks(4279) });

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 18,
                columns: new[] { "AccountMode", "CreatedAt" },
                values: new object[] { null, new DateTime(2026, 2, 10, 9, 12, 17, 197, DateTimeKind.Local).AddTicks(4280) });

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 19,
                columns: new[] { "AccountMode", "CreatedAt" },
                values: new object[] { null, new DateTime(2026, 2, 10, 9, 12, 17, 197, DateTimeKind.Local).AddTicks(4282) });

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 20,
                columns: new[] { "AccountMode", "CreatedAt" },
                values: new object[] { null, new DateTime(2026, 2, 10, 9, 12, 17, 197, DateTimeKind.Local).AddTicks(4290) });

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 21,
                columns: new[] { "AccountMode", "CreatedAt" },
                values: new object[] { null, new DateTime(2026, 2, 10, 9, 12, 17, 197, DateTimeKind.Local).AddTicks(4292) });

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 22,
                columns: new[] { "AccountMode", "CreatedAt" },
                values: new object[] { null, new DateTime(2026, 2, 10, 9, 12, 17, 197, DateTimeKind.Local).AddTicks(4293) });

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 23,
                columns: new[] { "AccountMode", "CreatedAt" },
                values: new object[] { null, new DateTime(2026, 2, 10, 9, 12, 17, 197, DateTimeKind.Local).AddTicks(4294) });

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 24,
                columns: new[] { "AccountMode", "CreatedAt" },
                values: new object[] { null, new DateTime(2026, 2, 10, 9, 12, 17, 197, DateTimeKind.Local).AddTicks(4295) });

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 25,
                columns: new[] { "AccountMode", "CreatedAt" },
                values: new object[] { null, new DateTime(2026, 2, 10, 9, 12, 17, 197, DateTimeKind.Local).AddTicks(4297) });

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 26,
                columns: new[] { "AccountMode", "CreatedAt" },
                values: new object[] { null, new DateTime(2026, 2, 10, 9, 12, 17, 197, DateTimeKind.Local).AddTicks(4298) });

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 27,
                columns: new[] { "AccountMode", "CreatedAt" },
                values: new object[] { null, new DateTime(2026, 2, 10, 9, 12, 17, 197, DateTimeKind.Local).AddTicks(4299) });

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 28,
                columns: new[] { "AccountMode", "CreatedAt" },
                values: new object[] { null, new DateTime(2026, 2, 10, 9, 12, 17, 197, DateTimeKind.Local).AddTicks(4301) });

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 29,
                columns: new[] { "AccountMode", "CreatedAt" },
                values: new object[] { null, new DateTime(2026, 2, 10, 9, 12, 17, 197, DateTimeKind.Local).AddTicks(4302) });

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 30,
                columns: new[] { "AccountMode", "CreatedAt" },
                values: new object[] { null, new DateTime(2026, 2, 10, 9, 12, 17, 197, DateTimeKind.Local).AddTicks(4303) });

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 31,
                columns: new[] { "AccountMode", "CreatedAt" },
                values: new object[] { null, new DateTime(2026, 2, 10, 9, 12, 17, 197, DateTimeKind.Local).AddTicks(4305) });

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 32,
                columns: new[] { "AccountMode", "CreatedAt" },
                values: new object[] { null, new DateTime(2026, 2, 10, 9, 12, 17, 197, DateTimeKind.Local).AddTicks(4306) });

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 33,
                columns: new[] { "AccountMode", "CreatedAt" },
                values: new object[] { null, new DateTime(2026, 2, 10, 9, 12, 17, 197, DateTimeKind.Local).AddTicks(4307) });

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 34,
                columns: new[] { "AccountMode", "CreatedAt" },
                values: new object[] { null, new DateTime(2026, 2, 10, 9, 12, 17, 197, DateTimeKind.Local).AddTicks(4309) });

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 35,
                columns: new[] { "AccountMode", "CreatedAt" },
                values: new object[] { null, new DateTime(2026, 2, 10, 9, 12, 17, 197, DateTimeKind.Local).AddTicks(4310) });

            migrationBuilder.UpdateData(
                table: "Branches",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 10, 9, 12, 17, 195, DateTimeKind.Local).AddTicks(7364), new DateTime(2026, 2, 10, 9, 12, 17, 195, DateTimeKind.Local).AddTicks(7448) });

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "LastUpdatedAt", "LicensedValidTill" },
                values: new object[] { new DateTime(2026, 2, 10, 9, 12, 17, 195, DateTimeKind.Local).AddTicks(5237), new DateTime(2026, 2, 10, 9, 12, 17, 195, DateTimeKind.Local).AddTicks(5326), new DateTime(2026, 8, 9, 9, 12, 17, 195, DateTimeKind.Local).AddTicks(5550) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 9, 12, 17, 198, DateTimeKind.Local).AddTicks(2270));

            migrationBuilder.UpdateData(
                table: "FinancialYears",
                keyColumn: "Code",
                keyValue: "2026",
                column: "FinStartDate",
                value: new DateTime(2026, 2, 10, 9, 12, 17, 194, DateTimeKind.Local).AddTicks(9325));

            migrationBuilder.UpdateData(
                table: "UserAuths",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 10, 9, 12, 17, 198, DateTimeKind.Local).AddTicks(3866));

            migrationBuilder.UpdateData(
                table: "UserRole",
                keyColumn: "RoleID",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 10, 9, 12, 17, 197, DateTimeKind.Local).AddTicks(6197), new DateTime(2026, 2, 10, 9, 12, 17, 197, DateTimeKind.Local).AddTicks(6286) });

            migrationBuilder.UpdateData(
                table: "UserRole",
                keyColumn: "RoleID",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 10, 9, 12, 17, 197, DateTimeKind.Local).AddTicks(6357), new DateTime(2026, 2, 10, 9, 12, 17, 197, DateTimeKind.Local).AddTicks(6358) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AccountMode",
                table: "AccountMasters");

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 6, 15, 12, 18, 26, DateTimeKind.Local).AddTicks(9579));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 6, 15, 12, 18, 27, DateTimeKind.Local).AddTicks(246));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 6, 15, 12, 18, 27, DateTimeKind.Local).AddTicks(248));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 6, 15, 12, 18, 27, DateTimeKind.Local).AddTicks(250));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 6, 15, 12, 18, 27, DateTimeKind.Local).AddTicks(251));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 6, 15, 12, 18, 27, DateTimeKind.Local).AddTicks(288));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 6, 15, 12, 18, 27, DateTimeKind.Local).AddTicks(353));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 6, 15, 12, 18, 27, DateTimeKind.Local).AddTicks(355));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 6, 15, 12, 18, 27, DateTimeKind.Local).AddTicks(356));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 6, 15, 12, 18, 27, DateTimeKind.Local).AddTicks(358));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 6, 15, 12, 18, 27, DateTimeKind.Local).AddTicks(359));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 6, 15, 12, 18, 27, DateTimeKind.Local).AddTicks(360));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 6, 15, 12, 18, 27, DateTimeKind.Local).AddTicks(361));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 14,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 6, 15, 12, 18, 27, DateTimeKind.Local).AddTicks(363));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 15,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 6, 15, 12, 18, 27, DateTimeKind.Local).AddTicks(364));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 16,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 6, 15, 12, 18, 27, DateTimeKind.Local).AddTicks(365));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 17,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 6, 15, 12, 18, 27, DateTimeKind.Local).AddTicks(366));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 18,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 6, 15, 12, 18, 27, DateTimeKind.Local).AddTicks(368));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 19,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 6, 15, 12, 18, 27, DateTimeKind.Local).AddTicks(369));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 20,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 6, 15, 12, 18, 27, DateTimeKind.Local).AddTicks(378));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 21,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 6, 15, 12, 18, 27, DateTimeKind.Local).AddTicks(380));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 22,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 6, 15, 12, 18, 27, DateTimeKind.Local).AddTicks(381));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 23,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 6, 15, 12, 18, 27, DateTimeKind.Local).AddTicks(382));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 24,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 6, 15, 12, 18, 27, DateTimeKind.Local).AddTicks(383));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 25,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 6, 15, 12, 18, 27, DateTimeKind.Local).AddTicks(385));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 26,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 6, 15, 12, 18, 27, DateTimeKind.Local).AddTicks(386));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 27,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 6, 15, 12, 18, 27, DateTimeKind.Local).AddTicks(388));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 28,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 6, 15, 12, 18, 27, DateTimeKind.Local).AddTicks(389));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 29,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 6, 15, 12, 18, 27, DateTimeKind.Local).AddTicks(390));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 30,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 6, 15, 12, 18, 27, DateTimeKind.Local).AddTicks(392));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 31,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 6, 15, 12, 18, 27, DateTimeKind.Local).AddTicks(393));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 32,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 6, 15, 12, 18, 27, DateTimeKind.Local).AddTicks(394));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 33,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 6, 15, 12, 18, 27, DateTimeKind.Local).AddTicks(396));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 34,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 6, 15, 12, 18, 27, DateTimeKind.Local).AddTicks(397));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 35,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 6, 15, 12, 18, 27, DateTimeKind.Local).AddTicks(398));

            migrationBuilder.UpdateData(
                table: "Branches",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 6, 15, 12, 18, 25, DateTimeKind.Local).AddTicks(3655), new DateTime(2026, 2, 6, 15, 12, 18, 25, DateTimeKind.Local).AddTicks(3728) });

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "LastUpdatedAt", "LicensedValidTill" },
                values: new object[] { new DateTime(2026, 2, 6, 15, 12, 18, 25, DateTimeKind.Local).AddTicks(1731), new DateTime(2026, 2, 6, 15, 12, 18, 25, DateTimeKind.Local).AddTicks(1812), new DateTime(2026, 8, 5, 15, 12, 18, 25, DateTimeKind.Local).AddTicks(2019) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 6, 15, 12, 18, 27, DateTimeKind.Local).AddTicks(7821));

            migrationBuilder.UpdateData(
                table: "FinancialYears",
                keyColumn: "Code",
                keyValue: "2026",
                column: "FinStartDate",
                value: new DateTime(2026, 2, 6, 15, 12, 18, 24, DateTimeKind.Local).AddTicks(5692));

            migrationBuilder.UpdateData(
                table: "UserAuths",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 6, 15, 12, 18, 27, DateTimeKind.Local).AddTicks(9293));

            migrationBuilder.UpdateData(
                table: "UserRole",
                keyColumn: "RoleID",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 6, 15, 12, 18, 27, DateTimeKind.Local).AddTicks(2143), new DateTime(2026, 2, 6, 15, 12, 18, 27, DateTimeKind.Local).AddTicks(2228) });

            migrationBuilder.UpdateData(
                table: "UserRole",
                keyColumn: "RoleID",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 6, 15, 12, 18, 27, DateTimeKind.Local).AddTicks(2298), new DateTime(2026, 2, 6, 15, 12, 18, 27, DateTimeKind.Local).AddTicks(2299) });
        }
    }
}
