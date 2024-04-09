using Microsoft.EntityFrameworkCore;
using ResumeApp.Data.Entities;
using ResumeApp.Data.EntityTypeConfiguarations;

namespace ResumeApp.Data
{
    public class ResumeAppDbContext: DbContext
    {
        public ResumeAppDbContext(DbContextOptions<ResumeAppDbContext> options) : base (options)
        {
        }

        public DbSet<DegreeType> DegreeTypes { get; set; }

        public DbSet<Education> Educations { get; set; }    

        public DbSet<Job> Jobs { get; set; }

        public DbSet<JobAchievement> JobAchievements { get; set; }
        
        public DbSet<Person> People { get; set; }

        public DbSet<ProgrammingLanguage> ProgrammingLanguages { get; set; }

        public DbSet<Resume> Resumes { get; set; }

        public DbSet<ResumeProgrammingLanguageAssociation> ResumeProgrammingLanguageAssociations { get; set; }

        public DbSet<ResumeServerAssociation> ResumeServerAssociations { get; set; }

        public DbSet<ResumeTechnologyAssociation> ResumeTechnologyAssociations { get; set; }

        public DbSet<Server> Servers { get; set; }

        public DbSet<State> States { get; set; }

        public DbSet<Technology> Technologies { get; set; }

        public DbSet<University> Universities { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration<Education>(new EducationEntityTypeConfiguaration());
            modelBuilder.ApplyConfiguration<Job>(new JobEntityTypeConfiguaration());
            modelBuilder.ApplyConfiguration<JobAchievement>(new JobAchievementEntityTypeConfiguaration());
            modelBuilder.ApplyConfiguration<Person>(new PersonEntityTypeConfiguaration());

            modelBuilder.ApplyConfiguration<Resume>(new ResumeEntityTypeConfiguaration());
            modelBuilder.ApplyConfiguration<ResumeProgrammingLanguageAssociation>(new ResumeProgrammingLanguageAssociationEntityTypeConfiguaration());
            modelBuilder.ApplyConfiguration<ResumeTechnologyAssociation>(new ResumeTechnologyAssociationEntityTypeConfiguaration());
            modelBuilder.ApplyConfiguration<ResumeServerAssociation>(new ResumeServerAssociationEntityTypeConfiguaration());
        }
    }
}
