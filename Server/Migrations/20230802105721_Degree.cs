using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AccreditationWatch.Server.Migrations
{
    /// <inheritdoc />
    public partial class Degree : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Degree",
                table: "Programs",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Degree",
                table: "Programs");
        }
    }
}
