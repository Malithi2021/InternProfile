using Grpc.Core;
using InternProfile.Data;
using Microsoft.EntityFrameworkCore;

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

        public override async Task<GetInternProfileResponse> GetInternProfile(GetProfileRequest request, ServerCallContext context)
        {
            var profile = await _dbContext.Profiles.FindAsync(request.Id);

            if (profile == null)
            {
                throw new RpcException(new Status(StatusCode.NotFound, "Profile not found"));
            }

            return new GetInternProfileResponse
            {
                Profile = profile
            };

            throw new RpcException(new Status(StatusCode.NotFound, $"No Task with id (request.Id)"));
        }

        public override async Task<GetAllProfilesResponse> GetInternProfilesList(GetAllProfilesRequest request, ServerCallContext context)
        {
            var profiles = await _dbContext.Profiles.ToListAsync();

            var response = new GetAllProfilesResponse();
            response.Profile.AddRange(profiles.Select(profile => new InternProfileResponse { Profile = profile }));

            return response;
        }

        public override async Task<UpdateProfileResponse> UpdateInternProfile(UpdateProfileRequest request, ServerCallContext context)
        {
            var profile = await _dbContext.Profiles.FindAsync(request.Id);

            if (profile == null)
            {
                throw new RpcException(new Status(StatusCode.NotFound, "Profile not found"));
            }

            profile.Name = request.Name;
            profile.University = request.University;
            profile.AssignedTeam = request.AssignedTeam;
            profile.MentorId = request.MentorId;
            profile.PofileStatus = request.ProfileStatus;

            await _dbContext.SaveChangesAsync();

            return new UpdateProfileResponse
            {
                Id = profile.Id
            };
        }

        public override async Task<DeleteProfileResponse> DeleteInternProfile(DeleteProfileRequest request, ServerCallContext context)
        {
            var profile = await _dbContext.Profiles.FindAsync(request.Id);

            if (profile == null)
            {
                throw new RpcException(new Status(StatusCode.NotFound, "Profile not found"));
            }

            _dbContext.Profiles.Remove(profile);
            await _dbContext.SaveChangesAsync();

            return new DeleteProfileResponse
            {
                Id = request.Id
            };
        }
    }
}
