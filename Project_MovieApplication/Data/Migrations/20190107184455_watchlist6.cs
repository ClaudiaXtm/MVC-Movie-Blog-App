using Microsoft.EntityFrameworkCore.Migrations;

namespace Project_MovieApplication.Data.Migrations
{
    public partial class watchlist6 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.AddColumn<int>(
                name: "MovieId",
                table: "Watchlist",
                nullable: false,
                defaultValue: 0);

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Watchlist_Movie_MovieId",
                table: "Watchlist");

            migrationBuilder.DropIndex(
                name: "IX_Watchlist_MovieId",
                table: "Watchlist");

            migrationBuilder.DropColumn(
                name: "MovieId",
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
    }
}
