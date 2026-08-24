using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SmartFleet.Data.Migrations
{
    /// <inheritdoc />
    public partial class LocationUpdateForOPPO : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsLocalForOppo",
                table: "Locations",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2026, 4, 6, 23, 50, 44, 816, DateTimeKind.Local).AddTicks(4829));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2026, 4, 6, 23, 50, 44, 816, DateTimeKind.Local).AddTicks(6750));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2026, 4, 6, 23, 50, 44, 816, DateTimeKind.Local).AddTicks(6757));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2026, 4, 6, 23, 50, 44, 816, DateTimeKind.Local).AddTicks(6760));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2026, 4, 6, 23, 50, 44, 816, DateTimeKind.Local).AddTicks(6762));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2026, 4, 6, 23, 50, 44, 816, DateTimeKind.Local).AddTicks(6783));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2026, 4, 6, 23, 50, 44, 816, DateTimeKind.Local).AddTicks(6959));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2026, 4, 6, 23, 50, 44, 816, DateTimeKind.Local).AddTicks(6962));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2026, 4, 6, 23, 50, 44, 816, DateTimeKind.Local).AddTicks(6965));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2026, 4, 6, 23, 50, 44, 816, DateTimeKind.Local).AddTicks(6968));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2026, 4, 6, 23, 50, 44, 816, DateTimeKind.Local).AddTicks(6970));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2026, 4, 6, 23, 50, 44, 816, DateTimeKind.Local).AddTicks(6973));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2026, 4, 6, 23, 50, 44, 816, DateTimeKind.Local).AddTicks(6975));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 14,
                column: "CreatedAt",
                value: new DateTime(2026, 4, 6, 23, 50, 44, 816, DateTimeKind.Local).AddTicks(6978));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 15,
                column: "CreatedAt",
                value: new DateTime(2026, 4, 6, 23, 50, 44, 816, DateTimeKind.Local).AddTicks(7093));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 16,
                column: "CreatedAt",
                value: new DateTime(2026, 4, 6, 23, 50, 44, 816, DateTimeKind.Local).AddTicks(7097));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 17,
                column: "CreatedAt",
                value: new DateTime(2026, 4, 6, 23, 50, 44, 816, DateTimeKind.Local).AddTicks(7099));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 18,
                column: "CreatedAt",
                value: new DateTime(2026, 4, 6, 23, 50, 44, 816, DateTimeKind.Local).AddTicks(7101));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 19,
                column: "CreatedAt",
                value: new DateTime(2026, 4, 6, 23, 50, 44, 816, DateTimeKind.Local).AddTicks(7104));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 20,
                column: "CreatedAt",
                value: new DateTime(2026, 4, 6, 23, 50, 44, 816, DateTimeKind.Local).AddTicks(7124));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 21,
                column: "CreatedAt",
                value: new DateTime(2026, 4, 6, 23, 50, 44, 816, DateTimeKind.Local).AddTicks(7127));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 22,
                column: "CreatedAt",
                value: new DateTime(2026, 4, 6, 23, 50, 44, 816, DateTimeKind.Local).AddTicks(7130));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 23,
                column: "CreatedAt",
                value: new DateTime(2026, 4, 6, 23, 50, 44, 816, DateTimeKind.Local).AddTicks(7132));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 24,
                column: "CreatedAt",
                value: new DateTime(2026, 4, 6, 23, 50, 44, 816, DateTimeKind.Local).AddTicks(7135));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 25,
                column: "CreatedAt",
                value: new DateTime(2026, 4, 6, 23, 50, 44, 816, DateTimeKind.Local).AddTicks(7137));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 26,
                column: "CreatedAt",
                value: new DateTime(2026, 4, 6, 23, 50, 44, 816, DateTimeKind.Local).AddTicks(7140));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 27,
                column: "CreatedAt",
                value: new DateTime(2026, 4, 6, 23, 50, 44, 816, DateTimeKind.Local).AddTicks(7143));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 28,
                column: "CreatedAt",
                value: new DateTime(2026, 4, 6, 23, 50, 44, 816, DateTimeKind.Local).AddTicks(7145));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 29,
                column: "CreatedAt",
                value: new DateTime(2026, 4, 6, 23, 50, 44, 816, DateTimeKind.Local).AddTicks(7148));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 30,
                column: "CreatedAt",
                value: new DateTime(2026, 4, 6, 23, 50, 44, 816, DateTimeKind.Local).AddTicks(7150));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 31,
                column: "CreatedAt",
                value: new DateTime(2026, 4, 6, 23, 50, 44, 816, DateTimeKind.Local).AddTicks(7152));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 32,
                column: "CreatedAt",
                value: new DateTime(2026, 4, 6, 23, 50, 44, 816, DateTimeKind.Local).AddTicks(7154));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 33,
                column: "CreatedAt",
                value: new DateTime(2026, 4, 6, 23, 50, 44, 816, DateTimeKind.Local).AddTicks(7157));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 34,
                column: "CreatedAt",
                value: new DateTime(2026, 4, 6, 23, 50, 44, 816, DateTimeKind.Local).AddTicks(7159));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 35,
                column: "CreatedAt",
                value: new DateTime(2026, 4, 6, 23, 50, 44, 816, DateTimeKind.Local).AddTicks(7162));

            migrationBuilder.UpdateData(
                table: "Branches",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 4, 6, 23, 50, 44, 812, DateTimeKind.Local).AddTicks(9971), new DateTime(2026, 4, 6, 23, 50, 44, 813, DateTimeKind.Local).AddTicks(180) });

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "LastUpdatedAt", "LicensedValidTill" },
                values: new object[] { new DateTime(2026, 4, 6, 23, 50, 44, 812, DateTimeKind.Local).AddTicks(4693), new DateTime(2026, 4, 6, 23, 50, 44, 812, DateTimeKind.Local).AddTicks(4923), new DateTime(2026, 10, 3, 23, 50, 44, 812, DateTimeKind.Local).AddTicks(5437) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2026, 4, 6, 23, 50, 44, 818, DateTimeKind.Local).AddTicks(6811));

            migrationBuilder.UpdateData(
                table: "FinancialYears",
                keyColumn: "Code",
                keyValue: "2026",
                column: "FinStartDate",
                value: new DateTime(2026, 4, 6, 23, 50, 44, 811, DateTimeKind.Local).AddTicks(1522));

            migrationBuilder.UpdateData(
                table: "UserAuths",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2026, 4, 6, 23, 50, 44, 819, DateTimeKind.Local).AddTicks(2234));

            migrationBuilder.UpdateData(
                table: "UserRole",
                keyColumn: "RoleID",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 4, 6, 23, 50, 44, 817, DateTimeKind.Local).AddTicks(1104), new DateTime(2026, 4, 6, 23, 50, 44, 817, DateTimeKind.Local).AddTicks(1333) });

            migrationBuilder.UpdateData(
                table: "UserRole",
                keyColumn: "RoleID",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 4, 6, 23, 50, 44, 817, DateTimeKind.Local).AddTicks(1514), new DateTime(2026, 4, 6, 23, 50, 44, 817, DateTimeKind.Local).AddTicks(1516) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsLocalForOppo",
                table: "Locations");

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2026, 4, 6, 21, 36, 42, 965, DateTimeKind.Local).AddTicks(6461));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2026, 4, 6, 21, 36, 42, 965, DateTimeKind.Local).AddTicks(7536));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2026, 4, 6, 21, 36, 42, 965, DateTimeKind.Local).AddTicks(7540));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2026, 4, 6, 21, 36, 42, 965, DateTimeKind.Local).AddTicks(7543));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2026, 4, 6, 21, 36, 42, 965, DateTimeKind.Local).AddTicks(7545));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2026, 4, 6, 21, 36, 42, 965, DateTimeKind.Local).AddTicks(7546));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2026, 4, 6, 21, 36, 42, 965, DateTimeKind.Local).AddTicks(7645));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2026, 4, 6, 21, 36, 42, 965, DateTimeKind.Local).AddTicks(7648));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2026, 4, 6, 21, 36, 42, 965, DateTimeKind.Local).AddTicks(7650));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2026, 4, 6, 21, 36, 42, 965, DateTimeKind.Local).AddTicks(7652));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2026, 4, 6, 21, 36, 42, 965, DateTimeKind.Local).AddTicks(7654));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2026, 4, 6, 21, 36, 42, 965, DateTimeKind.Local).AddTicks(7655));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2026, 4, 6, 21, 36, 42, 965, DateTimeKind.Local).AddTicks(7657));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 14,
                column: "CreatedAt",
                value: new DateTime(2026, 4, 6, 21, 36, 42, 965, DateTimeKind.Local).AddTicks(7659));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 15,
                column: "CreatedAt",
                value: new DateTime(2026, 4, 6, 21, 36, 42, 965, DateTimeKind.Local).AddTicks(7661));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 16,
                column: "CreatedAt",
                value: new DateTime(2026, 4, 6, 21, 36, 42, 965, DateTimeKind.Local).AddTicks(7674));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 17,
                column: "CreatedAt",
                value: new DateTime(2026, 4, 6, 21, 36, 42, 965, DateTimeKind.Local).AddTicks(7676));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 18,
                column: "CreatedAt",
                value: new DateTime(2026, 4, 6, 21, 36, 42, 965, DateTimeKind.Local).AddTicks(7678));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 19,
                column: "CreatedAt",
                value: new DateTime(2026, 4, 6, 21, 36, 42, 965, DateTimeKind.Local).AddTicks(7680));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 20,
                column: "CreatedAt",
                value: new DateTime(2026, 4, 6, 21, 36, 42, 965, DateTimeKind.Local).AddTicks(7682));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 21,
                column: "CreatedAt",
                value: new DateTime(2026, 4, 6, 21, 36, 42, 965, DateTimeKind.Local).AddTicks(7684));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 22,
                column: "CreatedAt",
                value: new DateTime(2026, 4, 6, 21, 36, 42, 965, DateTimeKind.Local).AddTicks(7685));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 23,
                column: "CreatedAt",
                value: new DateTime(2026, 4, 6, 21, 36, 42, 965, DateTimeKind.Local).AddTicks(7687));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 24,
                column: "CreatedAt",
                value: new DateTime(2026, 4, 6, 21, 36, 42, 965, DateTimeKind.Local).AddTicks(7689));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 25,
                column: "CreatedAt",
                value: new DateTime(2026, 4, 6, 21, 36, 42, 965, DateTimeKind.Local).AddTicks(7691));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 26,
                column: "CreatedAt",
                value: new DateTime(2026, 4, 6, 21, 36, 42, 965, DateTimeKind.Local).AddTicks(7693));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 27,
                column: "CreatedAt",
                value: new DateTime(2026, 4, 6, 21, 36, 42, 965, DateTimeKind.Local).AddTicks(7695));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 28,
                column: "CreatedAt",
                value: new DateTime(2026, 4, 6, 21, 36, 42, 965, DateTimeKind.Local).AddTicks(7697));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 29,
                column: "CreatedAt",
                value: new DateTime(2026, 4, 6, 21, 36, 42, 965, DateTimeKind.Local).AddTicks(7698));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 30,
                column: "CreatedAt",
                value: new DateTime(2026, 4, 6, 21, 36, 42, 965, DateTimeKind.Local).AddTicks(7700));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 31,
                column: "CreatedAt",
                value: new DateTime(2026, 4, 6, 21, 36, 42, 965, DateTimeKind.Local).AddTicks(7702));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 32,
                column: "CreatedAt",
                value: new DateTime(2026, 4, 6, 21, 36, 42, 965, DateTimeKind.Local).AddTicks(7704));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 33,
                column: "CreatedAt",
                value: new DateTime(2026, 4, 6, 21, 36, 42, 965, DateTimeKind.Local).AddTicks(7706));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 34,
                column: "CreatedAt",
                value: new DateTime(2026, 4, 6, 21, 36, 42, 965, DateTimeKind.Local).AddTicks(7708));

            migrationBuilder.UpdateData(
                table: "AccountMasters",
                keyColumn: "AccountID",
                keyValue: 35,
                column: "CreatedAt",
                value: new DateTime(2026, 4, 6, 21, 36, 42, 965, DateTimeKind.Local).AddTicks(7710));

            migrationBuilder.UpdateData(
                table: "Branches",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "LastUpdatedAt" },
                values: new object[] { new DateTime(2026, 4, 6, 21, 36, 42, 963, DateTimeKind.Local).AddTicks(3533), new DateTime(2026, 4, 6, 21, 36, 42, 963, DateTimeKind.Local).AddTicks(3653) });

            migrationBuilder.UpdateData(
                table: "Companies",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "LastUpdatedAt", "LicensedValidTill" },
                values: new object[] { new DateTime(2026, 4, 6, 21, 36, 42, 963, DateTimeKind.Local).AddTicks(44), new DateTime(2026, 4, 6, 21, 36, 42, 963, DateTimeKind.Local).AddTicks(168), new DateTime(2026, 10, 3, 21, 36, 42, 963, DateTimeKind.Local).AddTicks(474) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2026, 4, 6, 21, 36, 42, 967, DateTimeKind.Local).AddTicks(6135));

            migrationBuilder.UpdateData(
                table: "FinancialYears",
                keyColumn: "Code",
                keyValue: "2026",
                column: "FinStartDate",
                value: new DateTime(2026, 4, 6, 21, 36, 42, 962, DateTimeKind.Local).AddTicks(1451));

            migrationBuilder.UpdateData(
                table: "UserAuths",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2026, 4, 6, 21, 36, 42, 967, DateTimeKind.Local).AddTicks(9788));

            migrationBuilder.UpdateData(
                table: "UserRole",
                keyColumn: "RoleID",
                keyValue: 1,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 4, 6, 21, 36, 42, 966, DateTimeKind.Local).AddTicks(226), new DateTime(2026, 4, 6, 21, 36, 42, 966, DateTimeKind.Local).AddTicks(366) });

            migrationBuilder.UpdateData(
                table: "UserRole",
                keyColumn: "RoleID",
                keyValue: 2,
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2026, 4, 6, 21, 36, 42, 966, DateTimeKind.Local).AddTicks(471), new DateTime(2026, 4, 6, 21, 36, 42, 966, DateTimeKind.Local).AddTicks(472) });
        }
    }
}
