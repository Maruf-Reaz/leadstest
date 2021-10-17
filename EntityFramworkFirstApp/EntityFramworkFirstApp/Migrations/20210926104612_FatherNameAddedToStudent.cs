using Microsoft.EntityFrameworkCore.Migrations;

namespace EntityFramworkFirstApp.Migrations
{
    public partial class FatherNameAddedToStudent : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "FathersName",
                table: "StudentRecords",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "FathersName",
                table: "StudentRecords");
        }
    }
}
