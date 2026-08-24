using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SmartFleet.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddYearCodeUpdate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "YearCode",
                table: "TripTransaction",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<bool>(
                name: "IsYearClosed",
                table: "FinancialYears",
                type: "bit",
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
                columns: new[] { "FinStartDate", "IsYearClosed" },
                values: new object[] { new DateTime(2026, 3, 1, 10, 26, 40, 891, DateTimeKind.Local).AddTicks(2351), null });

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
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "YearCode",
                table: "TripTransaction");

            migrationBuilder.DropColumn(
                name: "IsYearClosed",
                table: "FinancialYears");

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2026, 3, 1, 0, 18, 51, 72, DateTimeKind.Local).AddTicks(2458));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2026, 3, 1, 0, 18, 51, 72, DateTimeKind.Local).AddTicks(3166));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2026, 3, 1, 0, 18, 51, 72, DateTimeKind.Local).AddTicks(3169));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2026, 3, 1, 0, 18, 51, 72, DateTimeKind.Local).AddTicks(3170));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2026, 3, 1, 0, 18, 51, 72, DateTimeKind.Local).AddTicks(3171));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2026, 3, 1, 0, 18, 51, 72, DateTimeKind.Local).AddTicks(3173));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2026, 3, 1, 0, 18, 51, 72, DateTimeKind.Local).AddTicks(3238));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2026, 3, 1, 0, 18, 51, 72, DateTimeKind.Local).AddTicks(3239));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2026, 3, 1, 0, 18, 51, 72, DateTimeKind.Local).AddTicks(3241));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2026, 3, 1, 0, 18, 51, 72, DateTimeKind.Local).AddTicks(3249));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2026, 3, 1, 0, 18, 51, 72, DateTimeKind.Local).AddTicks(3250));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2026, 3, 1, 0, 18, 51, 72, DateTimeKind.Local).AddTicks(3252));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2026, 3, 1, 0, 18, 51, 72, DateTimeKind.Local).AddTicks(3253));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 14,
                column: "CreatedAt",
                value: new DateTime(2026, 3, 1, 0, 18, 51, 72, DateTimeKind.Local).AddTicks(3254));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 15,
                column: "CreatedAt",
                value: new DateTime(2026, 3, 1, 0, 18, 51, 72, DateTimeKind.Local).AddTicks(3255));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 16,
                column: "CreatedAt",
                value: new DateTime(2026, 3, 1, 0, 18, 51, 72, DateTimeKind.Local).AddTicks(3257));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 17,
                column: "CreatedAt",
                value: new DateTime(2026, 3, 1, 0, 18, 51, 72, DateTimeKind.Local).AddTicks(3258));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 18,
                column: "CreatedAt",
                value: new DateTime(2026, 3, 1, 0, 18, 51, 72, DateTimeKind.Local).AddTicks(3259));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 19,
                column: "CreatedAt",
                value: new DateTime(2026, 3, 1, 0, 18, 51, 72, DateTimeKind.Local).AddTicks(3260));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 20,
                column: "CreatedAt",
                value: new DateTime(2026, 3, 1, 0, 18, 51, 72, DateTimeKind.Local).AddTicks(3262));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 21,
                column: "CreatedAt",
                value: new DateTime(2026, 3, 1, 0, 18, 51, 72, DateTimeKind.Local).AddTicks(3263));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 22,
                column: "CreatedAt",
                value: new DateTime(2026, 3, 1, 0, 18, 51, 72, DateTimeKind.Local).AddTicks(3264));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 23,
                column: "CreatedAt",
                value: new DateTime(2026, 3, 1, 0, 18, 51, 72, DateTimeKind.Local).AddTicks(3266));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 24,
                column: "CreatedAt",
                value: new DateTime(2026, 3, 1, 0, 18, 51, 72, DateTimeKind.Local).AddTicks(3267));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 25,
                column: "CreatedAt",
                value: new DateTime(2026, 3, 1, 0, 18, 51, 72, DateTimeKind.Local).AddTicks(3268));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 26,
                column: "CreatedAt",
                value: new DateTime(2026, 3, 1, 0, 18, 51, 72, DateTimeKind.Local).AddTicks(3270));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 27,
                column: "CreatedAt",
                value: new DateTime(2026, 3, 1, 0, 18, 51, 72, DateTimeKind.Local).AddTicks(3271));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 28,
                column: "CreatedAt",
                value: new DateTime(2026, 3, 1, 0, 18, 51, 72, DateTimeKind.Local).AddTicks(3272));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 29,
                column: "CreatedAt",
                value: new DateTime(2026, 3, 1, 0, 18, 51, 72, DateTimeKind.Local).AddTicks(3274));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 30,
                column: "CreatedAt",
                value: new DateTime(2026, 3, 1, 0, 18, 51, 72, DateTimeKind.Local).AddTicks(3275));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 31,
                column: "CreatedAt",
                value: new DateTime(2026, 3, 1, 0, 18, 51, 72, DateTimeKind.Local).AddTicks(3276));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 32,
                column: "CreatedAt",
                value: new DateTime(2026, 3, 1, 0, 18, 51, 72, DateTimeKind.Local).AddTicks(3277));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 33,
                column: "CreatedAt",
                value: new DateTime(2026, 3, 1, 0, 18, 51, 72, DateTimeKind.Local).AddTicks(3279));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 34,
                column: "CreatedAt",
                value: new DateTime(2026, 3, 1, 0, 18, 51, 72, DateTimeKind.Local).AddTicks(3280));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 35,
                column: "CreatedAt",
                value: new DateTime(2026, 3, 1, 0, 18, 51, 72, DateTimeKind.Local).AddTicks(3281));

            migrationBuilder.UpdateData(
                table: "Branches",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 3, 1, 0, 18, 51, 70, DateTimeKind.Local).AddTicks(7123), new DateTime(2026, 3, 1, 0, 18, 51, 70, DateTimeKind.Local).AddTicks(7200) });

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "LastUpdatedAt", "LicensedValidTill" },
                values: new object[] { new DateTime(2026, 3, 1, 0, 18, 51, 70, DateTimeKind.Local).AddTicks(4985), new DateTime(2026, 3, 1, 0, 18, 51, 70, DateTimeKind.Local).AddTicks(5071), new DateTime(2026, 8, 28, 0, 18, 51, 70, DateTimeKind.Local).AddTicks(5278) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2026, 3, 1, 0, 18, 51, 73, DateTimeKind.Local).AddTicks(1295));

            migrationBuilder.UpdateData(
                table: "FinancialYears",
                keyColumn: "Code",
                keyValue: "2026",
                column: "FinStartDate",
                value: new DateTime(2026, 3, 1, 0, 18, 51, 69, DateTimeKind.Local).AddTicks(8876));

            migrationBuilder.UpdateData(
                table: "UserAuths",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2026, 3, 1, 0, 18, 51, 73, DateTimeKind.Local).AddTicks(3032));

            migrationBuilder.UpdateData(
                table: "UserRole",
                keyColumn: "RoleID",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 3, 1, 0, 18, 51, 72, DateTimeKind.Local).AddTicks(4852), new DateTime(2026, 3, 1, 0, 18, 51, 72, DateTimeKind.Local).AddTicks(4938) });

            migrationBuilder.UpdateData(
                table: "UserRole",
                keyColumn: "RoleID",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 3, 1, 0, 18, 51, 72, DateTimeKind.Local).AddTicks(5007), new DateTime(2026, 3, 1, 0, 18, 51, 72, DateTimeKind.Local).AddTicks(5007) });
        }
    }
}
