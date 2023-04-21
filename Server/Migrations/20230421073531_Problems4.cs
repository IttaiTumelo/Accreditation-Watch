using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Accreditation_Watch.Server.Migrations
{
    /// <inheritdoc />
    public partial class Problems4 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Problems_Programs_ProgramId",
                table: "Problems");

            migrationBuilder.DropIndex(
                name: "IX_Problems_ProgramId",
                table: "Problems");

            migrationBuilder.DropColumn(
                name: "ProgramId",
                table: "Problems");

            migrationBuilder.AddColumn<int>(
                name: "AWProgramId",
                table: "Problems",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Problems_AWProgramId",
                table: "Problems",
                column: "AWProgramId");

            migrationBuilder.AddForeignKey(
                name: "FK_Problems_Programs_AWProgramId",
                table: "Problems",
                column: "AWProgramId",
                principalTable: "Programs",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Problems_Programs_AWProgramId",
                table: "Problems");

            migrationBuilder.DropIndex(
                name: "IX_Problems_AWProgramId",
                table: "Problems");

            migrationBuilder.DropColumn(
                name: "AWProgramId",
                table: "Problems");

            migrationBuilder.AddColumn<int>(
                name: "ProgramId",
                table: "Problems",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Problems_ProgramId",
                table: "Problems",
                column: "ProgramId");

            migrationBuilder.AddForeignKey(
                name: "FK_Problems_Programs_ProgramId",
                table: "Problems",
                column: "ProgramId",
                principalTable: "Programs",
                principalColumn: "Id");
        }
    }
}
