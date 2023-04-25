using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Accreditation_Watch.Server.Migrations
{
    /// <inheritdoc />
    public partial class progress45 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AccrediteStatuses",
                keyColumn: "Id",
                keyValue: 12,
                column: "Name",
                value: "About to expire");

            migrationBuilder.UpdateData(
                table: "AccrediteStatuses",
                keyColumn: "Id",
                keyValue: 13,
                column: "Name",
                value: "Exipired");

            migrationBuilder.UpdateData(
                table: "AccrediteStatuses",
                keyColumn: "Id",
                keyValue: 14,
                column: "Name",
                value: "Internally reviewed");

            migrationBuilder.UpdateData(
                table: "AccrediteStatuses",
                keyColumn: "Id",
                keyValue: 15,
                column: "Name",
                value: "Externally reviewed");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
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
        }
    }
}
