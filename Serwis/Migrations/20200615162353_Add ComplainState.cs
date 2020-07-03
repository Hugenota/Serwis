using Microsoft.EntityFrameworkCore.Migrations;

namespace Serwis.Migrations
{
    public partial class AddComplainState : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ComplainState",
                table: "Complaints",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ComplainState",
                table: "Complaints");
        }
    }
}
