using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Accreditation_Watch.Server.Migrations
{
    /// <inheritdoc />
    public partial class UpdatedRoles : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Tasks_AWDocuments_DocumentId",
                table: "Tasks");

            migrationBuilder.DropForeignKey(
                name: "FK_Tasks_Programs_ProgramId",
                table: "Tasks");

            migrationBuilder.DropForeignKey(
                name: "FK_Tasks_ResultTypes_ResultTypeId",
                table: "Tasks");

            migrationBuilder.DropForeignKey(
                name: "FK_Tasks_TaskTypes_TypeId",
                table: "Tasks");

            migrationBuilder.DropForeignKey(
                name: "FK_Tasks_Users_AssigneeId",
                table: "Tasks");

            migrationBuilder.AlterColumn<int>(
                name: "TypeId",
                table: "Tasks",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "ResultTypeId",
                table: "Tasks",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "ProgramId",
                table: "Tasks",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "DocumentId",
                table: "Tasks",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "AssigneeId",
                table: "Tasks",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_Tasks_AWDocuments_DocumentId",
                table: "Tasks",
                column: "DocumentId",
                principalTable: "AWDocuments",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Tasks_Programs_ProgramId",
                table: "Tasks",
                column: "ProgramId",
                principalTable: "Programs",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Tasks_ResultTypes_ResultTypeId",
                table: "Tasks",
                column: "ResultTypeId",
                principalTable: "ResultTypes",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Tasks_TaskTypes_TypeId",
                table: "Tasks",
                column: "TypeId",
                principalTable: "TaskTypes",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Tasks_Users_AssigneeId",
                table: "Tasks",
                column: "AssigneeId",
                principalTable: "Users",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Tasks_AWDocuments_DocumentId",
                table: "Tasks");

            migrationBuilder.DropForeignKey(
                name: "FK_Tasks_Programs_ProgramId",
                table: "Tasks");

            migrationBuilder.DropForeignKey(
                name: "FK_Tasks_ResultTypes_ResultTypeId",
                table: "Tasks");

            migrationBuilder.DropForeignKey(
                name: "FK_Tasks_TaskTypes_TypeId",
                table: "Tasks");

            migrationBuilder.DropForeignKey(
                name: "FK_Tasks_Users_AssigneeId",
                table: "Tasks");

            migrationBuilder.AlterColumn<int>(
                name: "TypeId",
                table: "Tasks",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "ResultTypeId",
                table: "Tasks",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "ProgramId",
                table: "Tasks",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "DocumentId",
                table: "Tasks",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "AssigneeId",
                table: "Tasks",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Tasks_AWDocuments_DocumentId",
                table: "Tasks",
                column: "DocumentId",
                principalTable: "AWDocuments",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Tasks_Programs_ProgramId",
                table: "Tasks",
                column: "ProgramId",
                principalTable: "Programs",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Tasks_ResultTypes_ResultTypeId",
                table: "Tasks",
                column: "ResultTypeId",
                principalTable: "ResultTypes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Tasks_TaskTypes_TypeId",
                table: "Tasks",
                column: "TypeId",
                principalTable: "TaskTypes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Tasks_Users_AssigneeId",
                table: "Tasks",
                column: "AssigneeId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
