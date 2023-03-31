using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Accreditation_Watch.Server.Migrations
{
    /// <inheritdoc />
    public partial class RemovingPasswordsFromUser : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Password",
                table: "Users");

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Password",
                table: "Users",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "Programs",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ValidFrom", "ValidTo" },
                values: new object[] { new DateTime(2023, 3, 23, 14, 13, 47, 794, DateTimeKind.Local).AddTicks(2899), new DateTime(2023, 3, 23, 14, 13, 47, 794, DateTimeKind.Local).AddTicks(2903) });

            migrationBuilder.UpdateData(
                table: "Programs",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ValidFrom", "ValidTo" },
                values: new object[] { new DateTime(2023, 3, 23, 14, 13, 47, 794, DateTimeKind.Local).AddTicks(2911), new DateTime(2023, 3, 23, 14, 13, 47, 794, DateTimeKind.Local).AddTicks(2912) });

            migrationBuilder.UpdateData(
                table: "Programs",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "ValidFrom", "ValidTo" },
                values: new object[] { new DateTime(2023, 3, 23, 14, 13, 47, 794, DateTimeKind.Local).AddTicks(2917), new DateTime(2023, 3, 23, 14, 13, 47, 794, DateTimeKind.Local).AddTicks(2919) });

            migrationBuilder.UpdateData(
                table: "Programs",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "ValidFrom", "ValidTo" },
                values: new object[] { new DateTime(2023, 3, 23, 14, 13, 47, 794, DateTimeKind.Local).AddTicks(2923), new DateTime(2023, 3, 23, 14, 13, 47, 794, DateTimeKind.Local).AddTicks(2924) });

            migrationBuilder.UpdateData(
                table: "Programs",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "ValidFrom", "ValidTo" },
                values: new object[] { new DateTime(2023, 3, 23, 14, 13, 47, 794, DateTimeKind.Local).AddTicks(2928), new DateTime(2023, 3, 23, 14, 13, 47, 794, DateTimeKind.Local).AddTicks(2930) });

            migrationBuilder.UpdateData(
                table: "Programs",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "ValidFrom", "ValidTo" },
                values: new object[] { new DateTime(2023, 3, 23, 14, 13, 47, 794, DateTimeKind.Local).AddTicks(2934), new DateTime(2023, 3, 23, 14, 13, 47, 794, DateTimeKind.Local).AddTicks(2935) });

            migrationBuilder.UpdateData(
                table: "Programs",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "ValidFrom", "ValidTo" },
                values: new object[] { new DateTime(2023, 3, 23, 14, 13, 47, 794, DateTimeKind.Local).AddTicks(2939), new DateTime(2023, 3, 23, 14, 13, 47, 794, DateTimeKind.Local).AddTicks(2940) });

            migrationBuilder.UpdateData(
                table: "Programs",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "ValidFrom", "ValidTo" },
                values: new object[] { new DateTime(2023, 3, 23, 14, 13, 47, 794, DateTimeKind.Local).AddTicks(2944), new DateTime(2023, 3, 23, 14, 13, 47, 794, DateTimeKind.Local).AddTicks(2945) });

            migrationBuilder.UpdateData(
                table: "Programs",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "ValidFrom", "ValidTo" },
                values: new object[] { new DateTime(2023, 3, 23, 14, 13, 47, 794, DateTimeKind.Local).AddTicks(2950), new DateTime(2023, 3, 23, 14, 13, 47, 794, DateTimeKind.Local).AddTicks(2952) });

            migrationBuilder.UpdateData(
                table: "Programs",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "ValidFrom", "ValidTo" },
                values: new object[] { new DateTime(2023, 3, 23, 14, 13, 47, 794, DateTimeKind.Local).AddTicks(2956), new DateTime(2023, 3, 23, 14, 13, 47, 794, DateTimeKind.Local).AddTicks(2957) });

            migrationBuilder.UpdateData(
                table: "Programs",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "ValidFrom", "ValidTo" },
                values: new object[] { new DateTime(2023, 3, 23, 14, 13, 47, 794, DateTimeKind.Local).AddTicks(2961), new DateTime(2023, 3, 23, 14, 13, 47, 794, DateTimeKind.Local).AddTicks(2963) });

            migrationBuilder.UpdateData(
                table: "Programs",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "ValidFrom", "ValidTo" },
                values: new object[] { new DateTime(2023, 3, 23, 14, 13, 47, 794, DateTimeKind.Local).AddTicks(2967), new DateTime(2023, 3, 23, 14, 13, 47, 794, DateTimeKind.Local).AddTicks(2968) });

            migrationBuilder.UpdateData(
                table: "Programs",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "ValidFrom", "ValidTo" },
                values: new object[] { new DateTime(2023, 3, 23, 14, 13, 47, 794, DateTimeKind.Local).AddTicks(2972), new DateTime(2023, 3, 23, 14, 13, 47, 794, DateTimeKind.Local).AddTicks(2974) });

            migrationBuilder.UpdateData(
                table: "Programs",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "ValidFrom", "ValidTo" },
                values: new object[] { new DateTime(2023, 3, 23, 14, 13, 47, 794, DateTimeKind.Local).AddTicks(2978), new DateTime(2023, 3, 23, 14, 13, 47, 794, DateTimeKind.Local).AddTicks(2979) });

            migrationBuilder.UpdateData(
                table: "Programs",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "ValidFrom", "ValidTo" },
                values: new object[] { new DateTime(2023, 3, 23, 14, 13, 47, 794, DateTimeKind.Local).AddTicks(2983), new DateTime(2023, 3, 23, 14, 13, 47, 794, DateTimeKind.Local).AddTicks(2984) });

            migrationBuilder.UpdateData(
                table: "Programs",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "ValidFrom", "ValidTo" },
                values: new object[] { new DateTime(2023, 3, 23, 14, 13, 47, 794, DateTimeKind.Local).AddTicks(2989), new DateTime(2023, 3, 23, 14, 13, 47, 794, DateTimeKind.Local).AddTicks(2990) });

            migrationBuilder.UpdateData(
                table: "Programs",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "ValidFrom", "ValidTo" },
                values: new object[] { new DateTime(2023, 3, 23, 14, 13, 47, 794, DateTimeKind.Local).AddTicks(2994), new DateTime(2023, 3, 23, 14, 13, 47, 794, DateTimeKind.Local).AddTicks(2996) });

            migrationBuilder.UpdateData(
                table: "Programs",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "ValidFrom", "ValidTo" },
                values: new object[] { new DateTime(2023, 3, 23, 14, 13, 47, 794, DateTimeKind.Local).AddTicks(2999), new DateTime(2023, 3, 23, 14, 13, 47, 794, DateTimeKind.Local).AddTicks(3001) });

            migrationBuilder.UpdateData(
                table: "Programs",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "ValidFrom", "ValidTo" },
                values: new object[] { new DateTime(2023, 3, 23, 14, 13, 47, 794, DateTimeKind.Local).AddTicks(3007), new DateTime(2023, 3, 23, 14, 13, 47, 794, DateTimeKind.Local).AddTicks(3008) });

            migrationBuilder.UpdateData(
                table: "Programs",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "ValidFrom", "ValidTo" },
                values: new object[] { new DateTime(2023, 3, 23, 14, 13, 47, 794, DateTimeKind.Local).AddTicks(3012), new DateTime(2023, 3, 23, 14, 13, 47, 794, DateTimeKind.Local).AddTicks(3013) });

            migrationBuilder.UpdateData(
                table: "Programs",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "ValidFrom", "ValidTo" },
                values: new object[] { new DateTime(2023, 3, 23, 14, 13, 47, 794, DateTimeKind.Local).AddTicks(3017), new DateTime(2023, 3, 23, 14, 13, 47, 794, DateTimeKind.Local).AddTicks(3018) });

            migrationBuilder.UpdateData(
                table: "Programs",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "ValidFrom", "ValidTo" },
                values: new object[] { new DateTime(2023, 3, 23, 14, 13, 47, 794, DateTimeKind.Local).AddTicks(3022), new DateTime(2023, 3, 23, 14, 13, 47, 794, DateTimeKind.Local).AddTicks(3024) });

            migrationBuilder.UpdateData(
                table: "Programs",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "ValidFrom", "ValidTo" },
                values: new object[] { new DateTime(2023, 3, 23, 14, 13, 47, 794, DateTimeKind.Local).AddTicks(3027), new DateTime(2023, 3, 23, 14, 13, 47, 794, DateTimeKind.Local).AddTicks(3029) });
        }
    }
}
