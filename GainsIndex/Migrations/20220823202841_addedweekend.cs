using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GainsIndex.Migrations
{
    public partial class addedweekend : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "bella_saturday",
                table: "Exercises");

            migrationBuilder.DropColumn(
                name: "bella_sunday",
                table: "Exercises");

            migrationBuilder.RenameColumn(
                name: "geo_sunday",
                table: "Exercises",
                newName: "geo_weekend");

            migrationBuilder.RenameColumn(
                name: "geo_saturday",
                table: "Exercises",
                newName: "bella_weekend");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "geo_weekend",
                table: "Exercises",
                newName: "geo_sunday");

            migrationBuilder.RenameColumn(
                name: "bella_weekend",
                table: "Exercises",
                newName: "geo_saturday");

            migrationBuilder.AddColumn<bool>(
                name: "bella_saturday",
                table: "Exercises",
                type: "INTEGER",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "bella_sunday",
                table: "Exercises",
                type: "INTEGER",
                nullable: false,
                defaultValue: false);
        }
    }
}
