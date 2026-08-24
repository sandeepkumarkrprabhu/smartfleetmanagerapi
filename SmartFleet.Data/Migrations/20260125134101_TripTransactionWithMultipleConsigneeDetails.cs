using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SmartFleet.Data.Migrations
{
    /// <inheritdoc />
    public partial class TripTransactionWithMultipleConsigneeDetails : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "TripConsigneeDetails",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LRNo = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    InvoiceNo = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    ToConsigneeId = table.Column<int>(type: "int", nullable: false),
                    DestinationId = table.Column<int>(type: "int", nullable: false),
                    TripTransactionId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TripConsigneeDetails", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TripConsigneeDetails_Customers_ToConsigneeId",
                        column: x => x.ToConsigneeId,
                        principalTable: "Customers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TripConsigneeDetails_Locations_DestinationId",
                        column: x => x.DestinationId,
                        principalTable: "Locations",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TripConsigneeDetails_TripTransaction_TripTransactionId",
                        column: x => x.TripTransactionId,
                        principalTable: "TripTransaction",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

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

            migrationBuilder.CreateIndex(
                name: "IX_TripConsigneeDetails_DestinationId",
                table: "TripConsigneeDetails",
                column: "DestinationId");

            migrationBuilder.CreateIndex(
                name: "IX_TripConsigneeDetails_ToConsigneeId",
                table: "TripConsigneeDetails",
                column: "ToConsigneeId");

            migrationBuilder.CreateIndex(
                name: "IX_TripConsigneeDetails_TripTransactionId",
                table: "TripConsigneeDetails",
                column: "TripTransactionId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TripConsigneeDetails");

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
    }
}
