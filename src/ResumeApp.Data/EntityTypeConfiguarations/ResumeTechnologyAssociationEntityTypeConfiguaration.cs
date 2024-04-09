using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using ResumeApp.Data.Entities;

namespace ResumeApp.Data.EntityTypeConfiguarations
{
    public class ResumeTechnologyAssociationEntityTypeConfiguaration : IEntityTypeConfiguration<ResumeTechnologyAssociation>
    {
        public void Configure(EntityTypeBuilder<ResumeTechnologyAssociation> builder)
        {
            builder.HasOne(x => x.Technology)
                  .WithMany(d => d.ResumeTechnologyAssociations)
                  .HasForeignKey(x => x.TechnologyId)
                  .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(x => x.Resume)
                  .WithMany(d => d.ResumeTechnologyAssociations)
                  .HasForeignKey(x => x.ResumeId)
                  .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
