using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace StudentCourseApp.Persistence.Migrations
{
    public partial class test2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Students_StudentClass_StudentClassId",
                table: "Students");

            migrationBuilder.AddForeignKey(
                name: "FK_Students_StudentClass_StudentClassId",
                table: "Students",
                column: "StudentClassId",
                principalTable: "StudentClass",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Students_StudentClass_StudentClassId",
                table: "Students");

            migrationBuilder.AddForeignKey(
                name: "FK_Students_StudentClass_StudentClassId",
                table: "Students",
                column: "StudentClassId",
                principalTable: "StudentClass",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
