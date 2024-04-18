using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace InternProfile.Migrations
{
    /// <inheritdoc />
    public partial class FirstMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Email",
                table: "Profiles",
                newName: "University");

            migrationBuilder.AddColumn<string>(
                name: "Accomplishments",
                table: "Profiles",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "AssignedTeam",
                table: "Profiles",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CvUrl",
                table: "Profiles",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Evalution1Feedback",
                table: "Profiles",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<float>(
                name: "Evalution1Score",
                table: "Profiles",
                type: "REAL",
                nullable: false,
                defaultValue: 0f);

            migrationBuilder.AddColumn<string>(
                name: "Evalution2Feedback",
                table: "Profiles",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<float>(
                name: "Evalution2Score",
                table: "Profiles",
                type: "REAL",
                nullable: false,
                defaultValue: 0f);

            migrationBuilder.AddColumn<float>(
                name: "Gpa",
                table: "Profiles",
                type: "REAL",
                nullable: false,
                defaultValue: 0f);

            migrationBuilder.AddColumn<string>(
                name: "InterviewFeedback",
                table: "Profiles",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<float>(
                name: "InterviewScore",
                table: "Profiles",
                type: "REAL",
                nullable: false,
                defaultValue: 0f);

            migrationBuilder.AddColumn<string>(
                name: "MentorId",
                table: "Profiles",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "PofileStatus",
                table: "Profiles",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "ProjectDetails",
                table: "Profiles",
                type: "TEXT",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Accomplishments",
                table: "Profiles");

            migrationBuilder.DropColumn(
                name: "AssignedTeam",
                table: "Profiles");

            migrationBuilder.DropColumn(
                name: "CvUrl",
                table: "Profiles");

            migrationBuilder.DropColumn(
                name: "Evalution1Feedback",
                table: "Profiles");

            migrationBuilder.DropColumn(
                name: "Evalution1Score",
                table: "Profiles");

            migrationBuilder.DropColumn(
                name: "Evalution2Feedback",
                table: "Profiles");

            migrationBuilder.DropColumn(
                name: "Evalution2Score",
                table: "Profiles");

            migrationBuilder.DropColumn(
                name: "Gpa",
                table: "Profiles");

            migrationBuilder.DropColumn(
                name: "InterviewFeedback",
                table: "Profiles");

            migrationBuilder.DropColumn(
                name: "InterviewScore",
                table: "Profiles");

            migrationBuilder.DropColumn(
                name: "MentorId",
                table: "Profiles");

            migrationBuilder.DropColumn(
                name: "PofileStatus",
                table: "Profiles");

            migrationBuilder.DropColumn(
                name: "ProjectDetails",
                table: "Profiles");

            migrationBuilder.RenameColumn(
                name: "University",
                table: "Profiles",
                newName: "Email");
        }
    }
}
