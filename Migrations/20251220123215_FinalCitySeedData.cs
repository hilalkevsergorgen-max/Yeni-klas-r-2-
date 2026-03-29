using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace SEYRİ_ALA.Migrations
{
    /// <inheritdoc />
    public partial class FinalCitySeedData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Cities",
                columns: new[] { "Id", "Description", "FoodScore", "HistoryScore", "Latitude", "Longitude", "Name", "NatureScore" },
                values: new object[,]
                {
                    { 1, "Türkiye'nin kalbi, Cumhuriyet'in başkenti ve Anıtkabir'in evi.", 8, 10, 39.933399999999999, 32.859699999999997, "Ankara", 6 },
                    { 2, "İki kıtanın buluştuğu, tarihin kalbi İstanbul.", 10, 10, 41.008200000000002, 28.978400000000001, "İstanbul", 5 },
                    { 3, "Peri bacaları ve sıcak hava balonlarıyla masalsı bir yolculuk.", 7, 9, 38.643099999999997, 34.828899999999997, "Kapadokya", 10 },
                    { 4, "Masmavi deniz ve antik kentlerin buluşma noktası.", 8, 8, 36.884099999999997, 30.7056, "Antalya", 9 },
                    { 5, "Sümela Manastırı ve Uzungöl ile doğanın yeşil tonları.", 9, 8, 41.002699999999997, 39.716799999999999, "Trabzon", 10 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 5);
        }
    }
}
