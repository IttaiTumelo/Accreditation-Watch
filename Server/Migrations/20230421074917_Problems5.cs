using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Accreditation_Watch.Server.Migrations
{
    /// <inheritdoc />
    public partial class Problems5 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Problems_Programs_AWProgramId",
                table: "Problems");

            migrationBuilder.DropIndex(
                name: "IX_Problems_AWProgramId",
                table: "Problems");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
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
    }
}
