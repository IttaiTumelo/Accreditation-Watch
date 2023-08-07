using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AccreditationWatch.Server.Migrations
{
    /// <inheritdoc />
    public partial class Reminders : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Programs_Reminders_ReminderId",
                table: "Programs");

            migrationBuilder.DropIndex(
                name: "IX_Programs_ReminderId",
                table: "Programs");

            migrationBuilder.DropColumn(
                name: "ReminderId",
                table: "Programs");

            migrationBuilder.AddColumn<int>(
                name: "ProgramId",
                table: "Reminders",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Reminders_ProgramId",
                table: "Reminders",
                column: "ProgramId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Reminders_Programs_ProgramId",
                table: "Reminders",
                column: "ProgramId",
                principalTable: "Programs",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Reminders_Programs_ProgramId",
                table: "Reminders");

            migrationBuilder.DropIndex(
                name: "IX_Reminders_ProgramId",
                table: "Reminders");

            migrationBuilder.DropColumn(
                name: "ProgramId",
                table: "Reminders");

            migrationBuilder.AddColumn<int>(
                name: "ReminderId",
                table: "Programs",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Programs_ReminderId",
                table: "Programs",
                column: "ReminderId");

            migrationBuilder.AddForeignKey(
                name: "FK_Programs_Reminders_ReminderId",
                table: "Programs",
                column: "ReminderId",
                principalTable: "Reminders",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
