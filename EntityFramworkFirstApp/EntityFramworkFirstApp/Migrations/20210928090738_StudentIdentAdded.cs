using Microsoft.EntityFrameworkCore.Migrations;

namespace EntityFramworkFirstApp.Migrations
{
    public partial class StudentIdentAdded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "StudentIdentificationNumber",
                table: "StudentRecords",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "StudentIdentificationNumber",
                table: "StudentRecords");
        }
    }
}
