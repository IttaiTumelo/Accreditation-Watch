using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Accreditation_Watch.Server.Migrations
{
    /// <inheritdoc />
    public partial class Initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AccrediteStatuses",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AccrediteStatuses", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AccrediteTypes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AccrediteTypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AWDocuments",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Path = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Type = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Status = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Progress = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TaskType = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Role = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TaskId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UserId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AWDocuments", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Feedbacks",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Message = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Feedbacks", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ResultTypes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ResultTypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Roles",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Roles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Schools",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Schools", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Statuses",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Statuses", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TaskTypes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TaskTypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Accredites",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AccrediteName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TypeId = table.Column<int>(type: "int", nullable: false),
                    AccrediteStatusId = table.Column<int>(type: "int", nullable: false),
                    AccrediteDate = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AccrediteExpirationDate = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AccrediteURL = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AccrediteNotes = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AccrediteContact = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Accredites", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Accredites_AccrediteStatuses_AccrediteStatusId",
                        column: x => x.AccrediteStatusId,
                        principalTable: "AccrediteStatuses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Accredites_AccrediteTypes_TypeId",
                        column: x => x.TypeId,
                        principalTable: "AccrediteTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RoleId = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Users_Roles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "Roles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Departments",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SchoolId = table.Column<int>(type: "int", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Departments", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Departments_Schools_SchoolId",
                        column: x => x.SchoolId,
                        principalTable: "Schools",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Tasks",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AssigneeId = table.Column<int>(type: "int", nullable: false),
                    Due = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Progress = table.Column<int>(type: "int", nullable: false),
                    TypeId = table.Column<int>(type: "int", nullable: false),
                    DocumentId = table.Column<int>(type: "int", nullable: false),
                    ResultTypeId = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tasks", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Tasks_AWDocuments_DocumentId",
                        column: x => x.DocumentId,
                        principalTable: "AWDocuments",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Tasks_ResultTypes_ResultTypeId",
                        column: x => x.ResultTypeId,
                        principalTable: "ResultTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Tasks_TaskTypes_TypeId",
                        column: x => x.TypeId,
                        principalTable: "TaskTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Tasks_Users_AssigneeId",
                        column: x => x.AssigneeId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Programs",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StatusId = table.Column<int>(type: "int", nullable: true),
                    DepartmentId = table.Column<int>(type: "int", nullable: true),
                    ValidFrom = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ValidTo = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsAccredited = table.Column<bool>(type: "bit", nullable: false),
                    AccrediteId = table.Column<int>(type: "int", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Programs", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Programs_Accredites_AccrediteId",
                        column: x => x.AccrediteId,
                        principalTable: "Accredites",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Programs_Departments_DepartmentId",
                        column: x => x.DepartmentId,
                        principalTable: "Departments",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Programs_Statuses_StatusId",
                        column: x => x.StatusId,
                        principalTable: "Statuses",
                        principalColumn: "Id");
                });

            migrationBuilder.InsertData(
                table: "AccrediteStatuses",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "CAD_REJECTED" },
                    { 2, "SENATE_REJECTED" },
                    { 3, "REVISION_REQUIRED" },
                    { 4, "UNDER_REVIEW" },
                    { 5, "CAD_APPROVED" },
                    { 6, "PENDING" },
                    { 7, "HEA_APPROVED" },
                    { 8, "HEA_REJECTED" },
                    { 9, "CAD_APPROVED_WITH_CONDITIONS" },
                    { 10, "CAD_APPROVED_WITH_CONDITIONS_AND_REVISIONS" },
                    { 11, "SUBMITTED" },
                    { 12, "ACCREDITED" },
                    { 13, "DENIED" },
                    { 14, "NOT_APPLICABLE" },
                    { 15, "UNDER_INTERNAL_EVALUATION" },
                    { 16, "EVALUATED" }
                });

            migrationBuilder.InsertData(
                table: "AccrediteTypes",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Accredited" },
                    { 2, "Provisional" },
                    { 3, "Denied" },
                    { 4, "Withdrawn" },
                    { 5, "NotApplicable" }
                });

            migrationBuilder.InsertData(
                table: "ResultTypes",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Pass" },
                    { 2, "Fail" },
                    { 3, "Not_Applicable" }
                });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Admin" },
                    { 2, "User" },
                    { 3, "Developer" }
                });

            migrationBuilder.InsertData(
                table: "Schools",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "School of Business" },
                    { 2, "School of Education" },
                    { 3, "School of Engineering" },
                    { 4, "School of Health Sciences" },
                    { 5, "School of Humanities and Social Sciences" },
                    { 6, "School of Natural Sciences" },
                    { 7, "School of Nursing" },
                    { 8, "School of Pharmacy" },
                    { 9, "School of Public Health" },
                    { 10, "School of Social Work" }
                });

            migrationBuilder.InsertData(
                table: "Statuses",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Pending" },
                    { 2, "Approved" },
                    { 3, "Rejected" },
                    { 4, "Expired" }
                });

            migrationBuilder.InsertData(
                table: "TaskTypes",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Accreditation" },
                    { 2, "Internal_Audit" },
                    { 3, "External_Audit" },
                    { 4, "Reaccreditation" }
                });

            migrationBuilder.InsertData(
                table: "Departments",
                columns: new[] { "Id", "Name", "SchoolId" },
                values: new object[,]
                {
                    { 1, "Computer Science", 1 },
                    { 2, "Mathematics", 1 },
                    { 3, "Physics", 1 },
                    { 4, "Chemistry", 1 },
                    { 5, "Biology", 1 },
                    { 6, "English", 1 },
                    { 7, "History", 1 },
                    { 8, "Philosophy", 1 },
                    { 9, "Psychology", 1 },
                    { 10, "Sociology", 1 },
                    { 11, "Economics", 1 },
                    { 12, "Finance", 1 },
                    { 13, "Management", 1 },
                    { 14, "Marketing", 1 },
                    { 15, "Accounting", 1 },
                    { 16, "Mechanical Engineering", 1 },
                    { 17, "Electrical Engineering", 1 },
                    { 18, "Civil Engineering", 1 },
                    { 19, "Chemical Engineering", 1 },
                    { 20, "Computer Engineering", 1 },
                    { 21, "Nursing", 1 },
                    { 22, "Health Science", 1 },
                    { 23, "Health Administration", 1 }
                });

            migrationBuilder.InsertData(
                table: "Programs",
                columns: new[] { "Id", "AccrediteId", "DepartmentId", "IsAccredited", "Name", "StatusId", "ValidFrom", "ValidTo" },
                values: new object[,]
                {
                    { 1, null, 1, true, "Biology", 1, new DateTime(2023, 3, 15, 16, 3, 45, 149, DateTimeKind.Local).AddTicks(2284), new DateTime(2023, 3, 15, 16, 3, 45, 149, DateTimeKind.Local).AddTicks(2302) },
                    { 2, null, 1, true, "Chemistry", 2, new DateTime(2023, 3, 15, 16, 3, 45, 149, DateTimeKind.Local).AddTicks(2306), new DateTime(2023, 3, 15, 16, 3, 45, 149, DateTimeKind.Local).AddTicks(2307) },
                    { 3, null, 1, true, "Computer Science", 3, new DateTime(2023, 3, 15, 16, 3, 45, 149, DateTimeKind.Local).AddTicks(2310), new DateTime(2023, 3, 15, 16, 3, 45, 149, DateTimeKind.Local).AddTicks(2311) },
                    { 4, null, 1, true, "Mathematics", 3, new DateTime(2023, 3, 15, 16, 3, 45, 149, DateTimeKind.Local).AddTicks(2313), new DateTime(2023, 3, 15, 16, 3, 45, 149, DateTimeKind.Local).AddTicks(2314) },
                    { 5, null, 1, true, "Physics", 3, new DateTime(2023, 3, 15, 16, 3, 45, 149, DateTimeKind.Local).AddTicks(2316), new DateTime(2023, 3, 15, 16, 3, 45, 149, DateTimeKind.Local).AddTicks(2317) },
                    { 6, null, 1, true, "Psychology", 2, new DateTime(2023, 3, 15, 16, 3, 45, 149, DateTimeKind.Local).AddTicks(2319), new DateTime(2023, 3, 15, 16, 3, 45, 149, DateTimeKind.Local).AddTicks(2321) },
                    { 7, null, 1, true, "Sociology", 3, new DateTime(2023, 3, 15, 16, 3, 45, 149, DateTimeKind.Local).AddTicks(2323), new DateTime(2023, 3, 15, 16, 3, 45, 149, DateTimeKind.Local).AddTicks(2324) },
                    { 8, null, 1, true, "Statistics", 4, new DateTime(2023, 3, 15, 16, 3, 45, 149, DateTimeKind.Local).AddTicks(2326), new DateTime(2023, 3, 15, 16, 3, 45, 149, DateTimeKind.Local).AddTicks(2327) },
                    { 9, null, 1, true, "Theatre", 1, new DateTime(2023, 3, 15, 16, 3, 45, 149, DateTimeKind.Local).AddTicks(2329), new DateTime(2023, 3, 15, 16, 3, 45, 149, DateTimeKind.Local).AddTicks(2330) },
                    { 10, null, 1, true, "Visual Arts", 1, new DateTime(2023, 3, 15, 16, 3, 45, 149, DateTimeKind.Local).AddTicks(2333), new DateTime(2023, 3, 15, 16, 3, 45, 149, DateTimeKind.Local).AddTicks(2334) },
                    { 11, null, 1, true, "World Languages", 1, new DateTime(2023, 3, 15, 16, 3, 45, 149, DateTimeKind.Local).AddTicks(2336), new DateTime(2023, 3, 15, 16, 3, 45, 149, DateTimeKind.Local).AddTicks(2337) },
                    { 12, null, 1, true, "African American Studies", 2, new DateTime(2023, 3, 15, 16, 3, 45, 149, DateTimeKind.Local).AddTicks(2339), new DateTime(2023, 3, 15, 16, 3, 45, 149, DateTimeKind.Local).AddTicks(2340) },
                    { 13, null, 1, true, "American Studies", 3, new DateTime(2023, 3, 15, 16, 3, 45, 149, DateTimeKind.Local).AddTicks(2342), new DateTime(2023, 3, 15, 16, 3, 45, 149, DateTimeKind.Local).AddTicks(2344) },
                    { 14, null, 1, true, "Anthropology", 4, new DateTime(2023, 3, 15, 16, 3, 45, 149, DateTimeKind.Local).AddTicks(2346), new DateTime(2023, 3, 15, 16, 3, 45, 149, DateTimeKind.Local).AddTicks(2347) },
                    { 15, null, 1, true, "Art History", 1, new DateTime(2023, 3, 15, 16, 3, 45, 149, DateTimeKind.Local).AddTicks(2349), new DateTime(2023, 3, 15, 16, 3, 45, 149, DateTimeKind.Local).AddTicks(2350) },
                    { 16, null, 1, true, "Asian Studies", 1, new DateTime(2023, 3, 15, 16, 3, 45, 149, DateTimeKind.Local).AddTicks(2352), new DateTime(2023, 3, 15, 16, 3, 45, 149, DateTimeKind.Local).AddTicks(2355) },
                    { 17, null, 1, true, "Classics", 1, new DateTime(2023, 3, 15, 16, 3, 45, 149, DateTimeKind.Local).AddTicks(2357), new DateTime(2023, 3, 15, 16, 3, 45, 149, DateTimeKind.Local).AddTicks(2358) },
                    { 18, null, 1, true, "Communication", 1, new DateTime(2023, 3, 15, 16, 3, 45, 149, DateTimeKind.Local).AddTicks(2360), new DateTime(2023, 3, 15, 16, 3, 45, 149, DateTimeKind.Local).AddTicks(2361) },
                    { 19, null, 1, true, "Economics", 1, new DateTime(2023, 3, 15, 16, 3, 45, 149, DateTimeKind.Local).AddTicks(2363), new DateTime(2023, 3, 15, 16, 3, 45, 149, DateTimeKind.Local).AddTicks(2364) },
                    { 20, null, 1, true, "English", 2, new DateTime(2023, 3, 15, 16, 3, 45, 149, DateTimeKind.Local).AddTicks(2366), new DateTime(2023, 3, 15, 16, 3, 45, 149, DateTimeKind.Local).AddTicks(2367) },
                    { 21, null, 1, true, "Environmental Studies", 2, new DateTime(2023, 3, 15, 16, 3, 45, 149, DateTimeKind.Local).AddTicks(2370), new DateTime(2023, 3, 15, 16, 3, 45, 149, DateTimeKind.Local).AddTicks(2371) },
                    { 22, null, 1, true, "European Studies", 2, new DateTime(2023, 3, 15, 16, 3, 45, 149, DateTimeKind.Local).AddTicks(2373), new DateTime(2023, 3, 15, 16, 3, 45, 149, DateTimeKind.Local).AddTicks(2374) },
                    { 23, null, 1, true, "Film Studies", 3, new DateTime(2023, 3, 15, 16, 3, 45, 149, DateTimeKind.Local).AddTicks(2376), new DateTime(2023, 3, 15, 16, 3, 45, 149, DateTimeKind.Local).AddTicks(2377) }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Accredites_AccrediteStatusId",
                table: "Accredites",
                column: "AccrediteStatusId");

            migrationBuilder.CreateIndex(
                name: "IX_Accredites_TypeId",
                table: "Accredites",
                column: "TypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Departments_SchoolId",
                table: "Departments",
                column: "SchoolId");

            migrationBuilder.CreateIndex(
                name: "IX_Programs_AccrediteId",
                table: "Programs",
                column: "AccrediteId");

            migrationBuilder.CreateIndex(
                name: "IX_Programs_DepartmentId",
                table: "Programs",
                column: "DepartmentId");

            migrationBuilder.CreateIndex(
                name: "IX_Programs_StatusId",
                table: "Programs",
                column: "StatusId");

            migrationBuilder.CreateIndex(
                name: "IX_Tasks_AssigneeId",
                table: "Tasks",
                column: "AssigneeId");

            migrationBuilder.CreateIndex(
                name: "IX_Tasks_DocumentId",
                table: "Tasks",
                column: "DocumentId");

            migrationBuilder.CreateIndex(
                name: "IX_Tasks_ResultTypeId",
                table: "Tasks",
                column: "ResultTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Tasks_TypeId",
                table: "Tasks",
                column: "TypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Users_RoleId",
                table: "Users",
                column: "RoleId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Feedbacks");

            migrationBuilder.DropTable(
                name: "Programs");

            migrationBuilder.DropTable(
                name: "Tasks");

            migrationBuilder.DropTable(
                name: "Accredites");

            migrationBuilder.DropTable(
                name: "Departments");

            migrationBuilder.DropTable(
                name: "Statuses");

            migrationBuilder.DropTable(
                name: "AWDocuments");

            migrationBuilder.DropTable(
                name: "ResultTypes");

            migrationBuilder.DropTable(
                name: "TaskTypes");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "AccrediteStatuses");

            migrationBuilder.DropTable(
                name: "AccrediteTypes");

            migrationBuilder.DropTable(
                name: "Schools");

            migrationBuilder.DropTable(
                name: "Roles");
        }
    }
}
