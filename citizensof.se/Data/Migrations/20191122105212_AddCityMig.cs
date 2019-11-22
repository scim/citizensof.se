using Microsoft.EntityFrameworkCore.Migrations;

namespace citizensof.se.Data.Migrations
{
    public partial class AddCityMig : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "City",
                table: "Members",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "City",
                table: "Members");
        }
    }
}
