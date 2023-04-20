using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Accreditation_Watch.Server.Migrations
{
    /// <inheritdoc />
    public partial class Problems : Migration
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

            migrationBuilder.DropPrimaryKey(
                name: "PK_Tasks",
                table: "Tasks");

            migrationBuilder.RenameTable(
                name: "Tasks",
                newName: "AWTask");

            migrationBuilder.RenameColumn(
                name: "ProgramId",
                table: "AWTask",
                newName: "ProblemId");

            migrationBuilder.RenameIndex(
                name: "IX_Tasks_TypeId",
                table: "AWTask",
                newName: "IX_AWTask_TypeId");

            migrationBuilder.RenameIndex(
                name: "IX_Tasks_ResultTypeId",
                table: "AWTask",
                newName: "IX_AWTask_ResultTypeId");

            migrationBuilder.RenameIndex(
                name: "IX_Tasks_ProgramId",
                table: "AWTask",
                newName: "IX_AWTask_ProblemId");

            migrationBuilder.RenameIndex(
                name: "IX_Tasks_DocumentId",
                table: "AWTask",
                newName: "IX_AWTask_DocumentId");

            migrationBuilder.RenameIndex(
                name: "IX_Tasks_AssigneeId",
                table: "AWTask",
                newName: "IX_AWTask_AssigneeId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_AWTask",
                table: "AWTask",
                column: "Id");

            migrationBuilder.CreateTable(
                name: "Problems",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsResolved = table.Column<bool>(type: "bit", nullable: false),
                    ProgramId = table.Column<int>(type: "int", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Problems", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Problems_Programs_ProgramId",
                        column: x => x.ProgramId,
                        principalTable: "Programs",
                        principalColumn: "Id");
                });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 1,
                column: "Name",
                value: "Basic");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 2,
                column: "Name",
                value: "Secondary");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 3,
                column: "Name",
                value: "Directors");

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "IsDeleted", "Name" },
                values: new object[] { 4, false, "Developer" });

            migrationBuilder.CreateIndex(
                name: "IX_Problems_ProgramId",
                table: "Problems",
                column: "ProgramId");

            migrationBuilder.AddForeignKey(
                name: "FK_AWTask_AWDocuments_DocumentId",
                table: "AWTask",
                column: "DocumentId",
                principalTable: "AWDocuments",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_AWTask_Problems_ProblemId",
                table: "AWTask",
                column: "ProblemId",
                principalTable: "Problems",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_AWTask_ResultTypes_ResultTypeId",
                table: "AWTask",
                column: "ResultTypeId",
                principalTable: "ResultTypes",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_AWTask_TaskTypes_TypeId",
                table: "AWTask",
                column: "TypeId",
                principalTable: "TaskTypes",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_AWTask_Users_AssigneeId",
                table: "AWTask",
                column: "AssigneeId",
                principalTable: "Users",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AWTask_AWDocuments_DocumentId",
                table: "AWTask");

            migrationBuilder.DropForeignKey(
                name: "FK_AWTask_Problems_ProblemId",
                table: "AWTask");

            migrationBuilder.DropForeignKey(
                name: "FK_AWTask_ResultTypes_ResultTypeId",
                table: "AWTask");

            migrationBuilder.DropForeignKey(
                name: "FK_AWTask_TaskTypes_TypeId",
                table: "AWTask");

            migrationBuilder.DropForeignKey(
                name: "FK_AWTask_Users_AssigneeId",
                table: "AWTask");

            migrationBuilder.DropTable(
                name: "Problems");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AWTask",
                table: "AWTask");

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.RenameTable(
                name: "AWTask",
                newName: "Tasks");

            migrationBuilder.RenameColumn(
                name: "ProblemId",
                table: "Tasks",
                newName: "ProgramId");

            migrationBuilder.RenameIndex(
                name: "IX_AWTask_TypeId",
                table: "Tasks",
                newName: "IX_Tasks_TypeId");

            migrationBuilder.RenameIndex(
                name: "IX_AWTask_ResultTypeId",
                table: "Tasks",
                newName: "IX_Tasks_ResultTypeId");

            migrationBuilder.RenameIndex(
                name: "IX_AWTask_ProblemId",
                table: "Tasks",
                newName: "IX_Tasks_ProgramId");

            migrationBuilder.RenameIndex(
                name: "IX_AWTask_DocumentId",
                table: "Tasks",
                newName: "IX_Tasks_DocumentId");

            migrationBuilder.RenameIndex(
                name: "IX_AWTask_AssigneeId",
                table: "Tasks",
                newName: "IX_Tasks_AssigneeId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Tasks",
                table: "Tasks",
                column: "Id");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 1,
                column: "Name",
                value: "Admin");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 2,
                column: "Name",
                value: "User");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: 3,
                column: "Name",
                value: "Developer");

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
    }
}
