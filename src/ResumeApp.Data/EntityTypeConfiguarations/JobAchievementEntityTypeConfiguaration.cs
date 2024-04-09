using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using ResumeApp.Data.Entities;

namespace ResumeApp.Data.EntityTypeConfiguarations
{
    public class JobAchievementEntityTypeConfiguaration : IEntityTypeConfiguration<JobAchievement>
    {
        public void Configure(EntityTypeBuilder<JobAchievement> builder)
        {
            builder.HasOne(x => x.Job)
                .WithMany(d => d.JobAchievements)
                .HasForeignKey(x => x.JobId)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
