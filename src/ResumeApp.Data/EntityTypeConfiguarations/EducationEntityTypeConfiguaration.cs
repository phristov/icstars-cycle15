using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ResumeApp.Data.Entities;

namespace ResumeApp.Data.EntityTypeConfiguarations
{
    public class EducationEntityTypeConfiguaration : IEntityTypeConfiguration<Education>
    {
        public void Configure(EntityTypeBuilder<Education> builder)
        {
            builder.HasOne(x => x.DegreeType)
                .WithMany(d => d.Educations)
                .HasForeignKey(x => x.DegreeTypeId)
                .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(x => x.University)
                .WithMany(d => d.Educations)
                .HasForeignKey(x => x.UniversityId);

            builder.HasOne(x => x.Resume)
                .WithMany(d => d.Educations)
                .HasForeignKey(x => x.ResumeId)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
