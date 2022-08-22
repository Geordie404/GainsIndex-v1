using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GainsIndex.Migrations
{
    public partial class addedenums : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "body_focus",
                table: "Exercises",
                type: "INTEGER",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "exercise_type",
                table: "Exercises",
                type: "INTEGER",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "motion_group",
                table: "Exercises",
                type: "INTEGER",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "body_focus",
                table: "Exercises");

            migrationBuilder.DropColumn(
                name: "exercise_type",
                table: "Exercises");

            migrationBuilder.DropColumn(
                name: "motion_group",
                table: "Exercises");
        }
    }
}
