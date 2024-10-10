using DevJobs.API.Entities;
using Microsoft.EntityFrameworkCore;

namespace DevJobs.API.Persistence
{
    public class DevJobsContext : DbContext
    {
        public DbSet<JobApplication> JobApplications { get; set; }

        public DbSet<JobVacancy> JobVacancies { get; set; }

        public DevJobsContext(DbContextOptions<DevJobsContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<JobApplication>(ja =>
            {
                ja.HasKey(ja => ja.Id);
            });

            modelBuilder.Entity<JobVacancy>(jv =>
            {
                jv.HasKey(jv => jv.Id);

                jv.HasMany(jv => jv.Applications)
                    .WithOne()
                    .HasForeignKey(ja => ja.IdJobVacancy)
                    .OnDelete(DeleteBehavior.Restrict);
            });
        }
    }
}