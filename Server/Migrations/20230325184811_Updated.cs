using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Accreditation_Watch.Server.Migrations
{
    /// <inheritdoc />
    public partial class Updated : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Programs_Departments_DepartmentId",
                table: "Programs");

            migrationBuilder.DropForeignKey(
                name: "FK_Programs_Statuses_StatusId",
                table: "Programs");

            migrationBuilder.AlterColumn<int>(
                name: "StatusId",
                table: "Programs",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "DepartmentId",
                table: "Programs",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "Programs",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ValidFrom", "ValidTo" },
                values: new object[] { new DateTime(2023, 3, 25, 20, 48, 10, 891, DateTimeKind.Local).AddTicks(5055), new DateTime(2023, 3, 25, 20, 48, 10, 891, DateTimeKind.Local).AddTicks(5056) });

            migrationBuilder.UpdateData(
                table: "Programs",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ValidFrom", "ValidTo" },
                values: new object[] { new DateTime(2023, 3, 25, 20, 48, 10, 891, DateTimeKind.Local).AddTicks(5061), new DateTime(2023, 3, 25, 20, 48, 10, 891, DateTimeKind.Local).AddTicks(5062) });

            migrationBuilder.UpdateData(
                table: "Programs",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "ValidFrom", "ValidTo" },
                values: new object[] { new DateTime(2023, 3, 25, 20, 48, 10, 891, DateTimeKind.Local).AddTicks(5065), new DateTime(2023, 3, 25, 20, 48, 10, 891, DateTimeKind.Local).AddTicks(5066) });

            migrationBuilder.UpdateData(
                table: "Programs",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "ValidFrom", "ValidTo" },
                values: new object[] { new DateTime(2023, 3, 25, 20, 48, 10, 891, DateTimeKind.Local).AddTicks(5070), new DateTime(2023, 3, 25, 20, 48, 10, 891, DateTimeKind.Local).AddTicks(5070) });

            migrationBuilder.UpdateData(
                table: "Programs",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "ValidFrom", "ValidTo" },
                values: new object[] { new DateTime(2023, 3, 25, 20, 48, 10, 891, DateTimeKind.Local).AddTicks(5073), new DateTime(2023, 3, 25, 20, 48, 10, 891, DateTimeKind.Local).AddTicks(5074) });

            migrationBuilder.UpdateData(
                table: "Programs",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "ValidFrom", "ValidTo" },
                values: new object[] { new DateTime(2023, 3, 25, 20, 48, 10, 891, DateTimeKind.Local).AddTicks(5076), new DateTime(2023, 3, 25, 20, 48, 10, 891, DateTimeKind.Local).AddTicks(5077) });

            migrationBuilder.UpdateData(
                table: "Programs",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "ValidFrom", "ValidTo" },
                values: new object[] { new DateTime(2023, 3, 25, 20, 48, 10, 891, DateTimeKind.Local).AddTicks(5080), new DateTime(2023, 3, 25, 20, 48, 10, 891, DateTimeKind.Local).AddTicks(5081) });

            migrationBuilder.UpdateData(
                table: "Programs",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "ValidFrom", "ValidTo" },
                values: new object[] { new DateTime(2023, 3, 25, 20, 48, 10, 891, DateTimeKind.Local).AddTicks(5083), new DateTime(2023, 3, 25, 20, 48, 10, 891, DateTimeKind.Local).AddTicks(5084) });

            migrationBuilder.UpdateData(
                table: "Programs",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "ValidFrom", "ValidTo" },
                values: new object[] { new DateTime(2023, 3, 25, 20, 48, 10, 891, DateTimeKind.Local).AddTicks(5087), new DateTime(2023, 3, 25, 20, 48, 10, 891, DateTimeKind.Local).AddTicks(5088) });

            migrationBuilder.UpdateData(
                table: "Programs",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "ValidFrom", "ValidTo" },
                values: new object[] { new DateTime(2023, 3, 25, 20, 48, 10, 891, DateTimeKind.Local).AddTicks(5090), new DateTime(2023, 3, 25, 20, 48, 10, 891, DateTimeKind.Local).AddTicks(5091) });

            migrationBuilder.UpdateData(
                table: "Programs",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "ValidFrom", "ValidTo" },
                values: new object[] { new DateTime(2023, 3, 25, 20, 48, 10, 891, DateTimeKind.Local).AddTicks(5094), new DateTime(2023, 3, 25, 20, 48, 10, 891, DateTimeKind.Local).AddTicks(5095) });

            migrationBuilder.UpdateData(
                table: "Programs",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "ValidFrom", "ValidTo" },
                values: new object[] { new DateTime(2023, 3, 25, 20, 48, 10, 891, DateTimeKind.Local).AddTicks(5097), new DateTime(2023, 3, 25, 20, 48, 10, 891, DateTimeKind.Local).AddTicks(5098) });

            migrationBuilder.UpdateData(
                table: "Programs",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "ValidFrom", "ValidTo" },
                values: new object[] { new DateTime(2023, 3, 25, 20, 48, 10, 891, DateTimeKind.Local).AddTicks(5101), new DateTime(2023, 3, 25, 20, 48, 10, 891, DateTimeKind.Local).AddTicks(5102) });

            migrationBuilder.UpdateData(
                table: "Programs",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "ValidFrom", "ValidTo" },
                values: new object[] { new DateTime(2023, 3, 25, 20, 48, 10, 891, DateTimeKind.Local).AddTicks(5104), new DateTime(2023, 3, 25, 20, 48, 10, 891, DateTimeKind.Local).AddTicks(5105) });

            migrationBuilder.UpdateData(
                table: "Programs",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "ValidFrom", "ValidTo" },
                values: new object[] { new DateTime(2023, 3, 25, 20, 48, 10, 891, DateTimeKind.Local).AddTicks(5108), new DateTime(2023, 3, 25, 20, 48, 10, 891, DateTimeKind.Local).AddTicks(5109) });

            migrationBuilder.UpdateData(
                table: "Programs",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "ValidFrom", "ValidTo" },
                values: new object[] { new DateTime(2023, 3, 25, 20, 48, 10, 891, DateTimeKind.Local).AddTicks(5112), new DateTime(2023, 3, 25, 20, 48, 10, 891, DateTimeKind.Local).AddTicks(5112) });

            migrationBuilder.UpdateData(
                table: "Programs",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "ValidFrom", "ValidTo" },
                values: new object[] { new DateTime(2023, 3, 25, 20, 48, 10, 891, DateTimeKind.Local).AddTicks(5115), new DateTime(2023, 3, 25, 20, 48, 10, 891, DateTimeKind.Local).AddTicks(5116) });

            migrationBuilder.UpdateData(
                table: "Programs",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "ValidFrom", "ValidTo" },
                values: new object[] { new DateTime(2023, 3, 25, 20, 48, 10, 891, DateTimeKind.Local).AddTicks(5118), new DateTime(2023, 3, 25, 20, 48, 10, 891, DateTimeKind.Local).AddTicks(5119) });

            migrationBuilder.UpdateData(
                table: "Programs",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "ValidFrom", "ValidTo" },
                values: new object[] { new DateTime(2023, 3, 25, 20, 48, 10, 891, DateTimeKind.Local).AddTicks(5122), new DateTime(2023, 3, 25, 20, 48, 10, 891, DateTimeKind.Local).AddTicks(5123) });

            migrationBuilder.UpdateData(
                table: "Programs",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "ValidFrom", "ValidTo" },
                values: new object[] { new DateTime(2023, 3, 25, 20, 48, 10, 891, DateTimeKind.Local).AddTicks(5126), new DateTime(2023, 3, 25, 20, 48, 10, 891, DateTimeKind.Local).AddTicks(5127) });

            migrationBuilder.UpdateData(
                table: "Programs",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "ValidFrom", "ValidTo" },
                values: new object[] { new DateTime(2023, 3, 25, 20, 48, 10, 891, DateTimeKind.Local).AddTicks(5130), new DateTime(2023, 3, 25, 20, 48, 10, 891, DateTimeKind.Local).AddTicks(5131) });

            migrationBuilder.UpdateData(
                table: "Programs",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "ValidFrom", "ValidTo" },
                values: new object[] { new DateTime(2023, 3, 25, 20, 48, 10, 891, DateTimeKind.Local).AddTicks(5136), new DateTime(2023, 3, 25, 20, 48, 10, 891, DateTimeKind.Local).AddTicks(5136) });

            migrationBuilder.UpdateData(
                table: "Programs",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "ValidFrom", "ValidTo" },
                values: new object[] { new DateTime(2023, 3, 25, 20, 48, 10, 891, DateTimeKind.Local).AddTicks(5139), new DateTime(2023, 3, 25, 20, 48, 10, 891, DateTimeKind.Local).AddTicks(5140) });

            migrationBuilder.AddForeignKey(
                name: "FK_Programs_Departments_DepartmentId",
                table: "Programs",
                column: "DepartmentId",
                principalTable: "Departments",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Programs_Statuses_StatusId",
                table: "Programs",
                column: "StatusId",
                principalTable: "Statuses",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Programs_Departments_DepartmentId",
                table: "Programs");

            migrationBuilder.DropForeignKey(
                name: "FK_Programs_Statuses_StatusId",
                table: "Programs");

            migrationBuilder.AlterColumn<int>(
                name: "StatusId",
                table: "Programs",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "DepartmentId",
                table: "Programs",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.UpdateData(
                table: "Programs",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ValidFrom", "ValidTo" },
                values: new object[] { new DateTime(2023, 3, 24, 8, 32, 14, 361, DateTimeKind.Local).AddTicks(8673), new DateTime(2023, 3, 24, 8, 32, 14, 361, DateTimeKind.Local).AddTicks(8678) });

            migrationBuilder.UpdateData(
                table: "Programs",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ValidFrom", "ValidTo" },
                values: new object[] { new DateTime(2023, 3, 24, 8, 32, 14, 361, DateTimeKind.Local).AddTicks(8681), new DateTime(2023, 3, 24, 8, 32, 14, 361, DateTimeKind.Local).AddTicks(8683) });

            migrationBuilder.UpdateData(
                table: "Programs",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "ValidFrom", "ValidTo" },
                values: new object[] { new DateTime(2023, 3, 24, 8, 32, 14, 361, DateTimeKind.Local).AddTicks(8686), new DateTime(2023, 3, 24, 8, 32, 14, 361, DateTimeKind.Local).AddTicks(8686) });

            migrationBuilder.UpdateData(
                table: "Programs",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "ValidFrom", "ValidTo" },
                values: new object[] { new DateTime(2023, 3, 24, 8, 32, 14, 361, DateTimeKind.Local).AddTicks(8689), new DateTime(2023, 3, 24, 8, 32, 14, 361, DateTimeKind.Local).AddTicks(8690) });

            migrationBuilder.UpdateData(
                table: "Programs",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "ValidFrom", "ValidTo" },
                values: new object[] { new DateTime(2023, 3, 24, 8, 32, 14, 361, DateTimeKind.Local).AddTicks(8693), new DateTime(2023, 3, 24, 8, 32, 14, 361, DateTimeKind.Local).AddTicks(8694) });

            migrationBuilder.UpdateData(
                table: "Programs",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "ValidFrom", "ValidTo" },
                values: new object[] { new DateTime(2023, 3, 24, 8, 32, 14, 361, DateTimeKind.Local).AddTicks(8696), new DateTime(2023, 3, 24, 8, 32, 14, 361, DateTimeKind.Local).AddTicks(8697) });

            migrationBuilder.UpdateData(
                table: "Programs",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "ValidFrom", "ValidTo" },
                values: new object[] { new DateTime(2023, 3, 24, 8, 32, 14, 361, DateTimeKind.Local).AddTicks(8700), new DateTime(2023, 3, 24, 8, 32, 14, 361, DateTimeKind.Local).AddTicks(8701) });

            migrationBuilder.UpdateData(
                table: "Programs",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "ValidFrom", "ValidTo" },
                values: new object[] { new DateTime(2023, 3, 24, 8, 32, 14, 361, DateTimeKind.Local).AddTicks(8703), new DateTime(2023, 3, 24, 8, 32, 14, 361, DateTimeKind.Local).AddTicks(8704) });

            migrationBuilder.UpdateData(
                table: "Programs",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "ValidFrom", "ValidTo" },
                values: new object[] { new DateTime(2023, 3, 24, 8, 32, 14, 361, DateTimeKind.Local).AddTicks(8707), new DateTime(2023, 3, 24, 8, 32, 14, 361, DateTimeKind.Local).AddTicks(8708) });

            migrationBuilder.UpdateData(
                table: "Programs",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "ValidFrom", "ValidTo" },
                values: new object[] { new DateTime(2023, 3, 24, 8, 32, 14, 361, DateTimeKind.Local).AddTicks(8711), new DateTime(2023, 3, 24, 8, 32, 14, 361, DateTimeKind.Local).AddTicks(8711) });

            migrationBuilder.UpdateData(
                table: "Programs",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "ValidFrom", "ValidTo" },
                values: new object[] { new DateTime(2023, 3, 24, 8, 32, 14, 361, DateTimeKind.Local).AddTicks(8714), new DateTime(2023, 3, 24, 8, 32, 14, 361, DateTimeKind.Local).AddTicks(8715) });

            migrationBuilder.UpdateData(
                table: "Programs",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "ValidFrom", "ValidTo" },
                values: new object[] { new DateTime(2023, 3, 24, 8, 32, 14, 361, DateTimeKind.Local).AddTicks(8718), new DateTime(2023, 3, 24, 8, 32, 14, 361, DateTimeKind.Local).AddTicks(8719) });

            migrationBuilder.UpdateData(
                table: "Programs",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "ValidFrom", "ValidTo" },
                values: new object[] { new DateTime(2023, 3, 24, 8, 32, 14, 361, DateTimeKind.Local).AddTicks(8721), new DateTime(2023, 3, 24, 8, 32, 14, 361, DateTimeKind.Local).AddTicks(8722) });

            migrationBuilder.UpdateData(
                table: "Programs",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "ValidFrom", "ValidTo" },
                values: new object[] { new DateTime(2023, 3, 24, 8, 32, 14, 361, DateTimeKind.Local).AddTicks(8725), new DateTime(2023, 3, 24, 8, 32, 14, 361, DateTimeKind.Local).AddTicks(8726) });

            migrationBuilder.UpdateData(
                table: "Programs",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "ValidFrom", "ValidTo" },
                values: new object[] { new DateTime(2023, 3, 24, 8, 32, 14, 361, DateTimeKind.Local).AddTicks(8728), new DateTime(2023, 3, 24, 8, 32, 14, 361, DateTimeKind.Local).AddTicks(8731) });

            migrationBuilder.UpdateData(
                table: "Programs",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "ValidFrom", "ValidTo" },
                values: new object[] { new DateTime(2023, 3, 24, 8, 32, 14, 361, DateTimeKind.Local).AddTicks(8733), new DateTime(2023, 3, 24, 8, 32, 14, 361, DateTimeKind.Local).AddTicks(8734) });

            migrationBuilder.UpdateData(
                table: "Programs",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "ValidFrom", "ValidTo" },
                values: new object[] { new DateTime(2023, 3, 24, 8, 32, 14, 361, DateTimeKind.Local).AddTicks(8737), new DateTime(2023, 3, 24, 8, 32, 14, 361, DateTimeKind.Local).AddTicks(8738) });

            migrationBuilder.UpdateData(
                table: "Programs",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "ValidFrom", "ValidTo" },
                values: new object[] { new DateTime(2023, 3, 24, 8, 32, 14, 361, DateTimeKind.Local).AddTicks(8741), new DateTime(2023, 3, 24, 8, 32, 14, 361, DateTimeKind.Local).AddTicks(8741) });

            migrationBuilder.UpdateData(
                table: "Programs",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "ValidFrom", "ValidTo" },
                values: new object[] { new DateTime(2023, 3, 24, 8, 32, 14, 361, DateTimeKind.Local).AddTicks(8744), new DateTime(2023, 3, 24, 8, 32, 14, 361, DateTimeKind.Local).AddTicks(8745) });

            migrationBuilder.UpdateData(
                table: "Programs",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "ValidFrom", "ValidTo" },
                values: new object[] { new DateTime(2023, 3, 24, 8, 32, 14, 361, DateTimeKind.Local).AddTicks(8748), new DateTime(2023, 3, 24, 8, 32, 14, 361, DateTimeKind.Local).AddTicks(8749) });

            migrationBuilder.UpdateData(
                table: "Programs",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "ValidFrom", "ValidTo" },
                values: new object[] { new DateTime(2023, 3, 24, 8, 32, 14, 361, DateTimeKind.Local).AddTicks(8751), new DateTime(2023, 3, 24, 8, 32, 14, 361, DateTimeKind.Local).AddTicks(8752) });

            migrationBuilder.UpdateData(
                table: "Programs",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "ValidFrom", "ValidTo" },
                values: new object[] { new DateTime(2023, 3, 24, 8, 32, 14, 361, DateTimeKind.Local).AddTicks(8755), new DateTime(2023, 3, 24, 8, 32, 14, 361, DateTimeKind.Local).AddTicks(8756) });

            migrationBuilder.UpdateData(
                table: "Programs",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "ValidFrom", "ValidTo" },
                values: new object[] { new DateTime(2023, 3, 24, 8, 32, 14, 361, DateTimeKind.Local).AddTicks(8758), new DateTime(2023, 3, 24, 8, 32, 14, 361, DateTimeKind.Local).AddTicks(8759) });

            migrationBuilder.AddForeignKey(
                name: "FK_Programs_Departments_DepartmentId",
                table: "Programs",
                column: "DepartmentId",
                principalTable: "Departments",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Programs_Statuses_StatusId",
                table: "Programs",
                column: "StatusId",
                principalTable: "Statuses",
                principalColumn: "Id");
        }
    }
}
