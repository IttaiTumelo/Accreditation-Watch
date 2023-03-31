using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Accreditation_Watch.Server.Migrations
{
    /// <inheritdoc />
    public partial class AddedProgressToCoddingStatusOnLogIn2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Status",
                table: "PendingImplimentations",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "Programs",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ValidFrom", "ValidTo" },
                values: new object[] { new DateTime(2023, 3, 24, 8, 32, 14, 361, DateTimeKind.Local).AddTicks(8673), new DateTime(2023, 3, 24, 8, 32, 14, 361, DateTimeKind.Local).AddTicks(8678) });

            migrationBuilder.UpdateData(
                table: "Programs",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ValidFrom", "ValidTo" },
                values: new object[] { new DateTime(2023, 3, 24, 8, 32, 14, 361, DateTimeKind.Local).AddTicks(8681), new DateTime(2023, 3, 24, 8, 32, 14, 361, DateTimeKind.Local).AddTicks(8683) });

            migrationBuilder.UpdateData(
                table: "Programs",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "ValidFrom", "ValidTo" },
                values: new object[] { new DateTime(2023, 3, 24, 8, 32, 14, 361, DateTimeKind.Local).AddTicks(8686), new DateTime(2023, 3, 24, 8, 32, 14, 361, DateTimeKind.Local).AddTicks(8686) });

            migrationBuilder.UpdateData(
                table: "Programs",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "ValidFrom", "ValidTo" },
                values: new object[] { new DateTime(2023, 3, 24, 8, 32, 14, 361, DateTimeKind.Local).AddTicks(8689), new DateTime(2023, 3, 24, 8, 32, 14, 361, DateTimeKind.Local).AddTicks(8690) });

            migrationBuilder.UpdateData(
                table: "Programs",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "ValidFrom", "ValidTo" },
                values: new object[] { new DateTime(2023, 3, 24, 8, 32, 14, 361, DateTimeKind.Local).AddTicks(8693), new DateTime(2023, 3, 24, 8, 32, 14, 361, DateTimeKind.Local).AddTicks(8694) });

            migrationBuilder.UpdateData(
                table: "Programs",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "ValidFrom", "ValidTo" },
                values: new object[] { new DateTime(2023, 3, 24, 8, 32, 14, 361, DateTimeKind.Local).AddTicks(8696), new DateTime(2023, 3, 24, 8, 32, 14, 361, DateTimeKind.Local).AddTicks(8697) });

            migrationBuilder.UpdateData(
                table: "Programs",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "ValidFrom", "ValidTo" },
                values: new object[] { new DateTime(2023, 3, 24, 8, 32, 14, 361, DateTimeKind.Local).AddTicks(8700), new DateTime(2023, 3, 24, 8, 32, 14, 361, DateTimeKind.Local).AddTicks(8701) });

            migrationBuilder.UpdateData(
                table: "Programs",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "ValidFrom", "ValidTo" },
                values: new object[] { new DateTime(2023, 3, 24, 8, 32, 14, 361, DateTimeKind.Local).AddTicks(8703), new DateTime(2023, 3, 24, 8, 32, 14, 361, DateTimeKind.Local).AddTicks(8704) });

            migrationBuilder.UpdateData(
                table: "Programs",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "ValidFrom", "ValidTo" },
                values: new object[] { new DateTime(2023, 3, 24, 8, 32, 14, 361, DateTimeKind.Local).AddTicks(8707), new DateTime(2023, 3, 24, 8, 32, 14, 361, DateTimeKind.Local).AddTicks(8708) });

            migrationBuilder.UpdateData(
                table: "Programs",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "ValidFrom", "ValidTo" },
                values: new object[] { new DateTime(2023, 3, 24, 8, 32, 14, 361, DateTimeKind.Local).AddTicks(8711), new DateTime(2023, 3, 24, 8, 32, 14, 361, DateTimeKind.Local).AddTicks(8711) });

            migrationBuilder.UpdateData(
                table: "Programs",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "ValidFrom", "ValidTo" },
                values: new object[] { new DateTime(2023, 3, 24, 8, 32, 14, 361, DateTimeKind.Local).AddTicks(8714), new DateTime(2023, 3, 24, 8, 32, 14, 361, DateTimeKind.Local).AddTicks(8715) });

            migrationBuilder.UpdateData(
                table: "Programs",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "ValidFrom", "ValidTo" },
                values: new object[] { new DateTime(2023, 3, 24, 8, 32, 14, 361, DateTimeKind.Local).AddTicks(8718), new DateTime(2023, 3, 24, 8, 32, 14, 361, DateTimeKind.Local).AddTicks(8719) });

            migrationBuilder.UpdateData(
                table: "Programs",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "ValidFrom", "ValidTo" },
                values: new object[] { new DateTime(2023, 3, 24, 8, 32, 14, 361, DateTimeKind.Local).AddTicks(8721), new DateTime(2023, 3, 24, 8, 32, 14, 361, DateTimeKind.Local).AddTicks(8722) });

            migrationBuilder.UpdateData(
                table: "Programs",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "ValidFrom", "ValidTo" },
                values: new object[] { new DateTime(2023, 3, 24, 8, 32, 14, 361, DateTimeKind.Local).AddTicks(8725), new DateTime(2023, 3, 24, 8, 32, 14, 361, DateTimeKind.Local).AddTicks(8726) });

            migrationBuilder.UpdateData(
                table: "Programs",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "ValidFrom", "ValidTo" },
                values: new object[] { new DateTime(2023, 3, 24, 8, 32, 14, 361, DateTimeKind.Local).AddTicks(8728), new DateTime(2023, 3, 24, 8, 32, 14, 361, DateTimeKind.Local).AddTicks(8731) });

            migrationBuilder.UpdateData(
                table: "Programs",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "ValidFrom", "ValidTo" },
                values: new object[] { new DateTime(2023, 3, 24, 8, 32, 14, 361, DateTimeKind.Local).AddTicks(8733), new DateTime(2023, 3, 24, 8, 32, 14, 361, DateTimeKind.Local).AddTicks(8734) });

            migrationBuilder.UpdateData(
                table: "Programs",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "ValidFrom", "ValidTo" },
                values: new object[] { new DateTime(2023, 3, 24, 8, 32, 14, 361, DateTimeKind.Local).AddTicks(8737), new DateTime(2023, 3, 24, 8, 32, 14, 361, DateTimeKind.Local).AddTicks(8738) });

            migrationBuilder.UpdateData(
                table: "Programs",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "ValidFrom", "ValidTo" },
                values: new object[] { new DateTime(2023, 3, 24, 8, 32, 14, 361, DateTimeKind.Local).AddTicks(8741), new DateTime(2023, 3, 24, 8, 32, 14, 361, DateTimeKind.Local).AddTicks(8741) });

            migrationBuilder.UpdateData(
                table: "Programs",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "ValidFrom", "ValidTo" },
                values: new object[] { new DateTime(2023, 3, 24, 8, 32, 14, 361, DateTimeKind.Local).AddTicks(8744), new DateTime(2023, 3, 24, 8, 32, 14, 361, DateTimeKind.Local).AddTicks(8745) });

            migrationBuilder.UpdateData(
                table: "Programs",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "ValidFrom", "ValidTo" },
                values: new object[] { new DateTime(2023, 3, 24, 8, 32, 14, 361, DateTimeKind.Local).AddTicks(8748), new DateTime(2023, 3, 24, 8, 32, 14, 361, DateTimeKind.Local).AddTicks(8749) });

            migrationBuilder.UpdateData(
                table: "Programs",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "ValidFrom", "ValidTo" },
                values: new object[] { new DateTime(2023, 3, 24, 8, 32, 14, 361, DateTimeKind.Local).AddTicks(8751), new DateTime(2023, 3, 24, 8, 32, 14, 361, DateTimeKind.Local).AddTicks(8752) });

            migrationBuilder.UpdateData(
                table: "Programs",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "ValidFrom", "ValidTo" },
                values: new object[] { new DateTime(2023, 3, 24, 8, 32, 14, 361, DateTimeKind.Local).AddTicks(8755), new DateTime(2023, 3, 24, 8, 32, 14, 361, DateTimeKind.Local).AddTicks(8756) });

            migrationBuilder.UpdateData(
                table: "Programs",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "ValidFrom", "ValidTo" },
                values: new object[] { new DateTime(2023, 3, 24, 8, 32, 14, 361, DateTimeKind.Local).AddTicks(8758), new DateTime(2023, 3, 24, 8, 32, 14, 361, DateTimeKind.Local).AddTicks(8759) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Status",
                table: "PendingImplimentations");

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
    }
}
