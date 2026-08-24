using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SmartFleet.Data.Migrations
{
    /// <inheritdoc />
    public partial class paymentTableUpdateForAccTransaction : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "AccountStatus",
                table: "payments",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "AccountTransactionId",
                table: "payments",
                type: "int",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2026, 3, 8, 13, 2, 58, 351, DateTimeKind.Local).AddTicks(5380));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2026, 3, 8, 13, 2, 58, 351, DateTimeKind.Local).AddTicks(6169));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2026, 3, 8, 13, 2, 58, 351, DateTimeKind.Local).AddTicks(6172));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2026, 3, 8, 13, 2, 58, 351, DateTimeKind.Local).AddTicks(6174));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2026, 3, 8, 13, 2, 58, 351, DateTimeKind.Local).AddTicks(6175));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2026, 3, 8, 13, 2, 58, 351, DateTimeKind.Local).AddTicks(6177));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2026, 3, 8, 13, 2, 58, 351, DateTimeKind.Local).AddTicks(6246));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2026, 3, 8, 13, 2, 58, 351, DateTimeKind.Local).AddTicks(6248));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2026, 3, 8, 13, 2, 58, 351, DateTimeKind.Local).AddTicks(6249));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2026, 3, 8, 13, 2, 58, 351, DateTimeKind.Local).AddTicks(6251));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2026, 3, 8, 13, 2, 58, 351, DateTimeKind.Local).AddTicks(6252));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2026, 3, 8, 13, 2, 58, 351, DateTimeKind.Local).AddTicks(6253));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2026, 3, 8, 13, 2, 58, 351, DateTimeKind.Local).AddTicks(6255));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 14,
                column: "CreatedAt",
                value: new DateTime(2026, 3, 8, 13, 2, 58, 351, DateTimeKind.Local).AddTicks(6256));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 15,
                column: "CreatedAt",
                value: new DateTime(2026, 3, 8, 13, 2, 58, 351, DateTimeKind.Local).AddTicks(6257));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 16,
                column: "CreatedAt",
                value: new DateTime(2026, 3, 8, 13, 2, 58, 351, DateTimeKind.Local).AddTicks(6259));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 17,
                column: "CreatedAt",
                value: new DateTime(2026, 3, 8, 13, 2, 58, 351, DateTimeKind.Local).AddTicks(6267));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 18,
                column: "CreatedAt",
                value: new DateTime(2026, 3, 8, 13, 2, 58, 351, DateTimeKind.Local).AddTicks(6269));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 19,
                column: "CreatedAt",
                value: new DateTime(2026, 3, 8, 13, 2, 58, 351, DateTimeKind.Local).AddTicks(6270));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 20,
                column: "CreatedAt",
                value: new DateTime(2026, 3, 8, 13, 2, 58, 351, DateTimeKind.Local).AddTicks(6272));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 21,
                column: "CreatedAt",
                value: new DateTime(2026, 3, 8, 13, 2, 58, 351, DateTimeKind.Local).AddTicks(6308));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 22,
                column: "CreatedAt",
                value: new DateTime(2026, 3, 8, 13, 2, 58, 351, DateTimeKind.Local).AddTicks(6310));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 23,
                column: "CreatedAt",
                value: new DateTime(2026, 3, 8, 13, 2, 58, 351, DateTimeKind.Local).AddTicks(6311));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 24,
                column: "CreatedAt",
                value: new DateTime(2026, 3, 8, 13, 2, 58, 351, DateTimeKind.Local).AddTicks(6313));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 25,
                column: "CreatedAt",
                value: new DateTime(2026, 3, 8, 13, 2, 58, 351, DateTimeKind.Local).AddTicks(6314));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 26,
                column: "CreatedAt",
                value: new DateTime(2026, 3, 8, 13, 2, 58, 351, DateTimeKind.Local).AddTicks(6315));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 27,
                column: "CreatedAt",
                value: new DateTime(2026, 3, 8, 13, 2, 58, 351, DateTimeKind.Local).AddTicks(6317));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 28,
                column: "CreatedAt",
                value: new DateTime(2026, 3, 8, 13, 2, 58, 351, DateTimeKind.Local).AddTicks(6318));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 29,
                column: "CreatedAt",
                value: new DateTime(2026, 3, 8, 13, 2, 58, 351, DateTimeKind.Local).AddTicks(6320));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 30,
                column: "CreatedAt",
                value: new DateTime(2026, 3, 8, 13, 2, 58, 351, DateTimeKind.Local).AddTicks(6321));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 31,
                column: "CreatedAt",
                value: new DateTime(2026, 3, 8, 13, 2, 58, 351, DateTimeKind.Local).AddTicks(6323));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 32,
                column: "CreatedAt",
                value: new DateTime(2026, 3, 8, 13, 2, 58, 351, DateTimeKind.Local).AddTicks(6324));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 33,
                column: "CreatedAt",
                value: new DateTime(2026, 3, 8, 13, 2, 58, 351, DateTimeKind.Local).AddTicks(6325));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 34,
                column: "CreatedAt",
                value: new DateTime(2026, 3, 8, 13, 2, 58, 351, DateTimeKind.Local).AddTicks(6327));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 35,
                column: "CreatedAt",
                value: new DateTime(2026, 3, 8, 13, 2, 58, 351, DateTimeKind.Local).AddTicks(6328));

            migrationBuilder.UpdateData(
                table: "Branches",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 3, 8, 13, 2, 58, 349, DateTimeKind.Local).AddTicks(8774), new DateTime(2026, 3, 8, 13, 2, 58, 349, DateTimeKind.Local).AddTicks(8859) });

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "LastUpdatedAt", "LicensedValidTill" },
                values: new object[] { new DateTime(2026, 3, 8, 13, 2, 58, 349, DateTimeKind.Local).AddTicks(6163), new DateTime(2026, 3, 8, 13, 2, 58, 349, DateTimeKind.Local).AddTicks(6250), new DateTime(2026, 9, 4, 13, 2, 58, 349, DateTimeKind.Local).AddTicks(6479) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2026, 3, 8, 13, 2, 58, 353, DateTimeKind.Local).AddTicks(2369));

            migrationBuilder.UpdateData(
                table: "FinancialYears",
                keyColumn: "Code",
                keyValue: "2026",
                column: "FinStartDate",
                value: new DateTime(2026, 3, 8, 13, 2, 58, 348, DateTimeKind.Local).AddTicks(8709));

            migrationBuilder.UpdateData(
                table: "UserAuths",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2026, 3, 8, 13, 2, 58, 353, DateTimeKind.Local).AddTicks(7748));

            migrationBuilder.UpdateData(
                table: "UserRole",
                keyColumn: "RoleID",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 3, 8, 13, 2, 58, 351, DateTimeKind.Local).AddTicks(8343), new DateTime(2026, 3, 8, 13, 2, 58, 351, DateTimeKind.Local).AddTicks(8509) });

            migrationBuilder.UpdateData(
                table: "UserRole",
                keyColumn: "RoleID",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 3, 8, 13, 2, 58, 351, DateTimeKind.Local).AddTicks(8628), new DateTime(2026, 3, 8, 13, 2, 58, 351, DateTimeKind.Local).AddTicks(8628) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AccountStatus",
                table: "payments");

            migrationBuilder.DropColumn(
                name: "AccountTransactionId",
                table: "payments");

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2026, 3, 5, 15, 31, 55, 687, DateTimeKind.Local).AddTicks(2491));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2026, 3, 5, 15, 31, 55, 687, DateTimeKind.Local).AddTicks(3239));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2026, 3, 5, 15, 31, 55, 687, DateTimeKind.Local).AddTicks(3242));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2026, 3, 5, 15, 31, 55, 687, DateTimeKind.Local).AddTicks(3243));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2026, 3, 5, 15, 31, 55, 687, DateTimeKind.Local).AddTicks(3245));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2026, 3, 5, 15, 31, 55, 687, DateTimeKind.Local).AddTicks(3246));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2026, 3, 5, 15, 31, 55, 687, DateTimeKind.Local).AddTicks(3316));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2026, 3, 5, 15, 31, 55, 687, DateTimeKind.Local).AddTicks(3318));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2026, 3, 5, 15, 31, 55, 687, DateTimeKind.Local).AddTicks(3320));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2026, 3, 5, 15, 31, 55, 687, DateTimeKind.Local).AddTicks(3321));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2026, 3, 5, 15, 31, 55, 687, DateTimeKind.Local).AddTicks(3323));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2026, 3, 5, 15, 31, 55, 687, DateTimeKind.Local).AddTicks(3324));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2026, 3, 5, 15, 31, 55, 687, DateTimeKind.Local).AddTicks(3325));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 14,
                column: "CreatedAt",
                value: new DateTime(2026, 3, 5, 15, 31, 55, 687, DateTimeKind.Local).AddTicks(3327));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 15,
                column: "CreatedAt",
                value: new DateTime(2026, 3, 5, 15, 31, 55, 687, DateTimeKind.Local).AddTicks(3328));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 16,
                column: "CreatedAt",
                value: new DateTime(2026, 3, 5, 15, 31, 55, 687, DateTimeKind.Local).AddTicks(3338));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 17,
                column: "CreatedAt",
                value: new DateTime(2026, 3, 5, 15, 31, 55, 687, DateTimeKind.Local).AddTicks(3339));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 18,
                column: "CreatedAt",
                value: new DateTime(2026, 3, 5, 15, 31, 55, 687, DateTimeKind.Local).AddTicks(3341));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 19,
                column: "CreatedAt",
                value: new DateTime(2026, 3, 5, 15, 31, 55, 687, DateTimeKind.Local).AddTicks(3342));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 20,
                column: "CreatedAt",
                value: new DateTime(2026, 3, 5, 15, 31, 55, 687, DateTimeKind.Local).AddTicks(3344));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 21,
                column: "CreatedAt",
                value: new DateTime(2026, 3, 5, 15, 31, 55, 687, DateTimeKind.Local).AddTicks(3345));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 22,
                column: "CreatedAt",
                value: new DateTime(2026, 3, 5, 15, 31, 55, 687, DateTimeKind.Local).AddTicks(3346));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 23,
                column: "CreatedAt",
                value: new DateTime(2026, 3, 5, 15, 31, 55, 687, DateTimeKind.Local).AddTicks(3348));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 24,
                column: "CreatedAt",
                value: new DateTime(2026, 3, 5, 15, 31, 55, 687, DateTimeKind.Local).AddTicks(3349));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 25,
                column: "CreatedAt",
                value: new DateTime(2026, 3, 5, 15, 31, 55, 687, DateTimeKind.Local).AddTicks(3351));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 26,
                column: "CreatedAt",
                value: new DateTime(2026, 3, 5, 15, 31, 55, 687, DateTimeKind.Local).AddTicks(3352));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 27,
                column: "CreatedAt",
                value: new DateTime(2026, 3, 5, 15, 31, 55, 687, DateTimeKind.Local).AddTicks(3353));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 28,
                column: "CreatedAt",
                value: new DateTime(2026, 3, 5, 15, 31, 55, 687, DateTimeKind.Local).AddTicks(3355));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 29,
                column: "CreatedAt",
                value: new DateTime(2026, 3, 5, 15, 31, 55, 687, DateTimeKind.Local).AddTicks(3356));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 30,
                column: "CreatedAt",
                value: new DateTime(2026, 3, 5, 15, 31, 55, 687, DateTimeKind.Local).AddTicks(3358));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 31,
                column: "CreatedAt",
                value: new DateTime(2026, 3, 5, 15, 31, 55, 687, DateTimeKind.Local).AddTicks(3359));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 32,
                column: "CreatedAt",
                value: new DateTime(2026, 3, 5, 15, 31, 55, 687, DateTimeKind.Local).AddTicks(3360));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 33,
                column: "CreatedAt",
                value: new DateTime(2026, 3, 5, 15, 31, 55, 687, DateTimeKind.Local).AddTicks(3362));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 34,
                column: "CreatedAt",
                value: new DateTime(2026, 3, 5, 15, 31, 55, 687, DateTimeKind.Local).AddTicks(3363));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 35,
                column: "CreatedAt",
                value: new DateTime(2026, 3, 5, 15, 31, 55, 687, DateTimeKind.Local).AddTicks(3365));

            migrationBuilder.UpdateData(
                table: "Branches",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 3, 5, 15, 31, 55, 685, DateTimeKind.Local).AddTicks(3701), new DateTime(2026, 3, 5, 15, 31, 55, 685, DateTimeKind.Local).AddTicks(3789) });

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "LastUpdatedAt", "LicensedValidTill" },
                values: new object[] { new DateTime(2026, 3, 5, 15, 31, 55, 685, DateTimeKind.Local).AddTicks(1495), new DateTime(2026, 3, 5, 15, 31, 55, 685, DateTimeKind.Local).AddTicks(1581), new DateTime(2026, 9, 1, 15, 31, 55, 685, DateTimeKind.Local).AddTicks(1797) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2026, 3, 5, 15, 31, 55, 688, DateTimeKind.Local).AddTicks(1768));

            migrationBuilder.UpdateData(
                table: "FinancialYears",
                keyColumn: "Code",
                keyValue: "2026",
                column: "FinStartDate",
                value: new DateTime(2026, 3, 5, 15, 31, 55, 684, DateTimeKind.Local).AddTicks(5454));

            migrationBuilder.UpdateData(
                table: "UserAuths",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2026, 3, 5, 15, 31, 55, 688, DateTimeKind.Local).AddTicks(3491));

            migrationBuilder.UpdateData(
                table: "UserRole",
                keyColumn: "RoleID",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 3, 5, 15, 31, 55, 687, DateTimeKind.Local).AddTicks(5069), new DateTime(2026, 3, 5, 15, 31, 55, 687, DateTimeKind.Local).AddTicks(5163) });

            migrationBuilder.UpdateData(
                table: "UserRole",
                keyColumn: "RoleID",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 3, 5, 15, 31, 55, 687, DateTimeKind.Local).AddTicks(5237), new DateTime(2026, 3, 5, 15, 31, 55, 687, DateTimeKind.Local).AddTicks(5237) });
        }
    }
}
