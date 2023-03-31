using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Accreditation_Watch.Server.Migrations
{
    /// <inheritdoc />
    public partial class RemovingPasswordsFromUser2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Programs",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ValidFrom", "ValidTo" },
                values: new object[] { new DateTime(2023, 3, 23, 14, 31, 15, 572, DateTimeKind.Local).AddTicks(5028), new DateTime(2023, 3, 23, 14, 31, 15, 572, DateTimeKind.Local).AddTicks(5031) });

            migrationBuilder.UpdateData(
                table: "Programs",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ValidFrom", "ValidTo" },
                values: new object[] { new DateTime(2023, 3, 23, 14, 31, 15, 572, DateTimeKind.Local).AddTicks(5034), new DateTime(2023, 3, 23, 14, 31, 15, 572, DateTimeKind.Local).AddTicks(5035) });

            migrationBuilder.UpdateData(
                table: "Programs",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "ValidFrom", "ValidTo" },
                values: new object[] { new DateTime(2023, 3, 23, 14, 31, 15, 572, DateTimeKind.Local).AddTicks(5037), new DateTime(2023, 3, 23, 14, 31, 15, 572, DateTimeKind.Local).AddTicks(5038) });

            migrationBuilder.UpdateData(
                table: "Programs",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "ValidFrom", "ValidTo" },
                values: new object[] { new DateTime(2023, 3, 23, 14, 31, 15, 572, DateTimeKind.Local).AddTicks(5040), new DateTime(2023, 3, 23, 14, 31, 15, 572, DateTimeKind.Local).AddTicks(5041) });

            migrationBuilder.UpdateData(
                table: "Programs",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "ValidFrom", "ValidTo" },
                values: new object[] { new DateTime(2023, 3, 23, 14, 31, 15, 572, DateTimeKind.Local).AddTicks(5043), new DateTime(2023, 3, 23, 14, 31, 15, 572, DateTimeKind.Local).AddTicks(5044) });

            migrationBuilder.UpdateData(
                table: "Programs",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "ValidFrom", "ValidTo" },
                values: new object[] { new DateTime(2023, 3, 23, 14, 31, 15, 572, DateTimeKind.Local).AddTicks(5046), new DateTime(2023, 3, 23, 14, 31, 15, 572, DateTimeKind.Local).AddTicks(5047) });

            migrationBuilder.UpdateData(
                table: "Programs",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "ValidFrom", "ValidTo" },
                values: new object[] { new DateTime(2023, 3, 23, 14, 31, 15, 572, DateTimeKind.Local).AddTicks(5049), new DateTime(2023, 3, 23, 14, 31, 15, 572, DateTimeKind.Local).AddTicks(5050) });

            migrationBuilder.UpdateData(
                table: "Programs",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "ValidFrom", "ValidTo" },
                values: new object[] { new DateTime(2023, 3, 23, 14, 31, 15, 572, DateTimeKind.Local).AddTicks(5052), new DateTime(2023, 3, 23, 14, 31, 15, 572, DateTimeKind.Local).AddTicks(5052) });

            migrationBuilder.UpdateData(
                table: "Programs",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "ValidFrom", "ValidTo" },
                values: new object[] { new DateTime(2023, 3, 23, 14, 31, 15, 572, DateTimeKind.Local).AddTicks(5056), new DateTime(2023, 3, 23, 14, 31, 15, 572, DateTimeKind.Local).AddTicks(5057) });

            migrationBuilder.UpdateData(
                table: "Programs",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "ValidFrom", "ValidTo" },
                values: new object[] { new DateTime(2023, 3, 23, 14, 31, 15, 572, DateTimeKind.Local).AddTicks(5059), new DateTime(2023, 3, 23, 14, 31, 15, 572, DateTimeKind.Local).AddTicks(5060) });

            migrationBuilder.UpdateData(
                table: "Programs",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "ValidFrom", "ValidTo" },
                values: new object[] { new DateTime(2023, 3, 23, 14, 31, 15, 572, DateTimeKind.Local).AddTicks(5062), new DateTime(2023, 3, 23, 14, 31, 15, 572, DateTimeKind.Local).AddTicks(5063) });

            migrationBuilder.UpdateData(
                table: "Programs",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "ValidFrom", "ValidTo" },
                values: new object[] { new DateTime(2023, 3, 23, 14, 31, 15, 572, DateTimeKind.Local).AddTicks(5065), new DateTime(2023, 3, 23, 14, 31, 15, 572, DateTimeKind.Local).AddTicks(5066) });

            migrationBuilder.UpdateData(
                table: "Programs",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "ValidFrom", "ValidTo" },
                values: new object[] { new DateTime(2023, 3, 23, 14, 31, 15, 572, DateTimeKind.Local).AddTicks(5068), new DateTime(2023, 3, 23, 14, 31, 15, 572, DateTimeKind.Local).AddTicks(5069) });

            migrationBuilder.UpdateData(
                table: "Programs",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "ValidFrom", "ValidTo" },
                values: new object[] { new DateTime(2023, 3, 23, 14, 31, 15, 572, DateTimeKind.Local).AddTicks(5071), new DateTime(2023, 3, 23, 14, 31, 15, 572, DateTimeKind.Local).AddTicks(5072) });

            migrationBuilder.UpdateData(
                table: "Programs",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "ValidFrom", "ValidTo" },
                values: new object[] { new DateTime(2023, 3, 23, 14, 31, 15, 572, DateTimeKind.Local).AddTicks(5074), new DateTime(2023, 3, 23, 14, 31, 15, 572, DateTimeKind.Local).AddTicks(5075) });

            migrationBuilder.UpdateData(
                table: "Programs",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "ValidFrom", "ValidTo" },
                values: new object[] { new DateTime(2023, 3, 23, 14, 31, 15, 572, DateTimeKind.Local).AddTicks(5077), new DateTime(2023, 3, 23, 14, 31, 15, 572, DateTimeKind.Local).AddTicks(5077) });

            migrationBuilder.UpdateData(
                table: "Programs",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "ValidFrom", "ValidTo" },
                values: new object[] { new DateTime(2023, 3, 23, 14, 31, 15, 572, DateTimeKind.Local).AddTicks(5080), new DateTime(2023, 3, 23, 14, 31, 15, 572, DateTimeKind.Local).AddTicks(5080) });

            migrationBuilder.UpdateData(
                table: "Programs",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "ValidFrom", "ValidTo" },
                values: new object[] { new DateTime(2023, 3, 23, 14, 31, 15, 572, DateTimeKind.Local).AddTicks(5083), new DateTime(2023, 3, 23, 14, 31, 15, 572, DateTimeKind.Local).AddTicks(5083) });

            migrationBuilder.UpdateData(
                table: "Programs",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "ValidFrom", "ValidTo" },
                values: new object[] { new DateTime(2023, 3, 23, 14, 31, 15, 572, DateTimeKind.Local).AddTicks(5085), new DateTime(2023, 3, 23, 14, 31, 15, 572, DateTimeKind.Local).AddTicks(5086) });

            migrationBuilder.UpdateData(
                table: "Programs",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "ValidFrom", "ValidTo" },
                values: new object[] { new DateTime(2023, 3, 23, 14, 31, 15, 572, DateTimeKind.Local).AddTicks(5088), new DateTime(2023, 3, 23, 14, 31, 15, 572, DateTimeKind.Local).AddTicks(5089) });

            migrationBuilder.UpdateData(
                table: "Programs",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "ValidFrom", "ValidTo" },
                values: new object[] { new DateTime(2023, 3, 23, 14, 31, 15, 572, DateTimeKind.Local).AddTicks(5091), new DateTime(2023, 3, 23, 14, 31, 15, 572, DateTimeKind.Local).AddTicks(5092) });

            migrationBuilder.UpdateData(
                table: "Programs",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "ValidFrom", "ValidTo" },
                values: new object[] { new DateTime(2023, 3, 23, 14, 31, 15, 572, DateTimeKind.Local).AddTicks(5094), new DateTime(2023, 3, 23, 14, 31, 15, 572, DateTimeKind.Local).AddTicks(5095) });

            migrationBuilder.UpdateData(
                table: "Programs",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "ValidFrom", "ValidTo" },
                values: new object[] { new DateTime(2023, 3, 23, 14, 31, 15, 572, DateTimeKind.Local).AddTicks(5097), new DateTime(2023, 3, 23, 14, 31, 15, 572, DateTimeKind.Local).AddTicks(5098) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Programs",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ValidFrom", "ValidTo" },
                values: new object[] { new DateTime(2023, 3, 23, 14, 27, 24, 859, DateTimeKind.Local).AddTicks(6120), new DateTime(2023, 3, 23, 14, 27, 24, 859, DateTimeKind.Local).AddTicks(6124) });

            migrationBuilder.UpdateData(
                table: "Programs",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ValidFrom", "ValidTo" },
                values: new object[] { new DateTime(2023, 3, 23, 14, 27, 24, 859, DateTimeKind.Local).AddTicks(6132), new DateTime(2023, 3, 23, 14, 27, 24, 859, DateTimeKind.Local).AddTicks(6136) });

            migrationBuilder.UpdateData(
                table: "Programs",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "ValidFrom", "ValidTo" },
                values: new object[] { new DateTime(2023, 3, 23, 14, 27, 24, 859, DateTimeKind.Local).AddTicks(6140), new DateTime(2023, 3, 23, 14, 27, 24, 859, DateTimeKind.Local).AddTicks(6144) });

            migrationBuilder.UpdateData(
                table: "Programs",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "ValidFrom", "ValidTo" },
                values: new object[] { new DateTime(2023, 3, 23, 14, 27, 24, 859, DateTimeKind.Local).AddTicks(6148), new DateTime(2023, 3, 23, 14, 27, 24, 859, DateTimeKind.Local).AddTicks(6149) });

            migrationBuilder.UpdateData(
                table: "Programs",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "ValidFrom", "ValidTo" },
                values: new object[] { new DateTime(2023, 3, 23, 14, 27, 24, 859, DateTimeKind.Local).AddTicks(6154), new DateTime(2023, 3, 23, 14, 27, 24, 859, DateTimeKind.Local).AddTicks(6155) });

            migrationBuilder.UpdateData(
                table: "Programs",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "ValidFrom", "ValidTo" },
                values: new object[] { new DateTime(2023, 3, 23, 14, 27, 24, 859, DateTimeKind.Local).AddTicks(6162), new DateTime(2023, 3, 23, 14, 27, 24, 859, DateTimeKind.Local).AddTicks(6163) });

            migrationBuilder.UpdateData(
                table: "Programs",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "ValidFrom", "ValidTo" },
                values: new object[] { new DateTime(2023, 3, 23, 14, 27, 24, 859, DateTimeKind.Local).AddTicks(6168), new DateTime(2023, 3, 23, 14, 27, 24, 859, DateTimeKind.Local).AddTicks(6170) });

            migrationBuilder.UpdateData(
                table: "Programs",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "ValidFrom", "ValidTo" },
                values: new object[] { new DateTime(2023, 3, 23, 14, 27, 24, 859, DateTimeKind.Local).AddTicks(6177), new DateTime(2023, 3, 23, 14, 27, 24, 859, DateTimeKind.Local).AddTicks(6179) });

            migrationBuilder.UpdateData(
                table: "Programs",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "ValidFrom", "ValidTo" },
                values: new object[] { new DateTime(2023, 3, 23, 14, 27, 24, 859, DateTimeKind.Local).AddTicks(6182), new DateTime(2023, 3, 23, 14, 27, 24, 859, DateTimeKind.Local).AddTicks(6185) });

            migrationBuilder.UpdateData(
                table: "Programs",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "ValidFrom", "ValidTo" },
                values: new object[] { new DateTime(2023, 3, 23, 14, 27, 24, 859, DateTimeKind.Local).AddTicks(6189), new DateTime(2023, 3, 23, 14, 27, 24, 859, DateTimeKind.Local).AddTicks(6192) });

            migrationBuilder.UpdateData(
                table: "Programs",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "ValidFrom", "ValidTo" },
                values: new object[] { new DateTime(2023, 3, 23, 14, 27, 24, 859, DateTimeKind.Local).AddTicks(6195), new DateTime(2023, 3, 23, 14, 27, 24, 859, DateTimeKind.Local).AddTicks(6197) });

            migrationBuilder.UpdateData(
                table: "Programs",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "ValidFrom", "ValidTo" },
                values: new object[] { new DateTime(2023, 3, 23, 14, 27, 24, 859, DateTimeKind.Local).AddTicks(6202), new DateTime(2023, 3, 23, 14, 27, 24, 859, DateTimeKind.Local).AddTicks(6203) });

            migrationBuilder.UpdateData(
                table: "Programs",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "ValidFrom", "ValidTo" },
                values: new object[] { new DateTime(2023, 3, 23, 14, 27, 24, 859, DateTimeKind.Local).AddTicks(6209), new DateTime(2023, 3, 23, 14, 27, 24, 859, DateTimeKind.Local).AddTicks(6210) });

            migrationBuilder.UpdateData(
                table: "Programs",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "ValidFrom", "ValidTo" },
                values: new object[] { new DateTime(2023, 3, 23, 14, 27, 24, 859, DateTimeKind.Local).AddTicks(6215), new DateTime(2023, 3, 23, 14, 27, 24, 859, DateTimeKind.Local).AddTicks(6217) });

            migrationBuilder.UpdateData(
                table: "Programs",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "ValidFrom", "ValidTo" },
                values: new object[] { new DateTime(2023, 3, 23, 14, 27, 24, 859, DateTimeKind.Local).AddTicks(6220), new DateTime(2023, 3, 23, 14, 27, 24, 859, DateTimeKind.Local).AddTicks(6224) });

            migrationBuilder.UpdateData(
                table: "Programs",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "ValidFrom", "ValidTo" },
                values: new object[] { new DateTime(2023, 3, 23, 14, 27, 24, 859, DateTimeKind.Local).AddTicks(6228), new DateTime(2023, 3, 23, 14, 27, 24, 859, DateTimeKind.Local).AddTicks(6229) });

            migrationBuilder.UpdateData(
                table: "Programs",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "ValidFrom", "ValidTo" },
                values: new object[] { new DateTime(2023, 3, 23, 14, 27, 24, 859, DateTimeKind.Local).AddTicks(6235), new DateTime(2023, 3, 23, 14, 27, 24, 859, DateTimeKind.Local).AddTicks(6236) });

            migrationBuilder.UpdateData(
                table: "Programs",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "ValidFrom", "ValidTo" },
                values: new object[] { new DateTime(2023, 3, 23, 14, 27, 24, 859, DateTimeKind.Local).AddTicks(6242), new DateTime(2023, 3, 23, 14, 27, 24, 859, DateTimeKind.Local).AddTicks(6244) });

            migrationBuilder.UpdateData(
                table: "Programs",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "ValidFrom", "ValidTo" },
                values: new object[] { new DateTime(2023, 3, 23, 14, 27, 24, 859, DateTimeKind.Local).AddTicks(6247), new DateTime(2023, 3, 23, 14, 27, 24, 859, DateTimeKind.Local).AddTicks(6253) });

            migrationBuilder.UpdateData(
                table: "Programs",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "ValidFrom", "ValidTo" },
                values: new object[] { new DateTime(2023, 3, 23, 14, 27, 24, 859, DateTimeKind.Local).AddTicks(6257), new DateTime(2023, 3, 23, 14, 27, 24, 859, DateTimeKind.Local).AddTicks(6258) });

            migrationBuilder.UpdateData(
                table: "Programs",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "ValidFrom", "ValidTo" },
                values: new object[] { new DateTime(2023, 3, 23, 14, 27, 24, 859, DateTimeKind.Local).AddTicks(6341), new DateTime(2023, 3, 23, 14, 27, 24, 859, DateTimeKind.Local).AddTicks(6343) });

            migrationBuilder.UpdateData(
                table: "Programs",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "ValidFrom", "ValidTo" },
                values: new object[] { new DateTime(2023, 3, 23, 14, 27, 24, 859, DateTimeKind.Local).AddTicks(6349), new DateTime(2023, 3, 23, 14, 27, 24, 859, DateTimeKind.Local).AddTicks(6350) });

            migrationBuilder.UpdateData(
                table: "Programs",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "ValidFrom", "ValidTo" },
                values: new object[] { new DateTime(2023, 3, 23, 14, 27, 24, 859, DateTimeKind.Local).AddTicks(6356), new DateTime(2023, 3, 23, 14, 27, 24, 859, DateTimeKind.Local).AddTicks(6357) });
        }
    }
}
