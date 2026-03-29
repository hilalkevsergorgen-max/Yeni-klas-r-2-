using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SEYRİ_ALA.Migrations
{
    /// <inheritdoc />
    public partial class Hafta4_Final_Update : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Favorites_UserId",
                table: "Favorites");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 16,
                column: "Description",
                value: "Osmanlı's ilk başkenti ve Uludağ.");

            migrationBuilder.CreateIndex(
                name: "IX_Favorites_UserId_CityId",
                table: "Favorites",
                columns: new[] { "UserId", "CityId" },
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Favorites_UserId_CityId",
                table: "Favorites");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 16,
                column: "Description",
                value: "Osmanlı'nın ilk başkenti ve Uludağ.");

            migrationBuilder.CreateIndex(
                name: "IX_Favorites_UserId",
                table: "Favorites",
                column: "UserId");
        }
    }
}
