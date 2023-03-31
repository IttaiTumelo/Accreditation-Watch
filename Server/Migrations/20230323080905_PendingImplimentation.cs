using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Accreditation_Watch.Server.Migrations
{
    /// <inheritdoc />
    public partial class PendingImplimentation : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<byte[]>(
                name: "PasswordHash",
                table: "Users",
                type: "varbinary(max)",
                nullable: true);

            migrationBuilder.AddColumn<byte[]>(
                name: "PasswordSalt",
                table: "Users",
                type: "varbinary(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Token",
                table: "Users",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.CreateTable(
                name: "PendingImplimentations",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PendingImplimentations", x => x.Id);
                });

            migrationBuilder.UpdateData(
                table: "Programs",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ValidFrom", "ValidTo" },
                values: new object[] { new DateTime(2023, 3, 23, 10, 9, 5, 30, DateTimeKind.Local).AddTicks(9054), new DateTime(2023, 3, 23, 10, 9, 5, 30, DateTimeKind.Local).AddTicks(9058) });

            migrationBuilder.UpdateData(
                table: "Programs",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ValidFrom", "ValidTo" },
                values: new object[] { new DateTime(2023, 3, 23, 10, 9, 5, 30, DateTimeKind.Local).AddTicks(9066), new DateTime(2023, 3, 23, 10, 9, 5, 30, DateTimeKind.Local).AddTicks(9068) });

            migrationBuilder.UpdateData(
                table: "Programs",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "ValidFrom", "ValidTo" },
                values: new object[] { new DateTime(2023, 3, 23, 10, 9, 5, 30, DateTimeKind.Local).AddTicks(9073), new DateTime(2023, 3, 23, 10, 9, 5, 30, DateTimeKind.Local).AddTicks(9075) });

            migrationBuilder.UpdateData(
                table: "Programs",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "ValidFrom", "ValidTo" },
                values: new object[] { new DateTime(2023, 3, 23, 10, 9, 5, 30, DateTimeKind.Local).AddTicks(9080), new DateTime(2023, 3, 23, 10, 9, 5, 30, DateTimeKind.Local).AddTicks(9081) });

            migrationBuilder.UpdateData(
                table: "Programs",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "ValidFrom", "ValidTo" },
                values: new object[] { new DateTime(2023, 3, 23, 10, 9, 5, 30, DateTimeKind.Local).AddTicks(9086), new DateTime(2023, 3, 23, 10, 9, 5, 30, DateTimeKind.Local).AddTicks(9088) });

            migrationBuilder.UpdateData(
                table: "Programs",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "ValidFrom", "ValidTo" },
                values: new object[] { new DateTime(2023, 3, 23, 10, 9, 5, 30, DateTimeKind.Local).AddTicks(9093), new DateTime(2023, 3, 23, 10, 9, 5, 30, DateTimeKind.Local).AddTicks(9094) });

            migrationBuilder.UpdateData(
                table: "Programs",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "ValidFrom", "ValidTo" },
                values: new object[] { new DateTime(2023, 3, 23, 10, 9, 5, 30, DateTimeKind.Local).AddTicks(9099), new DateTime(2023, 3, 23, 10, 9, 5, 30, DateTimeKind.Local).AddTicks(9101) });

            migrationBuilder.UpdateData(
                table: "Programs",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "ValidFrom", "ValidTo" },
                values: new object[] { new DateTime(2023, 3, 23, 10, 9, 5, 30, DateTimeKind.Local).AddTicks(9106), new DateTime(2023, 3, 23, 10, 9, 5, 30, DateTimeKind.Local).AddTicks(9107) });

            migrationBuilder.UpdateData(
                table: "Programs",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "ValidFrom", "ValidTo" },
                values: new object[] { new DateTime(2023, 3, 23, 10, 9, 5, 30, DateTimeKind.Local).AddTicks(9114), new DateTime(2023, 3, 23, 10, 9, 5, 30, DateTimeKind.Local).AddTicks(9116) });

            migrationBuilder.UpdateData(
                table: "Programs",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "ValidFrom", "ValidTo" },
                values: new object[] { new DateTime(2023, 3, 23, 10, 9, 5, 30, DateTimeKind.Local).AddTicks(9121), new DateTime(2023, 3, 23, 10, 9, 5, 30, DateTimeKind.Local).AddTicks(9123) });

            migrationBuilder.UpdateData(
                table: "Programs",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "ValidFrom", "ValidTo" },
                values: new object[] { new DateTime(2023, 3, 23, 10, 9, 5, 30, DateTimeKind.Local).AddTicks(9127), new DateTime(2023, 3, 23, 10, 9, 5, 30, DateTimeKind.Local).AddTicks(9129) });

            migrationBuilder.UpdateData(
                table: "Programs",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "ValidFrom", "ValidTo" },
                values: new object[] { new DateTime(2023, 3, 23, 10, 9, 5, 30, DateTimeKind.Local).AddTicks(9134), new DateTime(2023, 3, 23, 10, 9, 5, 30, DateTimeKind.Local).AddTicks(9135) });

            migrationBuilder.UpdateData(
                table: "Programs",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "ValidFrom", "ValidTo" },
                values: new object[] { new DateTime(2023, 3, 23, 10, 9, 5, 30, DateTimeKind.Local).AddTicks(9140), new DateTime(2023, 3, 23, 10, 9, 5, 30, DateTimeKind.Local).AddTicks(9142) });

            migrationBuilder.UpdateData(
                table: "Programs",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "ValidFrom", "ValidTo" },
                values: new object[] { new DateTime(2023, 3, 23, 10, 9, 5, 30, DateTimeKind.Local).AddTicks(9147), new DateTime(2023, 3, 23, 10, 9, 5, 30, DateTimeKind.Local).AddTicks(9148) });

            migrationBuilder.UpdateData(
                table: "Programs",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "ValidFrom", "ValidTo" },
                values: new object[] { new DateTime(2023, 3, 23, 10, 9, 5, 30, DateTimeKind.Local).AddTicks(9153), new DateTime(2023, 3, 23, 10, 9, 5, 30, DateTimeKind.Local).AddTicks(9155) });

            migrationBuilder.UpdateData(
                table: "Programs",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "ValidFrom", "ValidTo" },
                values: new object[] { new DateTime(2023, 3, 23, 10, 9, 5, 30, DateTimeKind.Local).AddTicks(9160), new DateTime(2023, 3, 23, 10, 9, 5, 30, DateTimeKind.Local).AddTicks(9161) });

            migrationBuilder.UpdateData(
                table: "Programs",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "ValidFrom", "ValidTo" },
                values: new object[] { new DateTime(2023, 3, 23, 10, 9, 5, 30, DateTimeKind.Local).AddTicks(9166), new DateTime(2023, 3, 23, 10, 9, 5, 30, DateTimeKind.Local).AddTicks(9168) });

            migrationBuilder.UpdateData(
                table: "Programs",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "ValidFrom", "ValidTo" },
                values: new object[] { new DateTime(2023, 3, 23, 10, 9, 5, 30, DateTimeKind.Local).AddTicks(9173), new DateTime(2023, 3, 23, 10, 9, 5, 30, DateTimeKind.Local).AddTicks(9174) });

            migrationBuilder.UpdateData(
                table: "Programs",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "ValidFrom", "ValidTo" },
                values: new object[] { new DateTime(2023, 3, 23, 10, 9, 5, 30, DateTimeKind.Local).AddTicks(9179), new DateTime(2023, 3, 23, 10, 9, 5, 30, DateTimeKind.Local).AddTicks(9181) });

            migrationBuilder.UpdateData(
                table: "Programs",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "ValidFrom", "ValidTo" },
                values: new object[] { new DateTime(2023, 3, 23, 10, 9, 5, 30, DateTimeKind.Local).AddTicks(9186), new DateTime(2023, 3, 23, 10, 9, 5, 30, DateTimeKind.Local).AddTicks(9188) });

            migrationBuilder.UpdateData(
                table: "Programs",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "ValidFrom", "ValidTo" },
                values: new object[] { new DateTime(2023, 3, 23, 10, 9, 5, 30, DateTimeKind.Local).AddTicks(9193), new DateTime(2023, 3, 23, 10, 9, 5, 30, DateTimeKind.Local).AddTicks(9195) });

            migrationBuilder.UpdateData(
                table: "Programs",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "ValidFrom", "ValidTo" },
                values: new object[] { new DateTime(2023, 3, 23, 10, 9, 5, 30, DateTimeKind.Local).AddTicks(9200), new DateTime(2023, 3, 23, 10, 9, 5, 30, DateTimeKind.Local).AddTicks(9201) });

            migrationBuilder.UpdateData(
                table: "Programs",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "ValidFrom", "ValidTo" },
                values: new object[] { new DateTime(2023, 3, 23, 10, 9, 5, 30, DateTimeKind.Local).AddTicks(9206), new DateTime(2023, 3, 23, 10, 9, 5, 30, DateTimeKind.Local).AddTicks(9207) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PendingImplimentations");

            migrationBuilder.DropColumn(
                name: "PasswordHash",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "PasswordSalt",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "Token",
                table: "Users");

            migrationBuilder.UpdateData(
                table: "Programs",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ValidFrom", "ValidTo" },
                values: new object[] { new DateTime(2023, 3, 15, 16, 26, 43, 707, DateTimeKind.Local).AddTicks(1564), new DateTime(2023, 3, 15, 16, 26, 43, 707, DateTimeKind.Local).AddTicks(1594) });

            migrationBuilder.UpdateData(
                table: "Programs",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ValidFrom", "ValidTo" },
                values: new object[] { new DateTime(2023, 3, 15, 16, 26, 43, 707, DateTimeKind.Local).AddTicks(1599), new DateTime(2023, 3, 15, 16, 26, 43, 707, DateTimeKind.Local).AddTicks(1602) });

            migrationBuilder.UpdateData(
                table: "Programs",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "ValidFrom", "ValidTo" },
                values: new object[] { new DateTime(2023, 3, 15, 16, 26, 43, 707, DateTimeKind.Local).AddTicks(1606), new DateTime(2023, 3, 15, 16, 26, 43, 707, DateTimeKind.Local).AddTicks(1608) });

            migrationBuilder.UpdateData(
                table: "Programs",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "ValidFrom", "ValidTo" },
                values: new object[] { new DateTime(2023, 3, 15, 16, 26, 43, 707, DateTimeKind.Local).AddTicks(1611), new DateTime(2023, 3, 15, 16, 26, 43, 707, DateTimeKind.Local).AddTicks(1613) });

            migrationBuilder.UpdateData(
                table: "Programs",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "ValidFrom", "ValidTo" },
                values: new object[] { new DateTime(2023, 3, 15, 16, 26, 43, 707, DateTimeKind.Local).AddTicks(1617), new DateTime(2023, 3, 15, 16, 26, 43, 707, DateTimeKind.Local).AddTicks(1619) });

            migrationBuilder.UpdateData(
                table: "Programs",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "ValidFrom", "ValidTo" },
                values: new object[] { new DateTime(2023, 3, 15, 16, 26, 43, 707, DateTimeKind.Local).AddTicks(1622), new DateTime(2023, 3, 15, 16, 26, 43, 707, DateTimeKind.Local).AddTicks(1624) });

            migrationBuilder.UpdateData(
                table: "Programs",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "ValidFrom", "ValidTo" },
                values: new object[] { new DateTime(2023, 3, 15, 16, 26, 43, 707, DateTimeKind.Local).AddTicks(1628), new DateTime(2023, 3, 15, 16, 26, 43, 707, DateTimeKind.Local).AddTicks(1630) });

            migrationBuilder.UpdateData(
                table: "Programs",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "ValidFrom", "ValidTo" },
                values: new object[] { new DateTime(2023, 3, 15, 16, 26, 43, 707, DateTimeKind.Local).AddTicks(1633), new DateTime(2023, 3, 15, 16, 26, 43, 707, DateTimeKind.Local).AddTicks(1635) });

            migrationBuilder.UpdateData(
                table: "Programs",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "ValidFrom", "ValidTo" },
                values: new object[] { new DateTime(2023, 3, 15, 16, 26, 43, 707, DateTimeKind.Local).AddTicks(1639), new DateTime(2023, 3, 15, 16, 26, 43, 707, DateTimeKind.Local).AddTicks(1641) });

            migrationBuilder.UpdateData(
                table: "Programs",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "ValidFrom", "ValidTo" },
                values: new object[] { new DateTime(2023, 3, 15, 16, 26, 43, 707, DateTimeKind.Local).AddTicks(1644), new DateTime(2023, 3, 15, 16, 26, 43, 707, DateTimeKind.Local).AddTicks(1646) });

            migrationBuilder.UpdateData(
                table: "Programs",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "ValidFrom", "ValidTo" },
                values: new object[] { new DateTime(2023, 3, 15, 16, 26, 43, 707, DateTimeKind.Local).AddTicks(1650), new DateTime(2023, 3, 15, 16, 26, 43, 707, DateTimeKind.Local).AddTicks(1652) });

            migrationBuilder.UpdateData(
                table: "Programs",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "ValidFrom", "ValidTo" },
                values: new object[] { new DateTime(2023, 3, 15, 16, 26, 43, 707, DateTimeKind.Local).AddTicks(1655), new DateTime(2023, 3, 15, 16, 26, 43, 707, DateTimeKind.Local).AddTicks(1657) });

            migrationBuilder.UpdateData(
                table: "Programs",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "ValidFrom", "ValidTo" },
                values: new object[] { new DateTime(2023, 3, 15, 16, 26, 43, 707, DateTimeKind.Local).AddTicks(1661), new DateTime(2023, 3, 15, 16, 26, 43, 707, DateTimeKind.Local).AddTicks(1663) });

            migrationBuilder.UpdateData(
                table: "Programs",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "ValidFrom", "ValidTo" },
                values: new object[] { new DateTime(2023, 3, 15, 16, 26, 43, 707, DateTimeKind.Local).AddTicks(1668), new DateTime(2023, 3, 15, 16, 26, 43, 707, DateTimeKind.Local).AddTicks(1670) });

            migrationBuilder.UpdateData(
                table: "Programs",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "ValidFrom", "ValidTo" },
                values: new object[] { new DateTime(2023, 3, 15, 16, 26, 43, 707, DateTimeKind.Local).AddTicks(1674), new DateTime(2023, 3, 15, 16, 26, 43, 707, DateTimeKind.Local).AddTicks(1676) });

            migrationBuilder.UpdateData(
                table: "Programs",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "ValidFrom", "ValidTo" },
                values: new object[] { new DateTime(2023, 3, 15, 16, 26, 43, 707, DateTimeKind.Local).AddTicks(1679), new DateTime(2023, 3, 15, 16, 26, 43, 707, DateTimeKind.Local).AddTicks(1681) });

            migrationBuilder.UpdateData(
                table: "Programs",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "ValidFrom", "ValidTo" },
                values: new object[] { new DateTime(2023, 3, 15, 16, 26, 43, 707, DateTimeKind.Local).AddTicks(1684), new DateTime(2023, 3, 15, 16, 26, 43, 707, DateTimeKind.Local).AddTicks(1686) });

            migrationBuilder.UpdateData(
                table: "Programs",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "ValidFrom", "ValidTo" },
                values: new object[] { new DateTime(2023, 3, 15, 16, 26, 43, 707, DateTimeKind.Local).AddTicks(1690), new DateTime(2023, 3, 15, 16, 26, 43, 707, DateTimeKind.Local).AddTicks(1692) });

            migrationBuilder.UpdateData(
                table: "Programs",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "ValidFrom", "ValidTo" },
                values: new object[] { new DateTime(2023, 3, 15, 16, 26, 43, 707, DateTimeKind.Local).AddTicks(1695), new DateTime(2023, 3, 15, 16, 26, 43, 707, DateTimeKind.Local).AddTicks(1697) });

            migrationBuilder.UpdateData(
                table: "Programs",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "ValidFrom", "ValidTo" },
                values: new object[] { new DateTime(2023, 3, 15, 16, 26, 43, 707, DateTimeKind.Local).AddTicks(1701), new DateTime(2023, 3, 15, 16, 26, 43, 707, DateTimeKind.Local).AddTicks(1702) });

            migrationBuilder.UpdateData(
                table: "Programs",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "ValidFrom", "ValidTo" },
                values: new object[] { new DateTime(2023, 3, 15, 16, 26, 43, 707, DateTimeKind.Local).AddTicks(1706), new DateTime(2023, 3, 15, 16, 26, 43, 707, DateTimeKind.Local).AddTicks(1708) });

            migrationBuilder.UpdateData(
                table: "Programs",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "ValidFrom", "ValidTo" },
                values: new object[] { new DateTime(2023, 3, 15, 16, 26, 43, 707, DateTimeKind.Local).AddTicks(1711), new DateTime(2023, 3, 15, 16, 26, 43, 707, DateTimeKind.Local).AddTicks(1713) });

            migrationBuilder.UpdateData(
                table: "Programs",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "ValidFrom", "ValidTo" },
                values: new object[] { new DateTime(2023, 3, 15, 16, 26, 43, 707, DateTimeKind.Local).AddTicks(1717), new DateTime(2023, 3, 15, 16, 26, 43, 707, DateTimeKind.Local).AddTicks(1719) });
        }
    }
}
