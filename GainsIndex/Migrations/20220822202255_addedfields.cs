using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GainsIndex.Migrations
{
    public partial class addedfields : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "details",
                table: "Exercises",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<bool>(
                name: "is_active",
                table: "Exercises",
                type: "INTEGER",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<int>(
                name: "reps",
                table: "Exercises",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "sets",
                table: "Exercises",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "target_muscle",
                table: "Exercises",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "ww_bella",
                table: "Exercises",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ww_geo",
                table: "Exercises",
                type: "TEXT",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "details",
                table: "Exercises");

            migrationBuilder.DropColumn(
                name: "is_active",
                table: "Exercises");

            migrationBuilder.DropColumn(
                name: "reps",
                table: "Exercises");

            migrationBuilder.DropColumn(
                name: "sets",
                table: "Exercises");

            migrationBuilder.DropColumn(
                name: "target_muscle",
                table: "Exercises");

            migrationBuilder.DropColumn(
                name: "ww_bella",
                table: "Exercises");

            migrationBuilder.DropColumn(
                name: "ww_geo",
                table: "Exercises");
        }
    }
}
