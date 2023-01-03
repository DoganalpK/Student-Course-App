using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace StudentCourseApp.Persistence.Migrations
{
    public partial class test3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Students_StudentClass_StudentClassId",
                table: "Students");

            migrationBuilder.DropPrimaryKey(
                name: "PK_StudentClass",
                table: "StudentClass");

            migrationBuilder.RenameTable(
                name: "StudentClass",
                newName: "StudentClasses");

            migrationBuilder.AddPrimaryKey(
                name: "PK_StudentClasses",
                table: "StudentClasses",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Students_StudentClasses_StudentClassId",
                table: "Students",
                column: "StudentClassId",
                principalTable: "StudentClasses",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Students_StudentClasses_StudentClassId",
                table: "Students");

            migrationBuilder.DropPrimaryKey(
                name: "PK_StudentClasses",
                table: "StudentClasses");

            migrationBuilder.RenameTable(
                name: "StudentClasses",
                newName: "StudentClass");

            migrationBuilder.AddPrimaryKey(
                name: "PK_StudentClass",
                table: "StudentClass",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Students_StudentClass_StudentClassId",
                table: "Students",
                column: "StudentClassId",
                principalTable: "StudentClass",
                principalColumn: "Id");
        }
    }
}
