using Microsoft.EntityFrameworkCore.Migrations;

namespace EntityFramworkFirstApp.Migrations
{
    public partial class SectionAdded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "StudentSectionId",
                table: "StudentRecords",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "SectionRecords",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SectionName = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SectionRecords", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_StudentRecords_StudentSectionId",
                table: "StudentRecords",
                column: "StudentSectionId");

            migrationBuilder.AddForeignKey(
                name: "FK_StudentRecords_SectionRecords_StudentSectionId",
                table: "StudentRecords",
                column: "StudentSectionId",
                principalTable: "SectionRecords",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_StudentRecords_SectionRecords_StudentSectionId",
                table: "StudentRecords");

            migrationBuilder.DropTable(
                name: "SectionRecords");

            migrationBuilder.DropIndex(
                name: "IX_StudentRecords_StudentSectionId",
                table: "StudentRecords");

            migrationBuilder.DropColumn(
                name: "StudentSectionId",
                table: "StudentRecords");
        }
    }
}
