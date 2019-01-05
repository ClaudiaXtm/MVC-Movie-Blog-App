using Microsoft.EntityFrameworkCore.Migrations;

namespace Project_MovieApplication.Data.Migrations
{
    public partial class UserId : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "UserID",
                table: "Movie",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Movie_UserID",
                table: "Movie",
                column: "UserID");

            migrationBuilder.AddForeignKey(
                name: "FK_Movie_AspNetUsers_UserID",
                table: "Movie",
                column: "UserID",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Movie_AspNetUsers_UserID",
                table: "Movie");

            migrationBuilder.DropIndex(
                name: "IX_Movie_UserID",
                table: "Movie");

            migrationBuilder.DropColumn(
                name: "UserID",
                table: "Movie");
        }
    }
}
