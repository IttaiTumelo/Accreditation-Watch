using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Accreditation_Watch.Server.Migrations
{
    /// <inheritdoc />
    public partial class progress4 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AccrediteStatuses",
                keyColumn: "Id",
                keyValue: 8,
                column: "Name",
                value: "Requires restructuring");

            migrationBuilder.UpdateData(
                table: "AccrediteStatuses",
                keyColumn: "Id",
                keyValue: 9,
                column: "Name",
                value: "Sent back to school for restructuring");

            migrationBuilder.UpdateData(
                table: "AccrediteStatuses",
                keyColumn: "Id",
                keyValue: 10,
                column: "Name",
                value: "back from school");

            migrationBuilder.UpdateData(
                table: "AccrediteStatuses",
                keyColumn: "Id",
                keyValue: 11,
                column: "Name",
                value: "Requires review");

            migrationBuilder.UpdateData(
                table: "AccrediteStatuses",
                keyColumn: "Id",
                keyValue: 12,
                column: "Name",
                value: "Internally reviewed");

            migrationBuilder.UpdateData(
                table: "AccrediteStatuses",
                keyColumn: "Id",
                keyValue: 13,
                column: "Name",
                value: "Externally reviewed");

            migrationBuilder.UpdateData(
                table: "AccrediteStatuses",
                keyColumn: "Id",
                keyValue: 14,
                column: "Name",
                value: "About to expire");

            migrationBuilder.UpdateData(
                table: "AccrediteStatuses",
                keyColumn: "Id",
                keyValue: 15,
                column: "Name",
                value: "Exipired");

            migrationBuilder.UpdateData(
                table: "AccrediteStatuses",
                keyColumn: "Id",
                keyValue: 16,
                column: "Name",
                value: "Reaccredited");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AccrediteStatuses",
                keyColumn: "Id",
                keyValue: 8,
                column: "Name",
                value: "Requires review");

            migrationBuilder.UpdateData(
                table: "AccrediteStatuses",
                keyColumn: "Id",
                keyValue: 9,
                column: "Name",
                value: "Internally reviewed");

            migrationBuilder.UpdateData(
                table: "AccrediteStatuses",
                keyColumn: "Id",
                keyValue: 10,
                column: "Name",
                value: "Externally reviewed");

            migrationBuilder.UpdateData(
                table: "AccrediteStatuses",
                keyColumn: "Id",
                keyValue: 11,
                column: "Name",
                value: "About to expire");

            migrationBuilder.UpdateData(
                table: "AccrediteStatuses",
                keyColumn: "Id",
                keyValue: 12,
                column: "Name",
                value: "Exipired");

            migrationBuilder.UpdateData(
                table: "AccrediteStatuses",
                keyColumn: "Id",
                keyValue: 13,
                column: "Name",
                value: "Reaccredited");

            migrationBuilder.UpdateData(
                table: "AccrediteStatuses",
                keyColumn: "Id",
                keyValue: 14,
                column: "Name",
                value: "Sent back to school for restructuring");

            migrationBuilder.UpdateData(
                table: "AccrediteStatuses",
                keyColumn: "Id",
                keyValue: 15,
                column: "Name",
                value: "back from school");

            migrationBuilder.UpdateData(
                table: "AccrediteStatuses",
                keyColumn: "Id",
                keyValue: 16,
                column: "Name",
                value: "Requires restructuring");
        }
    }
}
