using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SmartFleet.Data.Migrations
{
    /// <inheritdoc />
    public partial class UpdateEmployeeRelation : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Employees_AccountMasters_EmpAccountID",
                table: "Employees");

            migrationBuilder.AddColumn<string>(
                name: "AccountNumber",
                table: "AccountMasters",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "BankName",
                table: "AccountMasters",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "BranchName",
                table: "AccountMasters",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "IFSCCode",
                table: "AccountMasters",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<bool>(
                name: "IsBankAccount",
                table: "AccountMasters",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsCashAccount",
                table: "AccountMasters",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "SWIFTCode",
                table: "AccountMasters",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 1,
                columns: new[] { "AccountNumber", "BankName", "BranchName", "CreatedAt", "IFSCCode", "IsBankAccount", "IsCashAccount", "SWIFTCode" },
                values: new object[] { "", "", "", new DateTime(2026, 2, 13, 22, 42, 50, 107, DateTimeKind.Local).AddTicks(8874), "", false, false, "" });

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 2,
                columns: new[] { "AccountNumber", "BankName", "BranchName", "CreatedAt", "IFSCCode", "IsBankAccount", "IsCashAccount", "SWIFTCode" },
                values: new object[] { "", "", "", new DateTime(2026, 2, 13, 22, 42, 50, 107, DateTimeKind.Local).AddTicks(9657), "", false, false, "" });

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 3,
                columns: new[] { "AccountNumber", "BankName", "BranchName", "CreatedAt", "IFSCCode", "IsBankAccount", "IsCashAccount", "SWIFTCode" },
                values: new object[] { "", "", "", new DateTime(2026, 2, 13, 22, 42, 50, 107, DateTimeKind.Local).AddTicks(9670), "", false, false, "" });

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 4,
                columns: new[] { "AccountNumber", "BankName", "BranchName", "CreatedAt", "IFSCCode", "IsBankAccount", "IsCashAccount", "SWIFTCode" },
                values: new object[] { "", "", "", new DateTime(2026, 2, 13, 22, 42, 50, 107, DateTimeKind.Local).AddTicks(9672), "", false, false, "" });

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 5,
                columns: new[] { "AccountNumber", "BankName", "BranchName", "CreatedAt", "IFSCCode", "IsBankAccount", "IsCashAccount", "SWIFTCode" },
                values: new object[] { "", "", "", new DateTime(2026, 2, 13, 22, 42, 50, 107, DateTimeKind.Local).AddTicks(9674), "", false, false, "" });

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 6,
                columns: new[] { "AccountNumber", "BankName", "BranchName", "CreatedAt", "IFSCCode", "IsBankAccount", "IsCashAccount", "SWIFTCode" },
                values: new object[] { "", "", "", new DateTime(2026, 2, 13, 22, 42, 50, 107, DateTimeKind.Local).AddTicks(9675), "", false, false, "" });

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 7,
                columns: new[] { "AccountNumber", "BankName", "BranchName", "CreatedAt", "IFSCCode", "IsBankAccount", "IsCashAccount", "SWIFTCode" },
                values: new object[] { "", "", "", new DateTime(2026, 2, 13, 22, 42, 50, 107, DateTimeKind.Local).AddTicks(9744), "", false, false, "" });

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 8,
                columns: new[] { "AccountNumber", "BankName", "BranchName", "CreatedAt", "IFSCCode", "IsBankAccount", "IsCashAccount", "SWIFTCode" },
                values: new object[] { "", "", "", new DateTime(2026, 2, 13, 22, 42, 50, 107, DateTimeKind.Local).AddTicks(9746), "", false, false, "" });

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 9,
                columns: new[] { "AccountNumber", "BankName", "BranchName", "CreatedAt", "IFSCCode", "IsBankAccount", "IsCashAccount", "SWIFTCode" },
                values: new object[] { "", "", "", new DateTime(2026, 2, 13, 22, 42, 50, 107, DateTimeKind.Local).AddTicks(9748), "", false, false, "" });

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 10,
                columns: new[] { "AccountNumber", "BankName", "BranchName", "CreatedAt", "IFSCCode", "IsBankAccount", "IsCashAccount", "SWIFTCode" },
                values: new object[] { "", "", "", new DateTime(2026, 2, 13, 22, 42, 50, 107, DateTimeKind.Local).AddTicks(9750), "", false, false, "" });

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 11,
                columns: new[] { "AccountNumber", "BankName", "BranchName", "CreatedAt", "IFSCCode", "IsBankAccount", "IsCashAccount", "SWIFTCode" },
                values: new object[] { "", "", "", new DateTime(2026, 2, 13, 22, 42, 50, 107, DateTimeKind.Local).AddTicks(9751), "", false, false, "" });

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 12,
                columns: new[] { "AccountNumber", "BankName", "BranchName", "CreatedAt", "IFSCCode", "IsBankAccount", "IsCashAccount", "SWIFTCode" },
                values: new object[] { "", "", "", new DateTime(2026, 2, 13, 22, 42, 50, 107, DateTimeKind.Local).AddTicks(9753), "", false, false, "" });

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 13,
                columns: new[] { "AccountNumber", "BankName", "BranchName", "CreatedAt", "IFSCCode", "IsBankAccount", "IsCashAccount", "SWIFTCode" },
                values: new object[] { "", "", "", new DateTime(2026, 2, 13, 22, 42, 50, 107, DateTimeKind.Local).AddTicks(9754), "", false, false, "" });

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 14,
                columns: new[] { "AccountNumber", "BankName", "BranchName", "CreatedAt", "IFSCCode", "IsBankAccount", "IsCashAccount", "SWIFTCode" },
                values: new object[] { "", "", "", new DateTime(2026, 2, 13, 22, 42, 50, 107, DateTimeKind.Local).AddTicks(9756), "", false, false, "" });

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 15,
                columns: new[] { "AccountNumber", "BankName", "BranchName", "CreatedAt", "IFSCCode", "IsBankAccount", "IsCashAccount", "SWIFTCode" },
                values: new object[] { "", "", "", new DateTime(2026, 2, 13, 22, 42, 50, 107, DateTimeKind.Local).AddTicks(9758), "", false, false, "" });

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 16,
                columns: new[] { "AccountNumber", "BankName", "BranchName", "CreatedAt", "IFSCCode", "IsBankAccount", "IsCashAccount", "SWIFTCode" },
                values: new object[] { "", "", "", new DateTime(2026, 2, 13, 22, 42, 50, 107, DateTimeKind.Local).AddTicks(9759), "", false, false, "" });

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 17,
                columns: new[] { "AccountNumber", "BankName", "BranchName", "CreatedAt", "IFSCCode", "IsBankAccount", "IsCashAccount", "SWIFTCode" },
                values: new object[] { "", "", "", new DateTime(2026, 2, 13, 22, 42, 50, 107, DateTimeKind.Local).AddTicks(9761), "", false, false, "" });

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 18,
                columns: new[] { "AccountNumber", "BankName", "BranchName", "CreatedAt", "IFSCCode", "IsBankAccount", "IsCashAccount", "SWIFTCode" },
                values: new object[] { "", "", "", new DateTime(2026, 2, 13, 22, 42, 50, 107, DateTimeKind.Local).AddTicks(9771), "", false, false, "" });

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 19,
                columns: new[] { "AccountNumber", "BankName", "BranchName", "CreatedAt", "IFSCCode", "IsBankAccount", "IsCashAccount", "SWIFTCode" },
                values: new object[] { "", "", "", new DateTime(2026, 2, 13, 22, 42, 50, 107, DateTimeKind.Local).AddTicks(9773), "", false, false, "" });

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 20,
                columns: new[] { "AccountNumber", "BankName", "BranchName", "CreatedAt", "IFSCCode", "IsBankAccount", "IsCashAccount", "SWIFTCode" },
                values: new object[] { "", "", "", new DateTime(2026, 2, 13, 22, 42, 50, 107, DateTimeKind.Local).AddTicks(9774), "", false, false, "" });

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 21,
                columns: new[] { "AccountNumber", "BankName", "BranchName", "CreatedAt", "IFSCCode", "IsBankAccount", "IsCashAccount", "SWIFTCode" },
                values: new object[] { "", "", "", new DateTime(2026, 2, 13, 22, 42, 50, 107, DateTimeKind.Local).AddTicks(9776), "", false, false, "" });

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 22,
                columns: new[] { "AccountNumber", "BankName", "BranchName", "CreatedAt", "IFSCCode", "IsBankAccount", "IsCashAccount", "SWIFTCode" },
                values: new object[] { "", "", "", new DateTime(2026, 2, 13, 22, 42, 50, 107, DateTimeKind.Local).AddTicks(9778), "", false, false, "" });

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 23,
                columns: new[] { "AccountNumber", "BankName", "BranchName", "CreatedAt", "IFSCCode", "IsBankAccount", "IsCashAccount", "SWIFTCode" },
                values: new object[] { "", "", "", new DateTime(2026, 2, 13, 22, 42, 50, 107, DateTimeKind.Local).AddTicks(9779), "", false, false, "" });

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 24,
                columns: new[] { "AccountNumber", "BankName", "BranchName", "CreatedAt", "IFSCCode", "IsBankAccount", "IsCashAccount", "SWIFTCode" },
                values: new object[] { "", "", "", new DateTime(2026, 2, 13, 22, 42, 50, 107, DateTimeKind.Local).AddTicks(9781), "", false, false, "" });

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 25,
                columns: new[] { "AccountNumber", "BankName", "BranchName", "CreatedAt", "IFSCCode", "IsBankAccount", "IsCashAccount", "SWIFTCode" },
                values: new object[] { "", "", "", new DateTime(2026, 2, 13, 22, 42, 50, 107, DateTimeKind.Local).AddTicks(9782), "", false, false, "" });

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 26,
                columns: new[] { "AccountNumber", "BankName", "BranchName", "CreatedAt", "IFSCCode", "IsBankAccount", "IsCashAccount", "SWIFTCode" },
                values: new object[] { "", "", "", new DateTime(2026, 2, 13, 22, 42, 50, 107, DateTimeKind.Local).AddTicks(9784), "", false, false, "" });

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 27,
                columns: new[] { "AccountNumber", "BankName", "BranchName", "CreatedAt", "IFSCCode", "IsBankAccount", "IsCashAccount", "SWIFTCode" },
                values: new object[] { "", "", "", new DateTime(2026, 2, 13, 22, 42, 50, 107, DateTimeKind.Local).AddTicks(9786), "", false, false, "" });

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 28,
                columns: new[] { "AccountNumber", "BankName", "BranchName", "CreatedAt", "IFSCCode", "IsBankAccount", "IsCashAccount", "SWIFTCode" },
                values: new object[] { "", "", "", new DateTime(2026, 2, 13, 22, 42, 50, 107, DateTimeKind.Local).AddTicks(9787), "", false, false, "" });

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 29,
                columns: new[] { "AccountNumber", "BankName", "BranchName", "CreatedAt", "IFSCCode", "IsBankAccount", "IsCashAccount", "SWIFTCode" },
                values: new object[] { "", "", "", new DateTime(2026, 2, 13, 22, 42, 50, 107, DateTimeKind.Local).AddTicks(9789), "", false, false, "" });

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 30,
                columns: new[] { "AccountNumber", "BankName", "BranchName", "CreatedAt", "IFSCCode", "IsBankAccount", "IsCashAccount", "SWIFTCode" },
                values: new object[] { "", "", "", new DateTime(2026, 2, 13, 22, 42, 50, 107, DateTimeKind.Local).AddTicks(9791), "", false, false, "" });

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 31,
                columns: new[] { "AccountNumber", "BankName", "BranchName", "CreatedAt", "IFSCCode", "IsBankAccount", "IsCashAccount", "SWIFTCode" },
                values: new object[] { "", "", "", new DateTime(2026, 2, 13, 22, 42, 50, 107, DateTimeKind.Local).AddTicks(9792), "", false, false, "" });

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 32,
                columns: new[] { "AccountNumber", "BankName", "BranchName", "CreatedAt", "IFSCCode", "IsBankAccount", "IsCashAccount", "SWIFTCode" },
                values: new object[] { "", "", "", new DateTime(2026, 2, 13, 22, 42, 50, 107, DateTimeKind.Local).AddTicks(9794), "", false, false, "" });

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 33,
                columns: new[] { "AccountNumber", "BankName", "BranchName", "CreatedAt", "IFSCCode", "IsBankAccount", "IsCashAccount", "SWIFTCode" },
                values: new object[] { "", "", "", new DateTime(2026, 2, 13, 22, 42, 50, 107, DateTimeKind.Local).AddTicks(9796), "", false, false, "" });

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 34,
                columns: new[] { "AccountNumber", "BankName", "BranchName", "CreatedAt", "IFSCCode", "IsBankAccount", "IsCashAccount", "SWIFTCode" },
                values: new object[] { "", "", "", new DateTime(2026, 2, 13, 22, 42, 50, 107, DateTimeKind.Local).AddTicks(9797), "", false, false, "" });

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 35,
                columns: new[] { "AccountNumber", "BankName", "BranchName", "CreatedAt", "IFSCCode", "IsBankAccount", "IsCashAccount", "SWIFTCode" },
                values: new object[] { "", "", "", new DateTime(2026, 2, 13, 22, 42, 50, 107, DateTimeKind.Local).AddTicks(9799), "", false, false, "" });

            migrationBuilder.UpdateData(
                table: "Branches",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 13, 22, 42, 50, 105, DateTimeKind.Local).AddTicks(8225), new DateTime(2026, 2, 13, 22, 42, 50, 105, DateTimeKind.Local).AddTicks(8432) });

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "LastUpdatedAt", "LicensedValidTill" },
                values: new object[] { new DateTime(2026, 2, 13, 22, 42, 50, 105, DateTimeKind.Local).AddTicks(4177), new DateTime(2026, 2, 13, 22, 42, 50, 105, DateTimeKind.Local).AddTicks(4273), new DateTime(2026, 8, 12, 22, 42, 50, 105, DateTimeKind.Local).AddTicks(5720) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 13, 22, 42, 50, 108, DateTimeKind.Local).AddTicks(8071));

            migrationBuilder.UpdateData(
                table: "FinancialYears",
                keyColumn: "Code",
                keyValue: "2026",
                column: "FinStartDate",
                value: new DateTime(2026, 2, 13, 22, 42, 50, 104, DateTimeKind.Local).AddTicks(8442));

            migrationBuilder.UpdateData(
                table: "UserAuths",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 13, 22, 42, 50, 108, DateTimeKind.Local).AddTicks(9665));

            migrationBuilder.UpdateData(
                table: "UserRole",
                keyColumn: "RoleID",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 13, 22, 42, 50, 108, DateTimeKind.Local).AddTicks(1809), new DateTime(2026, 2, 13, 22, 42, 50, 108, DateTimeKind.Local).AddTicks(1903) });

            migrationBuilder.UpdateData(
                table: "UserRole",
                keyColumn: "RoleID",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 13, 22, 42, 50, 108, DateTimeKind.Local).AddTicks(1981), new DateTime(2026, 2, 13, 22, 42, 50, 108, DateTimeKind.Local).AddTicks(1982) });

            migrationBuilder.AddForeignKey(
                name: "FK_Employees_AccountMasters_EmpAccountID",
                table: "Employees",
                column: "EmpAccountID",
                principalTable: "AccountMasters",
                principalColumn: "AccountID",
                onDelete: ReferentialAction.Restrict);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Employees_AccountMasters_EmpAccountID",
                table: "Employees");

            migrationBuilder.DropColumn(
                name: "AccountNumber",
                table: "AccountMasters");

            migrationBuilder.DropColumn(
                name: "BankName",
                table: "AccountMasters");

            migrationBuilder.DropColumn(
                name: "BranchName",
                table: "AccountMasters");

            migrationBuilder.DropColumn(
                name: "IFSCCode",
                table: "AccountMasters");

            migrationBuilder.DropColumn(
                name: "IsBankAccount",
                table: "AccountMasters");

            migrationBuilder.DropColumn(
                name: "IsCashAccount",
                table: "AccountMasters");

            migrationBuilder.DropColumn(
                name: "SWIFTCode",
                table: "AccountMasters");

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 13, 8, 28, 38, 654, DateTimeKind.Local).AddTicks(8059));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 13, 8, 28, 38, 654, DateTimeKind.Local).AddTicks(8853));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 13, 8, 28, 38, 654, DateTimeKind.Local).AddTicks(8856));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 13, 8, 28, 38, 654, DateTimeKind.Local).AddTicks(8857));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 13, 8, 28, 38, 654, DateTimeKind.Local).AddTicks(8859));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 13, 8, 28, 38, 654, DateTimeKind.Local).AddTicks(8860));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 13, 8, 28, 38, 654, DateTimeKind.Local).AddTicks(8930));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 13, 8, 28, 38, 654, DateTimeKind.Local).AddTicks(8941));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 13, 8, 28, 38, 654, DateTimeKind.Local).AddTicks(8942));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 13, 8, 28, 38, 654, DateTimeKind.Local).AddTicks(8944));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 13, 8, 28, 38, 654, DateTimeKind.Local).AddTicks(8945));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 13, 8, 28, 38, 654, DateTimeKind.Local).AddTicks(8947));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 13, 8, 28, 38, 654, DateTimeKind.Local).AddTicks(8948));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 14,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 13, 8, 28, 38, 654, DateTimeKind.Local).AddTicks(8950));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 15,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 13, 8, 28, 38, 654, DateTimeKind.Local).AddTicks(8951));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 16,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 13, 8, 28, 38, 654, DateTimeKind.Local).AddTicks(8952));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 17,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 13, 8, 28, 38, 654, DateTimeKind.Local).AddTicks(8954));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 18,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 13, 8, 28, 38, 654, DateTimeKind.Local).AddTicks(8955));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 19,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 13, 8, 28, 38, 654, DateTimeKind.Local).AddTicks(8957));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 20,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 13, 8, 28, 38, 654, DateTimeKind.Local).AddTicks(8958));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 21,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 13, 8, 28, 38, 654, DateTimeKind.Local).AddTicks(8959));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 22,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 13, 8, 28, 38, 654, DateTimeKind.Local).AddTicks(9017));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 23,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 13, 8, 28, 38, 654, DateTimeKind.Local).AddTicks(9018));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 24,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 13, 8, 28, 38, 654, DateTimeKind.Local).AddTicks(9020));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 25,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 13, 8, 28, 38, 654, DateTimeKind.Local).AddTicks(9021));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 26,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 13, 8, 28, 38, 654, DateTimeKind.Local).AddTicks(9023));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 27,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 13, 8, 28, 38, 654, DateTimeKind.Local).AddTicks(9024));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 28,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 13, 8, 28, 38, 654, DateTimeKind.Local).AddTicks(9025));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 29,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 13, 8, 28, 38, 654, DateTimeKind.Local).AddTicks(9027));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 30,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 13, 8, 28, 38, 654, DateTimeKind.Local).AddTicks(9028));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 31,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 13, 8, 28, 38, 654, DateTimeKind.Local).AddTicks(9030));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 32,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 13, 8, 28, 38, 654, DateTimeKind.Local).AddTicks(9031));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 33,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 13, 8, 28, 38, 654, DateTimeKind.Local).AddTicks(9032));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 34,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 13, 8, 28, 38, 654, DateTimeKind.Local).AddTicks(9034));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 35,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 13, 8, 28, 38, 654, DateTimeKind.Local).AddTicks(9035));

            migrationBuilder.UpdateData(
                table: "Branches",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 13, 8, 28, 38, 652, DateTimeKind.Local).AddTicks(8852), new DateTime(2026, 2, 13, 8, 28, 38, 652, DateTimeKind.Local).AddTicks(8933) });

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "LastUpdatedAt", "LicensedValidTill" },
                values: new object[] { new DateTime(2026, 2, 13, 8, 28, 38, 652, DateTimeKind.Local).AddTicks(6646), new DateTime(2026, 2, 13, 8, 28, 38, 652, DateTimeKind.Local).AddTicks(6743), new DateTime(2026, 8, 12, 8, 28, 38, 652, DateTimeKind.Local).AddTicks(7016) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 13, 8, 28, 38, 655, DateTimeKind.Local).AddTicks(9703));

            migrationBuilder.UpdateData(
                table: "FinancialYears",
                keyColumn: "Code",
                keyValue: "2026",
                column: "FinStartDate",
                value: new DateTime(2026, 2, 13, 8, 28, 38, 652, DateTimeKind.Local).AddTicks(615));

            migrationBuilder.UpdateData(
                table: "UserAuths",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2026, 2, 13, 8, 28, 38, 656, DateTimeKind.Local).AddTicks(1493));

            migrationBuilder.UpdateData(
                table: "UserRole",
                keyColumn: "RoleID",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 13, 8, 28, 38, 655, DateTimeKind.Local).AddTicks(1175), new DateTime(2026, 2, 13, 8, 28, 38, 655, DateTimeKind.Local).AddTicks(1282) });

            migrationBuilder.UpdateData(
                table: "UserRole",
                keyColumn: "RoleID",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 2, 13, 8, 28, 38, 655, DateTimeKind.Local).AddTicks(1359), new DateTime(2026, 2, 13, 8, 28, 38, 655, DateTimeKind.Local).AddTicks(1359) });

            migrationBuilder.AddForeignKey(
                name: "FK_Employees_AccountMasters_EmpAccountID",
                table: "Employees",
                column: "EmpAccountID",
                principalTable: "AccountMasters",
                principalColumn: "AccountID");
        }
    }
}
