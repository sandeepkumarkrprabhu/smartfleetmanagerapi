using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SmartFleet.Data.Migrations
{
    /// <inheritdoc />
    public partial class BillRMTInvoiceNoUpdate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_financialYears",
                table: "financialYears");

            migrationBuilder.RenameTable(
                name: "financialYears",
                newName: "FinancialYears");

            migrationBuilder.AddColumn<int>(
                name: "RMTInvoiceNo",
                table: "BillTransaction",
                type: "int",
                maxLength: 100,
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddPrimaryKey(
                name: "PK_FinancialYears",
                table: "FinancialYears",
                column: "Code");

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 18, 23, 10, 43, 990, DateTimeKind.Local).AddTicks(4420));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 18, 23, 10, 43, 990, DateTimeKind.Local).AddTicks(5119));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 18, 23, 10, 43, 990, DateTimeKind.Local).AddTicks(5122));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 18, 23, 10, 43, 990, DateTimeKind.Local).AddTicks(5123));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 18, 23, 10, 43, 990, DateTimeKind.Local).AddTicks(5124));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 18, 23, 10, 43, 990, DateTimeKind.Local).AddTicks(5126));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 18, 23, 10, 43, 990, DateTimeKind.Local).AddTicks(5191));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 18, 23, 10, 43, 990, DateTimeKind.Local).AddTicks(5193));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 18, 23, 10, 43, 990, DateTimeKind.Local).AddTicks(5194));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 18, 23, 10, 43, 990, DateTimeKind.Local).AddTicks(5195));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 18, 23, 10, 43, 990, DateTimeKind.Local).AddTicks(5197));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 18, 23, 10, 43, 990, DateTimeKind.Local).AddTicks(5198));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 18, 23, 10, 43, 990, DateTimeKind.Local).AddTicks(5199));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 14,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 18, 23, 10, 43, 990, DateTimeKind.Local).AddTicks(5200));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 15,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 18, 23, 10, 43, 990, DateTimeKind.Local).AddTicks(5201));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 16,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 18, 23, 10, 43, 990, DateTimeKind.Local).AddTicks(5202));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 17,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 18, 23, 10, 43, 990, DateTimeKind.Local).AddTicks(5204));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 18,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 18, 23, 10, 43, 990, DateTimeKind.Local).AddTicks(5212));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 19,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 18, 23, 10, 43, 990, DateTimeKind.Local).AddTicks(5213));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 20,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 18, 23, 10, 43, 990, DateTimeKind.Local).AddTicks(5214));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 21,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 18, 23, 10, 43, 990, DateTimeKind.Local).AddTicks(5216));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 22,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 18, 23, 10, 43, 990, DateTimeKind.Local).AddTicks(5217));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 23,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 18, 23, 10, 43, 990, DateTimeKind.Local).AddTicks(5218));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 24,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 18, 23, 10, 43, 990, DateTimeKind.Local).AddTicks(5219));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 25,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 18, 23, 10, 43, 990, DateTimeKind.Local).AddTicks(5220));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 26,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 18, 23, 10, 43, 990, DateTimeKind.Local).AddTicks(5222));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 27,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 18, 23, 10, 43, 990, DateTimeKind.Local).AddTicks(5223));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 28,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 18, 23, 10, 43, 990, DateTimeKind.Local).AddTicks(5224));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 29,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 18, 23, 10, 43, 990, DateTimeKind.Local).AddTicks(5225));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 30,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 18, 23, 10, 43, 990, DateTimeKind.Local).AddTicks(5226));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 31,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 18, 23, 10, 43, 990, DateTimeKind.Local).AddTicks(5228));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 32,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 18, 23, 10, 43, 990, DateTimeKind.Local).AddTicks(5229));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 33,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 18, 23, 10, 43, 990, DateTimeKind.Local).AddTicks(5230));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 34,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 18, 23, 10, 43, 990, DateTimeKind.Local).AddTicks(5231));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 35,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 18, 23, 10, 43, 990, DateTimeKind.Local).AddTicks(5233));

            migrationBuilder.UpdateData(
                table: "Branches",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 1, 18, 23, 10, 43, 989, DateTimeKind.Local).AddTicks(618), new DateTime(2026, 1, 18, 23, 10, 43, 989, DateTimeKind.Local).AddTicks(696) });

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "LastUpdatedAt", "LicensedValidTill" },
                values: new object[] { new DateTime(2026, 1, 18, 23, 10, 43, 988, DateTimeKind.Local).AddTicks(8426), new DateTime(2026, 1, 18, 23, 10, 43, 988, DateTimeKind.Local).AddTicks(8509), new DateTime(2026, 7, 17, 23, 10, 43, 988, DateTimeKind.Local).AddTicks(8784) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 18, 23, 10, 43, 991, DateTimeKind.Local).AddTicks(1697));

            migrationBuilder.UpdateData(
                table: "FinancialYears",
                keyColumn: "Code",
                keyValue: "2026",
                columns: new[] { "Description", "FinStartDate", "Name" },
                values: new object[] { "2026-2027", new DateTime(2026, 1, 18, 23, 10, 43, 988, DateTimeKind.Local).AddTicks(2867), "2026-2027" });

            migrationBuilder.UpdateData(
                table: "UserAuths",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 18, 23, 10, 43, 991, DateTimeKind.Local).AddTicks(3077));

            migrationBuilder.UpdateData(
                table: "UserRole",
                keyColumn: "RoleID",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 1, 18, 23, 10, 43, 990, DateTimeKind.Local).AddTicks(6785), new DateTime(2026, 1, 18, 23, 10, 43, 990, DateTimeKind.Local).AddTicks(6867) });

            migrationBuilder.UpdateData(
                table: "UserRole",
                keyColumn: "RoleID",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 1, 18, 23, 10, 43, 990, DateTimeKind.Local).AddTicks(6955), new DateTime(2026, 1, 18, 23, 10, 43, 990, DateTimeKind.Local).AddTicks(6956) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_FinancialYears",
                table: "FinancialYears");

            migrationBuilder.DropColumn(
                name: "RMTInvoiceNo",
                table: "BillTransaction");

            migrationBuilder.RenameTable(
                name: "FinancialYears",
                newName: "financialYears");

            migrationBuilder.AddPrimaryKey(
                name: "PK_financialYears",
                table: "financialYears",
                column: "Code");

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 17, 20, 46, 35, 497, DateTimeKind.Local).AddTicks(2013));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 17, 20, 46, 35, 497, DateTimeKind.Local).AddTicks(2640));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 17, 20, 46, 35, 497, DateTimeKind.Local).AddTicks(2643));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 17, 20, 46, 35, 497, DateTimeKind.Local).AddTicks(2644));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 17, 20, 46, 35, 497, DateTimeKind.Local).AddTicks(2645));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 17, 20, 46, 35, 497, DateTimeKind.Local).AddTicks(2646));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 17, 20, 46, 35, 497, DateTimeKind.Local).AddTicks(2711));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 17, 20, 46, 35, 497, DateTimeKind.Local).AddTicks(2712));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 17, 20, 46, 35, 497, DateTimeKind.Local).AddTicks(2714));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 17, 20, 46, 35, 497, DateTimeKind.Local).AddTicks(2715));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 17, 20, 46, 35, 497, DateTimeKind.Local).AddTicks(2716));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 17, 20, 46, 35, 497, DateTimeKind.Local).AddTicks(2717));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 17, 20, 46, 35, 497, DateTimeKind.Local).AddTicks(2718));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 14,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 17, 20, 46, 35, 497, DateTimeKind.Local).AddTicks(2727));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 15,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 17, 20, 46, 35, 497, DateTimeKind.Local).AddTicks(2729));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 16,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 17, 20, 46, 35, 497, DateTimeKind.Local).AddTicks(2730));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 17,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 17, 20, 46, 35, 497, DateTimeKind.Local).AddTicks(2731));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 18,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 17, 20, 46, 35, 497, DateTimeKind.Local).AddTicks(2732));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 19,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 17, 20, 46, 35, 497, DateTimeKind.Local).AddTicks(2733));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 20,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 17, 20, 46, 35, 497, DateTimeKind.Local).AddTicks(2735));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 21,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 17, 20, 46, 35, 497, DateTimeKind.Local).AddTicks(2736));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 22,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 17, 20, 46, 35, 497, DateTimeKind.Local).AddTicks(2737));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 23,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 17, 20, 46, 35, 497, DateTimeKind.Local).AddTicks(2738));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 24,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 17, 20, 46, 35, 497, DateTimeKind.Local).AddTicks(2740));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 25,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 17, 20, 46, 35, 497, DateTimeKind.Local).AddTicks(2741));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 26,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 17, 20, 46, 35, 497, DateTimeKind.Local).AddTicks(2742));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 27,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 17, 20, 46, 35, 497, DateTimeKind.Local).AddTicks(2743));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 28,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 17, 20, 46, 35, 497, DateTimeKind.Local).AddTicks(2744));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 29,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 17, 20, 46, 35, 497, DateTimeKind.Local).AddTicks(2746));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 30,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 17, 20, 46, 35, 497, DateTimeKind.Local).AddTicks(2747));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 31,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 17, 20, 46, 35, 497, DateTimeKind.Local).AddTicks(2748));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 32,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 17, 20, 46, 35, 497, DateTimeKind.Local).AddTicks(2749));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 33,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 17, 20, 46, 35, 497, DateTimeKind.Local).AddTicks(2751));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 34,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 17, 20, 46, 35, 497, DateTimeKind.Local).AddTicks(2752));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 35,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 17, 20, 46, 35, 497, DateTimeKind.Local).AddTicks(2753));

            migrationBuilder.UpdateData(
                table: "Branches",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 1, 17, 20, 46, 35, 495, DateTimeKind.Local).AddTicks(8420), new DateTime(2026, 1, 17, 20, 46, 35, 495, DateTimeKind.Local).AddTicks(8497) });

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "LastUpdatedAt", "LicensedValidTill" },
                values: new object[] { new DateTime(2026, 1, 17, 20, 46, 35, 495, DateTimeKind.Local).AddTicks(6424), new DateTime(2026, 1, 17, 20, 46, 35, 495, DateTimeKind.Local).AddTicks(6514), new DateTime(2026, 7, 16, 20, 46, 35, 495, DateTimeKind.Local).AddTicks(6725) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 17, 20, 46, 35, 498, DateTimeKind.Local).AddTicks(750));

            migrationBuilder.UpdateData(
                table: "UserAuths",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2026, 1, 17, 20, 46, 35, 498, DateTimeKind.Local).AddTicks(2518));

            migrationBuilder.UpdateData(
                table: "UserRole",
                keyColumn: "RoleID",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 1, 17, 20, 46, 35, 497, DateTimeKind.Local).AddTicks(4387), new DateTime(2026, 1, 17, 20, 46, 35, 497, DateTimeKind.Local).AddTicks(4475) });

            migrationBuilder.UpdateData(
                table: "UserRole",
                keyColumn: "RoleID",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 1, 17, 20, 46, 35, 497, DateTimeKind.Local).AddTicks(4548), new DateTime(2026, 1, 17, 20, 46, 35, 497, DateTimeKind.Local).AddTicks(4548) });

            migrationBuilder.UpdateData(
                table: "financialYears",
                keyColumn: "Code",
                keyValue: "2026",
                columns: new[] { "Description", "FinStartDate", "Name" },
                values: new object[] { "2026-20261", new DateTime(2026, 1, 17, 20, 46, 35, 495, DateTimeKind.Local).AddTicks(715), "2026-20261" });
        }
    }
}
