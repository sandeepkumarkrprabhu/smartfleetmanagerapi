using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SmartFleet.Data.Migrations
{
    /// <inheritdoc />
    public partial class BillTransactionAccountTransactionUpdate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            
            migrationBuilder.AddColumn<string>(
                name: "AccountStatus",
                table: "BillTransaction",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "AccountTransactionId",
                table: "BillTransaction",
                type: "int",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 20, 17, 3, 46, 666, DateTimeKind.Local).AddTicks(7535));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 20, 17, 3, 46, 666, DateTimeKind.Local).AddTicks(8320));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 20, 17, 3, 46, 666, DateTimeKind.Local).AddTicks(8323));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 20, 17, 3, 46, 666, DateTimeKind.Local).AddTicks(8324));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 20, 17, 3, 46, 666, DateTimeKind.Local).AddTicks(8326));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 20, 17, 3, 46, 666, DateTimeKind.Local).AddTicks(8327));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 20, 17, 3, 46, 666, DateTimeKind.Local).AddTicks(8402));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 20, 17, 3, 46, 666, DateTimeKind.Local).AddTicks(8404));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 20, 17, 3, 46, 666, DateTimeKind.Local).AddTicks(8405));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 20, 17, 3, 46, 666, DateTimeKind.Local).AddTicks(8407));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 20, 17, 3, 46, 666, DateTimeKind.Local).AddTicks(8408));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 20, 17, 3, 46, 666, DateTimeKind.Local).AddTicks(8409));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 20, 17, 3, 46, 666, DateTimeKind.Local).AddTicks(8410));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 14,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 20, 17, 3, 46, 666, DateTimeKind.Local).AddTicks(8459));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 15,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 20, 17, 3, 46, 666, DateTimeKind.Local).AddTicks(8461));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 16,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 20, 17, 3, 46, 666, DateTimeKind.Local).AddTicks(8462));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 17,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 20, 17, 3, 46, 666, DateTimeKind.Local).AddTicks(8464));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 18,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 20, 17, 3, 46, 666, DateTimeKind.Local).AddTicks(8465));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 19,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 20, 17, 3, 46, 666, DateTimeKind.Local).AddTicks(8466));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 20,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 20, 17, 3, 46, 666, DateTimeKind.Local).AddTicks(8468));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 21,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 20, 17, 3, 46, 666, DateTimeKind.Local).AddTicks(8476));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 22,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 20, 17, 3, 46, 666, DateTimeKind.Local).AddTicks(8478));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 23,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 20, 17, 3, 46, 666, DateTimeKind.Local).AddTicks(8479));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 24,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 20, 17, 3, 46, 666, DateTimeKind.Local).AddTicks(8480));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 25,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 20, 17, 3, 46, 666, DateTimeKind.Local).AddTicks(8482));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 26,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 20, 17, 3, 46, 666, DateTimeKind.Local).AddTicks(8483));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 27,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 20, 17, 3, 46, 666, DateTimeKind.Local).AddTicks(8484));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 28,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 20, 17, 3, 46, 666, DateTimeKind.Local).AddTicks(8486));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 29,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 20, 17, 3, 46, 666, DateTimeKind.Local).AddTicks(8487));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 30,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 20, 17, 3, 46, 666, DateTimeKind.Local).AddTicks(8488));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 31,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 20, 17, 3, 46, 666, DateTimeKind.Local).AddTicks(8490));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 32,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 20, 17, 3, 46, 666, DateTimeKind.Local).AddTicks(8491));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 33,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 20, 17, 3, 46, 666, DateTimeKind.Local).AddTicks(8493));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 34,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 20, 17, 3, 46, 666, DateTimeKind.Local).AddTicks(8494));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 35,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 20, 17, 3, 46, 666, DateTimeKind.Local).AddTicks(8496));

            migrationBuilder.UpdateData(
                table: "Branches",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 20, 17, 3, 46, 665, DateTimeKind.Local).AddTicks(1471), new DateTime(2026, 2, 20, 17, 3, 46, 665, DateTimeKind.Local).AddTicks(1549) });

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "LastUpdatedAt", "LicensedValidTill" },
                values: new object[] { new DateTime(2026, 2, 20, 17, 3, 46, 664, DateTimeKind.Local).AddTicks(9417), new DateTime(2026, 2, 20, 17, 3, 46, 664, DateTimeKind.Local).AddTicks(9499), new DateTime(2026, 8, 19, 17, 3, 46, 664, DateTimeKind.Local).AddTicks(9710) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 20, 17, 3, 46, 667, DateTimeKind.Local).AddTicks(8965));

            migrationBuilder.UpdateData(
                table: "FinancialYears",
                keyColumn: "Code",
                keyValue: "2026",
                column: "FinStartDate",
                value: new DateTime(2026, 2, 20, 17, 3, 46, 664, DateTimeKind.Local).AddTicks(3437));

            migrationBuilder.UpdateData(
                table: "UserAuths",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 20, 17, 3, 46, 668, DateTimeKind.Local).AddTicks(731));

            migrationBuilder.UpdateData(
                table: "UserRole",
                keyColumn: "RoleID",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 20, 17, 3, 46, 667, DateTimeKind.Local).AddTicks(2205), new DateTime(2026, 2, 20, 17, 3, 46, 667, DateTimeKind.Local).AddTicks(2314) });

            migrationBuilder.UpdateData(
                table: "UserRole",
                keyColumn: "RoleID",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 20, 17, 3, 46, 667, DateTimeKind.Local).AddTicks(2388), new DateTime(2026, 2, 20, 17, 3, 46, 667, DateTimeKind.Local).AddTicks(2388) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AccountStatus",
                table: "BillTransaction");

            migrationBuilder.DropColumn(
                name: "AccountTransactionId",
                table: "BillTransaction");

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 20, 15, 40, 52, 814, DateTimeKind.Local).AddTicks(1280));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 20, 15, 40, 52, 814, DateTimeKind.Local).AddTicks(2078));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 20, 15, 40, 52, 814, DateTimeKind.Local).AddTicks(2081));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 20, 15, 40, 52, 814, DateTimeKind.Local).AddTicks(2082));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 20, 15, 40, 52, 814, DateTimeKind.Local).AddTicks(2084));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 20, 15, 40, 52, 814, DateTimeKind.Local).AddTicks(2085));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 20, 15, 40, 52, 814, DateTimeKind.Local).AddTicks(2155));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 20, 15, 40, 52, 814, DateTimeKind.Local).AddTicks(2157));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 20, 15, 40, 52, 814, DateTimeKind.Local).AddTicks(2159));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 20, 15, 40, 52, 814, DateTimeKind.Local).AddTicks(2168));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 20, 15, 40, 52, 814, DateTimeKind.Local).AddTicks(2169));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 20, 15, 40, 52, 814, DateTimeKind.Local).AddTicks(2170));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 20, 15, 40, 52, 814, DateTimeKind.Local).AddTicks(2172));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 14,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 20, 15, 40, 52, 814, DateTimeKind.Local).AddTicks(2173));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 15,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 20, 15, 40, 52, 814, DateTimeKind.Local).AddTicks(2174));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 16,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 20, 15, 40, 52, 814, DateTimeKind.Local).AddTicks(2176));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 17,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 20, 15, 40, 52, 814, DateTimeKind.Local).AddTicks(2177));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 18,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 20, 15, 40, 52, 814, DateTimeKind.Local).AddTicks(2178));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 19,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 20, 15, 40, 52, 814, DateTimeKind.Local).AddTicks(2180));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 20,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 20, 15, 40, 52, 814, DateTimeKind.Local).AddTicks(2181));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 21,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 20, 15, 40, 52, 814, DateTimeKind.Local).AddTicks(2183));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 22,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 20, 15, 40, 52, 814, DateTimeKind.Local).AddTicks(2184));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 23,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 20, 15, 40, 52, 814, DateTimeKind.Local).AddTicks(2185));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 24,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 20, 15, 40, 52, 814, DateTimeKind.Local).AddTicks(2187));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 25,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 20, 15, 40, 52, 814, DateTimeKind.Local).AddTicks(2188));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 26,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 20, 15, 40, 52, 814, DateTimeKind.Local).AddTicks(2190));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 27,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 20, 15, 40, 52, 814, DateTimeKind.Local).AddTicks(2191));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 28,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 20, 15, 40, 52, 814, DateTimeKind.Local).AddTicks(2192));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 29,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 20, 15, 40, 52, 814, DateTimeKind.Local).AddTicks(2194));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 30,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 20, 15, 40, 52, 814, DateTimeKind.Local).AddTicks(2195));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 31,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 20, 15, 40, 52, 814, DateTimeKind.Local).AddTicks(2197));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 32,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 20, 15, 40, 52, 814, DateTimeKind.Local).AddTicks(2198));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 33,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 20, 15, 40, 52, 814, DateTimeKind.Local).AddTicks(2199));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 34,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 20, 15, 40, 52, 814, DateTimeKind.Local).AddTicks(2201));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 35,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 20, 15, 40, 52, 814, DateTimeKind.Local).AddTicks(2202));

            migrationBuilder.UpdateData(
                table: "Branches",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 20, 15, 40, 52, 812, DateTimeKind.Local).AddTicks(4862), new DateTime(2026, 2, 20, 15, 40, 52, 812, DateTimeKind.Local).AddTicks(4951) });

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "LastUpdatedAt", "LicensedValidTill" },
                values: new object[] { new DateTime(2026, 2, 20, 15, 40, 52, 812, DateTimeKind.Local).AddTicks(2613), new DateTime(2026, 2, 20, 15, 40, 52, 812, DateTimeKind.Local).AddTicks(2703), new DateTime(2026, 8, 19, 15, 40, 52, 812, DateTimeKind.Local).AddTicks(2937) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 20, 15, 40, 52, 816, DateTimeKind.Local).AddTicks(2223));

            migrationBuilder.UpdateData(
                table: "FinancialYears",
                keyColumn: "Code",
                keyValue: "2026",
                column: "FinStartDate",
                value: new DateTime(2026, 2, 20, 15, 40, 52, 811, DateTimeKind.Local).AddTicks(6988));

            migrationBuilder.UpdateData(
                table: "UserAuths",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 20, 15, 40, 52, 816, DateTimeKind.Local).AddTicks(5273));

            migrationBuilder.UpdateData(
                table: "UserRole",
                keyColumn: "RoleID",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 20, 15, 40, 52, 815, DateTimeKind.Local).AddTicks(2078), new DateTime(2026, 2, 20, 15, 40, 52, 815, DateTimeKind.Local).AddTicks(2241) });

            migrationBuilder.UpdateData(
                table: "UserRole",
                keyColumn: "RoleID",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 20, 15, 40, 52, 815, DateTimeKind.Local).AddTicks(2334), new DateTime(2026, 2, 20, 15, 40, 52, 815, DateTimeKind.Local).AddTicks(2335) });

            migrationBuilder.CreateIndex(
                name: "IX_CustomerInvoiceAllocation_InvoiceId",
                table: "CustomerInvoiceAllocation",
                column: "InvoiceId");

            migrationBuilder.CreateIndex(
                name: "IX_CustomerInvoiceAllocation_ReceiptDetailId",
                table: "CustomerInvoiceAllocation",
                column: "ReceiptDetailId");
        }
    }
}
