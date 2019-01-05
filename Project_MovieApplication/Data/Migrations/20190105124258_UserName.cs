using Microsoft.EntityFrameworkCore.Migrations;

namespace Project_MovieApplication.Data.Migrations
{
    public partial class UserName : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Movie_AspNetUsers_UserID",
                table: "Movie");

            migrationBuilder.RenameColumn(
                name: "UserID",
                table: "Movie",
                newName: "UserId");

            migrationBuilder.RenameIndex(
                name: "IX_Movie_UserID",
                table: "Movie",
                newName: "IX_Movie_UserId");

            migrationBuilder.AddColumn<string>(
                name: "UserName",
                table: "Movie",
                nullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Movie_AspNetUsers_UserId",
                table: "Movie",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Movie_AspNetUsers_UserId",
                table: "Movie");

            migrationBuilder.DropColumn(
                name: "UserName",
                table: "Movie");

            migrationBuilder.RenameColumn(
                name: "UserId",
                table: "Movie",
                newName: "UserID");

            migrationBuilder.RenameIndex(
                name: "IX_Movie_UserId",
                table: "Movie",
                newName: "IX_Movie_UserID");

            migrationBuilder.AddForeignKey(
                name: "FK_Movie_AspNetUsers_UserID",
                table: "Movie",
                column: "UserID",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
