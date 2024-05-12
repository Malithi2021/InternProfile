

using System.ComponentModel.DataAnnotations.Schema;

namespace InternProfile.Models
{
    [Table("Profiles")]
    public class Profile
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? University { get; set; }
        public float InterviewScore { get; set; }
        public string? InterviewFeedback { get; set; }
        public float Evalution1Score { get; set; }
        public string? Evalution1Feedback { get; set; }
        public float Evalution2Score { get; set; }
        public string? Evalution2Feedback { get; set; }
        public string? Accomplishments { get; set; }
        public float gpa { get; set; }
        public string? ProjectDetails { get; set; }
        public string? AssignedTeam { get; set; }
        public string? MentorId { get; set; }
        public string? CVUrl { get; set; }
        public ProfileStatus ProfileStatus { get; set; }

        public Profile() { }
    }
    public enum ProfileStatus
    {
        PENDING,
        INTERVIEW_SCHEDULED,
        INTERVIEW_COMPLETE,
        HIRED,
        REJECTED,
        INTERNSHIP_STARTED,
        INTERNSHIP_ENDED

    }
}
