using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Accreditation_Watch.Server.Migrations
{
    /// <inheritdoc />
    public partial class AddedOptionalProgramToTask : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ProgramId",
                table: "AWTask",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_AWTask_ProgramId",
                table: "AWTask",
                column: "ProgramId");

            migrationBuilder.AddForeignKey(
                name: "FK_AWTask_Problems_ProgramId",
                table: "AWTask",
                column: "ProgramId",
                principalTable: "Problems",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AWTask_Problems_ProgramId",
                table: "AWTask");

            migrationBuilder.DropIndex(
                name: "IX_AWTask_ProgramId",
                table: "AWTask");

            migrationBuilder.DropColumn(
                name: "ProgramId",
                table: "AWTask");
        }
    }
}
