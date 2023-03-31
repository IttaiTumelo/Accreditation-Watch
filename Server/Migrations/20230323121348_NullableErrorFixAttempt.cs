using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Accreditation_Watch.Server.Migrations
{
    /// <inheritdoc />
    public partial class NullableErrorFixAttempt : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "FirstName",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "LastName",
                table: "Users");

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "FirstName",
                table: "Users",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "LastName",
                table: "Users",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

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
    }
}
