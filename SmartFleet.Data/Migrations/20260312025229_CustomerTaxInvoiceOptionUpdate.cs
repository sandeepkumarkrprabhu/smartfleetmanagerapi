using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SmartFleet.Data.Migrations
{
    /// <inheritdoc />
    public partial class CustomerTaxInvoiceOptionUpdate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsTaxableInvoice",
                table: "Customers",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "State",
                table: "Customers",
                type: "nvarchar(200)",
                maxLength: 200,
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2026, 3, 12, 8, 22, 27, 118, DateTimeKind.Local).AddTicks(7850));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2026, 3, 12, 8, 22, 27, 118, DateTimeKind.Local).AddTicks(8604));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2026, 3, 12, 8, 22, 27, 118, DateTimeKind.Local).AddTicks(8606));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2026, 3, 12, 8, 22, 27, 118, DateTimeKind.Local).AddTicks(8608));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2026, 3, 12, 8, 22, 27, 118, DateTimeKind.Local).AddTicks(8609));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2026, 3, 12, 8, 22, 27, 118, DateTimeKind.Local).AddTicks(8611));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2026, 3, 12, 8, 22, 27, 118, DateTimeKind.Local).AddTicks(8743));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2026, 3, 12, 8, 22, 27, 118, DateTimeKind.Local).AddTicks(8745));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2026, 3, 12, 8, 22, 27, 118, DateTimeKind.Local).AddTicks(8746));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2026, 3, 12, 8, 22, 27, 118, DateTimeKind.Local).AddTicks(8747));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2026, 3, 12, 8, 22, 27, 118, DateTimeKind.Local).AddTicks(8749));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2026, 3, 12, 8, 22, 27, 118, DateTimeKind.Local).AddTicks(8750));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2026, 3, 12, 8, 22, 27, 118, DateTimeKind.Local).AddTicks(8751));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 14,
                column: "CreatedAt",
                value: new DateTime(2026, 3, 12, 8, 22, 27, 118, DateTimeKind.Local).AddTicks(8753));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 15,
                column: "CreatedAt",
                value: new DateTime(2026, 3, 12, 8, 22, 27, 118, DateTimeKind.Local).AddTicks(8754));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 16,
                column: "CreatedAt",
                value: new DateTime(2026, 3, 12, 8, 22, 27, 118, DateTimeKind.Local).AddTicks(8755));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 17,
                column: "CreatedAt",
                value: new DateTime(2026, 3, 12, 8, 22, 27, 118, DateTimeKind.Local).AddTicks(8757));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 18,
                column: "CreatedAt",
                value: new DateTime(2026, 3, 12, 8, 22, 27, 118, DateTimeKind.Local).AddTicks(8758));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 19,
                column: "CreatedAt",
                value: new DateTime(2026, 3, 12, 8, 22, 27, 118, DateTimeKind.Local).AddTicks(8760));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 20,
                column: "CreatedAt",
                value: new DateTime(2026, 3, 12, 8, 22, 27, 118, DateTimeKind.Local).AddTicks(8761));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 21,
                column: "CreatedAt",
                value: new DateTime(2026, 3, 12, 8, 22, 27, 118, DateTimeKind.Local).AddTicks(8772));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 22,
                column: "CreatedAt",
                value: new DateTime(2026, 3, 12, 8, 22, 27, 118, DateTimeKind.Local).AddTicks(8773));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 23,
                column: "CreatedAt",
                value: new DateTime(2026, 3, 12, 8, 22, 27, 118, DateTimeKind.Local).AddTicks(8774));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 24,
                column: "CreatedAt",
                value: new DateTime(2026, 3, 12, 8, 22, 27, 118, DateTimeKind.Local).AddTicks(8776));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 25,
                column: "CreatedAt",
                value: new DateTime(2026, 3, 12, 8, 22, 27, 118, DateTimeKind.Local).AddTicks(8777));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 26,
                column: "CreatedAt",
                value: new DateTime(2026, 3, 12, 8, 22, 27, 118, DateTimeKind.Local).AddTicks(8779));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 27,
                column: "CreatedAt",
                value: new DateTime(2026, 3, 12, 8, 22, 27, 118, DateTimeKind.Local).AddTicks(8780));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 28,
                column: "CreatedAt",
                value: new DateTime(2026, 3, 12, 8, 22, 27, 118, DateTimeKind.Local).AddTicks(8782));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 29,
                column: "CreatedAt",
                value: new DateTime(2026, 3, 12, 8, 22, 27, 118, DateTimeKind.Local).AddTicks(8783));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 30,
                column: "CreatedAt",
                value: new DateTime(2026, 3, 12, 8, 22, 27, 118, DateTimeKind.Local).AddTicks(8784));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 31,
                column: "CreatedAt",
                value: new DateTime(2026, 3, 12, 8, 22, 27, 118, DateTimeKind.Local).AddTicks(8786));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 32,
                column: "CreatedAt",
                value: new DateTime(2026, 3, 12, 8, 22, 27, 118, DateTimeKind.Local).AddTicks(8787));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 33,
                column: "CreatedAt",
                value: new DateTime(2026, 3, 12, 8, 22, 27, 118, DateTimeKind.Local).AddTicks(8789));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 34,
                column: "CreatedAt",
                value: new DateTime(2026, 3, 12, 8, 22, 27, 118, DateTimeKind.Local).AddTicks(8790));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 35,
                column: "CreatedAt",
                value: new DateTime(2026, 3, 12, 8, 22, 27, 118, DateTimeKind.Local).AddTicks(8791));

            migrationBuilder.UpdateData(
                table: "Branches",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 3, 12, 8, 22, 27, 116, DateTimeKind.Local).AddTicks(9823), new DateTime(2026, 3, 12, 8, 22, 27, 116, DateTimeKind.Local).AddTicks(9901) });

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "LastUpdatedAt", "LicensedValidTill" },
                values: new object[] { new DateTime(2026, 3, 12, 8, 22, 27, 116, DateTimeKind.Local).AddTicks(7523), new DateTime(2026, 3, 12, 8, 22, 27, 116, DateTimeKind.Local).AddTicks(7611), new DateTime(2026, 9, 8, 8, 22, 27, 116, DateTimeKind.Local).AddTicks(7832) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2026, 3, 12, 8, 22, 27, 119, DateTimeKind.Local).AddTicks(7071));

            migrationBuilder.UpdateData(
                table: "FinancialYears",
                keyColumn: "Code",
                keyValue: "2026",
                column: "FinStartDate",
                value: new DateTime(2026, 3, 12, 8, 22, 27, 116, DateTimeKind.Local).AddTicks(1269));

            migrationBuilder.UpdateData(
                table: "UserAuths",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2026, 3, 12, 8, 22, 27, 119, DateTimeKind.Local).AddTicks(8824));

            migrationBuilder.UpdateData(
                table: "UserRole",
                keyColumn: "RoleID",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 3, 12, 8, 22, 27, 119, DateTimeKind.Local).AddTicks(526), new DateTime(2026, 3, 12, 8, 22, 27, 119, DateTimeKind.Local).AddTicks(620) });

            migrationBuilder.UpdateData(
                table: "UserRole",
                keyColumn: "RoleID",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 3, 12, 8, 22, 27, 119, DateTimeKind.Local).AddTicks(720), new DateTime(2026, 3, 12, 8, 22, 27, 119, DateTimeKind.Local).AddTicks(721) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsTaxableInvoice",
                table: "Customers");

            migrationBuilder.DropColumn(
                name: "State",
                table: "Customers");

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2026, 3, 8, 13, 2, 58, 351, DateTimeKind.Local).AddTicks(5380));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2026, 3, 8, 13, 2, 58, 351, DateTimeKind.Local).AddTicks(6169));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2026, 3, 8, 13, 2, 58, 351, DateTimeKind.Local).AddTicks(6172));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2026, 3, 8, 13, 2, 58, 351, DateTimeKind.Local).AddTicks(6174));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2026, 3, 8, 13, 2, 58, 351, DateTimeKind.Local).AddTicks(6175));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2026, 3, 8, 13, 2, 58, 351, DateTimeKind.Local).AddTicks(6177));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2026, 3, 8, 13, 2, 58, 351, DateTimeKind.Local).AddTicks(6246));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2026, 3, 8, 13, 2, 58, 351, DateTimeKind.Local).AddTicks(6248));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2026, 3, 8, 13, 2, 58, 351, DateTimeKind.Local).AddTicks(6249));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2026, 3, 8, 13, 2, 58, 351, DateTimeKind.Local).AddTicks(6251));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2026, 3, 8, 13, 2, 58, 351, DateTimeKind.Local).AddTicks(6252));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2026, 3, 8, 13, 2, 58, 351, DateTimeKind.Local).AddTicks(6253));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2026, 3, 8, 13, 2, 58, 351, DateTimeKind.Local).AddTicks(6255));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 14,
                column: "CreatedAt",
                value: new DateTime(2026, 3, 8, 13, 2, 58, 351, DateTimeKind.Local).AddTicks(6256));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 15,
                column: "CreatedAt",
                value: new DateTime(2026, 3, 8, 13, 2, 58, 351, DateTimeKind.Local).AddTicks(6257));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 16,
                column: "CreatedAt",
                value: new DateTime(2026, 3, 8, 13, 2, 58, 351, DateTimeKind.Local).AddTicks(6259));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 17,
                column: "CreatedAt",
                value: new DateTime(2026, 3, 8, 13, 2, 58, 351, DateTimeKind.Local).AddTicks(6267));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 18,
                column: "CreatedAt",
                value: new DateTime(2026, 3, 8, 13, 2, 58, 351, DateTimeKind.Local).AddTicks(6269));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 19,
                column: "CreatedAt",
                value: new DateTime(2026, 3, 8, 13, 2, 58, 351, DateTimeKind.Local).AddTicks(6270));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 20,
                column: "CreatedAt",
                value: new DateTime(2026, 3, 8, 13, 2, 58, 351, DateTimeKind.Local).AddTicks(6272));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 21,
                column: "CreatedAt",
                value: new DateTime(2026, 3, 8, 13, 2, 58, 351, DateTimeKind.Local).AddTicks(6308));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 22,
                column: "CreatedAt",
                value: new DateTime(2026, 3, 8, 13, 2, 58, 351, DateTimeKind.Local).AddTicks(6310));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 23,
                column: "CreatedAt",
                value: new DateTime(2026, 3, 8, 13, 2, 58, 351, DateTimeKind.Local).AddTicks(6311));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 24,
                column: "CreatedAt",
                value: new DateTime(2026, 3, 8, 13, 2, 58, 351, DateTimeKind.Local).AddTicks(6313));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 25,
                column: "CreatedAt",
                value: new DateTime(2026, 3, 8, 13, 2, 58, 351, DateTimeKind.Local).AddTicks(6314));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 26,
                column: "CreatedAt",
                value: new DateTime(2026, 3, 8, 13, 2, 58, 351, DateTimeKind.Local).AddTicks(6315));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 27,
                column: "CreatedAt",
                value: new DateTime(2026, 3, 8, 13, 2, 58, 351, DateTimeKind.Local).AddTicks(6317));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 28,
                column: "CreatedAt",
                value: new DateTime(2026, 3, 8, 13, 2, 58, 351, DateTimeKind.Local).AddTicks(6318));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 29,
                column: "CreatedAt",
                value: new DateTime(2026, 3, 8, 13, 2, 58, 351, DateTimeKind.Local).AddTicks(6320));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 30,
                column: "CreatedAt",
                value: new DateTime(2026, 3, 8, 13, 2, 58, 351, DateTimeKind.Local).AddTicks(6321));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 31,
                column: "CreatedAt",
                value: new DateTime(2026, 3, 8, 13, 2, 58, 351, DateTimeKind.Local).AddTicks(6323));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 32,
                column: "CreatedAt",
                value: new DateTime(2026, 3, 8, 13, 2, 58, 351, DateTimeKind.Local).AddTicks(6324));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 33,
                column: "CreatedAt",
                value: new DateTime(2026, 3, 8, 13, 2, 58, 351, DateTimeKind.Local).AddTicks(6325));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 34,
                column: "CreatedAt",
                value: new DateTime(2026, 3, 8, 13, 2, 58, 351, DateTimeKind.Local).AddTicks(6327));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 35,
                column: "CreatedAt",
                value: new DateTime(2026, 3, 8, 13, 2, 58, 351, DateTimeKind.Local).AddTicks(6328));

            migrationBuilder.UpdateData(
                table: "Branches",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 3, 8, 13, 2, 58, 349, DateTimeKind.Local).AddTicks(8774), new DateTime(2026, 3, 8, 13, 2, 58, 349, DateTimeKind.Local).AddTicks(8859) });

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "LastUpdatedAt", "LicensedValidTill" },
                values: new object[] { new DateTime(2026, 3, 8, 13, 2, 58, 349, DateTimeKind.Local).AddTicks(6163), new DateTime(2026, 3, 8, 13, 2, 58, 349, DateTimeKind.Local).AddTicks(6250), new DateTime(2026, 9, 4, 13, 2, 58, 349, DateTimeKind.Local).AddTicks(6479) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2026, 3, 8, 13, 2, 58, 353, DateTimeKind.Local).AddTicks(2369));

            migrationBuilder.UpdateData(
                table: "FinancialYears",
                keyColumn: "Code",
                keyValue: "2026",
                column: "FinStartDate",
                value: new DateTime(2026, 3, 8, 13, 2, 58, 348, DateTimeKind.Local).AddTicks(8709));

            migrationBuilder.UpdateData(
                table: "UserAuths",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2026, 3, 8, 13, 2, 58, 353, DateTimeKind.Local).AddTicks(7748));

            migrationBuilder.UpdateData(
                table: "UserRole",
                keyColumn: "RoleID",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 3, 8, 13, 2, 58, 351, DateTimeKind.Local).AddTicks(8343), new DateTime(2026, 3, 8, 13, 2, 58, 351, DateTimeKind.Local).AddTicks(8509) });

            migrationBuilder.UpdateData(
                table: "UserRole",
                keyColumn: "RoleID",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 3, 8, 13, 2, 58, 351, DateTimeKind.Local).AddTicks(8628), new DateTime(2026, 3, 8, 13, 2, 58, 351, DateTimeKind.Local).AddTicks(8628) });
        }
    }
}
