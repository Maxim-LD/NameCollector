using Microsoft.EntityFrameworkCore;
using NameCollector.Model.Entity;

namespace NameCollector.Migrations
{
    public class NameCollectorDbContext: DbContext
    {
        public NameCollectorDbContext(DbContextOptions<NameCollectorDbContext> options) : base(options)
        {
        }

        public DbSet<BasicProfile> BasicProfiles { get; set; }
        public DbSet<NextOfKinProfile> NextOfKinProfiles { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<BasicProfile>().ToTable("BasicProfile");
       
            modelBuilder.Entity<NextOfKinProfile>().ToTable("NextOfKinProfile");
        }
    }
}
