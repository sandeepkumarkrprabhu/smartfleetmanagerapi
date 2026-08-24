using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SmartFleet.Data.Migrations
{
    /// <inheritdoc />
    public partial class tripSalesReturnSatusUpdate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsSalesReturnTrip",
                table: "TripTransaction",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 24, 20, 8, 37, 411, DateTimeKind.Local).AddTicks(3451));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 24, 20, 8, 37, 411, DateTimeKind.Local).AddTicks(4123));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 24, 20, 8, 37, 411, DateTimeKind.Local).AddTicks(4125));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 24, 20, 8, 37, 411, DateTimeKind.Local).AddTicks(4126));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 24, 20, 8, 37, 411, DateTimeKind.Local).AddTicks(4127));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 24, 20, 8, 37, 411, DateTimeKind.Local).AddTicks(4129));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 24, 20, 8, 37, 411, DateTimeKind.Local).AddTicks(4192));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 24, 20, 8, 37, 411, DateTimeKind.Local).AddTicks(4193));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 24, 20, 8, 37, 411, DateTimeKind.Local).AddTicks(4195));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 24, 20, 8, 37, 411, DateTimeKind.Local).AddTicks(4196));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 24, 20, 8, 37, 411, DateTimeKind.Local).AddTicks(4197));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 24, 20, 8, 37, 411, DateTimeKind.Local).AddTicks(4198));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 24, 20, 8, 37, 411, DateTimeKind.Local).AddTicks(4199));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 14,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 24, 20, 8, 37, 411, DateTimeKind.Local).AddTicks(4201));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 15,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 24, 20, 8, 37, 411, DateTimeKind.Local).AddTicks(4202));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 16,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 24, 20, 8, 37, 411, DateTimeKind.Local).AddTicks(4203));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 17,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 24, 20, 8, 37, 411, DateTimeKind.Local).AddTicks(4211));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 18,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 24, 20, 8, 37, 411, DateTimeKind.Local).AddTicks(4212));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 19,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 24, 20, 8, 37, 411, DateTimeKind.Local).AddTicks(4214));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 20,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 24, 20, 8, 37, 411, DateTimeKind.Local).AddTicks(4215));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 21,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 24, 20, 8, 37, 411, DateTimeKind.Local).AddTicks(4216));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 22,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 24, 20, 8, 37, 411, DateTimeKind.Local).AddTicks(4218));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 23,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 24, 20, 8, 37, 411, DateTimeKind.Local).AddTicks(4219));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 24,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 24, 20, 8, 37, 411, DateTimeKind.Local).AddTicks(4220));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 25,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 24, 20, 8, 37, 411, DateTimeKind.Local).AddTicks(4221));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 26,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 24, 20, 8, 37, 411, DateTimeKind.Local).AddTicks(4222));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 27,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 24, 20, 8, 37, 411, DateTimeKind.Local).AddTicks(4224));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 28,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 24, 20, 8, 37, 411, DateTimeKind.Local).AddTicks(4225));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 29,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 24, 20, 8, 37, 411, DateTimeKind.Local).AddTicks(4226));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 30,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 24, 20, 8, 37, 411, DateTimeKind.Local).AddTicks(4227));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 31,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 24, 20, 8, 37, 411, DateTimeKind.Local).AddTicks(4228));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 32,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 24, 20, 8, 37, 411, DateTimeKind.Local).AddTicks(4230));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 33,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 24, 20, 8, 37, 411, DateTimeKind.Local).AddTicks(4231));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 34,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 24, 20, 8, 37, 411, DateTimeKind.Local).AddTicks(4233));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 35,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 24, 20, 8, 37, 411, DateTimeKind.Local).AddTicks(4234));

            migrationBuilder.UpdateData(
                table: "Branches",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 1, 24, 20, 8, 37, 409, DateTimeKind.Local).AddTicks(7858), new DateTime(2026, 1, 24, 20, 8, 37, 409, DateTimeKind.Local).AddTicks(7938) });

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "LastUpdatedAt", "LicensedValidTill" },
                values: new object[] { new DateTime(2026, 1, 24, 20, 8, 37, 409, DateTimeKind.Local).AddTicks(5800), new DateTime(2026, 1, 24, 20, 8, 37, 409, DateTimeKind.Local).AddTicks(5886), new DateTime(2026, 7, 23, 20, 8, 37, 409, DateTimeKind.Local).AddTicks(6096) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 24, 20, 8, 37, 412, DateTimeKind.Local).AddTicks(1811));

            migrationBuilder.UpdateData(
                table: "FinancialYears",
                keyColumn: "Code",
                keyValue: "2026",
                column: "FinStartDate",
                value: new DateTime(2026, 1, 24, 20, 8, 37, 408, DateTimeKind.Local).AddTicks(9552));

            migrationBuilder.UpdateData(
                table: "UserAuths",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 24, 20, 8, 37, 412, DateTimeKind.Local).AddTicks(3352));

            migrationBuilder.UpdateData(
                table: "UserRole",
                keyColumn: "RoleID",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 1, 24, 20, 8, 37, 411, DateTimeKind.Local).AddTicks(5858), new DateTime(2026, 1, 24, 20, 8, 37, 411, DateTimeKind.Local).AddTicks(5949) });

            migrationBuilder.UpdateData(
                table: "UserRole",
                keyColumn: "RoleID",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 1, 24, 20, 8, 37, 411, DateTimeKind.Local).AddTicks(6020), new DateTime(2026, 1, 24, 20, 8, 37, 411, DateTimeKind.Local).AddTicks(6021) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsSalesReturnTrip",
                table: "TripTransaction");

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 24, 19, 31, 54, 857, DateTimeKind.Local).AddTicks(6074));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 24, 19, 31, 54, 857, DateTimeKind.Local).AddTicks(6824));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 24, 19, 31, 54, 857, DateTimeKind.Local).AddTicks(6827));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 24, 19, 31, 54, 857, DateTimeKind.Local).AddTicks(6828));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 24, 19, 31, 54, 857, DateTimeKind.Local).AddTicks(6829));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 24, 19, 31, 54, 857, DateTimeKind.Local).AddTicks(6831));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 24, 19, 31, 54, 857, DateTimeKind.Local).AddTicks(6904));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 24, 19, 31, 54, 857, DateTimeKind.Local).AddTicks(6906));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 24, 19, 31, 54, 857, DateTimeKind.Local).AddTicks(6907));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 24, 19, 31, 54, 857, DateTimeKind.Local).AddTicks(6909));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 24, 19, 31, 54, 857, DateTimeKind.Local).AddTicks(6910));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 24, 19, 31, 54, 857, DateTimeKind.Local).AddTicks(6911));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 24, 19, 31, 54, 857, DateTimeKind.Local).AddTicks(6912));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 14,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 24, 19, 31, 54, 857, DateTimeKind.Local).AddTicks(6914));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 15,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 24, 19, 31, 54, 857, DateTimeKind.Local).AddTicks(6915));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 16,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 24, 19, 31, 54, 857, DateTimeKind.Local).AddTicks(6916));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 17,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 24, 19, 31, 54, 857, DateTimeKind.Local).AddTicks(6925));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 18,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 24, 19, 31, 54, 857, DateTimeKind.Local).AddTicks(6926));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 19,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 24, 19, 31, 54, 857, DateTimeKind.Local).AddTicks(6928));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 20,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 24, 19, 31, 54, 857, DateTimeKind.Local).AddTicks(7015));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 21,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 24, 19, 31, 54, 857, DateTimeKind.Local).AddTicks(7017));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 22,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 24, 19, 31, 54, 857, DateTimeKind.Local).AddTicks(7018));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 23,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 24, 19, 31, 54, 857, DateTimeKind.Local).AddTicks(7019));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 24,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 24, 19, 31, 54, 857, DateTimeKind.Local).AddTicks(7021));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 25,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 24, 19, 31, 54, 857, DateTimeKind.Local).AddTicks(7022));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 26,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 24, 19, 31, 54, 857, DateTimeKind.Local).AddTicks(7023));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 27,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 24, 19, 31, 54, 857, DateTimeKind.Local).AddTicks(7025));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 28,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 24, 19, 31, 54, 857, DateTimeKind.Local).AddTicks(7026));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 29,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 24, 19, 31, 54, 857, DateTimeKind.Local).AddTicks(7027));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 30,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 24, 19, 31, 54, 857, DateTimeKind.Local).AddTicks(7028));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 31,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 24, 19, 31, 54, 857, DateTimeKind.Local).AddTicks(7030));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 32,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 24, 19, 31, 54, 857, DateTimeKind.Local).AddTicks(7031));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 33,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 24, 19, 31, 54, 857, DateTimeKind.Local).AddTicks(7033));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 34,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 24, 19, 31, 54, 857, DateTimeKind.Local).AddTicks(7034));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 35,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 24, 19, 31, 54, 857, DateTimeKind.Local).AddTicks(7035));

            migrationBuilder.UpdateData(
                table: "Branches",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 1, 24, 19, 31, 54, 855, DateTimeKind.Local).AddTicks(8155), new DateTime(2026, 1, 24, 19, 31, 54, 855, DateTimeKind.Local).AddTicks(8243) });

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "LastUpdatedAt", "LicensedValidTill" },
                values: new object[] { new DateTime(2026, 1, 24, 19, 31, 54, 855, DateTimeKind.Local).AddTicks(5673), new DateTime(2026, 1, 24, 19, 31, 54, 855, DateTimeKind.Local).AddTicks(5771), new DateTime(2026, 7, 23, 19, 31, 54, 855, DateTimeKind.Local).AddTicks(6010) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 24, 19, 31, 54, 858, DateTimeKind.Local).AddTicks(5153));

            migrationBuilder.UpdateData(
                table: "FinancialYears",
                keyColumn: "Code",
                keyValue: "2026",
                column: "FinStartDate",
                value: new DateTime(2026, 1, 24, 19, 31, 54, 854, DateTimeKind.Local).AddTicks(7243));

            migrationBuilder.UpdateData(
                table: "UserAuths",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 24, 19, 31, 54, 858, DateTimeKind.Local).AddTicks(6973));

            migrationBuilder.UpdateData(
                table: "UserRole",
                keyColumn: "RoleID",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 1, 24, 19, 31, 54, 857, DateTimeKind.Local).AddTicks(8845), new DateTime(2026, 1, 24, 19, 31, 54, 857, DateTimeKind.Local).AddTicks(8950) });

            migrationBuilder.UpdateData(
                table: "UserRole",
                keyColumn: "RoleID",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 1, 24, 19, 31, 54, 857, DateTimeKind.Local).AddTicks(9030), new DateTime(2026, 1, 24, 19, 31, 54, 857, DateTimeKind.Local).AddTicks(9031) });
        }
    }
}
