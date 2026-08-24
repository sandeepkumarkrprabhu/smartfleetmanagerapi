using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SmartFleet.Data.Migrations
{
    /// <inheritdoc />
    public partial class FinancialYearUpdate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "financialYears",
                columns: table => new
                {
                    Code = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    FinStartDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    FinEndDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_financialYears", x => x.Code);
                });

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 17, 20, 46, 35, 497, DateTimeKind.Local).AddTicks(2013));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 17, 20, 46, 35, 497, DateTimeKind.Local).AddTicks(2640));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 17, 20, 46, 35, 497, DateTimeKind.Local).AddTicks(2643));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 17, 20, 46, 35, 497, DateTimeKind.Local).AddTicks(2644));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 17, 20, 46, 35, 497, DateTimeKind.Local).AddTicks(2645));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 17, 20, 46, 35, 497, DateTimeKind.Local).AddTicks(2646));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 17, 20, 46, 35, 497, DateTimeKind.Local).AddTicks(2711));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 17, 20, 46, 35, 497, DateTimeKind.Local).AddTicks(2712));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 17, 20, 46, 35, 497, DateTimeKind.Local).AddTicks(2714));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 17, 20, 46, 35, 497, DateTimeKind.Local).AddTicks(2715));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 17, 20, 46, 35, 497, DateTimeKind.Local).AddTicks(2716));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 17, 20, 46, 35, 497, DateTimeKind.Local).AddTicks(2717));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 17, 20, 46, 35, 497, DateTimeKind.Local).AddTicks(2718));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 14,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 17, 20, 46, 35, 497, DateTimeKind.Local).AddTicks(2727));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 15,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 17, 20, 46, 35, 497, DateTimeKind.Local).AddTicks(2729));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 16,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 17, 20, 46, 35, 497, DateTimeKind.Local).AddTicks(2730));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 17,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 17, 20, 46, 35, 497, DateTimeKind.Local).AddTicks(2731));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 18,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 17, 20, 46, 35, 497, DateTimeKind.Local).AddTicks(2732));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 19,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 17, 20, 46, 35, 497, DateTimeKind.Local).AddTicks(2733));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 20,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 17, 20, 46, 35, 497, DateTimeKind.Local).AddTicks(2735));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 21,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 17, 20, 46, 35, 497, DateTimeKind.Local).AddTicks(2736));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 22,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 17, 20, 46, 35, 497, DateTimeKind.Local).AddTicks(2737));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 23,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 17, 20, 46, 35, 497, DateTimeKind.Local).AddTicks(2738));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 24,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 17, 20, 46, 35, 497, DateTimeKind.Local).AddTicks(2740));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 25,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 17, 20, 46, 35, 497, DateTimeKind.Local).AddTicks(2741));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 26,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 17, 20, 46, 35, 497, DateTimeKind.Local).AddTicks(2742));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 27,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 17, 20, 46, 35, 497, DateTimeKind.Local).AddTicks(2743));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 28,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 17, 20, 46, 35, 497, DateTimeKind.Local).AddTicks(2744));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 29,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 17, 20, 46, 35, 497, DateTimeKind.Local).AddTicks(2746));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 30,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 17, 20, 46, 35, 497, DateTimeKind.Local).AddTicks(2747));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 31,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 17, 20, 46, 35, 497, DateTimeKind.Local).AddTicks(2748));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 32,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 17, 20, 46, 35, 497, DateTimeKind.Local).AddTicks(2749));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 33,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 17, 20, 46, 35, 497, DateTimeKind.Local).AddTicks(2751));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 34,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 17, 20, 46, 35, 497, DateTimeKind.Local).AddTicks(2752));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 35,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 17, 20, 46, 35, 497, DateTimeKind.Local).AddTicks(2753));

            migrationBuilder.UpdateData(
                table: "Branches",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 1, 17, 20, 46, 35, 495, DateTimeKind.Local).AddTicks(8420), new DateTime(2026, 1, 17, 20, 46, 35, 495, DateTimeKind.Local).AddTicks(8497) });

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "LastUpdatedAt", "LicensedValidTill" },
                values: new object[] { new DateTime(2026, 1, 17, 20, 46, 35, 495, DateTimeKind.Local).AddTicks(6424), new DateTime(2026, 1, 17, 20, 46, 35, 495, DateTimeKind.Local).AddTicks(6514), new DateTime(2026, 7, 16, 20, 46, 35, 495, DateTimeKind.Local).AddTicks(6725) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 17, 20, 46, 35, 498, DateTimeKind.Local).AddTicks(750));

            migrationBuilder.UpdateData(
                table: "UserAuths",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 17, 20, 46, 35, 498, DateTimeKind.Local).AddTicks(2518));

            migrationBuilder.UpdateData(
                table: "UserRole",
                keyColumn: "RoleID",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 1, 17, 20, 46, 35, 497, DateTimeKind.Local).AddTicks(4387), new DateTime(2026, 1, 17, 20, 46, 35, 497, DateTimeKind.Local).AddTicks(4475) });

            migrationBuilder.UpdateData(
                table: "UserRole",
                keyColumn: "RoleID",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 1, 17, 20, 46, 35, 497, DateTimeKind.Local).AddTicks(4548), new DateTime(2026, 1, 17, 20, 46, 35, 497, DateTimeKind.Local).AddTicks(4548) });

            migrationBuilder.InsertData(
                table: "financialYears",
                columns: new[] { "Code", "Description", "FinEndDate", "FinStartDate", "IsActive", "Name" },
                values: new object[] { "2026", "2026-20261", new DateTime(2027, 3, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2026, 1, 17, 20, 46, 35, 495, DateTimeKind.Local).AddTicks(715), true, "2026-20261" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "financialYears");

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 14, 20, 57, 43, 476, DateTimeKind.Local).AddTicks(4320));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 14, 20, 57, 43, 476, DateTimeKind.Local).AddTicks(4979));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 14, 20, 57, 43, 476, DateTimeKind.Local).AddTicks(4981));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 14, 20, 57, 43, 476, DateTimeKind.Local).AddTicks(4983));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 14, 20, 57, 43, 476, DateTimeKind.Local).AddTicks(4984));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 14, 20, 57, 43, 476, DateTimeKind.Local).AddTicks(4985));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 14, 20, 57, 43, 476, DateTimeKind.Local).AddTicks(5050));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 14, 20, 57, 43, 476, DateTimeKind.Local).AddTicks(5052));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 14, 20, 57, 43, 476, DateTimeKind.Local).AddTicks(5053));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 14, 20, 57, 43, 476, DateTimeKind.Local).AddTicks(5054));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 14, 20, 57, 43, 476, DateTimeKind.Local).AddTicks(5056));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 14, 20, 57, 43, 476, DateTimeKind.Local).AddTicks(5057));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 14, 20, 57, 43, 476, DateTimeKind.Local).AddTicks(5058));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 14,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 14, 20, 57, 43, 476, DateTimeKind.Local).AddTicks(5059));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 15,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 14, 20, 57, 43, 476, DateTimeKind.Local).AddTicks(5060));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 16,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 14, 20, 57, 43, 476, DateTimeKind.Local).AddTicks(5062));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 17,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 14, 20, 57, 43, 476, DateTimeKind.Local).AddTicks(5070));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 18,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 14, 20, 57, 43, 476, DateTimeKind.Local).AddTicks(5071));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 19,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 14, 20, 57, 43, 476, DateTimeKind.Local).AddTicks(5073));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 20,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 14, 20, 57, 43, 476, DateTimeKind.Local).AddTicks(5074));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 21,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 14, 20, 57, 43, 476, DateTimeKind.Local).AddTicks(5075));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 22,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 14, 20, 57, 43, 476, DateTimeKind.Local).AddTicks(5076));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 23,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 14, 20, 57, 43, 476, DateTimeKind.Local).AddTicks(5077));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 24,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 14, 20, 57, 43, 476, DateTimeKind.Local).AddTicks(5079));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 25,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 14, 20, 57, 43, 476, DateTimeKind.Local).AddTicks(5080));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 26,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 14, 20, 57, 43, 476, DateTimeKind.Local).AddTicks(5081));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 27,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 14, 20, 57, 43, 476, DateTimeKind.Local).AddTicks(5082));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 28,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 14, 20, 57, 43, 476, DateTimeKind.Local).AddTicks(5084));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 29,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 14, 20, 57, 43, 476, DateTimeKind.Local).AddTicks(5085));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 30,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 14, 20, 57, 43, 476, DateTimeKind.Local).AddTicks(5086));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 31,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 14, 20, 57, 43, 476, DateTimeKind.Local).AddTicks(5087));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 32,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 14, 20, 57, 43, 476, DateTimeKind.Local).AddTicks(5089));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 33,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 14, 20, 57, 43, 476, DateTimeKind.Local).AddTicks(5090));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 34,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 14, 20, 57, 43, 476, DateTimeKind.Local).AddTicks(5091));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 35,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 14, 20, 57, 43, 476, DateTimeKind.Local).AddTicks(5092));

            migrationBuilder.UpdateData(
                table: "Branches",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 1, 14, 20, 57, 43, 474, DateTimeKind.Local).AddTicks(9356), new DateTime(2026, 1, 14, 20, 57, 43, 474, DateTimeKind.Local).AddTicks(9445) });

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "LastUpdatedAt", "LicensedValidTill" },
                values: new object[] { new DateTime(2026, 1, 14, 20, 57, 43, 474, DateTimeKind.Local).AddTicks(3811), new DateTime(2026, 1, 14, 20, 57, 43, 474, DateTimeKind.Local).AddTicks(3927), new DateTime(2026, 7, 13, 20, 57, 43, 474, DateTimeKind.Local).AddTicks(4143) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 14, 20, 57, 43, 477, DateTimeKind.Local).AddTicks(1844));

            migrationBuilder.UpdateData(
                table: "UserAuths",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 14, 20, 57, 43, 477, DateTimeKind.Local).AddTicks(3503));

            migrationBuilder.UpdateData(
                table: "UserRole",
                keyColumn: "RoleID",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 1, 14, 20, 57, 43, 476, DateTimeKind.Local).AddTicks(6621), new DateTime(2026, 1, 14, 20, 57, 43, 476, DateTimeKind.Local).AddTicks(6706) });

            migrationBuilder.UpdateData(
                table: "UserRole",
                keyColumn: "RoleID",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 1, 14, 20, 57, 43, 476, DateTimeKind.Local).AddTicks(6776), new DateTime(2026, 1, 14, 20, 57, 43, 476, DateTimeKind.Local).AddTicks(6776) });
        }
    }
}
