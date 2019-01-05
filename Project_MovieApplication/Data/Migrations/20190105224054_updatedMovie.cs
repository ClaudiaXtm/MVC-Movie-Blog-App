using Microsoft.EntityFrameworkCore.Migrations;

namespace Project_MovieApplication.Data.Migrations
{
    public partial class updatedMovie : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ImagePath",
                table: "Movie");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ImagePath",
                table: "Movie",
                nullable: true);
        }
    }
}
