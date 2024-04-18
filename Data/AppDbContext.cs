using Microsoft.EntityFrameworkCore;

namespace InternProfile.Data
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) 
        { 

        }

        public DbSet<Profile> Profiles => Set<Profile>();
    }
}
