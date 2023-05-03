using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Accreditation_Watch.Server.Migrations
{
    /// <inheritdoc />
    public partial class AddedProblemBacktoPTask : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_AWTask_ProblemId",
                table: "AWTask",
                column: "ProblemId");

            migrationBuilder.AddForeignKey(
                name: "FK_AWTask_Problems_ProblemId",
                table: "AWTask",
                column: "ProblemId",
                principalTable: "Problems",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AWTask_Problems_ProblemId",
                table: "AWTask");

            migrationBuilder.DropIndex(
                name: "IX_AWTask_ProblemId",
                table: "AWTask");
        }
    }
}
