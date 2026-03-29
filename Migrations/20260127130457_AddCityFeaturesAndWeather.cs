using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SEYRİ_ALA.Migrations
{
    /// <inheritdoc />
    public partial class AddCityFeaturesAndWeather : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<double>(
                name: "Temperature",
                table: "Cities",
                type: "float",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "WeatherCondition",
                table: "Cities",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Temperature", "WeatherCondition" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Temperature", "WeatherCondition" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Temperature", "WeatherCondition" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Temperature", "WeatherCondition" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Temperature", "WeatherCondition" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Temperature", "WeatherCondition" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Temperature", "WeatherCondition" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Temperature", "WeatherCondition" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Temperature", "WeatherCondition" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Temperature", "WeatherCondition" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "Temperature", "WeatherCondition" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "Temperature", "WeatherCondition" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "Temperature", "WeatherCondition" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "Temperature", "WeatherCondition" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "Temperature", "WeatherCondition" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "Temperature", "WeatherCondition" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "Temperature", "WeatherCondition" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "Temperature", "WeatherCondition" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "Temperature", "WeatherCondition" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "Temperature", "WeatherCondition" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "Temperature", "WeatherCondition" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "Temperature", "WeatherCondition" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "Temperature", "WeatherCondition" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "Temperature", "WeatherCondition" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "Temperature", "WeatherCondition" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "Temperature", "WeatherCondition" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "Temperature", "WeatherCondition" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "Temperature", "WeatherCondition" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "Temperature", "WeatherCondition" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "Temperature", "WeatherCondition" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "Temperature", "WeatherCondition" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "Temperature", "WeatherCondition" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "Temperature", "WeatherCondition" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "Temperature", "WeatherCondition" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "Temperature", "WeatherCondition" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "Temperature", "WeatherCondition" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "Temperature", "WeatherCondition" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "Temperature", "WeatherCondition" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "Temperature", "WeatherCondition" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "Temperature", "WeatherCondition" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "Temperature", "WeatherCondition" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "Temperature", "WeatherCondition" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "Temperature", "WeatherCondition" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "Temperature", "WeatherCondition" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "Temperature", "WeatherCondition" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "Temperature", "WeatherCondition" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "Temperature", "WeatherCondition" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "Temperature", "WeatherCondition" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "Temperature", "WeatherCondition" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "Temperature", "WeatherCondition" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "Temperature", "WeatherCondition" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "Temperature", "WeatherCondition" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "Temperature", "WeatherCondition" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "Temperature", "WeatherCondition" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "Temperature", "WeatherCondition" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "Temperature", "WeatherCondition" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "Temperature", "WeatherCondition" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "Temperature", "WeatherCondition" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "Temperature", "WeatherCondition" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "Temperature", "WeatherCondition" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "Temperature", "WeatherCondition" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "Temperature", "WeatherCondition" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "Temperature", "WeatherCondition" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "Temperature", "WeatherCondition" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "Temperature", "WeatherCondition" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "Temperature", "WeatherCondition" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "Temperature", "WeatherCondition" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "Temperature", "WeatherCondition" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "Temperature", "WeatherCondition" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "Temperature", "WeatherCondition" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "Temperature", "WeatherCondition" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "Temperature", "WeatherCondition" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "Temperature", "WeatherCondition" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "Temperature", "WeatherCondition" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "Temperature", "WeatherCondition" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "Temperature", "WeatherCondition" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "Temperature", "WeatherCondition" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "Temperature", "WeatherCondition" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "Temperature", "WeatherCondition" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "Temperature", "WeatherCondition" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "Temperature", "WeatherCondition" },
                values: new object[] { null, null });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Temperature",
                table: "Cities");

            migrationBuilder.DropColumn(
                name: "WeatherCondition",
                table: "Cities");
        }
    }
}
