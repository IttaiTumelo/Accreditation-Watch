using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Accreditation_Watch.Server.Migrations
{
    /// <inheritdoc />
    public partial class AddingPoblmenProgramtoNote2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Notes_AWTask_AWTaskId",
                table: "Notes");

            migrationBuilder.DropForeignKey(
                name: "FK_Notes_Programs_ProgramId",
                table: "Notes");

            migrationBuilder.RenameColumn(
                name: "AWTaskId",
                table: "Notes",
                newName: "TaskId");

            migrationBuilder.RenameIndex(
                name: "IX_Notes_AWTaskId",
                table: "Notes",
                newName: "IX_Notes_TaskId");

            migrationBuilder.AlterColumn<int>(
                name: "ProgramId",
                table: "Notes",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<int>(
                name: "ProblemId",
                table: "Notes",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Notes_ProblemId",
                table: "Notes",
                column: "ProblemId");

            migrationBuilder.AddForeignKey(
                name: "FK_Notes_AWTask_TaskId",
                table: "Notes",
                column: "TaskId",
                principalTable: "AWTask",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Notes_Problems_ProblemId",
                table: "Notes",
                column: "ProblemId",
                principalTable: "Problems",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Notes_Programs_ProgramId",
                table: "Notes",
                column: "ProgramId",
                principalTable: "Programs",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Notes_AWTask_TaskId",
                table: "Notes");

            migrationBuilder.DropForeignKey(
                name: "FK_Notes_Problems_ProblemId",
                table: "Notes");

            migrationBuilder.DropForeignKey(
                name: "FK_Notes_Programs_ProgramId",
                table: "Notes");

            migrationBuilder.DropIndex(
                name: "IX_Notes_ProblemId",
                table: "Notes");

            migrationBuilder.DropColumn(
                name: "ProblemId",
                table: "Notes");

            migrationBuilder.RenameColumn(
                name: "TaskId",
                table: "Notes",
                newName: "AWTaskId");

            migrationBuilder.RenameIndex(
                name: "IX_Notes_TaskId",
                table: "Notes",
                newName: "IX_Notes_AWTaskId");

            migrationBuilder.AlterColumn<int>(
                name: "ProgramId",
                table: "Notes",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Notes_AWTask_AWTaskId",
                table: "Notes",
                column: "AWTaskId",
                principalTable: "AWTask",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Notes_Programs_ProgramId",
                table: "Notes",
                column: "ProgramId",
                principalTable: "Programs",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
