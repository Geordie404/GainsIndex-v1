using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GainsIndex.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Exercises",
                columns: table => new
                {
                    id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    exercise = table.Column<string>(type: "TEXT", nullable: false),
                    details = table.Column<string>(type: "TEXT", nullable: false),
                    ww_bella = table.Column<string>(type: "TEXT", nullable: true),
                    ww_geo = table.Column<string>(type: "TEXT", nullable: true),
                    target_muscle = table.Column<string>(type: "TEXT", nullable: false),
                    sets = table.Column<int>(type: "INTEGER", nullable: false),
                    reps = table.Column<int>(type: "INTEGER", nullable: false),
                    is_active = table.Column<bool>(type: "INTEGER", nullable: false),
                    motion_group = table.Column<int>(type: "INTEGER", nullable: false),
                    body_focus = table.Column<int>(type: "INTEGER", nullable: false),
                    exercise_type = table.Column<int>(type: "INTEGER", nullable: false),
                    week_day = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Exercises", x => x.id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Exercises");
        }
    }
}
