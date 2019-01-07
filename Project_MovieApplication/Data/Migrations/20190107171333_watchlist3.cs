using Microsoft.EntityFrameworkCore.Migrations;

namespace Project_MovieApplication.Data.Migrations
{
    public partial class watchlist3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Watchlist_Movie_WatchlistMovieId",
                table: "Watchlist");

            migrationBuilder.DropIndex(
                name: "IX_Watchlist_WatchlistMovieId",
                table: "Watchlist");

            migrationBuilder.DropColumn(
                name: "Title",
                table: "Watchlist");

            migrationBuilder.DropColumn(
                name: "WatchlistMovieId",
                table: "Watchlist");

            migrationBuilder.AddColumn<string>(
                name: "MovieToWatchlistID",
                table: "Movie",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Movie_MovieToWatchlistID",
                table: "Movie",
                column: "MovieToWatchlistID");

            migrationBuilder.AddForeignKey(
                name: "FK_Movie_Watchlist_MovieToWatchlistID",
                table: "Movie",
                column: "MovieToWatchlistID",
                principalTable: "Watchlist",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Movie_Watchlist_MovieToWatchlistID",
                table: "Movie");

            migrationBuilder.DropIndex(
                name: "IX_Movie_MovieToWatchlistID",
                table: "Movie");

            migrationBuilder.DropColumn(
                name: "MovieToWatchlistID",
                table: "Movie");

            migrationBuilder.AddColumn<string>(
                name: "Title",
                table: "Watchlist",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "WatchlistMovieId",
                table: "Watchlist",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Watchlist_WatchlistMovieId",
                table: "Watchlist",
                column: "WatchlistMovieId");

            migrationBuilder.AddForeignKey(
                name: "FK_Watchlist_Movie_WatchlistMovieId",
                table: "Watchlist",
                column: "WatchlistMovieId",
                principalTable: "Movie",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
