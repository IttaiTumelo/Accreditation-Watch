using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Accreditation_Watch.Server.Migrations
{
    /// <inheritdoc />
    public partial class AccrediteStatusIdToProgram : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Programs_Statuses_StatusId",
                table: "Programs");

            migrationBuilder.DeleteData(
                table: "Programs",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Programs",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Programs",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Programs",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Programs",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Programs",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Programs",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Programs",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Programs",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Programs",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Programs",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Programs",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Programs",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Programs",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Programs",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Programs",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Programs",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Programs",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Programs",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Programs",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Programs",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Programs",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Programs",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.RenameColumn(
                name: "StatusId",
                table: "Programs",
                newName: "AccrediteStatusId");

            migrationBuilder.RenameIndex(
                name: "IX_Programs_StatusId",
                table: "Programs",
                newName: "IX_Programs_AccrediteStatusId");

            migrationBuilder.AddForeignKey(
                name: "FK_Programs_AccrediteStatuses_AccrediteStatusId",
                table: "Programs",
                column: "AccrediteStatusId",
                principalTable: "AccrediteStatuses",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Programs_AccrediteStatuses_AccrediteStatusId",
                table: "Programs");

            migrationBuilder.RenameColumn(
                name: "AccrediteStatusId",
                table: "Programs",
                newName: "StatusId");

            migrationBuilder.RenameIndex(
                name: "IX_Programs_AccrediteStatusId",
                table: "Programs",
                newName: "IX_Programs_StatusId");

            migrationBuilder.InsertData(
                table: "Programs",
                columns: new[] { "Id", "AccrediteId", "DepartmentId", "IsAccredited", "Name", "StatusId", "ValidFrom", "ValidTo" },
                values: new object[,]
                {
                    { 1, null, 1, true, "Biology", 1, new DateTime(2023, 3, 25, 20, 48, 10, 891, DateTimeKind.Local).AddTicks(5055), new DateTime(2023, 3, 25, 20, 48, 10, 891, DateTimeKind.Local).AddTicks(5056) },
                    { 2, null, 1, true, "Chemistry", 2, new DateTime(2023, 3, 25, 20, 48, 10, 891, DateTimeKind.Local).AddTicks(5061), new DateTime(2023, 3, 25, 20, 48, 10, 891, DateTimeKind.Local).AddTicks(5062) },
                    { 3, null, 1, true, "Computer Science", 3, new DateTime(2023, 3, 25, 20, 48, 10, 891, DateTimeKind.Local).AddTicks(5065), new DateTime(2023, 3, 25, 20, 48, 10, 891, DateTimeKind.Local).AddTicks(5066) },
                    { 4, null, 1, true, "Mathematics", 3, new DateTime(2023, 3, 25, 20, 48, 10, 891, DateTimeKind.Local).AddTicks(5070), new DateTime(2023, 3, 25, 20, 48, 10, 891, DateTimeKind.Local).AddTicks(5070) },
                    { 5, null, 1, true, "Physics", 3, new DateTime(2023, 3, 25, 20, 48, 10, 891, DateTimeKind.Local).AddTicks(5073), new DateTime(2023, 3, 25, 20, 48, 10, 891, DateTimeKind.Local).AddTicks(5074) },
                    { 6, null, 1, true, "Psychology", 2, new DateTime(2023, 3, 25, 20, 48, 10, 891, DateTimeKind.Local).AddTicks(5076), new DateTime(2023, 3, 25, 20, 48, 10, 891, DateTimeKind.Local).AddTicks(5077) },
                    { 7, null, 1, true, "Sociology", 3, new DateTime(2023, 3, 25, 20, 48, 10, 891, DateTimeKind.Local).AddTicks(5080), new DateTime(2023, 3, 25, 20, 48, 10, 891, DateTimeKind.Local).AddTicks(5081) },
                    { 8, null, 1, true, "Statistics", 4, new DateTime(2023, 3, 25, 20, 48, 10, 891, DateTimeKind.Local).AddTicks(5083), new DateTime(2023, 3, 25, 20, 48, 10, 891, DateTimeKind.Local).AddTicks(5084) },
                    { 9, null, 1, true, "Theatre", 1, new DateTime(2023, 3, 25, 20, 48, 10, 891, DateTimeKind.Local).AddTicks(5087), new DateTime(2023, 3, 25, 20, 48, 10, 891, DateTimeKind.Local).AddTicks(5088) },
                    { 10, null, 1, true, "Visual Arts", 1, new DateTime(2023, 3, 25, 20, 48, 10, 891, DateTimeKind.Local).AddTicks(5090), new DateTime(2023, 3, 25, 20, 48, 10, 891, DateTimeKind.Local).AddTicks(5091) },
                    { 11, null, 1, true, "World Languages", 1, new DateTime(2023, 3, 25, 20, 48, 10, 891, DateTimeKind.Local).AddTicks(5094), new DateTime(2023, 3, 25, 20, 48, 10, 891, DateTimeKind.Local).AddTicks(5095) },
                    { 12, null, 1, true, "African American Studies", 2, new DateTime(2023, 3, 25, 20, 48, 10, 891, DateTimeKind.Local).AddTicks(5097), new DateTime(2023, 3, 25, 20, 48, 10, 891, DateTimeKind.Local).AddTicks(5098) },
                    { 13, null, 1, true, "American Studies", 3, new DateTime(2023, 3, 25, 20, 48, 10, 891, DateTimeKind.Local).AddTicks(5101), new DateTime(2023, 3, 25, 20, 48, 10, 891, DateTimeKind.Local).AddTicks(5102) },
                    { 14, null, 1, true, "Anthropology", 4, new DateTime(2023, 3, 25, 20, 48, 10, 891, DateTimeKind.Local).AddTicks(5104), new DateTime(2023, 3, 25, 20, 48, 10, 891, DateTimeKind.Local).AddTicks(5105) },
                    { 15, null, 1, true, "Art History", 1, new DateTime(2023, 3, 25, 20, 48, 10, 891, DateTimeKind.Local).AddTicks(5108), new DateTime(2023, 3, 25, 20, 48, 10, 891, DateTimeKind.Local).AddTicks(5109) },
                    { 16, null, 1, true, "Asian Studies", 1, new DateTime(2023, 3, 25, 20, 48, 10, 891, DateTimeKind.Local).AddTicks(5112), new DateTime(2023, 3, 25, 20, 48, 10, 891, DateTimeKind.Local).AddTicks(5112) },
                    { 17, null, 1, true, "Classics", 1, new DateTime(2023, 3, 25, 20, 48, 10, 891, DateTimeKind.Local).AddTicks(5115), new DateTime(2023, 3, 25, 20, 48, 10, 891, DateTimeKind.Local).AddTicks(5116) },
                    { 18, null, 1, true, "Communication", 1, new DateTime(2023, 3, 25, 20, 48, 10, 891, DateTimeKind.Local).AddTicks(5118), new DateTime(2023, 3, 25, 20, 48, 10, 891, DateTimeKind.Local).AddTicks(5119) },
                    { 19, null, 1, true, "Economics", 1, new DateTime(2023, 3, 25, 20, 48, 10, 891, DateTimeKind.Local).AddTicks(5122), new DateTime(2023, 3, 25, 20, 48, 10, 891, DateTimeKind.Local).AddTicks(5123) },
                    { 20, null, 1, true, "English", 2, new DateTime(2023, 3, 25, 20, 48, 10, 891, DateTimeKind.Local).AddTicks(5126), new DateTime(2023, 3, 25, 20, 48, 10, 891, DateTimeKind.Local).AddTicks(5127) },
                    { 21, null, 1, true, "Environmental Studies", 2, new DateTime(2023, 3, 25, 20, 48, 10, 891, DateTimeKind.Local).AddTicks(5130), new DateTime(2023, 3, 25, 20, 48, 10, 891, DateTimeKind.Local).AddTicks(5131) },
                    { 22, null, 1, true, "European Studies", 2, new DateTime(2023, 3, 25, 20, 48, 10, 891, DateTimeKind.Local).AddTicks(5136), new DateTime(2023, 3, 25, 20, 48, 10, 891, DateTimeKind.Local).AddTicks(5136) },
                    { 23, null, 1, true, "Film Studies", 3, new DateTime(2023, 3, 25, 20, 48, 10, 891, DateTimeKind.Local).AddTicks(5139), new DateTime(2023, 3, 25, 20, 48, 10, 891, DateTimeKind.Local).AddTicks(5140) }
                });

            migrationBuilder.AddForeignKey(
                name: "FK_Programs_Statuses_StatusId",
                table: "Programs",
                column: "StatusId",
                principalTable: "Statuses",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
