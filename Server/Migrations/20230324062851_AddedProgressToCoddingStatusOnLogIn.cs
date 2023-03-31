using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Accreditation_Watch.Server.Migrations
{
    /// <inheritdoc />
    public partial class AddedProgressToCoddingStatusOnLogIn : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Programs",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ValidFrom", "ValidTo" },
                values: new object[] { new DateTime(2023, 3, 24, 8, 28, 51, 114, DateTimeKind.Local).AddTicks(5553), new DateTime(2023, 3, 24, 8, 28, 51, 114, DateTimeKind.Local).AddTicks(5557) });

            migrationBuilder.UpdateData(
                table: "Programs",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ValidFrom", "ValidTo" },
                values: new object[] { new DateTime(2023, 3, 24, 8, 28, 51, 114, DateTimeKind.Local).AddTicks(5563), new DateTime(2023, 3, 24, 8, 28, 51, 114, DateTimeKind.Local).AddTicks(5564) });

            migrationBuilder.UpdateData(
                table: "Programs",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "ValidFrom", "ValidTo" },
                values: new object[] { new DateTime(2023, 3, 24, 8, 28, 51, 114, DateTimeKind.Local).AddTicks(5568), new DateTime(2023, 3, 24, 8, 28, 51, 114, DateTimeKind.Local).AddTicks(5569) });

            migrationBuilder.UpdateData(
                table: "Programs",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "ValidFrom", "ValidTo" },
                values: new object[] { new DateTime(2023, 3, 24, 8, 28, 51, 114, DateTimeKind.Local).AddTicks(5572), new DateTime(2023, 3, 24, 8, 28, 51, 114, DateTimeKind.Local).AddTicks(5573) });

            migrationBuilder.UpdateData(
                table: "Programs",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "ValidFrom", "ValidTo" },
                values: new object[] { new DateTime(2023, 3, 24, 8, 28, 51, 114, DateTimeKind.Local).AddTicks(5577), new DateTime(2023, 3, 24, 8, 28, 51, 114, DateTimeKind.Local).AddTicks(5578) });

            migrationBuilder.UpdateData(
                table: "Programs",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "ValidFrom", "ValidTo" },
                values: new object[] { new DateTime(2023, 3, 24, 8, 28, 51, 114, DateTimeKind.Local).AddTicks(5581), new DateTime(2023, 3, 24, 8, 28, 51, 114, DateTimeKind.Local).AddTicks(5583) });

            migrationBuilder.UpdateData(
                table: "Programs",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "ValidFrom", "ValidTo" },
                values: new object[] { new DateTime(2023, 3, 24, 8, 28, 51, 114, DateTimeKind.Local).AddTicks(5586), new DateTime(2023, 3, 24, 8, 28, 51, 114, DateTimeKind.Local).AddTicks(5587) });

            migrationBuilder.UpdateData(
                table: "Programs",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "ValidFrom", "ValidTo" },
                values: new object[] { new DateTime(2023, 3, 24, 8, 28, 51, 114, DateTimeKind.Local).AddTicks(5592), new DateTime(2023, 3, 24, 8, 28, 51, 114, DateTimeKind.Local).AddTicks(5593) });

            migrationBuilder.UpdateData(
                table: "Programs",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "ValidFrom", "ValidTo" },
                values: new object[] { new DateTime(2023, 3, 24, 8, 28, 51, 114, DateTimeKind.Local).AddTicks(5597), new DateTime(2023, 3, 24, 8, 28, 51, 114, DateTimeKind.Local).AddTicks(5598) });

            migrationBuilder.UpdateData(
                table: "Programs",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "ValidFrom", "ValidTo" },
                values: new object[] { new DateTime(2023, 3, 24, 8, 28, 51, 114, DateTimeKind.Local).AddTicks(5601), new DateTime(2023, 3, 24, 8, 28, 51, 114, DateTimeKind.Local).AddTicks(5602) });

            migrationBuilder.UpdateData(
                table: "Programs",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "ValidFrom", "ValidTo" },
                values: new object[] { new DateTime(2023, 3, 24, 8, 28, 51, 114, DateTimeKind.Local).AddTicks(5606), new DateTime(2023, 3, 24, 8, 28, 51, 114, DateTimeKind.Local).AddTicks(5607) });

            migrationBuilder.UpdateData(
                table: "Programs",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "ValidFrom", "ValidTo" },
                values: new object[] { new DateTime(2023, 3, 24, 8, 28, 51, 114, DateTimeKind.Local).AddTicks(5610), new DateTime(2023, 3, 24, 8, 28, 51, 114, DateTimeKind.Local).AddTicks(5612) });

            migrationBuilder.UpdateData(
                table: "Programs",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "ValidFrom", "ValidTo" },
                values: new object[] { new DateTime(2023, 3, 24, 8, 28, 51, 114, DateTimeKind.Local).AddTicks(5615), new DateTime(2023, 3, 24, 8, 28, 51, 114, DateTimeKind.Local).AddTicks(5616) });

            migrationBuilder.UpdateData(
                table: "Programs",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "ValidFrom", "ValidTo" },
                values: new object[] { new DateTime(2023, 3, 24, 8, 28, 51, 114, DateTimeKind.Local).AddTicks(5620), new DateTime(2023, 3, 24, 8, 28, 51, 114, DateTimeKind.Local).AddTicks(5621) });

            migrationBuilder.UpdateData(
                table: "Programs",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "ValidFrom", "ValidTo" },
                values: new object[] { new DateTime(2023, 3, 24, 8, 28, 51, 114, DateTimeKind.Local).AddTicks(5624), new DateTime(2023, 3, 24, 8, 28, 51, 114, DateTimeKind.Local).AddTicks(5625) });

            migrationBuilder.UpdateData(
                table: "Programs",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "ValidFrom", "ValidTo" },
                values: new object[] { new DateTime(2023, 3, 24, 8, 28, 51, 114, DateTimeKind.Local).AddTicks(5629), new DateTime(2023, 3, 24, 8, 28, 51, 114, DateTimeKind.Local).AddTicks(5630) });

            migrationBuilder.UpdateData(
                table: "Programs",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "ValidFrom", "ValidTo" },
                values: new object[] { new DateTime(2023, 3, 24, 8, 28, 51, 114, DateTimeKind.Local).AddTicks(5633), new DateTime(2023, 3, 24, 8, 28, 51, 114, DateTimeKind.Local).AddTicks(5634) });

            migrationBuilder.UpdateData(
                table: "Programs",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "ValidFrom", "ValidTo" },
                values: new object[] { new DateTime(2023, 3, 24, 8, 28, 51, 114, DateTimeKind.Local).AddTicks(5638), new DateTime(2023, 3, 24, 8, 28, 51, 114, DateTimeKind.Local).AddTicks(5639) });

            migrationBuilder.UpdateData(
                table: "Programs",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "ValidFrom", "ValidTo" },
                values: new object[] { new DateTime(2023, 3, 24, 8, 28, 51, 114, DateTimeKind.Local).AddTicks(5642), new DateTime(2023, 3, 24, 8, 28, 51, 114, DateTimeKind.Local).AddTicks(5644) });

            migrationBuilder.UpdateData(
                table: "Programs",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "ValidFrom", "ValidTo" },
                values: new object[] { new DateTime(2023, 3, 24, 8, 28, 51, 114, DateTimeKind.Local).AddTicks(5647), new DateTime(2023, 3, 24, 8, 28, 51, 114, DateTimeKind.Local).AddTicks(5648) });

            migrationBuilder.UpdateData(
                table: "Programs",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "ValidFrom", "ValidTo" },
                values: new object[] { new DateTime(2023, 3, 24, 8, 28, 51, 114, DateTimeKind.Local).AddTicks(5652), new DateTime(2023, 3, 24, 8, 28, 51, 114, DateTimeKind.Local).AddTicks(5653) });

            migrationBuilder.UpdateData(
                table: "Programs",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "ValidFrom", "ValidTo" },
                values: new object[] { new DateTime(2023, 3, 24, 8, 28, 51, 114, DateTimeKind.Local).AddTicks(5657), new DateTime(2023, 3, 24, 8, 28, 51, 114, DateTimeKind.Local).AddTicks(5658) });

            migrationBuilder.UpdateData(
                table: "Programs",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "ValidFrom", "ValidTo" },
                values: new object[] { new DateTime(2023, 3, 24, 8, 28, 51, 114, DateTimeKind.Local).AddTicks(5661), new DateTime(2023, 3, 24, 8, 28, 51, 114, DateTimeKind.Local).AddTicks(5663) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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
    }
}
