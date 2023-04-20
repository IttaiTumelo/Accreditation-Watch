using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Accreditation_Watch.Server.Migrations
{
    /// <inheritdoc />
    public partial class AddedProgramsToTasksTrail2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_Tasks_ProgramId",
                table: "Tasks",
                column: "ProgramId");

            migrationBuilder.AddForeignKey(
                name: "FK_Tasks_Programs_ProgramId",
                table: "Tasks",
                column: "ProgramId",
                principalTable: "Programs",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Tasks_Programs_ProgramId",
                table: "Tasks");

            migrationBuilder.DropIndex(
                name: "IX_Tasks_ProgramId",
                table: "Tasks");
        }
    }
}
