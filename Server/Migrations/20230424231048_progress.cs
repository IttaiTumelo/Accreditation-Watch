using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Accreditation_Watch.Server.Migrations
{
    /// <inheritdoc />
    public partial class progress : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AccrediteStatuses",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.UpdateData(
                table: "AccrediteStatuses",
                keyColumn: "Id",
                keyValue: 1,
                column: "Name",
                value: "ADC Approved");

            migrationBuilder.UpdateData(
                table: "AccrediteStatuses",
                keyColumn: "Id",
                keyValue: 2,
                column: "Name",
                value: "Submitted to HEA");

            migrationBuilder.UpdateData(
                table: "AccrediteStatuses",
                keyColumn: "Id",
                keyValue: 3,
                column: "Name",
                value: "At ZAQA");

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
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AccrediteStatuses",
                keyColumn: "Id",
                keyValue: 1,
                column: "Name",
                value: "CAD_REJECTED");

            migrationBuilder.UpdateData(
                table: "AccrediteStatuses",
                keyColumn: "Id",
                keyValue: 2,
                column: "Name",
                value: "SENATE_REJECTED");

            migrationBuilder.UpdateData(
                table: "AccrediteStatuses",
                keyColumn: "Id",
                keyValue: 3,
                column: "Name",
                value: "REVISION_REQUIRED");

            migrationBuilder.UpdateData(
                table: "AccrediteStatuses",
                keyColumn: "Id",
                keyValue: 4,
                column: "Name",
                value: "UNDER_REVIEW");

            migrationBuilder.UpdateData(
                table: "AccrediteStatuses",
                keyColumn: "Id",
                keyValue: 5,
                column: "Name",
                value: "CAD_APPROVED");

            migrationBuilder.UpdateData(
                table: "AccrediteStatuses",
                keyColumn: "Id",
                keyValue: 6,
                column: "Name",
                value: "PENDING");

            migrationBuilder.UpdateData(
                table: "AccrediteStatuses",
                keyColumn: "Id",
                keyValue: 7,
                column: "Name",
                value: "HEA_APPROVED");

            migrationBuilder.UpdateData(
                table: "AccrediteStatuses",
                keyColumn: "Id",
                keyValue: 8,
                column: "Name",
                value: "HEA_REJECTED");

            migrationBuilder.UpdateData(
                table: "AccrediteStatuses",
                keyColumn: "Id",
                keyValue: 9,
                column: "Name",
                value: "CAD_APPROVED_WITH_CONDITIONS");

            migrationBuilder.UpdateData(
                table: "AccrediteStatuses",
                keyColumn: "Id",
                keyValue: 10,
                column: "Name",
                value: "CAD_APPROVED_WITH_CONDITIONS_AND_REVISIONS");

            migrationBuilder.UpdateData(
                table: "AccrediteStatuses",
                keyColumn: "Id",
                keyValue: 11,
                column: "Name",
                value: "SUBMITTED");

            migrationBuilder.UpdateData(
                table: "AccrediteStatuses",
                keyColumn: "Id",
                keyValue: 12,
                column: "Name",
                value: "ACCREDITED");

            migrationBuilder.UpdateData(
                table: "AccrediteStatuses",
                keyColumn: "Id",
                keyValue: 13,
                column: "Name",
                value: "DENIED");

            migrationBuilder.UpdateData(
                table: "AccrediteStatuses",
                keyColumn: "Id",
                keyValue: 14,
                column: "Name",
                value: "NOT_APPLICABLE");

            migrationBuilder.UpdateData(
                table: "AccrediteStatuses",
                keyColumn: "Id",
                keyValue: 15,
                column: "Name",
                value: "UNDER_INTERNAL_EVALUATION");

            migrationBuilder.InsertData(
                table: "AccrediteStatuses",
                columns: new[] { "Id", "IsDeleted", "Name" },
                values: new object[] { 16, false, "EVALUATED" });
        }
    }
}
