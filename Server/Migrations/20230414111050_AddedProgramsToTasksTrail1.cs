using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Accreditation_Watch.Server.Migrations
{
    /// <inheritdoc />
    public partial class AddedProgramsToTasksTrail1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ProgramId",
                table: "Tasks",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ProgramId",
                table: "Tasks");
        }
    }
}
