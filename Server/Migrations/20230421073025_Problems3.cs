using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Accreditation_Watch.Server.Migrations
{
    /// <inheritdoc />
    public partial class Problems3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "AssignedToId",
                table: "AWTask",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_AWTask_AssignedToId",
                table: "AWTask",
                column: "AssignedToId");

            migrationBuilder.AddForeignKey(
                name: "FK_AWTask_Users_AssignedToId",
                table: "AWTask",
                column: "AssignedToId",
                principalTable: "Users",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AWTask_Users_AssignedToId",
                table: "AWTask");

            migrationBuilder.DropIndex(
                name: "IX_AWTask_AssignedToId",
                table: "AWTask");

            migrationBuilder.DropColumn(
                name: "AssignedToId",
                table: "AWTask");
        }
    }
}
