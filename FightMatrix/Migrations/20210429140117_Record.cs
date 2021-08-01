using Microsoft.EntityFrameworkCore.Migrations;

namespace FightMatrix.Migrations
{
    public partial class Record : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Draws",
                table: "Fighter",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Loses",
                table: "Fighter",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "NC",
                table: "Fighter",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Wins",
                table: "Fighter",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Draws",
                table: "Fighter");

            migrationBuilder.DropColumn(
                name: "Loses",
                table: "Fighter");

            migrationBuilder.DropColumn(
                name: "NC",
                table: "Fighter");

            migrationBuilder.DropColumn(
                name: "Wins",
                table: "Fighter");
        }
    }
}
