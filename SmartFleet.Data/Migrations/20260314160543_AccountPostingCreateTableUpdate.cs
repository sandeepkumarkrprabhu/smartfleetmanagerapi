using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SmartFleet.Data.Migrations
{
    /// <inheritdoc />
    public partial class AccountPostingCreateTableUpdate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "accountPostingSettings",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DocumentType = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    DocumentSubType = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    DebitAccountId = table.Column<int>(type: "int", nullable: false),
                    CreditAccountID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_accountPostingSettings", x => x.Id);
                });

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2026, 3, 14, 21, 35, 39, 502, DateTimeKind.Local).AddTicks(3246));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2026, 3, 14, 21, 35, 39, 502, DateTimeKind.Local).AddTicks(4053));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2026, 3, 14, 21, 35, 39, 502, DateTimeKind.Local).AddTicks(4056));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2026, 3, 14, 21, 35, 39, 502, DateTimeKind.Local).AddTicks(4058));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2026, 3, 14, 21, 35, 39, 502, DateTimeKind.Local).AddTicks(4059));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2026, 3, 14, 21, 35, 39, 502, DateTimeKind.Local).AddTicks(4101));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2026, 3, 14, 21, 35, 39, 502, DateTimeKind.Local).AddTicks(4171));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2026, 3, 14, 21, 35, 39, 502, DateTimeKind.Local).AddTicks(4173));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2026, 3, 14, 21, 35, 39, 502, DateTimeKind.Local).AddTicks(4175));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2026, 3, 14, 21, 35, 39, 502, DateTimeKind.Local).AddTicks(4176));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2026, 3, 14, 21, 35, 39, 502, DateTimeKind.Local).AddTicks(4178));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2026, 3, 14, 21, 35, 39, 502, DateTimeKind.Local).AddTicks(4179));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2026, 3, 14, 21, 35, 39, 502, DateTimeKind.Local).AddTicks(4180));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 14,
                column: "CreatedAt",
                value: new DateTime(2026, 3, 14, 21, 35, 39, 502, DateTimeKind.Local).AddTicks(4182));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 15,
                column: "CreatedAt",
                value: new DateTime(2026, 3, 14, 21, 35, 39, 502, DateTimeKind.Local).AddTicks(4183));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 16,
                column: "CreatedAt",
                value: new DateTime(2026, 3, 14, 21, 35, 39, 502, DateTimeKind.Local).AddTicks(4193));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 17,
                column: "CreatedAt",
                value: new DateTime(2026, 3, 14, 21, 35, 39, 502, DateTimeKind.Local).AddTicks(4195));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 18,
                column: "CreatedAt",
                value: new DateTime(2026, 3, 14, 21, 35, 39, 502, DateTimeKind.Local).AddTicks(4196));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 19,
                column: "CreatedAt",
                value: new DateTime(2026, 3, 14, 21, 35, 39, 502, DateTimeKind.Local).AddTicks(4198));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 20,
                column: "CreatedAt",
                value: new DateTime(2026, 3, 14, 21, 35, 39, 502, DateTimeKind.Local).AddTicks(4199));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 21,
                column: "CreatedAt",
                value: new DateTime(2026, 3, 14, 21, 35, 39, 502, DateTimeKind.Local).AddTicks(4201));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 22,
                column: "CreatedAt",
                value: new DateTime(2026, 3, 14, 21, 35, 39, 502, DateTimeKind.Local).AddTicks(4202));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 23,
                column: "CreatedAt",
                value: new DateTime(2026, 3, 14, 21, 35, 39, 502, DateTimeKind.Local).AddTicks(4203));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 24,
                column: "CreatedAt",
                value: new DateTime(2026, 3, 14, 21, 35, 39, 502, DateTimeKind.Local).AddTicks(4205));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 25,
                column: "CreatedAt",
                value: new DateTime(2026, 3, 14, 21, 35, 39, 502, DateTimeKind.Local).AddTicks(4206));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 26,
                column: "CreatedAt",
                value: new DateTime(2026, 3, 14, 21, 35, 39, 502, DateTimeKind.Local).AddTicks(4208));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 27,
                column: "CreatedAt",
                value: new DateTime(2026, 3, 14, 21, 35, 39, 502, DateTimeKind.Local).AddTicks(4209));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 28,
                column: "CreatedAt",
                value: new DateTime(2026, 3, 14, 21, 35, 39, 502, DateTimeKind.Local).AddTicks(4210));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 29,
                column: "CreatedAt",
                value: new DateTime(2026, 3, 14, 21, 35, 39, 502, DateTimeKind.Local).AddTicks(4212));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 30,
                column: "CreatedAt",
                value: new DateTime(2026, 3, 14, 21, 35, 39, 502, DateTimeKind.Local).AddTicks(4213));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 31,
                column: "CreatedAt",
                value: new DateTime(2026, 3, 14, 21, 35, 39, 502, DateTimeKind.Local).AddTicks(4215));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 32,
                column: "CreatedAt",
                value: new DateTime(2026, 3, 14, 21, 35, 39, 502, DateTimeKind.Local).AddTicks(4216));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 33,
                column: "CreatedAt",
                value: new DateTime(2026, 3, 14, 21, 35, 39, 502, DateTimeKind.Local).AddTicks(4217));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 34,
                column: "CreatedAt",
                value: new DateTime(2026, 3, 14, 21, 35, 39, 502, DateTimeKind.Local).AddTicks(4219));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 35,
                column: "CreatedAt",
                value: new DateTime(2026, 3, 14, 21, 35, 39, 502, DateTimeKind.Local).AddTicks(4220));

            migrationBuilder.UpdateData(
                table: "Branches",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 3, 14, 21, 35, 39, 500, DateTimeKind.Local).AddTicks(5834), new DateTime(2026, 3, 14, 21, 35, 39, 500, DateTimeKind.Local).AddTicks(5916) });

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "LastUpdatedAt", "LicensedValidTill" },
                values: new object[] { new DateTime(2026, 3, 14, 21, 35, 39, 500, DateTimeKind.Local).AddTicks(3229), new DateTime(2026, 3, 14, 21, 35, 39, 500, DateTimeKind.Local).AddTicks(3310), new DateTime(2026, 9, 10, 21, 35, 39, 500, DateTimeKind.Local).AddTicks(3515) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2026, 3, 14, 21, 35, 39, 503, DateTimeKind.Local).AddTicks(3484));

            migrationBuilder.UpdateData(
                table: "FinancialYears",
                keyColumn: "Code",
                keyValue: "2026",
                column: "FinStartDate",
                value: new DateTime(2026, 3, 14, 21, 35, 39, 499, DateTimeKind.Local).AddTicks(7664));

            migrationBuilder.UpdateData(
                table: "UserAuths",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2026, 3, 14, 21, 35, 39, 503, DateTimeKind.Local).AddTicks(4971));

            migrationBuilder.UpdateData(
                table: "UserRole",
                keyColumn: "RoleID",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 3, 14, 21, 35, 39, 502, DateTimeKind.Local).AddTicks(6434), new DateTime(2026, 3, 14, 21, 35, 39, 502, DateTimeKind.Local).AddTicks(6528) });

            migrationBuilder.UpdateData(
                table: "UserRole",
                keyColumn: "RoleID",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 3, 14, 21, 35, 39, 502, DateTimeKind.Local).AddTicks(6602), new DateTime(2026, 3, 14, 21, 35, 39, 502, DateTimeKind.Local).AddTicks(6603) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "accountPostingSettings");

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2026, 3, 14, 21, 25, 38, 615, DateTimeKind.Local).AddTicks(5393));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2026, 3, 14, 21, 25, 38, 615, DateTimeKind.Local).AddTicks(6109));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2026, 3, 14, 21, 25, 38, 615, DateTimeKind.Local).AddTicks(6111));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2026, 3, 14, 21, 25, 38, 615, DateTimeKind.Local).AddTicks(6113));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2026, 3, 14, 21, 25, 38, 615, DateTimeKind.Local).AddTicks(6114));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2026, 3, 14, 21, 25, 38, 615, DateTimeKind.Local).AddTicks(6115));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2026, 3, 14, 21, 25, 38, 615, DateTimeKind.Local).AddTicks(6191));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2026, 3, 14, 21, 25, 38, 615, DateTimeKind.Local).AddTicks(6193));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2026, 3, 14, 21, 25, 38, 615, DateTimeKind.Local).AddTicks(6194));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2026, 3, 14, 21, 25, 38, 615, DateTimeKind.Local).AddTicks(6196));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2026, 3, 14, 21, 25, 38, 615, DateTimeKind.Local).AddTicks(6197));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2026, 3, 14, 21, 25, 38, 615, DateTimeKind.Local).AddTicks(6198));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2026, 3, 14, 21, 25, 38, 615, DateTimeKind.Local).AddTicks(6200));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 14,
                column: "CreatedAt",
                value: new DateTime(2026, 3, 14, 21, 25, 38, 615, DateTimeKind.Local).AddTicks(6201));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 15,
                column: "CreatedAt",
                value: new DateTime(2026, 3, 14, 21, 25, 38, 615, DateTimeKind.Local).AddTicks(6202));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 16,
                column: "CreatedAt",
                value: new DateTime(2026, 3, 14, 21, 25, 38, 615, DateTimeKind.Local).AddTicks(6203));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 17,
                column: "CreatedAt",
                value: new DateTime(2026, 3, 14, 21, 25, 38, 615, DateTimeKind.Local).AddTicks(6205));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 18,
                column: "CreatedAt",
                value: new DateTime(2026, 3, 14, 21, 25, 38, 615, DateTimeKind.Local).AddTicks(6206));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 19,
                column: "CreatedAt",
                value: new DateTime(2026, 3, 14, 21, 25, 38, 615, DateTimeKind.Local).AddTicks(6207));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 20,
                column: "CreatedAt",
                value: new DateTime(2026, 3, 14, 21, 25, 38, 615, DateTimeKind.Local).AddTicks(6209));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 21,
                column: "CreatedAt",
                value: new DateTime(2026, 3, 14, 21, 25, 38, 615, DateTimeKind.Local).AddTicks(6216));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 22,
                column: "CreatedAt",
                value: new DateTime(2026, 3, 14, 21, 25, 38, 615, DateTimeKind.Local).AddTicks(6217));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 23,
                column: "CreatedAt",
                value: new DateTime(2026, 3, 14, 21, 25, 38, 615, DateTimeKind.Local).AddTicks(6218));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 24,
                column: "CreatedAt",
                value: new DateTime(2026, 3, 14, 21, 25, 38, 615, DateTimeKind.Local).AddTicks(6220));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 25,
                column: "CreatedAt",
                value: new DateTime(2026, 3, 14, 21, 25, 38, 615, DateTimeKind.Local).AddTicks(6221));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 26,
                column: "CreatedAt",
                value: new DateTime(2026, 3, 14, 21, 25, 38, 615, DateTimeKind.Local).AddTicks(6222));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 27,
                column: "CreatedAt",
                value: new DateTime(2026, 3, 14, 21, 25, 38, 615, DateTimeKind.Local).AddTicks(6224));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 28,
                column: "CreatedAt",
                value: new DateTime(2026, 3, 14, 21, 25, 38, 615, DateTimeKind.Local).AddTicks(6225));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 29,
                column: "CreatedAt",
                value: new DateTime(2026, 3, 14, 21, 25, 38, 615, DateTimeKind.Local).AddTicks(6226));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 30,
                column: "CreatedAt",
                value: new DateTime(2026, 3, 14, 21, 25, 38, 615, DateTimeKind.Local).AddTicks(6228));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 31,
                column: "CreatedAt",
                value: new DateTime(2026, 3, 14, 21, 25, 38, 615, DateTimeKind.Local).AddTicks(6258));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 32,
                column: "CreatedAt",
                value: new DateTime(2026, 3, 14, 21, 25, 38, 615, DateTimeKind.Local).AddTicks(6259));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 33,
                column: "CreatedAt",
                value: new DateTime(2026, 3, 14, 21, 25, 38, 615, DateTimeKind.Local).AddTicks(6261));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 34,
                column: "CreatedAt",
                value: new DateTime(2026, 3, 14, 21, 25, 38, 615, DateTimeKind.Local).AddTicks(6262));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 35,
                column: "CreatedAt",
                value: new DateTime(2026, 3, 14, 21, 25, 38, 615, DateTimeKind.Local).AddTicks(6264));

            migrationBuilder.UpdateData(
                table: "Branches",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 3, 14, 21, 25, 38, 613, DateTimeKind.Local).AddTicks(9703), new DateTime(2026, 3, 14, 21, 25, 38, 613, DateTimeKind.Local).AddTicks(9786) });

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "LastUpdatedAt", "LicensedValidTill" },
                values: new object[] { new DateTime(2026, 3, 14, 21, 25, 38, 613, DateTimeKind.Local).AddTicks(7668), new DateTime(2026, 3, 14, 21, 25, 38, 613, DateTimeKind.Local).AddTicks(7754), new DateTime(2026, 9, 10, 21, 25, 38, 613, DateTimeKind.Local).AddTicks(7971) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2026, 3, 14, 21, 25, 38, 616, DateTimeKind.Local).AddTicks(4758));

            migrationBuilder.UpdateData(
                table: "FinancialYears",
                keyColumn: "Code",
                keyValue: "2026",
                column: "FinStartDate",
                value: new DateTime(2026, 3, 14, 21, 25, 38, 613, DateTimeKind.Local).AddTicks(1917));

            migrationBuilder.UpdateData(
                table: "UserAuths",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2026, 3, 14, 21, 25, 38, 616, DateTimeKind.Local).AddTicks(6347));

            migrationBuilder.UpdateData(
                table: "UserRole",
                keyColumn: "RoleID",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 3, 14, 21, 25, 38, 615, DateTimeKind.Local).AddTicks(8071), new DateTime(2026, 3, 14, 21, 25, 38, 615, DateTimeKind.Local).AddTicks(8167) });

            migrationBuilder.UpdateData(
                table: "UserRole",
                keyColumn: "RoleID",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 3, 14, 21, 25, 38, 615, DateTimeKind.Local).AddTicks(8239), new DateTime(2026, 3, 14, 21, 25, 38, 615, DateTimeKind.Local).AddTicks(8240) });
        }
    }
}
