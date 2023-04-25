using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Accreditation_Watch.Server.Migrations
{
    /// <inheritdoc />
    public partial class progress3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AccrediteStatuses",
                keyColumn: "Id",
                keyValue: 5,
                column: "Name",
                value: "Pending Made");

            migrationBuilder.UpdateData(
                table: "AccrediteStatuses",
                keyColumn: "Id",
                keyValue: 6,
                column: "Name",
                value: "Accredited");

            migrationBuilder.UpdateData(
                table: "AccrediteStatuses",
                keyColumn: "Id",
                keyValue: 7,
                column: "Name",
                value: "Rejected");

            migrationBuilder.InsertData(
                table: "AccrediteStatuses",
                columns: new[] { "Id", "IsDeleted", "Name" },
                values: new object[] { 16, false, "Requires restructuring" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AccrediteStatuses",
                keyColumn: "Id",
                keyValue: 16);

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
    }
}
