using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Accreditation_Watch.Server.Migrations
{
    /// <inheritdoc />
    public partial class progress2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AccrediteStatuses",
                keyColumn: "Id",
                keyValue: 4,
                column: "Name",
                value: "Pending payment");

            migrationBuilder.UpdateData(
                table: "AccrediteStatuses",
                keyColumn: "Id",
                keyValue: 5,
                column: "Name",
                value: "Accredited");

            migrationBuilder.UpdateData(
                table: "AccrediteStatuses",
                keyColumn: "Id",
                keyValue: 6,
                column: "Name",
                value: "Rejected");

            migrationBuilder.UpdateData(
                table: "AccrediteStatuses",
                keyColumn: "Id",
                keyValue: 7,
                column: "Name",
                value: "Requires restructuring");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AccrediteStatuses",
                keyColumn: "Id",
                keyValue: 4,
                column: "Name",
                value: "Rejected");

            migrationBuilder.UpdateData(
                table: "AccrediteStatuses",
                keyColumn: "Id",
                keyValue: 5,
                column: "Name",
                value: "Requires restructuring");

            migrationBuilder.UpdateData(
                table: "AccrediteStatuses",
                keyColumn: "Id",
                keyValue: 6,
                column: "Name",
                value: "Pending payment");

            migrationBuilder.UpdateData(
                table: "AccrediteStatuses",
                keyColumn: "Id",
                keyValue: 7,
                column: "Name",
                value: "Accredited");
        }
    }
}
