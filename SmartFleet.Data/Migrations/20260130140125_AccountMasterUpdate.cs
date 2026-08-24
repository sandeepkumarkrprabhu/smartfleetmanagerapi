using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SmartFleet.Data.Migrations
{
    /// <inheritdoc />
    public partial class AccountMasterUpdate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            
            migrationBuilder.AddColumn<string>(
                name: "GroupName",
                table: "AccountMasters",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 1,
                columns: new[] { "CreatedAt", "GroupName" },
                values: new object[] { new DateTime(2026, 1, 30, 19, 31, 23, 201, DateTimeKind.Local).AddTicks(9157), "CASH" });

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 2,
                columns: new[] { "CreatedAt", "GroupName" },
                values: new object[] { new DateTime(2026, 1, 30, 19, 31, 23, 201, DateTimeKind.Local).AddTicks(9888), "BANK" });

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 3,
                columns: new[] { "CreatedAt", "GroupName" },
                values: new object[] { new DateTime(2026, 1, 30, 19, 31, 23, 201, DateTimeKind.Local).AddTicks(9890), "Receivables" });

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 4,
                columns: new[] { "CreatedAt", "GroupName" },
                values: new object[] { new DateTime(2026, 1, 30, 19, 31, 23, 201, DateTimeKind.Local).AddTicks(9892), "Inventory" });

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 5,
                columns: new[] { "CreatedAt", "GroupName" },
                values: new object[] { new DateTime(2026, 1, 30, 19, 31, 23, 201, DateTimeKind.Local).AddTicks(9893), "Vehicles" });

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 6,
                columns: new[] { "CreatedAt", "GroupName" },
                values: new object[] { new DateTime(2026, 1, 30, 19, 31, 23, 201, DateTimeKind.Local).AddTicks(9894), "Depreciation" });

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 7,
                columns: new[] { "CreatedAt", "GroupName" },
                values: new object[] { new DateTime(2026, 1, 30, 19, 31, 23, 201, DateTimeKind.Local).AddTicks(9957), "Fuel" });

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 8,
                columns: new[] { "CreatedAt", "GroupName" },
                values: new object[] { new DateTime(2026, 1, 30, 19, 31, 23, 201, DateTimeKind.Local).AddTicks(9959), "Spare & Inventory" });

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 9,
                columns: new[] { "CreatedAt", "GroupName" },
                values: new object[] { new DateTime(2026, 1, 30, 19, 31, 23, 201, DateTimeKind.Local).AddTicks(9960), "Payables" });

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 10,
                columns: new[] { "CreatedAt", "GroupName" },
                values: new object[] { new DateTime(2026, 1, 30, 19, 31, 23, 201, DateTimeKind.Local).AddTicks(9962), "Expenses" });

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 11,
                columns: new[] { "CreatedAt", "GroupName" },
                values: new object[] { new DateTime(2026, 1, 30, 19, 31, 23, 201, DateTimeKind.Local).AddTicks(9963), "Loans" });

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 12,
                columns: new[] { "CreatedAt", "GroupName" },
                values: new object[] { new DateTime(2026, 1, 30, 19, 31, 23, 201, DateTimeKind.Local).AddTicks(9964), "Payable" });

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 13,
                columns: new[] { "CreatedAt", "GroupName" },
                values: new object[] { new DateTime(2026, 1, 30, 19, 31, 23, 201, DateTimeKind.Local).AddTicks(9965), "Lease" });

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 14,
                columns: new[] { "CreatedAt", "GroupName" },
                values: new object[] { new DateTime(2026, 1, 30, 19, 31, 23, 201, DateTimeKind.Local).AddTicks(9976), "Equity" });

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 15,
                columns: new[] { "CreatedAt", "GroupName" },
                values: new object[] { new DateTime(2026, 1, 30, 19, 31, 23, 201, DateTimeKind.Local).AddTicks(9977), "Earnings" });

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 16,
                columns: new[] { "CreatedAt", "GroupName" },
                values: new object[] { new DateTime(2026, 1, 30, 19, 31, 23, 201, DateTimeKind.Local).AddTicks(9978), "Income" });

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 17,
                columns: new[] { "CreatedAt", "GroupName" },
                values: new object[] { new DateTime(2026, 1, 30, 19, 31, 23, 201, DateTimeKind.Local).AddTicks(9979), "Incone" });

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 18,
                columns: new[] { "CreatedAt", "GroupName" },
                values: new object[] { new DateTime(2026, 1, 30, 19, 31, 23, 201, DateTimeKind.Local).AddTicks(9981), "Incone" });

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 19,
                columns: new[] { "CreatedAt", "GroupName" },
                values: new object[] { new DateTime(2026, 1, 30, 19, 31, 23, 201, DateTimeKind.Local).AddTicks(9982), "Incone" });

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 20,
                columns: new[] { "CreatedAt", "GroupName" },
                values: new object[] { new DateTime(2026, 1, 30, 19, 31, 23, 201, DateTimeKind.Local).AddTicks(9983), "Incone" });

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 21,
                columns: new[] { "CreatedAt", "GroupName" },
                values: new object[] { new DateTime(2026, 1, 30, 19, 31, 23, 201, DateTimeKind.Local).AddTicks(9985), "Incone" });

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 22,
                columns: new[] { "CreatedAt", "GroupName" },
                values: new object[] { new DateTime(2026, 1, 30, 19, 31, 23, 201, DateTimeKind.Local).AddTicks(9986), "Expenses" });

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 23,
                columns: new[] { "CreatedAt", "GroupName" },
                values: new object[] { new DateTime(2026, 1, 30, 19, 31, 23, 201, DateTimeKind.Local).AddTicks(9987), "Expenses" });

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 24,
                columns: new[] { "CreatedAt", "GroupName" },
                values: new object[] { new DateTime(2026, 1, 30, 19, 31, 23, 201, DateTimeKind.Local).AddTicks(9989), "Expenses" });

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 25,
                columns: new[] { "CreatedAt", "GroupName" },
                values: new object[] { new DateTime(2026, 1, 30, 19, 31, 23, 201, DateTimeKind.Local).AddTicks(9990), "Expenses" });

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 26,
                columns: new[] { "CreatedAt", "GroupName" },
                values: new object[] { new DateTime(2026, 1, 30, 19, 31, 23, 201, DateTimeKind.Local).AddTicks(9991), "Expenses" });

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 27,
                columns: new[] { "CreatedAt", "GroupName" },
                values: new object[] { new DateTime(2026, 1, 30, 19, 31, 23, 201, DateTimeKind.Local).AddTicks(9993), "Expenses" });

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 28,
                columns: new[] { "CreatedAt", "GroupName" },
                values: new object[] { new DateTime(2026, 1, 30, 19, 31, 23, 201, DateTimeKind.Local).AddTicks(9994), "Expenses" });

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 29,
                columns: new[] { "CreatedAt", "GroupName" },
                values: new object[] { new DateTime(2026, 1, 30, 19, 31, 23, 201, DateTimeKind.Local).AddTicks(9995), "Expenses" });

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 30,
                columns: new[] { "CreatedAt", "GroupName" },
                values: new object[] { new DateTime(2026, 1, 30, 19, 31, 23, 201, DateTimeKind.Local).AddTicks(9996), "Expenses" });

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 31,
                columns: new[] { "CreatedAt", "GroupName" },
                values: new object[] { new DateTime(2026, 1, 30, 19, 31, 23, 201, DateTimeKind.Local).AddTicks(9998), "Expenses" });

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 32,
                columns: new[] { "CreatedAt", "GroupName" },
                values: new object[] { new DateTime(2026, 1, 30, 19, 31, 23, 201, DateTimeKind.Local).AddTicks(9999), "Expenses" });

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 33,
                columns: new[] { "CreatedAt", "GroupName" },
                values: new object[] { new DateTime(2026, 1, 30, 19, 31, 23, 202, DateTimeKind.Local), "Expenses" });

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 34,
                columns: new[] { "CreatedAt", "GroupName" },
                values: new object[] { new DateTime(2026, 1, 30, 19, 31, 23, 202, DateTimeKind.Local).AddTicks(2), "Expenses" });

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 35,
                columns: new[] { "CreatedAt", "GroupName" },
                values: new object[] { new DateTime(2026, 1, 30, 19, 31, 23, 202, DateTimeKind.Local).AddTicks(3), "Expenses" });

            migrationBuilder.UpdateData(
                table: "Branches",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 1, 30, 19, 31, 23, 200, DateTimeKind.Local).AddTicks(3066), new DateTime(2026, 1, 30, 19, 31, 23, 200, DateTimeKind.Local).AddTicks(3153) });

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "LastUpdatedAt", "LicensedValidTill" },
                values: new object[] { new DateTime(2026, 1, 30, 19, 31, 23, 199, DateTimeKind.Local).AddTicks(1604), new DateTime(2026, 1, 30, 19, 31, 23, 199, DateTimeKind.Local).AddTicks(1686), new DateTime(2026, 7, 29, 19, 31, 23, 199, DateTimeKind.Local).AddTicks(1892) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 30, 19, 31, 23, 202, DateTimeKind.Local).AddTicks(7846));

            migrationBuilder.UpdateData(
                table: "FinancialYears",
                keyColumn: "Code",
                keyValue: "2026",
                column: "FinStartDate",
                value: new DateTime(2026, 1, 30, 19, 31, 23, 198, DateTimeKind.Local).AddTicks(6174));

            migrationBuilder.UpdateData(
                table: "UserAuths",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 30, 19, 31, 23, 202, DateTimeKind.Local).AddTicks(9399));

            migrationBuilder.UpdateData(
                table: "UserRole",
                keyColumn: "RoleID",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 1, 30, 19, 31, 23, 202, DateTimeKind.Local).AddTicks(1595), new DateTime(2026, 1, 30, 19, 31, 23, 202, DateTimeKind.Local).AddTicks(1680) });

            migrationBuilder.UpdateData(
                table: "UserRole",
                keyColumn: "RoleID",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 1, 30, 19, 31, 23, 202, DateTimeKind.Local).AddTicks(1745), new DateTime(2026, 1, 30, 19, 31, 23, 202, DateTimeKind.Local).AddTicks(1746) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "GroupName",
                table: "AccountMasters");
        }
    }
}
