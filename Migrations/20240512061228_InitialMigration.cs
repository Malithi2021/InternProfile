using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace InternProfile.Migrations
{
    /// <inheritdoc />
    public partial class InitialMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Profiles",
                columns: table => new
                {
                    Id = table.Column<string>(type: "TEXT", nullable: false),
                    Name = table.Column<string>(type: "TEXT", nullable: true),
                    University = table.Column<string>(type: "TEXT", nullable: true),
                    InterviewScore = table.Column<float>(type: "REAL", nullable: false),
                    InterviewFeedback = table.Column<string>(type: "TEXT", nullable: true),
                    Evalution1Score = table.Column<float>(type: "REAL", nullable: false),
                    Evalution1Feedback = table.Column<string>(type: "TEXT", nullable: true),
                    Evalution2Score = table.Column<float>(type: "REAL", nullable: false),
                    Evalution2Feedback = table.Column<string>(type: "TEXT", nullable: true),
                    Accomplishments = table.Column<string>(type: "TEXT", nullable: true),
                    Gpa = table.Column<float>(type: "REAL", nullable: false),
                    ProjectDetails = table.Column<string>(type: "TEXT", nullable: true),
                    AssignedTeam = table.Column<string>(type: "TEXT", nullable: true),
                    MentorId = table.Column<string>(type: "TEXT", nullable: true),
                    CvUrl = table.Column<string>(type: "TEXT", nullable: true),
                    PofileStatus = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Profiles", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Profiles");
        }
    }
}
