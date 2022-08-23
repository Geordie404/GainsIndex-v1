using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GainsIndex.Migrations
{
    public partial class splitdaybools : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "bella_friday",
                table: "Exercises",
                type: "INTEGER",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "bella_monday",
                table: "Exercises",
                type: "INTEGER",
                nullable: false,
                defaultValue: false);

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

            migrationBuilder.AddColumn<bool>(
                name: "bella_thursday",
                table: "Exercises",
                type: "INTEGER",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "bella_tuesday",
                table: "Exercises",
                type: "INTEGER",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "bella_wednesday",
                table: "Exercises",
                type: "INTEGER",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "geo_friday",
                table: "Exercises",
                type: "INTEGER",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "geo_monday",
                table: "Exercises",
                type: "INTEGER",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "geo_saturday",
                table: "Exercises",
                type: "INTEGER",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "geo_sunday",
                table: "Exercises",
                type: "INTEGER",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "geo_thursday",
                table: "Exercises",
                type: "INTEGER",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "geo_tuesday",
                table: "Exercises",
                type: "INTEGER",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "geo_wednesday",
                table: "Exercises",
                type: "INTEGER",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "bella_friday",
                table: "Exercises");

            migrationBuilder.DropColumn(
                name: "bella_monday",
                table: "Exercises");

            migrationBuilder.DropColumn(
                name: "bella_saturday",
                table: "Exercises");

            migrationBuilder.DropColumn(
                name: "bella_sunday",
                table: "Exercises");

            migrationBuilder.DropColumn(
                name: "bella_thursday",
                table: "Exercises");

            migrationBuilder.DropColumn(
                name: "bella_tuesday",
                table: "Exercises");

            migrationBuilder.DropColumn(
                name: "bella_wednesday",
                table: "Exercises");

            migrationBuilder.DropColumn(
                name: "geo_friday",
                table: "Exercises");

            migrationBuilder.DropColumn(
                name: "geo_monday",
                table: "Exercises");

            migrationBuilder.DropColumn(
                name: "geo_saturday",
                table: "Exercises");

            migrationBuilder.DropColumn(
                name: "geo_sunday",
                table: "Exercises");

            migrationBuilder.DropColumn(
                name: "geo_thursday",
                table: "Exercises");

            migrationBuilder.DropColumn(
                name: "geo_tuesday",
                table: "Exercises");

            migrationBuilder.DropColumn(
                name: "geo_wednesday",
                table: "Exercises");
        }
    }
}
