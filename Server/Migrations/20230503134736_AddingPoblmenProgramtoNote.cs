using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Accreditation_Watch.Server.Migrations
{
    /// <inheritdoc />
    public partial class AddingPoblmenProgramtoNote : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Notes_Programs_AWProgramId",
                table: "Notes");

            migrationBuilder.DropIndex(
                name: "IX_Notes_AWProgramId",
                table: "Notes");

            migrationBuilder.DropColumn(
                name: "AWProgramId",
                table: "Notes");

            migrationBuilder.CreateIndex(
                name: "IX_Notes_ProgramId",
                table: "Notes",
                column: "ProgramId");

            migrationBuilder.AddForeignKey(
                name: "FK_Notes_Programs_ProgramId",
                table: "Notes",
                column: "ProgramId",
                principalTable: "Programs",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Notes_Programs_ProgramId",
                table: "Notes");

            migrationBuilder.DropIndex(
                name: "IX_Notes_ProgramId",
                table: "Notes");

            migrationBuilder.AddColumn<int>(
                name: "AWProgramId",
                table: "Notes",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Notes_AWProgramId",
                table: "Notes",
                column: "AWProgramId");

            migrationBuilder.AddForeignKey(
                name: "FK_Notes_Programs_AWProgramId",
                table: "Notes",
                column: "AWProgramId",
                principalTable: "Programs",
                principalColumn: "Id");
        }
    }
}
