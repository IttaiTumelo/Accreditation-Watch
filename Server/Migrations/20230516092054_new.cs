using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Accreditation_Watch.Server.Migrations
{
    /// <inheritdoc />
    public partial class @new : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AWTask_AWDocuments_DocumentId",
                table: "AWTask");

            migrationBuilder.DropForeignKey(
                name: "FK_Programs_Accredites_AccrediteId",
                table: "Programs");

            migrationBuilder.DropIndex(
                name: "IX_Programs_AccrediteId",
                table: "Programs");

            migrationBuilder.DropIndex(
                name: "IX_AWTask_DocumentId",
                table: "AWTask");

            migrationBuilder.DropColumn(
                name: "AccrediteId",
                table: "Programs");

            migrationBuilder.DropColumn(
                name: "DocumentId",
                table: "AWTask");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "AccrediteId",
                table: "Programs",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "DocumentId",
                table: "AWTask",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Programs_AccrediteId",
                table: "Programs",
                column: "AccrediteId");

            migrationBuilder.CreateIndex(
                name: "IX_AWTask_DocumentId",
                table: "AWTask",
                column: "DocumentId");

            migrationBuilder.AddForeignKey(
                name: "FK_AWTask_AWDocuments_DocumentId",
                table: "AWTask",
                column: "DocumentId",
                principalTable: "AWDocuments",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Programs_Accredites_AccrediteId",
                table: "Programs",
                column: "AccrediteId",
                principalTable: "Accredites",
                principalColumn: "Id");
        }
    }
}
