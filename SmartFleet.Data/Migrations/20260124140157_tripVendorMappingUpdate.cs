using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SmartFleet.Data.Migrations
{
    /// <inheritdoc />
    public partial class tripVendorMappingUpdate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "VendorId",
                table: "TripTransaction",
                type: "int",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 24, 19, 31, 54, 857, DateTimeKind.Local).AddTicks(6074));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 24, 19, 31, 54, 857, DateTimeKind.Local).AddTicks(6824));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 24, 19, 31, 54, 857, DateTimeKind.Local).AddTicks(6827));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 24, 19, 31, 54, 857, DateTimeKind.Local).AddTicks(6828));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 24, 19, 31, 54, 857, DateTimeKind.Local).AddTicks(6829));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 24, 19, 31, 54, 857, DateTimeKind.Local).AddTicks(6831));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 24, 19, 31, 54, 857, DateTimeKind.Local).AddTicks(6904));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 24, 19, 31, 54, 857, DateTimeKind.Local).AddTicks(6906));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 24, 19, 31, 54, 857, DateTimeKind.Local).AddTicks(6907));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 24, 19, 31, 54, 857, DateTimeKind.Local).AddTicks(6909));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 24, 19, 31, 54, 857, DateTimeKind.Local).AddTicks(6910));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 24, 19, 31, 54, 857, DateTimeKind.Local).AddTicks(6911));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 24, 19, 31, 54, 857, DateTimeKind.Local).AddTicks(6912));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 14,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 24, 19, 31, 54, 857, DateTimeKind.Local).AddTicks(6914));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 15,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 24, 19, 31, 54, 857, DateTimeKind.Local).AddTicks(6915));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 16,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 24, 19, 31, 54, 857, DateTimeKind.Local).AddTicks(6916));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 17,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 24, 19, 31, 54, 857, DateTimeKind.Local).AddTicks(6925));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 18,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 24, 19, 31, 54, 857, DateTimeKind.Local).AddTicks(6926));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 19,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 24, 19, 31, 54, 857, DateTimeKind.Local).AddTicks(6928));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 20,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 24, 19, 31, 54, 857, DateTimeKind.Local).AddTicks(7015));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 21,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 24, 19, 31, 54, 857, DateTimeKind.Local).AddTicks(7017));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 22,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 24, 19, 31, 54, 857, DateTimeKind.Local).AddTicks(7018));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 23,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 24, 19, 31, 54, 857, DateTimeKind.Local).AddTicks(7019));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 24,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 24, 19, 31, 54, 857, DateTimeKind.Local).AddTicks(7021));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 25,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 24, 19, 31, 54, 857, DateTimeKind.Local).AddTicks(7022));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 26,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 24, 19, 31, 54, 857, DateTimeKind.Local).AddTicks(7023));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 27,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 24, 19, 31, 54, 857, DateTimeKind.Local).AddTicks(7025));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 28,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 24, 19, 31, 54, 857, DateTimeKind.Local).AddTicks(7026));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 29,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 24, 19, 31, 54, 857, DateTimeKind.Local).AddTicks(7027));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 30,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 24, 19, 31, 54, 857, DateTimeKind.Local).AddTicks(7028));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 31,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 24, 19, 31, 54, 857, DateTimeKind.Local).AddTicks(7030));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 32,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 24, 19, 31, 54, 857, DateTimeKind.Local).AddTicks(7031));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 33,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 24, 19, 31, 54, 857, DateTimeKind.Local).AddTicks(7033));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 34,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 24, 19, 31, 54, 857, DateTimeKind.Local).AddTicks(7034));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 35,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 24, 19, 31, 54, 857, DateTimeKind.Local).AddTicks(7035));

            migrationBuilder.UpdateData(
                table: "Branches",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 1, 24, 19, 31, 54, 855, DateTimeKind.Local).AddTicks(8155), new DateTime(2026, 1, 24, 19, 31, 54, 855, DateTimeKind.Local).AddTicks(8243) });

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "LastUpdatedAt", "LicensedValidTill" },
                values: new object[] { new DateTime(2026, 1, 24, 19, 31, 54, 855, DateTimeKind.Local).AddTicks(5673), new DateTime(2026, 1, 24, 19, 31, 54, 855, DateTimeKind.Local).AddTicks(5771), new DateTime(2026, 7, 23, 19, 31, 54, 855, DateTimeKind.Local).AddTicks(6010) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 24, 19, 31, 54, 858, DateTimeKind.Local).AddTicks(5153));

            migrationBuilder.UpdateData(
                table: "FinancialYears",
                keyColumn: "Code",
                keyValue: "2026",
                column: "FinStartDate",
                value: new DateTime(2026, 1, 24, 19, 31, 54, 854, DateTimeKind.Local).AddTicks(7243));

            migrationBuilder.UpdateData(
                table: "UserAuths",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 24, 19, 31, 54, 858, DateTimeKind.Local).AddTicks(6973));

            migrationBuilder.UpdateData(
                table: "UserRole",
                keyColumn: "RoleID",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 1, 24, 19, 31, 54, 857, DateTimeKind.Local).AddTicks(8845), new DateTime(2026, 1, 24, 19, 31, 54, 857, DateTimeKind.Local).AddTicks(8950) });

            migrationBuilder.UpdateData(
                table: "UserRole",
                keyColumn: "RoleID",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 1, 24, 19, 31, 54, 857, DateTimeKind.Local).AddTicks(9030), new DateTime(2026, 1, 24, 19, 31, 54, 857, DateTimeKind.Local).AddTicks(9031) });

            migrationBuilder.CreateIndex(
                name: "IX_TripTransaction_VendorId",
                table: "TripTransaction",
                column: "VendorId");

            migrationBuilder.AddForeignKey(
                name: "FK_TripTransaction_Vendors_VendorId",
                table: "TripTransaction",
                column: "VendorId",
                principalTable: "Vendors",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TripTransaction_Vendors_VendorId",
                table: "TripTransaction");

            migrationBuilder.DropIndex(
                name: "IX_TripTransaction_VendorId",
                table: "TripTransaction");

            migrationBuilder.DropColumn(
                name: "VendorId",
                table: "TripTransaction");

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 24, 19, 24, 29, 608, DateTimeKind.Local).AddTicks(5645));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 24, 19, 24, 29, 608, DateTimeKind.Local).AddTicks(6415));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 24, 19, 24, 29, 608, DateTimeKind.Local).AddTicks(6428));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 24, 19, 24, 29, 608, DateTimeKind.Local).AddTicks(6430));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 24, 19, 24, 29, 608, DateTimeKind.Local).AddTicks(6431));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 24, 19, 24, 29, 608, DateTimeKind.Local).AddTicks(6432));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 24, 19, 24, 29, 608, DateTimeKind.Local).AddTicks(6509));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 24, 19, 24, 29, 608, DateTimeKind.Local).AddTicks(6511));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 24, 19, 24, 29, 608, DateTimeKind.Local).AddTicks(6512));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 24, 19, 24, 29, 608, DateTimeKind.Local).AddTicks(6513));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 24, 19, 24, 29, 608, DateTimeKind.Local).AddTicks(6515));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 24, 19, 24, 29, 608, DateTimeKind.Local).AddTicks(6516));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 24, 19, 24, 29, 608, DateTimeKind.Local).AddTicks(6517));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 14,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 24, 19, 24, 29, 608, DateTimeKind.Local).AddTicks(6518));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 15,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 24, 19, 24, 29, 608, DateTimeKind.Local).AddTicks(6519));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 16,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 24, 19, 24, 29, 608, DateTimeKind.Local).AddTicks(6521));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 17,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 24, 19, 24, 29, 608, DateTimeKind.Local).AddTicks(6522));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 18,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 24, 19, 24, 29, 608, DateTimeKind.Local).AddTicks(6523));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 19,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 24, 19, 24, 29, 608, DateTimeKind.Local).AddTicks(6533));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 20,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 24, 19, 24, 29, 608, DateTimeKind.Local).AddTicks(6535));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 21,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 24, 19, 24, 29, 608, DateTimeKind.Local).AddTicks(6536));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 22,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 24, 19, 24, 29, 608, DateTimeKind.Local).AddTicks(6537));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 23,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 24, 19, 24, 29, 608, DateTimeKind.Local).AddTicks(6538));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 24,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 24, 19, 24, 29, 608, DateTimeKind.Local).AddTicks(6540));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 25,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 24, 19, 24, 29, 608, DateTimeKind.Local).AddTicks(6541));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 26,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 24, 19, 24, 29, 608, DateTimeKind.Local).AddTicks(6542));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 27,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 24, 19, 24, 29, 608, DateTimeKind.Local).AddTicks(6544));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 28,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 24, 19, 24, 29, 608, DateTimeKind.Local).AddTicks(6545));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 29,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 24, 19, 24, 29, 608, DateTimeKind.Local).AddTicks(6546));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 30,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 24, 19, 24, 29, 608, DateTimeKind.Local).AddTicks(6548));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 31,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 24, 19, 24, 29, 608, DateTimeKind.Local).AddTicks(6549));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 32,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 24, 19, 24, 29, 608, DateTimeKind.Local).AddTicks(6551));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 33,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 24, 19, 24, 29, 608, DateTimeKind.Local).AddTicks(6552));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 34,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 24, 19, 24, 29, 608, DateTimeKind.Local).AddTicks(6553));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 35,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 24, 19, 24, 29, 608, DateTimeKind.Local).AddTicks(6555));

            migrationBuilder.UpdateData(
                table: "Branches",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 1, 24, 19, 24, 29, 606, DateTimeKind.Local).AddTicks(8441), new DateTime(2026, 1, 24, 19, 24, 29, 606, DateTimeKind.Local).AddTicks(8536) });

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "LastUpdatedAt", "LicensedValidTill" },
                values: new object[] { new DateTime(2026, 1, 24, 19, 24, 29, 606, DateTimeKind.Local).AddTicks(5892), new DateTime(2026, 1, 24, 19, 24, 29, 606, DateTimeKind.Local).AddTicks(5994), new DateTime(2026, 7, 23, 19, 24, 29, 606, DateTimeKind.Local).AddTicks(6236) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 24, 19, 24, 29, 609, DateTimeKind.Local).AddTicks(5419));

            migrationBuilder.UpdateData(
                table: "FinancialYears",
                keyColumn: "Code",
                keyValue: "2026",
                column: "FinStartDate",
                value: new DateTime(2026, 1, 24, 19, 24, 29, 605, DateTimeKind.Local).AddTicks(9173));

            migrationBuilder.UpdateData(
                table: "UserAuths",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 24, 19, 24, 29, 609, DateTimeKind.Local).AddTicks(7249));

            migrationBuilder.UpdateData(
                table: "UserRole",
                keyColumn: "RoleID",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 1, 24, 19, 24, 29, 608, DateTimeKind.Local).AddTicks(8343), new DateTime(2026, 1, 24, 19, 24, 29, 608, DateTimeKind.Local).AddTicks(8441) });

            migrationBuilder.UpdateData(
                table: "UserRole",
                keyColumn: "RoleID",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 1, 24, 19, 24, 29, 608, DateTimeKind.Local).AddTicks(8523), new DateTime(2026, 1, 24, 19, 24, 29, 608, DateTimeKind.Local).AddTicks(8524) });
        }
    }
}
