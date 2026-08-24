using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SmartFleet.Data.Migrations
{
    /// <inheritdoc />
    public partial class UpdateTripTableRemoveProduct : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TripProductDetails_TripTransaction_TripTransactionId",
                table: "TripProductDetails");

            migrationBuilder.DropIndex(
                name: "IX_TripProductDetails_TripTransactionId",
                table: "TripProductDetails");

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2026, 4, 28, 15, 29, 17, 183, DateTimeKind.Local).AddTicks(5731));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2026, 4, 28, 15, 29, 17, 183, DateTimeKind.Local).AddTicks(6739));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2026, 4, 28, 15, 29, 17, 183, DateTimeKind.Local).AddTicks(6743));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2026, 4, 28, 15, 29, 17, 183, DateTimeKind.Local).AddTicks(6745));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2026, 4, 28, 15, 29, 17, 183, DateTimeKind.Local).AddTicks(6746));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2026, 4, 28, 15, 29, 17, 183, DateTimeKind.Local).AddTicks(6748));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2026, 4, 28, 15, 29, 17, 183, DateTimeKind.Local).AddTicks(6825));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2026, 4, 28, 15, 29, 17, 183, DateTimeKind.Local).AddTicks(6827));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2026, 4, 28, 15, 29, 17, 183, DateTimeKind.Local).AddTicks(6829));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2026, 4, 28, 15, 29, 17, 183, DateTimeKind.Local).AddTicks(6830));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2026, 4, 28, 15, 29, 17, 183, DateTimeKind.Local).AddTicks(6840));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2026, 4, 28, 15, 29, 17, 183, DateTimeKind.Local).AddTicks(6841));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2026, 4, 28, 15, 29, 17, 183, DateTimeKind.Local).AddTicks(6843));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 14,
                column: "CreatedAt",
                value: new DateTime(2026, 4, 28, 15, 29, 17, 183, DateTimeKind.Local).AddTicks(6844));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 15,
                column: "CreatedAt",
                value: new DateTime(2026, 4, 28, 15, 29, 17, 183, DateTimeKind.Local).AddTicks(6908));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 16,
                column: "CreatedAt",
                value: new DateTime(2026, 4, 28, 15, 29, 17, 183, DateTimeKind.Local).AddTicks(6909));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 17,
                column: "CreatedAt",
                value: new DateTime(2026, 4, 28, 15, 29, 17, 183, DateTimeKind.Local).AddTicks(6911));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 18,
                column: "CreatedAt",
                value: new DateTime(2026, 4, 28, 15, 29, 17, 183, DateTimeKind.Local).AddTicks(6913));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 19,
                column: "CreatedAt",
                value: new DateTime(2026, 4, 28, 15, 29, 17, 183, DateTimeKind.Local).AddTicks(6914));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 20,
                column: "CreatedAt",
                value: new DateTime(2026, 4, 28, 15, 29, 17, 183, DateTimeKind.Local).AddTicks(6916));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 21,
                column: "CreatedAt",
                value: new DateTime(2026, 4, 28, 15, 29, 17, 183, DateTimeKind.Local).AddTicks(6917));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 22,
                column: "CreatedAt",
                value: new DateTime(2026, 4, 28, 15, 29, 17, 183, DateTimeKind.Local).AddTicks(6919));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 23,
                column: "CreatedAt",
                value: new DateTime(2026, 4, 28, 15, 29, 17, 183, DateTimeKind.Local).AddTicks(6920));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 24,
                column: "CreatedAt",
                value: new DateTime(2026, 4, 28, 15, 29, 17, 183, DateTimeKind.Local).AddTicks(6922));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 25,
                column: "CreatedAt",
                value: new DateTime(2026, 4, 28, 15, 29, 17, 183, DateTimeKind.Local).AddTicks(6923));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 26,
                column: "CreatedAt",
                value: new DateTime(2026, 4, 28, 15, 29, 17, 183, DateTimeKind.Local).AddTicks(6925));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 27,
                column: "CreatedAt",
                value: new DateTime(2026, 4, 28, 15, 29, 17, 183, DateTimeKind.Local).AddTicks(6926));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 28,
                column: "CreatedAt",
                value: new DateTime(2026, 4, 28, 15, 29, 17, 183, DateTimeKind.Local).AddTicks(6928));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 29,
                column: "CreatedAt",
                value: new DateTime(2026, 4, 28, 15, 29, 17, 183, DateTimeKind.Local).AddTicks(6929));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 30,
                column: "CreatedAt",
                value: new DateTime(2026, 4, 28, 15, 29, 17, 183, DateTimeKind.Local).AddTicks(6931));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 31,
                column: "CreatedAt",
                value: new DateTime(2026, 4, 28, 15, 29, 17, 183, DateTimeKind.Local).AddTicks(6932));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 32,
                column: "CreatedAt",
                value: new DateTime(2026, 4, 28, 15, 29, 17, 183, DateTimeKind.Local).AddTicks(6934));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 33,
                column: "CreatedAt",
                value: new DateTime(2026, 4, 28, 15, 29, 17, 183, DateTimeKind.Local).AddTicks(6935));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 34,
                column: "CreatedAt",
                value: new DateTime(2026, 4, 28, 15, 29, 17, 183, DateTimeKind.Local).AddTicks(6937));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 35,
                column: "CreatedAt",
                value: new DateTime(2026, 4, 28, 15, 29, 17, 183, DateTimeKind.Local).AddTicks(6938));

            migrationBuilder.UpdateData(
                table: "Branches",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 4, 28, 15, 29, 17, 181, DateTimeKind.Local).AddTicks(4222), new DateTime(2026, 4, 28, 15, 29, 17, 181, DateTimeKind.Local).AddTicks(4314) });

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "LastUpdatedAt", "LicensedValidTill" },
                values: new object[] { new DateTime(2026, 4, 28, 15, 29, 17, 181, DateTimeKind.Local).AddTicks(1616), new DateTime(2026, 4, 28, 15, 29, 17, 181, DateTimeKind.Local).AddTicks(1716), new DateTime(2026, 10, 25, 15, 29, 17, 181, DateTimeKind.Local).AddTicks(1960) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2026, 4, 28, 15, 29, 17, 184, DateTimeKind.Local).AddTicks(7216));

            migrationBuilder.UpdateData(
                table: "FinancialYears",
                keyColumn: "Code",
                keyValue: "2026",
                column: "FinStartDate",
                value: new DateTime(2026, 4, 28, 15, 29, 17, 180, DateTimeKind.Local).AddTicks(5243));

            migrationBuilder.UpdateData(
                table: "UserAuths",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2026, 4, 28, 15, 29, 17, 184, DateTimeKind.Local).AddTicks(9550));

            migrationBuilder.UpdateData(
                table: "UserRole",
                keyColumn: "RoleID",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 4, 28, 15, 29, 17, 183, DateTimeKind.Local).AddTicks(8741), new DateTime(2026, 4, 28, 15, 29, 17, 183, DateTimeKind.Local).AddTicks(8844) });

            migrationBuilder.UpdateData(
                table: "UserRole",
                keyColumn: "RoleID",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 4, 28, 15, 29, 17, 183, DateTimeKind.Local).AddTicks(8925), new DateTime(2026, 4, 28, 15, 29, 17, 183, DateTimeKind.Local).AddTicks(8926) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2026, 4, 27, 17, 40, 34, 43, DateTimeKind.Local).AddTicks(9823));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2026, 4, 27, 17, 40, 34, 44, DateTimeKind.Local).AddTicks(668));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2026, 4, 27, 17, 40, 34, 44, DateTimeKind.Local).AddTicks(671));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2026, 4, 27, 17, 40, 34, 44, DateTimeKind.Local).AddTicks(672));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2026, 4, 27, 17, 40, 34, 44, DateTimeKind.Local).AddTicks(727));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2026, 4, 27, 17, 40, 34, 44, DateTimeKind.Local).AddTicks(729));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2026, 4, 27, 17, 40, 34, 44, DateTimeKind.Local).AddTicks(796));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2026, 4, 27, 17, 40, 34, 44, DateTimeKind.Local).AddTicks(798));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2026, 4, 27, 17, 40, 34, 44, DateTimeKind.Local).AddTicks(800));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2026, 4, 27, 17, 40, 34, 44, DateTimeKind.Local).AddTicks(801));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2026, 4, 27, 17, 40, 34, 44, DateTimeKind.Local).AddTicks(810));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2026, 4, 27, 17, 40, 34, 44, DateTimeKind.Local).AddTicks(812));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2026, 4, 27, 17, 40, 34, 44, DateTimeKind.Local).AddTicks(813));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 14,
                column: "CreatedAt",
                value: new DateTime(2026, 4, 27, 17, 40, 34, 44, DateTimeKind.Local).AddTicks(814));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 15,
                column: "CreatedAt",
                value: new DateTime(2026, 4, 27, 17, 40, 34, 44, DateTimeKind.Local).AddTicks(816));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 16,
                column: "CreatedAt",
                value: new DateTime(2026, 4, 27, 17, 40, 34, 44, DateTimeKind.Local).AddTicks(817));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 17,
                column: "CreatedAt",
                value: new DateTime(2026, 4, 27, 17, 40, 34, 44, DateTimeKind.Local).AddTicks(818));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 18,
                column: "CreatedAt",
                value: new DateTime(2026, 4, 27, 17, 40, 34, 44, DateTimeKind.Local).AddTicks(820));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 19,
                column: "CreatedAt",
                value: new DateTime(2026, 4, 27, 17, 40, 34, 44, DateTimeKind.Local).AddTicks(821));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 20,
                column: "CreatedAt",
                value: new DateTime(2026, 4, 27, 17, 40, 34, 44, DateTimeKind.Local).AddTicks(823));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 21,
                column: "CreatedAt",
                value: new DateTime(2026, 4, 27, 17, 40, 34, 44, DateTimeKind.Local).AddTicks(824));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 22,
                column: "CreatedAt",
                value: new DateTime(2026, 4, 27, 17, 40, 34, 44, DateTimeKind.Local).AddTicks(825));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 23,
                column: "CreatedAt",
                value: new DateTime(2026, 4, 27, 17, 40, 34, 44, DateTimeKind.Local).AddTicks(827));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 24,
                column: "CreatedAt",
                value: new DateTime(2026, 4, 27, 17, 40, 34, 44, DateTimeKind.Local).AddTicks(828));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 25,
                column: "CreatedAt",
                value: new DateTime(2026, 4, 27, 17, 40, 34, 44, DateTimeKind.Local).AddTicks(829));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 26,
                column: "CreatedAt",
                value: new DateTime(2026, 4, 27, 17, 40, 34, 44, DateTimeKind.Local).AddTicks(831));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 27,
                column: "CreatedAt",
                value: new DateTime(2026, 4, 27, 17, 40, 34, 44, DateTimeKind.Local).AddTicks(832));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 28,
                column: "CreatedAt",
                value: new DateTime(2026, 4, 27, 17, 40, 34, 44, DateTimeKind.Local).AddTicks(834));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 29,
                column: "CreatedAt",
                value: new DateTime(2026, 4, 27, 17, 40, 34, 44, DateTimeKind.Local).AddTicks(835));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 30,
                column: "CreatedAt",
                value: new DateTime(2026, 4, 27, 17, 40, 34, 44, DateTimeKind.Local).AddTicks(836));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 31,
                column: "CreatedAt",
                value: new DateTime(2026, 4, 27, 17, 40, 34, 44, DateTimeKind.Local).AddTicks(838));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 32,
                column: "CreatedAt",
                value: new DateTime(2026, 4, 27, 17, 40, 34, 44, DateTimeKind.Local).AddTicks(839));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 33,
                column: "CreatedAt",
                value: new DateTime(2026, 4, 27, 17, 40, 34, 44, DateTimeKind.Local).AddTicks(840));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 34,
                column: "CreatedAt",
                value: new DateTime(2026, 4, 27, 17, 40, 34, 44, DateTimeKind.Local).AddTicks(842));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 35,
                column: "CreatedAt",
                value: new DateTime(2026, 4, 27, 17, 40, 34, 44, DateTimeKind.Local).AddTicks(843));

            migrationBuilder.UpdateData(
                table: "Branches",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 4, 27, 17, 40, 34, 41, DateTimeKind.Local).AddTicks(3175), new DateTime(2026, 4, 27, 17, 40, 34, 41, DateTimeKind.Local).AddTicks(3258) });

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "LastUpdatedAt", "LicensedValidTill" },
                values: new object[] { new DateTime(2026, 4, 27, 17, 40, 34, 41, DateTimeKind.Local).AddTicks(679), new DateTime(2026, 4, 27, 17, 40, 34, 41, DateTimeKind.Local).AddTicks(766), new DateTime(2026, 10, 24, 17, 40, 34, 41, DateTimeKind.Local).AddTicks(983) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2026, 4, 27, 17, 40, 34, 45, DateTimeKind.Local).AddTicks(868));

            migrationBuilder.UpdateData(
                table: "FinancialYears",
                keyColumn: "Code",
                keyValue: "2026",
                column: "FinStartDate",
                value: new DateTime(2026, 4, 27, 17, 40, 34, 40, DateTimeKind.Local).AddTicks(3729));

            migrationBuilder.UpdateData(
                table: "UserAuths",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2026, 4, 27, 17, 40, 34, 45, DateTimeKind.Local).AddTicks(2720));

            migrationBuilder.UpdateData(
                table: "UserRole",
                keyColumn: "RoleID",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 4, 27, 17, 40, 34, 44, DateTimeKind.Local).AddTicks(3056), new DateTime(2026, 4, 27, 17, 40, 34, 44, DateTimeKind.Local).AddTicks(3154) });

            migrationBuilder.UpdateData(
                table: "UserRole",
                keyColumn: "RoleID",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 4, 27, 17, 40, 34, 44, DateTimeKind.Local).AddTicks(3362), new DateTime(2026, 4, 27, 17, 40, 34, 44, DateTimeKind.Local).AddTicks(3363) });

            migrationBuilder.CreateIndex(
                name: "IX_TripProductDetails_TripTransactionId",
                table: "TripProductDetails",
                column: "TripTransactionId");

            migrationBuilder.AddForeignKey(
                name: "FK_TripProductDetails_TripTransaction_TripTransactionId",
                table: "TripProductDetails",
                column: "TripTransactionId",
                principalTable: "TripTransaction",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
