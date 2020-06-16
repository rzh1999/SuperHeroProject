using Microsoft.EntityFrameworkCore.Migrations;

namespace SuperHero.Data.Migrations
{
    public partial class SuperHeros : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "alterEgo",
                table: "SuperHeroes",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "catchPhrase",
                table: "SuperHeroes",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "name",
                table: "SuperHeroes",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "primaryAbility",
                table: "SuperHeroes",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "secondaryAbility",
                table: "SuperHeroes",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "alterEgo",
                table: "SuperHeroes");

            migrationBuilder.DropColumn(
                name: "catchPhrase",
                table: "SuperHeroes");

            migrationBuilder.DropColumn(
                name: "name",
                table: "SuperHeroes");

            migrationBuilder.DropColumn(
                name: "primaryAbility",
                table: "SuperHeroes");

            migrationBuilder.DropColumn(
                name: "secondaryAbility",
                table: "SuperHeroes");
        }
    }
}
