using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SmartFleet.Data.Migrations
{
    /// <inheritdoc />
    public partial class TripTransactionVendorChargesUpdate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<decimal>(
                name: "VendorRentCharges",
                table: "TripTransaction",
                type: "decimal(18,2)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 25, 19, 19, 31, 120, DateTimeKind.Local).AddTicks(4880));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 25, 19, 19, 31, 120, DateTimeKind.Local).AddTicks(5586));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 25, 19, 19, 31, 120, DateTimeKind.Local).AddTicks(5588));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 25, 19, 19, 31, 120, DateTimeKind.Local).AddTicks(5590));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 25, 19, 19, 31, 120, DateTimeKind.Local).AddTicks(5592));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 25, 19, 19, 31, 120, DateTimeKind.Local).AddTicks(5593));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 25, 19, 19, 31, 120, DateTimeKind.Local).AddTicks(5662));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 25, 19, 19, 31, 120, DateTimeKind.Local).AddTicks(5664));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 25, 19, 19, 31, 120, DateTimeKind.Local).AddTicks(5665));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 25, 19, 19, 31, 120, DateTimeKind.Local).AddTicks(5667));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 25, 19, 19, 31, 120, DateTimeKind.Local).AddTicks(5668));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 25, 19, 19, 31, 120, DateTimeKind.Local).AddTicks(5669));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 25, 19, 19, 31, 120, DateTimeKind.Local).AddTicks(5670));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 14,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 25, 19, 19, 31, 120, DateTimeKind.Local).AddTicks(5672));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 15,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 25, 19, 19, 31, 120, DateTimeKind.Local).AddTicks(5673));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 16,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 25, 19, 19, 31, 120, DateTimeKind.Local).AddTicks(5674));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 17,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 25, 19, 19, 31, 120, DateTimeKind.Local).AddTicks(5684));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 18,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 25, 19, 19, 31, 120, DateTimeKind.Local).AddTicks(5685));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 19,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 25, 19, 19, 31, 120, DateTimeKind.Local).AddTicks(5686));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 20,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 25, 19, 19, 31, 120, DateTimeKind.Local).AddTicks(5688));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 21,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 25, 19, 19, 31, 120, DateTimeKind.Local).AddTicks(5689));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 22,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 25, 19, 19, 31, 120, DateTimeKind.Local).AddTicks(5690));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 23,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 25, 19, 19, 31, 120, DateTimeKind.Local).AddTicks(5691));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 24,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 25, 19, 19, 31, 120, DateTimeKind.Local).AddTicks(5693));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 25,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 25, 19, 19, 31, 120, DateTimeKind.Local).AddTicks(5694));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 26,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 25, 19, 19, 31, 120, DateTimeKind.Local).AddTicks(5695));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 27,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 25, 19, 19, 31, 120, DateTimeKind.Local).AddTicks(5697));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 28,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 25, 19, 19, 31, 120, DateTimeKind.Local).AddTicks(5698));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 29,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 25, 19, 19, 31, 120, DateTimeKind.Local).AddTicks(5699));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 30,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 25, 19, 19, 31, 120, DateTimeKind.Local).AddTicks(5700));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 31,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 25, 19, 19, 31, 120, DateTimeKind.Local).AddTicks(5702));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 32,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 25, 19, 19, 31, 120, DateTimeKind.Local).AddTicks(5703));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 33,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 25, 19, 19, 31, 120, DateTimeKind.Local).AddTicks(5705));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 34,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 25, 19, 19, 31, 120, DateTimeKind.Local).AddTicks(5742));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 35,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 25, 19, 19, 31, 120, DateTimeKind.Local).AddTicks(5743));

            migrationBuilder.UpdateData(
                table: "Branches",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 1, 25, 19, 19, 31, 118, DateTimeKind.Local).AddTicks(9616), new DateTime(2026, 1, 25, 19, 19, 31, 118, DateTimeKind.Local).AddTicks(9697) });

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "LastUpdatedAt", "LicensedValidTill" },
                values: new object[] { new DateTime(2026, 1, 25, 19, 19, 31, 118, DateTimeKind.Local).AddTicks(7511), new DateTime(2026, 1, 25, 19, 19, 31, 118, DateTimeKind.Local).AddTicks(7603), new DateTime(2026, 7, 24, 19, 19, 31, 118, DateTimeKind.Local).AddTicks(7815) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 25, 19, 19, 31, 121, DateTimeKind.Local).AddTicks(3586));

            migrationBuilder.UpdateData(
                table: "FinancialYears",
                keyColumn: "Code",
                keyValue: "2026",
                column: "FinStartDate",
                value: new DateTime(2026, 1, 25, 19, 19, 31, 118, DateTimeKind.Local).AddTicks(1595));

            migrationBuilder.UpdateData(
                table: "UserAuths",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 25, 19, 19, 31, 121, DateTimeKind.Local).AddTicks(5222));

            migrationBuilder.UpdateData(
                table: "UserRole",
                keyColumn: "RoleID",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 1, 25, 19, 19, 31, 120, DateTimeKind.Local).AddTicks(7556), new DateTime(2026, 1, 25, 19, 19, 31, 120, DateTimeKind.Local).AddTicks(7657) });

            migrationBuilder.UpdateData(
                table: "UserRole",
                keyColumn: "RoleID",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 1, 25, 19, 19, 31, 120, DateTimeKind.Local).AddTicks(7733), new DateTime(2026, 1, 25, 19, 19, 31, 120, DateTimeKind.Local).AddTicks(7735) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "VendorRentCharges",
                table: "TripTransaction");

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 25, 19, 10, 57, 322, DateTimeKind.Local).AddTicks(7920));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 25, 19, 10, 57, 322, DateTimeKind.Local).AddTicks(8663));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 25, 19, 10, 57, 322, DateTimeKind.Local).AddTicks(8665));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 25, 19, 10, 57, 322, DateTimeKind.Local).AddTicks(8667));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 25, 19, 10, 57, 322, DateTimeKind.Local).AddTicks(8668));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 25, 19, 10, 57, 322, DateTimeKind.Local).AddTicks(8669));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 25, 19, 10, 57, 322, DateTimeKind.Local).AddTicks(8739));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 25, 19, 10, 57, 322, DateTimeKind.Local).AddTicks(8740));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 25, 19, 10, 57, 322, DateTimeKind.Local).AddTicks(8742));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 25, 19, 10, 57, 322, DateTimeKind.Local).AddTicks(8750));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 25, 19, 10, 57, 322, DateTimeKind.Local).AddTicks(8823));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 25, 19, 10, 57, 322, DateTimeKind.Local).AddTicks(8824));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 25, 19, 10, 57, 322, DateTimeKind.Local).AddTicks(8825));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 14,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 25, 19, 10, 57, 322, DateTimeKind.Local).AddTicks(8826));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 15,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 25, 19, 10, 57, 322, DateTimeKind.Local).AddTicks(8828));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 16,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 25, 19, 10, 57, 322, DateTimeKind.Local).AddTicks(8829));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 17,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 25, 19, 10, 57, 322, DateTimeKind.Local).AddTicks(8830));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 18,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 25, 19, 10, 57, 322, DateTimeKind.Local).AddTicks(8831));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 19,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 25, 19, 10, 57, 322, DateTimeKind.Local).AddTicks(8832));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 20,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 25, 19, 10, 57, 322, DateTimeKind.Local).AddTicks(8834));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 21,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 25, 19, 10, 57, 322, DateTimeKind.Local).AddTicks(8835));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 22,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 25, 19, 10, 57, 322, DateTimeKind.Local).AddTicks(8836));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 23,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 25, 19, 10, 57, 322, DateTimeKind.Local).AddTicks(8837));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 24,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 25, 19, 10, 57, 322, DateTimeKind.Local).AddTicks(8838));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 25,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 25, 19, 10, 57, 322, DateTimeKind.Local).AddTicks(8840));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 26,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 25, 19, 10, 57, 322, DateTimeKind.Local).AddTicks(8841));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 27,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 25, 19, 10, 57, 322, DateTimeKind.Local).AddTicks(8842));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 28,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 25, 19, 10, 57, 322, DateTimeKind.Local).AddTicks(8843));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 29,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 25, 19, 10, 57, 322, DateTimeKind.Local).AddTicks(8845));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 30,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 25, 19, 10, 57, 322, DateTimeKind.Local).AddTicks(8846));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 31,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 25, 19, 10, 57, 322, DateTimeKind.Local).AddTicks(8847));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 32,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 25, 19, 10, 57, 322, DateTimeKind.Local).AddTicks(8848));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 33,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 25, 19, 10, 57, 322, DateTimeKind.Local).AddTicks(8850));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 34,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 25, 19, 10, 57, 322, DateTimeKind.Local).AddTicks(8851));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 35,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 25, 19, 10, 57, 322, DateTimeKind.Local).AddTicks(8852));

            migrationBuilder.UpdateData(
                table: "Branches",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 1, 25, 19, 10, 57, 321, DateTimeKind.Local).AddTicks(2343), new DateTime(2026, 1, 25, 19, 10, 57, 321, DateTimeKind.Local).AddTicks(2429) });

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "LastUpdatedAt", "LicensedValidTill" },
                values: new object[] { new DateTime(2026, 1, 25, 19, 10, 57, 320, DateTimeKind.Local).AddTicks(9990), new DateTime(2026, 1, 25, 19, 10, 57, 321, DateTimeKind.Local).AddTicks(83), new DateTime(2026, 7, 24, 19, 10, 57, 321, DateTimeKind.Local).AddTicks(302) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 25, 19, 10, 57, 323, DateTimeKind.Local).AddTicks(6309));

            migrationBuilder.UpdateData(
                table: "FinancialYears",
                keyColumn: "Code",
                keyValue: "2026",
                column: "FinStartDate",
                value: new DateTime(2026, 1, 25, 19, 10, 57, 320, DateTimeKind.Local).AddTicks(2986));

            migrationBuilder.UpdateData(
                table: "UserAuths",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 25, 19, 10, 57, 323, DateTimeKind.Local).AddTicks(7856));

            migrationBuilder.UpdateData(
                table: "UserRole",
                keyColumn: "RoleID",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 1, 25, 19, 10, 57, 323, DateTimeKind.Local).AddTicks(487), new DateTime(2026, 1, 25, 19, 10, 57, 323, DateTimeKind.Local).AddTicks(579) });

            migrationBuilder.UpdateData(
                table: "UserRole",
                keyColumn: "RoleID",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 1, 25, 19, 10, 57, 323, DateTimeKind.Local).AddTicks(647), new DateTime(2026, 1, 25, 19, 10, 57, 323, DateTimeKind.Local).AddTicks(647) });
        }
    }
}
