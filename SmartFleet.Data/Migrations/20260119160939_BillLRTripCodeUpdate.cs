using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SmartFleet.Data.Migrations
{
    /// <inheritdoc />
    public partial class BillLRTripCodeUpdate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "code",
                table: "BillItemDetails",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 19, 21, 39, 36, 887, DateTimeKind.Local).AddTicks(4563));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 19, 21, 39, 36, 887, DateTimeKind.Local).AddTicks(5467));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 19, 21, 39, 36, 887, DateTimeKind.Local).AddTicks(5469));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 19, 21, 39, 36, 887, DateTimeKind.Local).AddTicks(5471));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 19, 21, 39, 36, 887, DateTimeKind.Local).AddTicks(5472));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 19, 21, 39, 36, 887, DateTimeKind.Local).AddTicks(5473));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 19, 21, 39, 36, 887, DateTimeKind.Local).AddTicks(5541));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 19, 21, 39, 36, 887, DateTimeKind.Local).AddTicks(5552));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 19, 21, 39, 36, 887, DateTimeKind.Local).AddTicks(5553));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 19, 21, 39, 36, 887, DateTimeKind.Local).AddTicks(5554));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 19, 21, 39, 36, 887, DateTimeKind.Local).AddTicks(5555));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 19, 21, 39, 36, 887, DateTimeKind.Local).AddTicks(5557));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 19, 21, 39, 36, 887, DateTimeKind.Local).AddTicks(5558));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 14,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 19, 21, 39, 36, 887, DateTimeKind.Local).AddTicks(5559));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 15,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 19, 21, 39, 36, 887, DateTimeKind.Local).AddTicks(5560));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 16,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 19, 21, 39, 36, 887, DateTimeKind.Local).AddTicks(5562));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 17,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 19, 21, 39, 36, 887, DateTimeKind.Local).AddTicks(5563));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 18,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 19, 21, 39, 36, 887, DateTimeKind.Local).AddTicks(5564));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 19,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 19, 21, 39, 36, 887, DateTimeKind.Local).AddTicks(5565));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 20,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 19, 21, 39, 36, 887, DateTimeKind.Local).AddTicks(5567));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 21,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 19, 21, 39, 36, 887, DateTimeKind.Local).AddTicks(5568));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 22,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 19, 21, 39, 36, 887, DateTimeKind.Local).AddTicks(5569));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 23,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 19, 21, 39, 36, 887, DateTimeKind.Local).AddTicks(5571));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 24,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 19, 21, 39, 36, 887, DateTimeKind.Local).AddTicks(5572));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 25,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 19, 21, 39, 36, 887, DateTimeKind.Local).AddTicks(5573));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 26,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 19, 21, 39, 36, 887, DateTimeKind.Local).AddTicks(5575));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 27,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 19, 21, 39, 36, 887, DateTimeKind.Local).AddTicks(5576));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 28,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 19, 21, 39, 36, 887, DateTimeKind.Local).AddTicks(5577));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 29,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 19, 21, 39, 36, 887, DateTimeKind.Local).AddTicks(5579));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 30,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 19, 21, 39, 36, 887, DateTimeKind.Local).AddTicks(5580));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 31,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 19, 21, 39, 36, 887, DateTimeKind.Local).AddTicks(5581));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 32,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 19, 21, 39, 36, 887, DateTimeKind.Local).AddTicks(5582));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 33,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 19, 21, 39, 36, 887, DateTimeKind.Local).AddTicks(5584));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 34,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 19, 21, 39, 36, 887, DateTimeKind.Local).AddTicks(5585));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 35,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 19, 21, 39, 36, 887, DateTimeKind.Local).AddTicks(5586));

            migrationBuilder.UpdateData(
                table: "Branches",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 1, 19, 21, 39, 36, 881, DateTimeKind.Local).AddTicks(5088), new DateTime(2026, 1, 19, 21, 39, 36, 881, DateTimeKind.Local).AddTicks(5177) });

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "LastUpdatedAt", "LicensedValidTill" },
                values: new object[] { new DateTime(2026, 1, 19, 21, 39, 36, 881, DateTimeKind.Local).AddTicks(2432), new DateTime(2026, 1, 19, 21, 39, 36, 881, DateTimeKind.Local).AddTicks(2524), new DateTime(2026, 7, 18, 21, 39, 36, 881, DateTimeKind.Local).AddTicks(2745) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 19, 21, 39, 36, 888, DateTimeKind.Local).AddTicks(4622));

            migrationBuilder.UpdateData(
                table: "FinancialYears",
                keyColumn: "Code",
                keyValue: "2026",
                column: "FinStartDate",
                value: new DateTime(2026, 1, 19, 21, 39, 36, 880, DateTimeKind.Local).AddTicks(3169));

            migrationBuilder.UpdateData(
                table: "UserAuths",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 19, 21, 39, 36, 888, DateTimeKind.Local).AddTicks(6668));

            migrationBuilder.UpdateData(
                table: "UserRole",
                keyColumn: "RoleID",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 1, 19, 21, 39, 36, 887, DateTimeKind.Local).AddTicks(8212), new DateTime(2026, 1, 19, 21, 39, 36, 887, DateTimeKind.Local).AddTicks(8306) });

            migrationBuilder.UpdateData(
                table: "UserRole",
                keyColumn: "RoleID",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 1, 19, 21, 39, 36, 887, DateTimeKind.Local).AddTicks(8420), new DateTime(2026, 1, 19, 21, 39, 36, 887, DateTimeKind.Local).AddTicks(8421) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "code",
                table: "BillItemDetails");

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 18, 23, 10, 43, 990, DateTimeKind.Local).AddTicks(4420));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 18, 23, 10, 43, 990, DateTimeKind.Local).AddTicks(5119));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 18, 23, 10, 43, 990, DateTimeKind.Local).AddTicks(5122));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 18, 23, 10, 43, 990, DateTimeKind.Local).AddTicks(5123));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 18, 23, 10, 43, 990, DateTimeKind.Local).AddTicks(5124));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 18, 23, 10, 43, 990, DateTimeKind.Local).AddTicks(5126));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 18, 23, 10, 43, 990, DateTimeKind.Local).AddTicks(5191));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 18, 23, 10, 43, 990, DateTimeKind.Local).AddTicks(5193));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 18, 23, 10, 43, 990, DateTimeKind.Local).AddTicks(5194));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 18, 23, 10, 43, 990, DateTimeKind.Local).AddTicks(5195));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 18, 23, 10, 43, 990, DateTimeKind.Local).AddTicks(5197));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 18, 23, 10, 43, 990, DateTimeKind.Local).AddTicks(5198));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 18, 23, 10, 43, 990, DateTimeKind.Local).AddTicks(5199));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 14,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 18, 23, 10, 43, 990, DateTimeKind.Local).AddTicks(5200));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 15,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 18, 23, 10, 43, 990, DateTimeKind.Local).AddTicks(5201));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 16,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 18, 23, 10, 43, 990, DateTimeKind.Local).AddTicks(5202));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 17,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 18, 23, 10, 43, 990, DateTimeKind.Local).AddTicks(5204));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 18,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 18, 23, 10, 43, 990, DateTimeKind.Local).AddTicks(5212));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 19,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 18, 23, 10, 43, 990, DateTimeKind.Local).AddTicks(5213));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 20,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 18, 23, 10, 43, 990, DateTimeKind.Local).AddTicks(5214));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 21,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 18, 23, 10, 43, 990, DateTimeKind.Local).AddTicks(5216));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 22,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 18, 23, 10, 43, 990, DateTimeKind.Local).AddTicks(5217));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 23,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 18, 23, 10, 43, 990, DateTimeKind.Local).AddTicks(5218));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 24,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 18, 23, 10, 43, 990, DateTimeKind.Local).AddTicks(5219));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 25,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 18, 23, 10, 43, 990, DateTimeKind.Local).AddTicks(5220));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 26,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 18, 23, 10, 43, 990, DateTimeKind.Local).AddTicks(5222));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 27,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 18, 23, 10, 43, 990, DateTimeKind.Local).AddTicks(5223));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 28,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 18, 23, 10, 43, 990, DateTimeKind.Local).AddTicks(5224));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 29,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 18, 23, 10, 43, 990, DateTimeKind.Local).AddTicks(5225));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 30,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 18, 23, 10, 43, 990, DateTimeKind.Local).AddTicks(5226));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 31,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 18, 23, 10, 43, 990, DateTimeKind.Local).AddTicks(5228));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 32,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 18, 23, 10, 43, 990, DateTimeKind.Local).AddTicks(5229));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 33,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 18, 23, 10, 43, 990, DateTimeKind.Local).AddTicks(5230));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 34,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 18, 23, 10, 43, 990, DateTimeKind.Local).AddTicks(5231));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 35,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 18, 23, 10, 43, 990, DateTimeKind.Local).AddTicks(5233));

            migrationBuilder.UpdateData(
                table: "Branches",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 1, 18, 23, 10, 43, 989, DateTimeKind.Local).AddTicks(618), new DateTime(2026, 1, 18, 23, 10, 43, 989, DateTimeKind.Local).AddTicks(696) });

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "LastUpdatedAt", "LicensedValidTill" },
                values: new object[] { new DateTime(2026, 1, 18, 23, 10, 43, 988, DateTimeKind.Local).AddTicks(8426), new DateTime(2026, 1, 18, 23, 10, 43, 988, DateTimeKind.Local).AddTicks(8509), new DateTime(2026, 7, 17, 23, 10, 43, 988, DateTimeKind.Local).AddTicks(8784) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 18, 23, 10, 43, 991, DateTimeKind.Local).AddTicks(1697));

            migrationBuilder.UpdateData(
                table: "FinancialYears",
                keyColumn: "Code",
                keyValue: "2026",
                column: "FinStartDate",
                value: new DateTime(2026, 1, 18, 23, 10, 43, 988, DateTimeKind.Local).AddTicks(2867));

            migrationBuilder.UpdateData(
                table: "UserAuths",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 18, 23, 10, 43, 991, DateTimeKind.Local).AddTicks(3077));

            migrationBuilder.UpdateData(
                table: "UserRole",
                keyColumn: "RoleID",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 1, 18, 23, 10, 43, 990, DateTimeKind.Local).AddTicks(6785), new DateTime(2026, 1, 18, 23, 10, 43, 990, DateTimeKind.Local).AddTicks(6867) });

            migrationBuilder.UpdateData(
                table: "UserRole",
                keyColumn: "RoleID",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 1, 18, 23, 10, 43, 990, DateTimeKind.Local).AddTicks(6955), new DateTime(2026, 1, 18, 23, 10, 43, 990, DateTimeKind.Local).AddTicks(6956) });
        }
    }
}
