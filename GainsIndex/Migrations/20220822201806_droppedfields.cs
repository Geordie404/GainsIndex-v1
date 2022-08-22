using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GainsIndex.Migrations
{
    public partial class droppedfields : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "body_focus",
                table: "Exercises");

            migrationBuilder.DropColumn(
                name: "details",
                table: "Exercises");

            migrationBuilder.DropColumn(
                name: "exercise",
                table: "Exercises");

            migrationBuilder.DropColumn(
                name: "exercise_type",
                table: "Exercises");

            migrationBuilder.DropColumn(
                name: "is_active",
                table: "Exercises");

            migrationBuilder.DropColumn(
                name: "motion_group",
                table: "Exercises");

            migrationBuilder.DropColumn(
                name: "reps",
                table: "Exercises");

            migrationBuilder.DropColumn(
                name: "sets",
                table: "Exercises");

            migrationBuilder.DropColumn(
                name: "week_day",
                table: "Exercises");

            migrationBuilder.DropColumn(
                name: "ww_bella",
                table: "Exercises");

            migrationBuilder.DropColumn(
                name: "ww_geo",
                table: "Exercises");

            migrationBuilder.RenameColumn(
                name: "target_muscle",
                table: "Exercises",
                newName: "exercise_name");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "exercise_name",
                table: "Exercises",
                newName: "target_muscle");

            migrationBuilder.AddColumn<int>(
                name: "body_focus",
                table: "Exercises",
                type: "INTEGER",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "details",
                table: "Exercises",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "exercise",
                table: "Exercises",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "exercise_type",
                table: "Exercises",
                type: "INTEGER",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "is_active",
                table: "Exercises",
                type: "INTEGER",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<int>(
                name: "motion_group",
                table: "Exercises",
                type: "INTEGER",
                nullable: true);

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

            migrationBuilder.AddColumn<int>(
                name: "week_day",
                table: "Exercises",
                type: "INTEGER",
                nullable: true);

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
    }
}
