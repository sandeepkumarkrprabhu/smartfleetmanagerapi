using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace SmartFleet.Data.Migrations
{
    /// <inheritdoc />
    public partial class smartLorryReceipt : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "MenuMasters",
                keyColumn: "MenuID",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "MenuMasters",
                keyColumn: "MenuID",
                keyValue: 21);

            migrationBuilder.CreateTable(
                name: "LorryReceipts",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ECNo = table.Column<int>(type: "int", nullable: false),
                    ReceiptDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    VehicleId = table.Column<int>(type: "int", nullable: false),
                    FromLocationId = table.Column<int>(type: "int", nullable: false),
                    ToLocationId = table.Column<int>(type: "int", nullable: false),
                    InvoiceNo = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    FromCsutomerId = table.Column<int>(type: "int", nullable: false),
                    ConsigneeId = table.Column<int>(type: "int", nullable: false),
                    Packages = table.Column<int>(type: "int", nullable: false),
                    ProductId = table.Column<int>(type: "int", nullable: false),
                    UnitId = table.Column<int>(type: "int", nullable: false),
                    GoodsValue = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    Weight = table.Column<decimal>(type: "decimal(18,3)", nullable: true),
                    InsuranceCo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PolicyNo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    InsuredDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    InsuredAmount = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    InsuredRisk = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LorryReceipts", x => x.Id);
                });

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 1, 9, 6, 45, 491, DateTimeKind.Local).AddTicks(4953));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 1, 9, 6, 45, 491, DateTimeKind.Local).AddTicks(6227));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 1, 9, 6, 45, 491, DateTimeKind.Local).AddTicks(6232));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 1, 9, 6, 45, 491, DateTimeKind.Local).AddTicks(6234));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 1, 9, 6, 45, 491, DateTimeKind.Local).AddTicks(6236));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 1, 9, 6, 45, 491, DateTimeKind.Local).AddTicks(6238));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 1, 9, 6, 45, 491, DateTimeKind.Local).AddTicks(6347));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 1, 9, 6, 45, 491, DateTimeKind.Local).AddTicks(6350));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 1, 9, 6, 45, 491, DateTimeKind.Local).AddTicks(6352));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 1, 9, 6, 45, 491, DateTimeKind.Local).AddTicks(6353));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 1, 9, 6, 45, 491, DateTimeKind.Local).AddTicks(6366));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 1, 9, 6, 45, 491, DateTimeKind.Local).AddTicks(6368));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 1, 9, 6, 45, 491, DateTimeKind.Local).AddTicks(6370));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 14,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 1, 9, 6, 45, 491, DateTimeKind.Local).AddTicks(6371));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 15,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 1, 9, 6, 45, 491, DateTimeKind.Local).AddTicks(6373));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 16,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 1, 9, 6, 45, 491, DateTimeKind.Local).AddTicks(6375));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 17,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 1, 9, 6, 45, 491, DateTimeKind.Local).AddTicks(6376));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 18,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 1, 9, 6, 45, 491, DateTimeKind.Local).AddTicks(6378));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 19,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 1, 9, 6, 45, 491, DateTimeKind.Local).AddTicks(6380));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 20,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 1, 9, 6, 45, 491, DateTimeKind.Local).AddTicks(6382));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 21,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 1, 9, 6, 45, 491, DateTimeKind.Local).AddTicks(6383));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 22,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 1, 9, 6, 45, 491, DateTimeKind.Local).AddTicks(6385));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 23,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 1, 9, 6, 45, 491, DateTimeKind.Local).AddTicks(6387));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 24,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 1, 9, 6, 45, 491, DateTimeKind.Local).AddTicks(6388));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 25,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 1, 9, 6, 45, 491, DateTimeKind.Local).AddTicks(6390));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 26,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 1, 9, 6, 45, 491, DateTimeKind.Local).AddTicks(6392));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 27,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 1, 9, 6, 45, 491, DateTimeKind.Local).AddTicks(6394));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 28,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 1, 9, 6, 45, 491, DateTimeKind.Local).AddTicks(6396));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 29,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 1, 9, 6, 45, 491, DateTimeKind.Local).AddTicks(6397));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 30,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 1, 9, 6, 45, 491, DateTimeKind.Local).AddTicks(6399));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 31,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 1, 9, 6, 45, 491, DateTimeKind.Local).AddTicks(6401));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 32,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 1, 9, 6, 45, 491, DateTimeKind.Local).AddTicks(6402));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 33,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 1, 9, 6, 45, 491, DateTimeKind.Local).AddTicks(6404));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 34,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 1, 9, 6, 45, 491, DateTimeKind.Local).AddTicks(6406));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 35,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 1, 9, 6, 45, 491, DateTimeKind.Local).AddTicks(6472));

            migrationBuilder.UpdateData(
                table: "Branches",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 1, 9, 6, 45, 489, DateTimeKind.Local).AddTicks(1888), new DateTime(2026, 2, 1, 9, 6, 45, 489, DateTimeKind.Local).AddTicks(1980) });

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "LastUpdatedAt", "LicensedValidTill" },
                values: new object[] { new DateTime(2026, 2, 1, 9, 6, 45, 488, DateTimeKind.Local).AddTicks(9558), new DateTime(2026, 2, 1, 9, 6, 45, 488, DateTimeKind.Local).AddTicks(9647), new DateTime(2026, 7, 31, 9, 6, 45, 488, DateTimeKind.Local).AddTicks(9866) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 1, 9, 6, 45, 492, DateTimeKind.Local).AddTicks(8088));

            migrationBuilder.UpdateData(
                table: "FinancialYears",
                keyColumn: "Code",
                keyValue: "2026",
                column: "FinStartDate",
                value: new DateTime(2026, 2, 1, 9, 6, 45, 488, DateTimeKind.Local).AddTicks(3915));

            migrationBuilder.UpdateData(
                table: "UserAuths",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 1, 9, 6, 45, 493, DateTimeKind.Local).AddTicks(649));

            migrationBuilder.UpdateData(
                table: "UserRole",
                keyColumn: "RoleID",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 1, 9, 6, 45, 491, DateTimeKind.Local).AddTicks(9006), new DateTime(2026, 2, 1, 9, 6, 45, 491, DateTimeKind.Local).AddTicks(9143) });

            migrationBuilder.UpdateData(
                table: "UserRole",
                keyColumn: "RoleID",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 1, 9, 6, 45, 491, DateTimeKind.Local).AddTicks(9257), new DateTime(2026, 2, 1, 9, 6, 45, 491, DateTimeKind.Local).AddTicks(9258) });

            migrationBuilder.InsertData(
                table: "UserRoleMenus",
                columns: new[] { "Id", "IsActive", "MenuId", "OrderId", "RoleId" },
                values: new object[,]
                {
                    { 19, true, 18, 1, 1 },
                    { 20, true, 19, 1, 1 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "LorryReceipts");

            migrationBuilder.DeleteData(
                table: "UserRoleMenus",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "UserRoleMenus",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 30, 23, 52, 53, 524, DateTimeKind.Local).AddTicks(6759));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 30, 23, 52, 53, 524, DateTimeKind.Local).AddTicks(7967));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 30, 23, 52, 53, 524, DateTimeKind.Local).AddTicks(7971));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 30, 23, 52, 53, 524, DateTimeKind.Local).AddTicks(7973));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 30, 23, 52, 53, 524, DateTimeKind.Local).AddTicks(7975));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 30, 23, 52, 53, 524, DateTimeKind.Local).AddTicks(7977));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 30, 23, 52, 53, 524, DateTimeKind.Local).AddTicks(8085));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 30, 23, 52, 53, 524, DateTimeKind.Local).AddTicks(8088));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 30, 23, 52, 53, 524, DateTimeKind.Local).AddTicks(8090));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 30, 23, 52, 53, 524, DateTimeKind.Local).AddTicks(8092));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 30, 23, 52, 53, 524, DateTimeKind.Local).AddTicks(8094));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 30, 23, 52, 53, 524, DateTimeKind.Local).AddTicks(8096));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 30, 23, 52, 53, 524, DateTimeKind.Local).AddTicks(8098));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 14,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 30, 23, 52, 53, 524, DateTimeKind.Local).AddTicks(8100));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 15,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 30, 23, 52, 53, 524, DateTimeKind.Local).AddTicks(8102));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 16,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 30, 23, 52, 53, 524, DateTimeKind.Local).AddTicks(8118));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 17,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 30, 23, 52, 53, 524, DateTimeKind.Local).AddTicks(8185));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 18,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 30, 23, 52, 53, 524, DateTimeKind.Local).AddTicks(8188));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 19,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 30, 23, 52, 53, 524, DateTimeKind.Local).AddTicks(8190));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 20,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 30, 23, 52, 53, 524, DateTimeKind.Local).AddTicks(8193));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 21,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 30, 23, 52, 53, 524, DateTimeKind.Local).AddTicks(8195));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 22,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 30, 23, 52, 53, 524, DateTimeKind.Local).AddTicks(8197));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 23,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 30, 23, 52, 53, 524, DateTimeKind.Local).AddTicks(8199));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 24,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 30, 23, 52, 53, 524, DateTimeKind.Local).AddTicks(8201));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 25,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 30, 23, 52, 53, 524, DateTimeKind.Local).AddTicks(8204));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 26,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 30, 23, 52, 53, 524, DateTimeKind.Local).AddTicks(8206));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 27,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 30, 23, 52, 53, 524, DateTimeKind.Local).AddTicks(8208));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 28,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 30, 23, 52, 53, 524, DateTimeKind.Local).AddTicks(8210));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 29,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 30, 23, 52, 53, 524, DateTimeKind.Local).AddTicks(8212));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 30,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 30, 23, 52, 53, 524, DateTimeKind.Local).AddTicks(8215));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 31,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 30, 23, 52, 53, 524, DateTimeKind.Local).AddTicks(8217));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 32,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 30, 23, 52, 53, 524, DateTimeKind.Local).AddTicks(8219));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 33,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 30, 23, 52, 53, 524, DateTimeKind.Local).AddTicks(8221));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 34,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 30, 23, 52, 53, 524, DateTimeKind.Local).AddTicks(8223));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 35,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 30, 23, 52, 53, 524, DateTimeKind.Local).AddTicks(8225));

            migrationBuilder.UpdateData(
                table: "Branches",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 1, 30, 23, 52, 53, 521, DateTimeKind.Local).AddTicks(7658), new DateTime(2026, 1, 30, 23, 52, 53, 521, DateTimeKind.Local).AddTicks(7797) });

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "LastUpdatedAt", "LicensedValidTill" },
                values: new object[] { new DateTime(2026, 1, 30, 23, 52, 53, 521, DateTimeKind.Local).AddTicks(3798), new DateTime(2026, 1, 30, 23, 52, 53, 521, DateTimeKind.Local).AddTicks(3957), new DateTime(2026, 7, 29, 23, 52, 53, 521, DateTimeKind.Local).AddTicks(4354) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 30, 23, 52, 53, 525, DateTimeKind.Local).AddTicks(9602));

            migrationBuilder.UpdateData(
                table: "FinancialYears",
                keyColumn: "Code",
                keyValue: "2026",
                column: "FinStartDate",
                value: new DateTime(2026, 1, 30, 23, 52, 53, 520, DateTimeKind.Local).AddTicks(2814));

            migrationBuilder.InsertData(
                table: "MenuMasters",
                columns: new[] { "MenuID", "GroupId", "IconName", "ModuleID", "Name", "isActive", "orderNo", "url" },
                values: new object[,]
                {
                    { 20, 2, "Droplet", 2, "Payments", false, 1, "/accounts/payments" },
                    { 21, 2, "Receipt", 2, "Receipts", false, 1, "/accounts/Receipts" }
                });

            migrationBuilder.UpdateData(
                table: "UserAuths",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 30, 23, 52, 53, 526, DateTimeKind.Local).AddTicks(2118));

            migrationBuilder.UpdateData(
                table: "UserRole",
                keyColumn: "RoleID",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 1, 30, 23, 52, 53, 525, DateTimeKind.Local).AddTicks(927), new DateTime(2026, 1, 30, 23, 52, 53, 525, DateTimeKind.Local).AddTicks(1079) });

            migrationBuilder.UpdateData(
                table: "UserRole",
                keyColumn: "RoleID",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 1, 30, 23, 52, 53, 525, DateTimeKind.Local).AddTicks(1194), new DateTime(2026, 1, 30, 23, 52, 53, 525, DateTimeKind.Local).AddTicks(1195) });
        }
    }
}
