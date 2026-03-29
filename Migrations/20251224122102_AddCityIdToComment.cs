using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SEYRİ_ALA.Migrations
{
    /// <inheritdoc />
    public partial class AddCityIdToComment : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Comments_Routes_RouteId",
                table: "Comments");

            migrationBuilder.AlterColumn<int>(
                name: "RouteId",
                table: "Comments",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<int>(
                name: "CityId",
                table: "Comments",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Comments_CityId",
                table: "Comments",
                column: "CityId");

            migrationBuilder.AddForeignKey(
                name: "FK_Comments_Cities_CityId",
                table: "Comments",
                column: "CityId",
                principalTable: "Cities",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Comments_Routes_RouteId",
                table: "Comments",
                column: "RouteId",
                principalTable: "Routes",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Comments_Cities_CityId",
                table: "Comments");

            migrationBuilder.DropForeignKey(
                name: "FK_Comments_Routes_RouteId",
                table: "Comments");

            migrationBuilder.DropIndex(
                name: "IX_Comments_CityId",
                table: "Comments");

            migrationBuilder.DropColumn(
                name: "CityId",
                table: "Comments");

            migrationBuilder.AlterColumn<int>(
                name: "RouteId",
                table: "Comments",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Comments_Routes_RouteId",
                table: "Comments",
                column: "RouteId",
                principalTable: "Routes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
