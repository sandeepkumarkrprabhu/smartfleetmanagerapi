using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SmartFleet.Data.Migrations
{
    /// <inheritdoc />
    public partial class ApplicationModuleSetting : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "applicationModuleSettings",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ModuleName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    SettingName = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    SettingKey = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    DataType = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DefaultValue = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsEditable = table.Column<bool>(type: "bit", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_applicationModuleSettings", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "applicationModuleSettingValues",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SettingId = table.Column<int>(type: "int", nullable: false),
                    Value = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    CompanyId = table.Column<int>(type: "int", nullable: true),
                    BranchId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_applicationModuleSettingValues", x => x.Id);
                    table.ForeignKey(
                        name: "FK_applicationModuleSettingValues_applicationModuleSettings_SettingId",
                        column: x => x.SettingId,
                        principalTable: "applicationModuleSettings",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2026, 3, 28, 10, 52, 22, 403, DateTimeKind.Local).AddTicks(463));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2026, 3, 28, 10, 52, 22, 403, DateTimeKind.Local).AddTicks(1921));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2026, 3, 28, 10, 52, 22, 403, DateTimeKind.Local).AddTicks(1926));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2026, 3, 28, 10, 52, 22, 403, DateTimeKind.Local).AddTicks(1946));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2026, 3, 28, 10, 52, 22, 403, DateTimeKind.Local).AddTicks(1949));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2026, 3, 28, 10, 52, 22, 403, DateTimeKind.Local).AddTicks(1951));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2026, 3, 28, 10, 52, 22, 403, DateTimeKind.Local).AddTicks(2067));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2026, 3, 28, 10, 52, 22, 403, DateTimeKind.Local).AddTicks(2069));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2026, 3, 28, 10, 52, 22, 403, DateTimeKind.Local).AddTicks(2071));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2026, 3, 28, 10, 52, 22, 403, DateTimeKind.Local).AddTicks(2073));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2026, 3, 28, 10, 52, 22, 403, DateTimeKind.Local).AddTicks(2074));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2026, 3, 28, 10, 52, 22, 403, DateTimeKind.Local).AddTicks(2076));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2026, 3, 28, 10, 52, 22, 403, DateTimeKind.Local).AddTicks(2078));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 14,
                column: "CreatedAt",
                value: new DateTime(2026, 3, 28, 10, 52, 22, 403, DateTimeKind.Local).AddTicks(2079));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 15,
                column: "CreatedAt",
                value: new DateTime(2026, 3, 28, 10, 52, 22, 403, DateTimeKind.Local).AddTicks(2081));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 16,
                column: "CreatedAt",
                value: new DateTime(2026, 3, 28, 10, 52, 22, 403, DateTimeKind.Local).AddTicks(2083));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 17,
                column: "CreatedAt",
                value: new DateTime(2026, 3, 28, 10, 52, 22, 403, DateTimeKind.Local).AddTicks(2085));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 18,
                column: "CreatedAt",
                value: new DateTime(2026, 3, 28, 10, 52, 22, 403, DateTimeKind.Local).AddTicks(2087));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 19,
                column: "CreatedAt",
                value: new DateTime(2026, 3, 28, 10, 52, 22, 403, DateTimeKind.Local).AddTicks(2100));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 20,
                column: "CreatedAt",
                value: new DateTime(2026, 3, 28, 10, 52, 22, 403, DateTimeKind.Local).AddTicks(2102));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 21,
                column: "CreatedAt",
                value: new DateTime(2026, 3, 28, 10, 52, 22, 403, DateTimeKind.Local).AddTicks(2104));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 22,
                column: "CreatedAt",
                value: new DateTime(2026, 3, 28, 10, 52, 22, 403, DateTimeKind.Local).AddTicks(2106));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 23,
                column: "CreatedAt",
                value: new DateTime(2026, 3, 28, 10, 52, 22, 403, DateTimeKind.Local).AddTicks(2108));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 24,
                column: "CreatedAt",
                value: new DateTime(2026, 3, 28, 10, 52, 22, 403, DateTimeKind.Local).AddTicks(2110));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 25,
                column: "CreatedAt",
                value: new DateTime(2026, 3, 28, 10, 52, 22, 403, DateTimeKind.Local).AddTicks(2112));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 26,
                column: "CreatedAt",
                value: new DateTime(2026, 3, 28, 10, 52, 22, 403, DateTimeKind.Local).AddTicks(2114));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 27,
                column: "CreatedAt",
                value: new DateTime(2026, 3, 28, 10, 52, 22, 403, DateTimeKind.Local).AddTicks(2115));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 28,
                column: "CreatedAt",
                value: new DateTime(2026, 3, 28, 10, 52, 22, 403, DateTimeKind.Local).AddTicks(2117));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 29,
                column: "CreatedAt",
                value: new DateTime(2026, 3, 28, 10, 52, 22, 403, DateTimeKind.Local).AddTicks(2119));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 30,
                column: "CreatedAt",
                value: new DateTime(2026, 3, 28, 10, 52, 22, 403, DateTimeKind.Local).AddTicks(2121));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 31,
                column: "CreatedAt",
                value: new DateTime(2026, 3, 28, 10, 52, 22, 403, DateTimeKind.Local).AddTicks(2123));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 32,
                column: "CreatedAt",
                value: new DateTime(2026, 3, 28, 10, 52, 22, 403, DateTimeKind.Local).AddTicks(2124));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 33,
                column: "CreatedAt",
                value: new DateTime(2026, 3, 28, 10, 52, 22, 403, DateTimeKind.Local).AddTicks(2126));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 34,
                column: "CreatedAt",
                value: new DateTime(2026, 3, 28, 10, 52, 22, 403, DateTimeKind.Local).AddTicks(2128));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 35,
                column: "CreatedAt",
                value: new DateTime(2026, 3, 28, 10, 52, 22, 403, DateTimeKind.Local).AddTicks(2129));

            migrationBuilder.UpdateData(
                table: "Branches",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 3, 28, 10, 52, 22, 399, DateTimeKind.Local).AddTicks(5481), new DateTime(2026, 3, 28, 10, 52, 22, 399, DateTimeKind.Local).AddTicks(5627) });

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "LastUpdatedAt", "LicensedValidTill" },
                values: new object[] { new DateTime(2026, 3, 28, 10, 52, 22, 399, DateTimeKind.Local).AddTicks(1370), new DateTime(2026, 3, 28, 10, 52, 22, 399, DateTimeKind.Local).AddTicks(1515), new DateTime(2026, 9, 24, 10, 52, 22, 399, DateTimeKind.Local).AddTicks(1891) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2026, 3, 28, 10, 52, 22, 404, DateTimeKind.Local).AddTicks(8344));

            migrationBuilder.UpdateData(
                table: "FinancialYears",
                keyColumn: "Code",
                keyValue: "2026",
                column: "FinStartDate",
                value: new DateTime(2026, 3, 28, 10, 52, 22, 398, DateTimeKind.Local).AddTicks(81));

            migrationBuilder.UpdateData(
                table: "UserAuths",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2026, 3, 28, 10, 52, 22, 405, DateTimeKind.Local).AddTicks(1107));

            migrationBuilder.UpdateData(
                table: "UserRole",
                keyColumn: "RoleID",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 3, 28, 10, 52, 22, 403, DateTimeKind.Local).AddTicks(5411), new DateTime(2026, 3, 28, 10, 52, 22, 403, DateTimeKind.Local).AddTicks(5575) });

            migrationBuilder.UpdateData(
                table: "UserRole",
                keyColumn: "RoleID",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 3, 28, 10, 52, 22, 403, DateTimeKind.Local).AddTicks(5804), new DateTime(2026, 3, 28, 10, 52, 22, 403, DateTimeKind.Local).AddTicks(5804) });

            migrationBuilder.CreateIndex(
                name: "IX_applicationModuleSettingValues_SettingId",
                table: "applicationModuleSettingValues",
                column: "SettingId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "applicationModuleSettingValues");

            migrationBuilder.DropTable(
                name: "applicationModuleSettings");

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2026, 3, 24, 19, 58, 55, 279, DateTimeKind.Local).AddTicks(5464));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2026, 3, 24, 19, 58, 55, 279, DateTimeKind.Local).AddTicks(6186));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2026, 3, 24, 19, 58, 55, 279, DateTimeKind.Local).AddTicks(6188));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2026, 3, 24, 19, 58, 55, 279, DateTimeKind.Local).AddTicks(6190));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2026, 3, 24, 19, 58, 55, 279, DateTimeKind.Local).AddTicks(6191));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2026, 3, 24, 19, 58, 55, 279, DateTimeKind.Local).AddTicks(6193));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2026, 3, 24, 19, 58, 55, 279, DateTimeKind.Local).AddTicks(6266));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2026, 3, 24, 19, 58, 55, 279, DateTimeKind.Local).AddTicks(6268));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2026, 3, 24, 19, 58, 55, 279, DateTimeKind.Local).AddTicks(6269));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2026, 3, 24, 19, 58, 55, 279, DateTimeKind.Local).AddTicks(6270));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2026, 3, 24, 19, 58, 55, 279, DateTimeKind.Local).AddTicks(6272));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2026, 3, 24, 19, 58, 55, 279, DateTimeKind.Local).AddTicks(6273));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2026, 3, 24, 19, 58, 55, 279, DateTimeKind.Local).AddTicks(6274));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 14,
                column: "CreatedAt",
                value: new DateTime(2026, 3, 24, 19, 58, 55, 279, DateTimeKind.Local).AddTicks(6275));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 15,
                column: "CreatedAt",
                value: new DateTime(2026, 3, 24, 19, 58, 55, 279, DateTimeKind.Local).AddTicks(6277));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 16,
                column: "CreatedAt",
                value: new DateTime(2026, 3, 24, 19, 58, 55, 279, DateTimeKind.Local).AddTicks(6278));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 17,
                column: "CreatedAt",
                value: new DateTime(2026, 3, 24, 19, 58, 55, 279, DateTimeKind.Local).AddTicks(6279));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 18,
                column: "CreatedAt",
                value: new DateTime(2026, 3, 24, 19, 58, 55, 279, DateTimeKind.Local).AddTicks(6280));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 19,
                column: "CreatedAt",
                value: new DateTime(2026, 3, 24, 19, 58, 55, 279, DateTimeKind.Local).AddTicks(6282));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 20,
                column: "CreatedAt",
                value: new DateTime(2026, 3, 24, 19, 58, 55, 279, DateTimeKind.Local).AddTicks(6283));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 21,
                column: "CreatedAt",
                value: new DateTime(2026, 3, 24, 19, 58, 55, 279, DateTimeKind.Local).AddTicks(6290));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 22,
                column: "CreatedAt",
                value: new DateTime(2026, 3, 24, 19, 58, 55, 279, DateTimeKind.Local).AddTicks(6292));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 23,
                column: "CreatedAt",
                value: new DateTime(2026, 3, 24, 19, 58, 55, 279, DateTimeKind.Local).AddTicks(6293));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 24,
                column: "CreatedAt",
                value: new DateTime(2026, 3, 24, 19, 58, 55, 279, DateTimeKind.Local).AddTicks(6294));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 25,
                column: "CreatedAt",
                value: new DateTime(2026, 3, 24, 19, 58, 55, 279, DateTimeKind.Local).AddTicks(6296));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 26,
                column: "CreatedAt",
                value: new DateTime(2026, 3, 24, 19, 58, 55, 279, DateTimeKind.Local).AddTicks(6297));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 27,
                column: "CreatedAt",
                value: new DateTime(2026, 3, 24, 19, 58, 55, 279, DateTimeKind.Local).AddTicks(6298));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 28,
                column: "CreatedAt",
                value: new DateTime(2026, 3, 24, 19, 58, 55, 279, DateTimeKind.Local).AddTicks(6300));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 29,
                column: "CreatedAt",
                value: new DateTime(2026, 3, 24, 19, 58, 55, 279, DateTimeKind.Local).AddTicks(6301));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 30,
                column: "CreatedAt",
                value: new DateTime(2026, 3, 24, 19, 58, 55, 279, DateTimeKind.Local).AddTicks(6302));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 31,
                column: "CreatedAt",
                value: new DateTime(2026, 3, 24, 19, 58, 55, 279, DateTimeKind.Local).AddTicks(6304));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 32,
                column: "CreatedAt",
                value: new DateTime(2026, 3, 24, 19, 58, 55, 279, DateTimeKind.Local).AddTicks(6345));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 33,
                column: "CreatedAt",
                value: new DateTime(2026, 3, 24, 19, 58, 55, 279, DateTimeKind.Local).AddTicks(6346));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 34,
                column: "CreatedAt",
                value: new DateTime(2026, 3, 24, 19, 58, 55, 279, DateTimeKind.Local).AddTicks(6348));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 35,
                column: "CreatedAt",
                value: new DateTime(2026, 3, 24, 19, 58, 55, 279, DateTimeKind.Local).AddTicks(6349));

            migrationBuilder.UpdateData(
                table: "Branches",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 3, 24, 19, 58, 55, 277, DateTimeKind.Local).AddTicks(8751), new DateTime(2026, 3, 24, 19, 58, 55, 277, DateTimeKind.Local).AddTicks(8829) });

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "LastUpdatedAt", "LicensedValidTill" },
                values: new object[] { new DateTime(2026, 3, 24, 19, 58, 55, 277, DateTimeKind.Local).AddTicks(6485), new DateTime(2026, 3, 24, 19, 58, 55, 277, DateTimeKind.Local).AddTicks(6572), new DateTime(2026, 9, 20, 19, 58, 55, 277, DateTimeKind.Local).AddTicks(6794) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2026, 3, 24, 19, 58, 55, 280, DateTimeKind.Local).AddTicks(3994));

            migrationBuilder.UpdateData(
                table: "FinancialYears",
                keyColumn: "Code",
                keyValue: "2026",
                column: "FinStartDate",
                value: new DateTime(2026, 3, 24, 19, 58, 55, 276, DateTimeKind.Local).AddTicks(8037));

            migrationBuilder.UpdateData(
                table: "UserAuths",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2026, 3, 24, 19, 58, 55, 280, DateTimeKind.Local).AddTicks(5460));

            migrationBuilder.UpdateData(
                table: "UserRole",
                keyColumn: "RoleID",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 3, 24, 19, 58, 55, 279, DateTimeKind.Local).AddTicks(7926), new DateTime(2026, 3, 24, 19, 58, 55, 279, DateTimeKind.Local).AddTicks(8044) });

            migrationBuilder.UpdateData(
                table: "UserRole",
                keyColumn: "RoleID",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 3, 24, 19, 58, 55, 279, DateTimeKind.Local).AddTicks(8116), new DateTime(2026, 3, 24, 19, 58, 55, 279, DateTimeKind.Local).AddTicks(8117) });
        }
    }
}
