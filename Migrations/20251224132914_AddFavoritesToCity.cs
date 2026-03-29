using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SEYRİ_ALA.Migrations
{
    /// <inheritdoc />
    public partial class AddFavoritesToCity : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Favorites_Routes_RouteId",
                table: "Favorites");

            migrationBuilder.RenameColumn(
                name: "RouteId",
                table: "Favorites",
                newName: "CityId");

            migrationBuilder.RenameIndex(
                name: "IX_Favorites_RouteId",
                table: "Favorites",
                newName: "IX_Favorites_CityId");

            migrationBuilder.AddForeignKey(
                name: "FK_Favorites_Cities_CityId",
                table: "Favorites",
                column: "CityId",
                principalTable: "Cities",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Favorites_Cities_CityId",
                table: "Favorites");

            migrationBuilder.RenameColumn(
                name: "CityId",
                table: "Favorites",
                newName: "RouteId");

            migrationBuilder.RenameIndex(
                name: "IX_Favorites_CityId",
                table: "Favorites",
                newName: "IX_Favorites_RouteId");

            migrationBuilder.AddForeignKey(
                name: "FK_Favorites_Routes_RouteId",
                table: "Favorites",
                column: "RouteId",
                principalTable: "Routes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
