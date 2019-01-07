using Microsoft.EntityFrameworkCore.Migrations;

namespace Project_MovieApplication.Data.Migrations
{
    public partial class watchlist7 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Watchlist_Movie_MovieId",
                table: "Watchlist");

            migrationBuilder.DropIndex(
                name: "IX_Watchlist_MovieId",
                table: "Watchlist");

            migrationBuilder.RenameColumn(
                name: "MovieId",
                table: "Watchlist",
                newName: "MovieIdForWatchlist");

            migrationBuilder.AddColumn<int>(
                name: "MoviesId",
                table: "Watchlist",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Watchlist_MoviesId",
                table: "Watchlist",
                column: "MoviesId");

            migrationBuilder.AddForeignKey(
                name: "FK_Watchlist_Movie_MoviesId",
                table: "Watchlist",
                column: "MoviesId",
                principalTable: "Movie",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Watchlist_Movie_MoviesId",
                table: "Watchlist");

            migrationBuilder.DropIndex(
                name: "IX_Watchlist_MoviesId",
                table: "Watchlist");

            migrationBuilder.DropColumn(
                name: "MoviesId",
                table: "Watchlist");

            migrationBuilder.RenameColumn(
                name: "MovieIdForWatchlist",
                table: "Watchlist",
                newName: "MovieId");

            migrationBuilder.CreateIndex(
                name: "IX_Watchlist_MovieId",
                table: "Watchlist",
                column: "MovieId");

            migrationBuilder.AddForeignKey(
                name: "FK_Watchlist_Movie_MovieId",
                table: "Watchlist",
                column: "MovieId",
                principalTable: "Movie",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
