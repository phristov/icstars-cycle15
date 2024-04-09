using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using ResumeApp.Data.Entities;

namespace ResumeApp.Data.EntityTypeConfiguarations
{
    public class JobEntityTypeConfiguaration : IEntityTypeConfiguration<Job>
    {
        public void Configure(EntityTypeBuilder<Job> builder)
        {
            builder.HasOne(x => x.State)
                  .WithMany(d => d.Jobs)
                  .HasForeignKey(x => x.StateId)
                  .OnDelete(DeleteBehavior.Restrict);

            builder.Property(x => x.StartDate)
                .HasColumnType("datetime2(7)");

            builder.Property(x => x.EndDate)
              .HasColumnType("datetime2(7)");

            builder.HasOne(x => x.Resume)
                .WithMany(d => d.Jobs)
                .HasForeignKey(x => x.ResumeId)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
