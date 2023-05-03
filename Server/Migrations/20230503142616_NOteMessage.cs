using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Accreditation_Watch.Server.Migrations
{
    /// <inheritdoc />
    public partial class NOteMessage : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CreatorId",
                table: "Notes",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "NoteMessages",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Content = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    Time = table.Column<DateTime>(type: "datetime2", nullable: false),
                    NoteId = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NoteMessages", x => x.Id);
                    table.ForeignKey(
                        name: "FK_NoteMessages_Notes_NoteId",
                        column: x => x.NoteId,
                        principalTable: "Notes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_NoteMessages_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Notes_CreatorId",
                table: "Notes",
                column: "CreatorId");

            migrationBuilder.CreateIndex(
                name: "IX_NoteMessages_NoteId",
                table: "NoteMessages",
                column: "NoteId");

            migrationBuilder.CreateIndex(
                name: "IX_NoteMessages_UserId",
                table: "NoteMessages",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Notes_Users_CreatorId",
                table: "Notes",
                column: "CreatorId",
                principalTable: "Users",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Notes_Users_CreatorId",
                table: "Notes");

            migrationBuilder.DropTable(
                name: "NoteMessages");

            migrationBuilder.DropIndex(
                name: "IX_Notes_CreatorId",
                table: "Notes");

            migrationBuilder.DropColumn(
                name: "CreatorId",
                table: "Notes");
        }
    }
}
