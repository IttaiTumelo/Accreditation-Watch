using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Accreditation_Watch.Server.Migrations
{
    /// <inheritdoc />
    public partial class third : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "AWTaskId",
                table: "Notes",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Notes_AWTaskId",
                table: "Notes",
                column: "AWTaskId");

            migrationBuilder.AddForeignKey(
                name: "FK_Notes_AWTask_AWTaskId",
                table: "Notes",
                column: "AWTaskId",
                principalTable: "AWTask",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Notes_AWTask_AWTaskId",
                table: "Notes");

            migrationBuilder.DropIndex(
                name: "IX_Notes_AWTaskId",
                table: "Notes");

            migrationBuilder.DropColumn(
                name: "AWTaskId",
                table: "Notes");
        }
    }
}
