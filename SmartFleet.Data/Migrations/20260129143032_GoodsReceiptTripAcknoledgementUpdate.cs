using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SmartFleet.Data.Migrations
{
    /// <inheritdoc />
    public partial class GoodsReceiptTripAcknoledgementUpdate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "TripReceiptAcknoledgementsInfos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TripId = table.Column<int>(type: "int", nullable: false),
                    DeliveredOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ReceivedByName = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    ReceiverMobile = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    Remarks = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    UploadedReceiptUrl = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TripReceiptAcknoledgementsInfos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TripReceiptAcknoledgementsInfos_TripTransaction_TripId",
                        column: x => x.TripId,
                        principalTable: "TripTransaction",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 29, 20, 0, 29, 227, DateTimeKind.Local).AddTicks(300));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 29, 20, 0, 29, 227, DateTimeKind.Local).AddTicks(924));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 29, 20, 0, 29, 227, DateTimeKind.Local).AddTicks(926));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 29, 20, 0, 29, 227, DateTimeKind.Local).AddTicks(927));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 29, 20, 0, 29, 227, DateTimeKind.Local).AddTicks(928));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 29, 20, 0, 29, 227, DateTimeKind.Local).AddTicks(929));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 29, 20, 0, 29, 227, DateTimeKind.Local).AddTicks(995));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 29, 20, 0, 29, 227, DateTimeKind.Local).AddTicks(997));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 29, 20, 0, 29, 227, DateTimeKind.Local).AddTicks(998));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 29, 20, 0, 29, 227, DateTimeKind.Local).AddTicks(999));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 29, 20, 0, 29, 227, DateTimeKind.Local).AddTicks(1031));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 29, 20, 0, 29, 227, DateTimeKind.Local).AddTicks(1033));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 29, 20, 0, 29, 227, DateTimeKind.Local).AddTicks(1034));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 14,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 29, 20, 0, 29, 227, DateTimeKind.Local).AddTicks(1035));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 15,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 29, 20, 0, 29, 227, DateTimeKind.Local).AddTicks(1036));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 16,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 29, 20, 0, 29, 227, DateTimeKind.Local).AddTicks(1037));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 17,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 29, 20, 0, 29, 227, DateTimeKind.Local).AddTicks(1046));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 18,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 29, 20, 0, 29, 227, DateTimeKind.Local).AddTicks(1047));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 19,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 29, 20, 0, 29, 227, DateTimeKind.Local).AddTicks(1048));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 20,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 29, 20, 0, 29, 227, DateTimeKind.Local).AddTicks(1049));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 21,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 29, 20, 0, 29, 227, DateTimeKind.Local).AddTicks(1051));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 22,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 29, 20, 0, 29, 227, DateTimeKind.Local).AddTicks(1052));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 23,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 29, 20, 0, 29, 227, DateTimeKind.Local).AddTicks(1053));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 24,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 29, 20, 0, 29, 227, DateTimeKind.Local).AddTicks(1054));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 25,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 29, 20, 0, 29, 227, DateTimeKind.Local).AddTicks(1055));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 26,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 29, 20, 0, 29, 227, DateTimeKind.Local).AddTicks(1057));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 27,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 29, 20, 0, 29, 227, DateTimeKind.Local).AddTicks(1058));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 28,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 29, 20, 0, 29, 227, DateTimeKind.Local).AddTicks(1059));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 29,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 29, 20, 0, 29, 227, DateTimeKind.Local).AddTicks(1061));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 30,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 29, 20, 0, 29, 227, DateTimeKind.Local).AddTicks(1062));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 31,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 29, 20, 0, 29, 227, DateTimeKind.Local).AddTicks(1063));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 32,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 29, 20, 0, 29, 227, DateTimeKind.Local).AddTicks(1064));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 33,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 29, 20, 0, 29, 227, DateTimeKind.Local).AddTicks(1066));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 34,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 29, 20, 0, 29, 227, DateTimeKind.Local).AddTicks(1067));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 35,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 29, 20, 0, 29, 227, DateTimeKind.Local).AddTicks(1068));

            migrationBuilder.UpdateData(
                table: "Branches",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 1, 29, 20, 0, 29, 225, DateTimeKind.Local).AddTicks(6102), new DateTime(2026, 1, 29, 20, 0, 29, 225, DateTimeKind.Local).AddTicks(6179) });

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "LastUpdatedAt", "LicensedValidTill" },
                values: new object[] { new DateTime(2026, 1, 29, 20, 0, 29, 225, DateTimeKind.Local).AddTicks(3968), new DateTime(2026, 1, 29, 20, 0, 29, 225, DateTimeKind.Local).AddTicks(4073), new DateTime(2026, 7, 28, 20, 0, 29, 225, DateTimeKind.Local).AddTicks(4281) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 29, 20, 0, 29, 227, DateTimeKind.Local).AddTicks(8572));

            migrationBuilder.UpdateData(
                table: "FinancialYears",
                keyColumn: "Code",
                keyValue: "2026",
                column: "FinStartDate",
                value: new DateTime(2026, 1, 29, 20, 0, 29, 224, DateTimeKind.Local).AddTicks(8426));

            migrationBuilder.UpdateData(
                table: "UserAuths",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 29, 20, 0, 29, 228, DateTimeKind.Local).AddTicks(18));

            migrationBuilder.UpdateData(
                table: "UserRole",
                keyColumn: "RoleID",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 1, 29, 20, 0, 29, 227, DateTimeKind.Local).AddTicks(2618), new DateTime(2026, 1, 29, 20, 0, 29, 227, DateTimeKind.Local).AddTicks(2706) });

            migrationBuilder.UpdateData(
                table: "UserRole",
                keyColumn: "RoleID",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 1, 29, 20, 0, 29, 227, DateTimeKind.Local).AddTicks(2776), new DateTime(2026, 1, 29, 20, 0, 29, 227, DateTimeKind.Local).AddTicks(2776) });

            migrationBuilder.CreateIndex(
                name: "IX_TripReceiptAcknoledgementsInfos_TripId",
                table: "TripReceiptAcknoledgementsInfos",
                column: "TripId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TripReceiptAcknoledgementsInfos");

            migrationBuilder.CreateTable(
                name: "TripAcknoledgementReceipts",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TripId = table.Column<int>(type: "int", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DeliveredOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ReceivedByName = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    ReceiverMobile = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    Remarks = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    UploadedReceiptUrl = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TripAcknoledgementReceipts", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TripAcknoledgementReceipts_TripTransaction_TripId",
                        column: x => x.TripId,
                        principalTable: "TripTransaction",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 29, 19, 58, 3, 7, DateTimeKind.Local).AddTicks(4678));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 29, 19, 58, 3, 7, DateTimeKind.Local).AddTicks(6052));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 29, 19, 58, 3, 7, DateTimeKind.Local).AddTicks(6057));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 29, 19, 58, 3, 7, DateTimeKind.Local).AddTicks(6059));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 29, 19, 58, 3, 7, DateTimeKind.Local).AddTicks(6061));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 29, 19, 58, 3, 7, DateTimeKind.Local).AddTicks(6063));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 29, 19, 58, 3, 7, DateTimeKind.Local).AddTicks(6179));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 29, 19, 58, 3, 7, DateTimeKind.Local).AddTicks(6197));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 29, 19, 58, 3, 7, DateTimeKind.Local).AddTicks(6199));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 29, 19, 58, 3, 7, DateTimeKind.Local).AddTicks(6200));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 29, 19, 58, 3, 7, DateTimeKind.Local).AddTicks(6202));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 29, 19, 58, 3, 7, DateTimeKind.Local).AddTicks(6203));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 29, 19, 58, 3, 7, DateTimeKind.Local).AddTicks(6205));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 14,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 29, 19, 58, 3, 7, DateTimeKind.Local).AddTicks(6206));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 15,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 29, 19, 58, 3, 7, DateTimeKind.Local).AddTicks(6207));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 16,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 29, 19, 58, 3, 7, DateTimeKind.Local).AddTicks(6209));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 17,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 29, 19, 58, 3, 7, DateTimeKind.Local).AddTicks(6210));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 18,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 29, 19, 58, 3, 7, DateTimeKind.Local).AddTicks(6212));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 19,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 29, 19, 58, 3, 7, DateTimeKind.Local).AddTicks(6214));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 20,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 29, 19, 58, 3, 7, DateTimeKind.Local).AddTicks(6215));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 21,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 29, 19, 58, 3, 7, DateTimeKind.Local).AddTicks(6217));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 22,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 29, 19, 58, 3, 7, DateTimeKind.Local).AddTicks(6218));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 23,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 29, 19, 58, 3, 7, DateTimeKind.Local).AddTicks(6220));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 24,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 29, 19, 58, 3, 7, DateTimeKind.Local).AddTicks(6221));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 25,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 29, 19, 58, 3, 7, DateTimeKind.Local).AddTicks(6223));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 26,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 29, 19, 58, 3, 7, DateTimeKind.Local).AddTicks(6225));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 27,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 29, 19, 58, 3, 7, DateTimeKind.Local).AddTicks(6226));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 28,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 29, 19, 58, 3, 7, DateTimeKind.Local).AddTicks(6228));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 29,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 29, 19, 58, 3, 7, DateTimeKind.Local).AddTicks(6229));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 30,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 29, 19, 58, 3, 7, DateTimeKind.Local).AddTicks(6231));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 31,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 29, 19, 58, 3, 7, DateTimeKind.Local).AddTicks(6282));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 32,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 29, 19, 58, 3, 7, DateTimeKind.Local).AddTicks(6284));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 33,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 29, 19, 58, 3, 7, DateTimeKind.Local).AddTicks(6286));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 34,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 29, 19, 58, 3, 7, DateTimeKind.Local).AddTicks(6287));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 35,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 29, 19, 58, 3, 7, DateTimeKind.Local).AddTicks(6289));

            migrationBuilder.UpdateData(
                table: "Branches",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 1, 29, 19, 58, 3, 5, DateTimeKind.Local).AddTicks(671), new DateTime(2026, 1, 29, 19, 58, 3, 5, DateTimeKind.Local).AddTicks(810) });

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "LastUpdatedAt", "LicensedValidTill" },
                values: new object[] { new DateTime(2026, 1, 29, 19, 58, 3, 4, DateTimeKind.Local).AddTicks(7162), new DateTime(2026, 1, 29, 19, 58, 3, 4, DateTimeKind.Local).AddTicks(7308), new DateTime(2026, 7, 28, 19, 58, 3, 4, DateTimeKind.Local).AddTicks(7652) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 29, 19, 58, 3, 8, DateTimeKind.Local).AddTicks(9804));

            migrationBuilder.UpdateData(
                table: "FinancialYears",
                keyColumn: "Code",
                keyValue: "2026",
                column: "FinStartDate",
                value: new DateTime(2026, 1, 29, 19, 58, 3, 3, DateTimeKind.Local).AddTicks(8316));

            migrationBuilder.UpdateData(
                table: "UserAuths",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 29, 19, 58, 3, 9, DateTimeKind.Local).AddTicks(1930));

            migrationBuilder.UpdateData(
                table: "UserRole",
                keyColumn: "RoleID",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 1, 29, 19, 58, 3, 7, DateTimeKind.Local).AddTicks(9602), new DateTime(2026, 1, 29, 19, 58, 3, 7, DateTimeKind.Local).AddTicks(9762) });

            migrationBuilder.UpdateData(
                table: "UserRole",
                keyColumn: "RoleID",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 1, 29, 19, 58, 3, 7, DateTimeKind.Local).AddTicks(9882), new DateTime(2026, 1, 29, 19, 58, 3, 7, DateTimeKind.Local).AddTicks(9883) });

            migrationBuilder.CreateIndex(
                name: "IX_TripAcknoledgementReceipts_TripId",
                table: "TripAcknoledgementReceipts",
                column: "TripId");
        }
    }
}
