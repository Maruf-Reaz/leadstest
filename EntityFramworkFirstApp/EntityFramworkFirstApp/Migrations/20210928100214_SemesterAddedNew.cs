using Microsoft.EntityFrameworkCore.Migrations;

namespace EntityFramworkFirstApp.Migrations
{
    public partial class SemesterAddedNew : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_StudentRecords_Semester_SemesterId",
                table: "StudentRecords");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Semester",
                table: "Semester");

            migrationBuilder.RenameTable(
                name: "Semester",
                newName: "Semesters");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Semesters",
                table: "Semesters",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_StudentRecords_Semesters_SemesterId",
                table: "StudentRecords",
                column: "SemesterId",
                principalTable: "Semesters",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_StudentRecords_Semesters_SemesterId",
                table: "StudentRecords");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Semesters",
                table: "Semesters");

            migrationBuilder.RenameTable(
                name: "Semesters",
                newName: "Semester");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Semester",
                table: "Semester",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_StudentRecords_Semester_SemesterId",
                table: "StudentRecords",
                column: "SemesterId",
                principalTable: "Semester",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
