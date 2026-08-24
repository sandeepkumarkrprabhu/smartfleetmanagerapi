using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SmartFleet.Data.Migrations
{
    /// <inheritdoc />
    public partial class vehicleVendorRentDb : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "vehicleVendorRents",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    VehicleId = table.Column<int>(type: "int", nullable: false),
                    VendorId = table.Column<int>(type: "int", nullable: false),
                    RentFromDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    RentToDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    RentAmount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_vehicleVendorRents", x => x.Id);
                    table.ForeignKey(
                        name: "FK_vehicleVendorRents_Vehilces_VehicleId",
                        column: x => x.VehicleId,
                        principalTable: "Vehilces",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_vehicleVendorRents_Vendors_VendorId",
                        column: x => x.VendorId,
                        principalTable: "Vendors",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 23, 10, 45, 43, 830, DateTimeKind.Local).AddTicks(9065));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 23, 10, 45, 43, 831, DateTimeKind.Local).AddTicks(111));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 23, 10, 45, 43, 831, DateTimeKind.Local).AddTicks(116));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 23, 10, 45, 43, 831, DateTimeKind.Local).AddTicks(118));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 23, 10, 45, 43, 831, DateTimeKind.Local).AddTicks(119));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 23, 10, 45, 43, 831, DateTimeKind.Local).AddTicks(121));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 23, 10, 45, 43, 831, DateTimeKind.Local).AddTicks(226));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 23, 10, 45, 43, 831, DateTimeKind.Local).AddTicks(228));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 23, 10, 45, 43, 831, DateTimeKind.Local).AddTicks(230));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 23, 10, 45, 43, 831, DateTimeKind.Local).AddTicks(231));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 23, 10, 45, 43, 831, DateTimeKind.Local).AddTicks(232));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 23, 10, 45, 43, 831, DateTimeKind.Local).AddTicks(234));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 23, 10, 45, 43, 831, DateTimeKind.Local).AddTicks(235));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 14,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 23, 10, 45, 43, 831, DateTimeKind.Local).AddTicks(236));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 15,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 23, 10, 45, 43, 831, DateTimeKind.Local).AddTicks(237));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 16,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 23, 10, 45, 43, 831, DateTimeKind.Local).AddTicks(239));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 17,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 23, 10, 45, 43, 831, DateTimeKind.Local).AddTicks(240));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 18,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 23, 10, 45, 43, 831, DateTimeKind.Local).AddTicks(250));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 19,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 23, 10, 45, 43, 831, DateTimeKind.Local).AddTicks(252));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 20,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 23, 10, 45, 43, 831, DateTimeKind.Local).AddTicks(253));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 21,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 23, 10, 45, 43, 831, DateTimeKind.Local).AddTicks(255));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 22,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 23, 10, 45, 43, 831, DateTimeKind.Local).AddTicks(256));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 23,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 23, 10, 45, 43, 831, DateTimeKind.Local).AddTicks(257));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 24,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 23, 10, 45, 43, 831, DateTimeKind.Local).AddTicks(259));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 25,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 23, 10, 45, 43, 831, DateTimeKind.Local).AddTicks(260));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 26,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 23, 10, 45, 43, 831, DateTimeKind.Local).AddTicks(262));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 27,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 23, 10, 45, 43, 831, DateTimeKind.Local).AddTicks(263));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 28,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 23, 10, 45, 43, 831, DateTimeKind.Local).AddTicks(264));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 29,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 23, 10, 45, 43, 831, DateTimeKind.Local).AddTicks(266));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 30,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 23, 10, 45, 43, 831, DateTimeKind.Local).AddTicks(267));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 31,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 23, 10, 45, 43, 831, DateTimeKind.Local).AddTicks(268));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 32,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 23, 10, 45, 43, 831, DateTimeKind.Local).AddTicks(269));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 33,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 23, 10, 45, 43, 831, DateTimeKind.Local).AddTicks(271));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 34,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 23, 10, 45, 43, 831, DateTimeKind.Local).AddTicks(272));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 35,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 23, 10, 45, 43, 831, DateTimeKind.Local).AddTicks(274));

            migrationBuilder.UpdateData(
                table: "Branches",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 1, 23, 10, 45, 43, 828, DateTimeKind.Local).AddTicks(6941), new DateTime(2026, 1, 23, 10, 45, 43, 828, DateTimeKind.Local).AddTicks(7018) });

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "LastUpdatedAt", "LicensedValidTill" },
                values: new object[] { new DateTime(2026, 1, 23, 10, 45, 43, 828, DateTimeKind.Local).AddTicks(4762), new DateTime(2026, 1, 23, 10, 45, 43, 828, DateTimeKind.Local).AddTicks(4847), new DateTime(2026, 7, 22, 10, 45, 43, 828, DateTimeKind.Local).AddTicks(5125) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 23, 10, 45, 43, 833, DateTimeKind.Local).AddTicks(7997));

            migrationBuilder.UpdateData(
                table: "FinancialYears",
                keyColumn: "Code",
                keyValue: "2026",
                column: "FinStartDate",
                value: new DateTime(2026, 1, 23, 10, 45, 43, 827, DateTimeKind.Local).AddTicks(9012));

            migrationBuilder.UpdateData(
                table: "UserAuths",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 23, 10, 45, 43, 834, DateTimeKind.Local).AddTicks(1102));

            migrationBuilder.UpdateData(
                table: "UserRole",
                keyColumn: "RoleID",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 1, 23, 10, 45, 43, 831, DateTimeKind.Local).AddTicks(6163), new DateTime(2026, 1, 23, 10, 45, 43, 831, DateTimeKind.Local).AddTicks(6281) });

            migrationBuilder.UpdateData(
                table: "UserRole",
                keyColumn: "RoleID",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 1, 23, 10, 45, 43, 831, DateTimeKind.Local).AddTicks(6434), new DateTime(2026, 1, 23, 10, 45, 43, 831, DateTimeKind.Local).AddTicks(6435) });

            migrationBuilder.CreateIndex(
                name: "IX_vehicleVendorRents_VehicleId",
                table: "vehicleVendorRents",
                column: "VehicleId");

            migrationBuilder.CreateIndex(
                name: "IX_vehicleVendorRents_VendorId",
                table: "vehicleVendorRents",
                column: "VendorId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "vehicleVendorRents");

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 22, 23, 16, 37, 596, DateTimeKind.Local).AddTicks(6321));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 22, 23, 16, 37, 596, DateTimeKind.Local).AddTicks(6929));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 22, 23, 16, 37, 596, DateTimeKind.Local).AddTicks(6931));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 22, 23, 16, 37, 596, DateTimeKind.Local).AddTicks(6933));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 22, 23, 16, 37, 596, DateTimeKind.Local).AddTicks(6934));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 22, 23, 16, 37, 596, DateTimeKind.Local).AddTicks(6935));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 22, 23, 16, 37, 596, DateTimeKind.Local).AddTicks(7036));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 22, 23, 16, 37, 596, DateTimeKind.Local).AddTicks(7037));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 22, 23, 16, 37, 596, DateTimeKind.Local).AddTicks(7038));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 22, 23, 16, 37, 596, DateTimeKind.Local).AddTicks(7040));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 22, 23, 16, 37, 596, DateTimeKind.Local).AddTicks(7047));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 22, 23, 16, 37, 596, DateTimeKind.Local).AddTicks(7049));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 22, 23, 16, 37, 596, DateTimeKind.Local).AddTicks(7050));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 14,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 22, 23, 16, 37, 596, DateTimeKind.Local).AddTicks(7051));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 15,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 22, 23, 16, 37, 596, DateTimeKind.Local).AddTicks(7052));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 16,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 22, 23, 16, 37, 596, DateTimeKind.Local).AddTicks(7053));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 17,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 22, 23, 16, 37, 596, DateTimeKind.Local).AddTicks(7054));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 18,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 22, 23, 16, 37, 596, DateTimeKind.Local).AddTicks(7056));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 19,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 22, 23, 16, 37, 596, DateTimeKind.Local).AddTicks(7057));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 20,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 22, 23, 16, 37, 596, DateTimeKind.Local).AddTicks(7058));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 21,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 22, 23, 16, 37, 596, DateTimeKind.Local).AddTicks(7059));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 22,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 22, 23, 16, 37, 596, DateTimeKind.Local).AddTicks(7061));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 23,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 22, 23, 16, 37, 596, DateTimeKind.Local).AddTicks(7062));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 24,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 22, 23, 16, 37, 596, DateTimeKind.Local).AddTicks(7063));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 25,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 22, 23, 16, 37, 596, DateTimeKind.Local).AddTicks(7064));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 26,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 22, 23, 16, 37, 596, DateTimeKind.Local).AddTicks(7065));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 27,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 22, 23, 16, 37, 596, DateTimeKind.Local).AddTicks(7067));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 28,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 22, 23, 16, 37, 596, DateTimeKind.Local).AddTicks(7068));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 29,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 22, 23, 16, 37, 596, DateTimeKind.Local).AddTicks(7069));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 30,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 22, 23, 16, 37, 596, DateTimeKind.Local).AddTicks(7070));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 31,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 22, 23, 16, 37, 596, DateTimeKind.Local).AddTicks(7072));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 32,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 22, 23, 16, 37, 596, DateTimeKind.Local).AddTicks(7073));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 33,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 22, 23, 16, 37, 596, DateTimeKind.Local).AddTicks(7074));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 34,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 22, 23, 16, 37, 596, DateTimeKind.Local).AddTicks(7075));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 35,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 22, 23, 16, 37, 596, DateTimeKind.Local).AddTicks(7077));

            migrationBuilder.UpdateData(
                table: "Branches",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 1, 22, 23, 16, 37, 595, DateTimeKind.Local).AddTicks(2762), new DateTime(2026, 1, 22, 23, 16, 37, 595, DateTimeKind.Local).AddTicks(2872) });

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "LastUpdatedAt", "LicensedValidTill" },
                values: new object[] { new DateTime(2026, 1, 22, 23, 16, 37, 595, DateTimeKind.Local).AddTicks(289), new DateTime(2026, 1, 22, 23, 16, 37, 595, DateTimeKind.Local).AddTicks(370), new DateTime(2026, 7, 21, 23, 16, 37, 595, DateTimeKind.Local).AddTicks(613) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 22, 23, 16, 37, 597, DateTimeKind.Local).AddTicks(3888));

            migrationBuilder.UpdateData(
                table: "FinancialYears",
                keyColumn: "Code",
                keyValue: "2026",
                column: "FinStartDate",
                value: new DateTime(2026, 1, 22, 23, 16, 37, 594, DateTimeKind.Local).AddTicks(5106));

            migrationBuilder.UpdateData(
                table: "UserAuths",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 22, 23, 16, 37, 597, DateTimeKind.Local).AddTicks(5356));

            migrationBuilder.UpdateData(
                table: "UserRole",
                keyColumn: "RoleID",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 1, 22, 23, 16, 37, 596, DateTimeKind.Local).AddTicks(8596), new DateTime(2026, 1, 22, 23, 16, 37, 596, DateTimeKind.Local).AddTicks(8689) });

            migrationBuilder.UpdateData(
                table: "UserRole",
                keyColumn: "RoleID",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 1, 22, 23, 16, 37, 596, DateTimeKind.Local).AddTicks(8763), new DateTime(2026, 1, 22, 23, 16, 37, 596, DateTimeKind.Local).AddTicks(8763) });
        }
    }
}
