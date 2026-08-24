using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SmartFleet.Data.Migrations
{
    /// <inheritdoc />
    public partial class TripConsigneeGoodsValueUpdate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<decimal>(
                name: "GoodsValue",
                table: "TripConsigneeDetails",
                type: "decimal(18,2)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 25, 20, 29, 29, 140, DateTimeKind.Local).AddTicks(7029));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 25, 20, 29, 29, 140, DateTimeKind.Local).AddTicks(7860));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 25, 20, 29, 29, 140, DateTimeKind.Local).AddTicks(7862));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 25, 20, 29, 29, 140, DateTimeKind.Local).AddTicks(7864));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 25, 20, 29, 29, 140, DateTimeKind.Local).AddTicks(7865));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 25, 20, 29, 29, 140, DateTimeKind.Local).AddTicks(7866));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 25, 20, 29, 29, 140, DateTimeKind.Local).AddTicks(7938));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 25, 20, 29, 29, 140, DateTimeKind.Local).AddTicks(7940));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 25, 20, 29, 29, 140, DateTimeKind.Local).AddTicks(7941));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 25, 20, 29, 29, 140, DateTimeKind.Local).AddTicks(7943));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 25, 20, 29, 29, 140, DateTimeKind.Local).AddTicks(7944));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 25, 20, 29, 29, 140, DateTimeKind.Local).AddTicks(7946));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 25, 20, 29, 29, 140, DateTimeKind.Local).AddTicks(8003));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 14,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 25, 20, 29, 29, 140, DateTimeKind.Local).AddTicks(8005));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 15,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 25, 20, 29, 29, 140, DateTimeKind.Local).AddTicks(8006));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 16,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 25, 20, 29, 29, 140, DateTimeKind.Local).AddTicks(8008));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 17,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 25, 20, 29, 29, 140, DateTimeKind.Local).AddTicks(8017));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 18,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 25, 20, 29, 29, 140, DateTimeKind.Local).AddTicks(8019));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 19,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 25, 20, 29, 29, 140, DateTimeKind.Local).AddTicks(8020));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 20,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 25, 20, 29, 29, 140, DateTimeKind.Local).AddTicks(8022));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 21,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 25, 20, 29, 29, 140, DateTimeKind.Local).AddTicks(8023));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 22,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 25, 20, 29, 29, 140, DateTimeKind.Local).AddTicks(8024));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 23,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 25, 20, 29, 29, 140, DateTimeKind.Local).AddTicks(8026));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 24,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 25, 20, 29, 29, 140, DateTimeKind.Local).AddTicks(8027));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 25,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 25, 20, 29, 29, 140, DateTimeKind.Local).AddTicks(8028));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 26,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 25, 20, 29, 29, 140, DateTimeKind.Local).AddTicks(8030));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 27,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 25, 20, 29, 29, 140, DateTimeKind.Local).AddTicks(8031));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 28,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 25, 20, 29, 29, 140, DateTimeKind.Local).AddTicks(8032));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 29,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 25, 20, 29, 29, 140, DateTimeKind.Local).AddTicks(8034));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 30,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 25, 20, 29, 29, 140, DateTimeKind.Local).AddTicks(8035));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 31,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 25, 20, 29, 29, 140, DateTimeKind.Local).AddTicks(8036));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 32,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 25, 20, 29, 29, 140, DateTimeKind.Local).AddTicks(8038));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 33,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 25, 20, 29, 29, 140, DateTimeKind.Local).AddTicks(8039));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 34,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 25, 20, 29, 29, 140, DateTimeKind.Local).AddTicks(8041));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 35,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 25, 20, 29, 29, 140, DateTimeKind.Local).AddTicks(8042));

            migrationBuilder.UpdateData(
                table: "Branches",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 1, 25, 20, 29, 29, 138, DateTimeKind.Local).AddTicks(6267), new DateTime(2026, 1, 25, 20, 29, 29, 138, DateTimeKind.Local).AddTicks(6516) });

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "LastUpdatedAt", "LicensedValidTill" },
                values: new object[] { new DateTime(2026, 1, 25, 20, 29, 29, 138, DateTimeKind.Local).AddTicks(2917), new DateTime(2026, 1, 25, 20, 29, 29, 138, DateTimeKind.Local).AddTicks(3036), new DateTime(2026, 7, 24, 20, 29, 29, 138, DateTimeKind.Local).AddTicks(3708) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 25, 20, 29, 29, 141, DateTimeKind.Local).AddTicks(5563));

            migrationBuilder.UpdateData(
                table: "FinancialYears",
                keyColumn: "Code",
                keyValue: "2026",
                column: "FinStartDate",
                value: new DateTime(2026, 1, 25, 20, 29, 29, 137, DateTimeKind.Local).AddTicks(4408));

            migrationBuilder.UpdateData(
                table: "UserAuths",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 25, 20, 29, 29, 141, DateTimeKind.Local).AddTicks(7234));

            migrationBuilder.UpdateData(
                table: "UserRole",
                keyColumn: "RoleID",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 1, 25, 20, 29, 29, 140, DateTimeKind.Local).AddTicks(9889), new DateTime(2026, 1, 25, 20, 29, 29, 140, DateTimeKind.Local).AddTicks(9985) });

            migrationBuilder.UpdateData(
                table: "UserRole",
                keyColumn: "RoleID",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 1, 25, 20, 29, 29, 141, DateTimeKind.Local).AddTicks(63), new DateTime(2026, 1, 25, 20, 29, 29, 141, DateTimeKind.Local).AddTicks(64) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "GoodsValue",
                table: "TripConsigneeDetails");

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
    }
}
