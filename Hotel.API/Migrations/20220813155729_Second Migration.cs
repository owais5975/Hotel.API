using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Hotel.API.Migrations
{
    public partial class SecondMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CityId",
                table: "Hotels");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CityId",
                table: "Hotels",
                type: "integer",
                nullable: false,
                defaultValue: 0);
        }
    }
}
