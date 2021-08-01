using Microsoft.EntityFrameworkCore.Migrations;

namespace FightMatrix.Migrations
{
    public partial class Num3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Age",
                table: "Fighter",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "Promotion",
                table: "Fighter",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "RatingPoints",
                table: "Fighter",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Age",
                table: "Fighter");

            migrationBuilder.DropColumn(
                name: "Promotion",
                table: "Fighter");

            migrationBuilder.DropColumn(
                name: "RatingPoints",
                table: "Fighter");
        }
    }
}
