using Microsoft.EntityFrameworkCore;

namespace InternProfile.Data
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) 
        { 

        }

        public DbSet<Profile> Profiles => Set<Profile>();
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {

            optionsBuilder.UseSqlite("Data Source=C:/Users/MalithiAbayadeera/source/repos/Xternship/Database/Xternship.db");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<Profile>()
                .ToTable("Profiles");
        }
    }
}
