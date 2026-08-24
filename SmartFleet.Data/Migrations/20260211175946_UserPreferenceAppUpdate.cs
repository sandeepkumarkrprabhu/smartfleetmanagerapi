using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SmartFleet.Data.Migrations
{
    /// <inheritdoc />
    public partial class UserPreferenceAppUpdate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DefaultModule",
                table: "UserPreferences");

            migrationBuilder.AddColumn<string>(
                name: "KeyName",
                table: "UserPreferences",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "KeyValue",
                table: "UserPreferences",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 11, 23, 29, 43, 543, DateTimeKind.Local).AddTicks(5239));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 11, 23, 29, 43, 543, DateTimeKind.Local).AddTicks(5931));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 11, 23, 29, 43, 543, DateTimeKind.Local).AddTicks(5934));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 11, 23, 29, 43, 543, DateTimeKind.Local).AddTicks(5943));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 11, 23, 29, 43, 543, DateTimeKind.Local).AddTicks(5944));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 11, 23, 29, 43, 543, DateTimeKind.Local).AddTicks(5945));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 11, 23, 29, 43, 543, DateTimeKind.Local).AddTicks(6013));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 11, 23, 29, 43, 543, DateTimeKind.Local).AddTicks(6015));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 11, 23, 29, 43, 543, DateTimeKind.Local).AddTicks(6016));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 11, 23, 29, 43, 543, DateTimeKind.Local).AddTicks(6017));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 11, 23, 29, 43, 543, DateTimeKind.Local).AddTicks(6018));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 11, 23, 29, 43, 543, DateTimeKind.Local).AddTicks(6020));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 11, 23, 29, 43, 543, DateTimeKind.Local).AddTicks(6021));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 14,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 11, 23, 29, 43, 543, DateTimeKind.Local).AddTicks(6022));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 15,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 11, 23, 29, 43, 543, DateTimeKind.Local).AddTicks(6023));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 16,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 11, 23, 29, 43, 543, DateTimeKind.Local).AddTicks(6025));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 17,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 11, 23, 29, 43, 543, DateTimeKind.Local).AddTicks(6026));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 18,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 11, 23, 29, 43, 543, DateTimeKind.Local).AddTicks(6034));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 19,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 11, 23, 29, 43, 543, DateTimeKind.Local).AddTicks(6036));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 20,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 11, 23, 29, 43, 543, DateTimeKind.Local).AddTicks(6037));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 21,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 11, 23, 29, 43, 543, DateTimeKind.Local).AddTicks(6038));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 22,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 11, 23, 29, 43, 543, DateTimeKind.Local).AddTicks(6040));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 23,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 11, 23, 29, 43, 543, DateTimeKind.Local).AddTicks(6041));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 24,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 11, 23, 29, 43, 543, DateTimeKind.Local).AddTicks(6042));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 25,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 11, 23, 29, 43, 543, DateTimeKind.Local).AddTicks(6044));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 26,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 11, 23, 29, 43, 543, DateTimeKind.Local).AddTicks(6045));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 27,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 11, 23, 29, 43, 543, DateTimeKind.Local).AddTicks(6046));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 28,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 11, 23, 29, 43, 543, DateTimeKind.Local).AddTicks(6048));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 29,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 11, 23, 29, 43, 543, DateTimeKind.Local).AddTicks(6049));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 30,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 11, 23, 29, 43, 543, DateTimeKind.Local).AddTicks(6050));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 31,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 11, 23, 29, 43, 543, DateTimeKind.Local).AddTicks(6051));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 32,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 11, 23, 29, 43, 543, DateTimeKind.Local).AddTicks(6053));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 33,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 11, 23, 29, 43, 543, DateTimeKind.Local).AddTicks(6054));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 34,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 11, 23, 29, 43, 543, DateTimeKind.Local).AddTicks(6055));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 35,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 11, 23, 29, 43, 543, DateTimeKind.Local).AddTicks(6057));

            migrationBuilder.UpdateData(
                table: "Branches",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 11, 23, 29, 43, 541, DateTimeKind.Local).AddTicks(6680), new DateTime(2026, 2, 11, 23, 29, 43, 541, DateTimeKind.Local).AddTicks(6756) });

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "LastUpdatedAt", "LicensedValidTill" },
                values: new object[] { new DateTime(2026, 2, 11, 23, 29, 43, 541, DateTimeKind.Local).AddTicks(4561), new DateTime(2026, 2, 11, 23, 29, 43, 541, DateTimeKind.Local).AddTicks(4652), new DateTime(2026, 8, 10, 23, 29, 43, 541, DateTimeKind.Local).AddTicks(4872) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 11, 23, 29, 43, 544, DateTimeKind.Local).AddTicks(3676));

            migrationBuilder.UpdateData(
                table: "FinancialYears",
                keyColumn: "Code",
                keyValue: "2026",
                column: "FinStartDate",
                value: new DateTime(2026, 2, 11, 23, 29, 43, 540, DateTimeKind.Local).AddTicks(8126));

            migrationBuilder.UpdateData(
                table: "UserAuths",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 11, 23, 29, 43, 544, DateTimeKind.Local).AddTicks(5244));

            migrationBuilder.UpdateData(
                table: "UserRole",
                keyColumn: "RoleID",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 11, 23, 29, 43, 543, DateTimeKind.Local).AddTicks(7600), new DateTime(2026, 2, 11, 23, 29, 43, 543, DateTimeKind.Local).AddTicks(7688) });

            migrationBuilder.UpdateData(
                table: "UserRole",
                keyColumn: "RoleID",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 11, 23, 29, 43, 543, DateTimeKind.Local).AddTicks(7755), new DateTime(2026, 2, 11, 23, 29, 43, 543, DateTimeKind.Local).AddTicks(7755) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "KeyName",
                table: "UserPreferences");

            migrationBuilder.DropColumn(
                name: "KeyValue",
                table: "UserPreferences");

            migrationBuilder.AddColumn<int>(
                name: "DefaultModule",
                table: "UserPreferences",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 11, 23, 26, 31, 196, DateTimeKind.Local).AddTicks(9764));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 11, 23, 26, 31, 197, DateTimeKind.Local).AddTicks(513));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 11, 23, 26, 31, 197, DateTimeKind.Local).AddTicks(515));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 11, 23, 26, 31, 197, DateTimeKind.Local).AddTicks(516));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 11, 23, 26, 31, 197, DateTimeKind.Local).AddTicks(518));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 11, 23, 26, 31, 197, DateTimeKind.Local).AddTicks(519));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 11, 23, 26, 31, 197, DateTimeKind.Local).AddTicks(586));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 11, 23, 26, 31, 197, DateTimeKind.Local).AddTicks(588));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 11, 23, 26, 31, 197, DateTimeKind.Local).AddTicks(589));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 11, 23, 26, 31, 197, DateTimeKind.Local).AddTicks(598));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 11, 23, 26, 31, 197, DateTimeKind.Local).AddTicks(599));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 11, 23, 26, 31, 197, DateTimeKind.Local).AddTicks(600));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 11, 23, 26, 31, 197, DateTimeKind.Local).AddTicks(602));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 14,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 11, 23, 26, 31, 197, DateTimeKind.Local).AddTicks(603));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 15,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 11, 23, 26, 31, 197, DateTimeKind.Local).AddTicks(604));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 16,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 11, 23, 26, 31, 197, DateTimeKind.Local).AddTicks(605));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 17,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 11, 23, 26, 31, 197, DateTimeKind.Local).AddTicks(607));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 18,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 11, 23, 26, 31, 197, DateTimeKind.Local).AddTicks(608));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 19,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 11, 23, 26, 31, 197, DateTimeKind.Local).AddTicks(609));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 20,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 11, 23, 26, 31, 197, DateTimeKind.Local).AddTicks(611));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 21,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 11, 23, 26, 31, 197, DateTimeKind.Local).AddTicks(612));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 22,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 11, 23, 26, 31, 197, DateTimeKind.Local).AddTicks(613));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 23,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 11, 23, 26, 31, 197, DateTimeKind.Local).AddTicks(614));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 24,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 11, 23, 26, 31, 197, DateTimeKind.Local).AddTicks(616));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 25,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 11, 23, 26, 31, 197, DateTimeKind.Local).AddTicks(617));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 26,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 11, 23, 26, 31, 197, DateTimeKind.Local).AddTicks(618));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 27,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 11, 23, 26, 31, 197, DateTimeKind.Local).AddTicks(619));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 28,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 11, 23, 26, 31, 197, DateTimeKind.Local).AddTicks(621));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 29,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 11, 23, 26, 31, 197, DateTimeKind.Local).AddTicks(622));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 30,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 11, 23, 26, 31, 197, DateTimeKind.Local).AddTicks(623));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 31,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 11, 23, 26, 31, 197, DateTimeKind.Local).AddTicks(625));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 32,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 11, 23, 26, 31, 197, DateTimeKind.Local).AddTicks(626));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 33,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 11, 23, 26, 31, 197, DateTimeKind.Local).AddTicks(627));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 34,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 11, 23, 26, 31, 197, DateTimeKind.Local).AddTicks(628));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 35,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 11, 23, 26, 31, 197, DateTimeKind.Local).AddTicks(630));

            migrationBuilder.UpdateData(
                table: "Branches",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 11, 23, 26, 31, 195, DateTimeKind.Local).AddTicks(3161), new DateTime(2026, 2, 11, 23, 26, 31, 195, DateTimeKind.Local).AddTicks(3244) });

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "LastUpdatedAt", "LicensedValidTill" },
                values: new object[] { new DateTime(2026, 2, 11, 23, 26, 31, 194, DateTimeKind.Local).AddTicks(9386), new DateTime(2026, 2, 11, 23, 26, 31, 194, DateTimeKind.Local).AddTicks(9530), new DateTime(2026, 8, 10, 23, 26, 31, 195, DateTimeKind.Local).AddTicks(69) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 11, 23, 26, 31, 198, DateTimeKind.Local).AddTicks(941));

            migrationBuilder.UpdateData(
                table: "FinancialYears",
                keyColumn: "Code",
                keyValue: "2026",
                column: "FinStartDate",
                value: new DateTime(2026, 2, 11, 23, 26, 31, 194, DateTimeKind.Local).AddTicks(69));

            migrationBuilder.UpdateData(
                table: "UserAuths",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 11, 23, 26, 31, 198, DateTimeKind.Local).AddTicks(2785));

            migrationBuilder.UpdateData(
                table: "UserRole",
                keyColumn: "RoleID",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 11, 23, 26, 31, 197, DateTimeKind.Local).AddTicks(2762), new DateTime(2026, 2, 11, 23, 26, 31, 197, DateTimeKind.Local).AddTicks(2851) });

            migrationBuilder.UpdateData(
                table: "UserRole",
                keyColumn: "RoleID",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 11, 23, 26, 31, 197, DateTimeKind.Local).AddTicks(2920), new DateTime(2026, 2, 11, 23, 26, 31, 197, DateTimeKind.Local).AddTicks(2921) });
        }
    }
}
