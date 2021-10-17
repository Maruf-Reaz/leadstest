using Microsoft.EntityFrameworkCore.Migrations;

namespace EntityFramworkFirstApp.Migrations
{
    public partial class SemesterAdded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "SemesterId",
                table: "StudentRecords",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Semester",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SemesterName = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Semester", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_StudentRecords_SemesterId",
                table: "StudentRecords",
                column: "SemesterId");

            migrationBuilder.AddForeignKey(
                name: "FK_StudentRecords_Semester_SemesterId",
                table: "StudentRecords",
                column: "SemesterId",
                principalTable: "Semester",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_StudentRecords_Semester_SemesterId",
                table: "StudentRecords");

            migrationBuilder.DropTable(
                name: "Semester");

            migrationBuilder.DropIndex(
                name: "IX_StudentRecords_SemesterId",
                table: "StudentRecords");

            migrationBuilder.DropColumn(
                name: "SemesterId",
                table: "StudentRecords");
        }
    }
}
