using Grpc.Core;
using InternProfile.Data;
using InternProfile.Models;

namespace InternProfile.Services
{
    public class InternProfileService : InternProfile.InternProfileBase
    {
      private readonly AppDbContext _dbContext;
      private readonly ILogger<InternProfileService> _logger;

        public InternProfileService(ILogger<InternProfileService> logger, AppDbContext dbContext)
        {
            _logger = logger;
            _dbContext = dbContext;
        }

        public override async Task<InternProfileResponse> CreateInternProfile(CreateInternProfileRequest request, ServerCallContext context)
        {
            if (request.Name == string.Empty || request.Name == string.Empty) {
                throw new RpcException(new Status(StatusCode.NotFound, "You must supply a valid object"));
            }
               
            var profile = new Profile
            {
                Id = Guid.NewGuid().ToString(),
                Name = request.Name,
                University = request.University,
                InterviewScore = request.InterviewScore,
                InterviewFeedback = request.InterviewFeedback,
                Evalution1Score = request.Evalution1Score,
                Evalution1Feedback = request.Evalution1Feedback,
                Evalution2Score = request.Evalution2Score,
                Evalution2Feedback = request.Evalution2Feedback,
                Accomplishments = request.Accomplishments,
                ProjectDetails = request.ProjectDetails,
                AssignedTeam = request.AssignedTeam,
                Gpa = request.Gpa,
                MentorId = request.MentorId,
                PofileStatus = request.ProfileStatus,
                CvUrl = request.CvUrl
            };

          await _dbContext.AddAsync(profile);
            await _dbContext.SaveChangesAsync();

            return await Task.FromResult(new InternProfileResponse
            {
                Profile = profile
            } );
           
        }


       

    }
}
