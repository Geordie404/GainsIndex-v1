using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GainsIndex.Migrations
{
    public partial class addeddays : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "is_friday",
                table: "Exercises",
                type: "INTEGER",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "is_monday",
                table: "Exercises",
                type: "INTEGER",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "is_saturday",
                table: "Exercises",
                type: "INTEGER",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "is_sunday",
                table: "Exercises",
                type: "INTEGER",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "is_thursday",
                table: "Exercises",
                type: "INTEGER",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "is_tuesday",
                table: "Exercises",
                type: "INTEGER",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "is_wednesday",
                table: "Exercises",
                type: "INTEGER",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "is_friday",
                table: "Exercises");

            migrationBuilder.DropColumn(
                name: "is_monday",
                table: "Exercises");

            migrationBuilder.DropColumn(
                name: "is_saturday",
                table: "Exercises");

            migrationBuilder.DropColumn(
                name: "is_sunday",
                table: "Exercises");

            migrationBuilder.DropColumn(
                name: "is_thursday",
                table: "Exercises");

            migrationBuilder.DropColumn(
                name: "is_tuesday",
                table: "Exercises");

            migrationBuilder.DropColumn(
                name: "is_wednesday",
                table: "Exercises");
        }
    }
}
