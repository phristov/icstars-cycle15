using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using ResumeApp.Data.Entities;

namespace ResumeApp.Data.EntityTypeConfiguarations
{
    public class ResumeServerAssociationEntityTypeConfiguaration : IEntityTypeConfiguration<ResumeServerAssociation>
    {
        public void Configure(EntityTypeBuilder<ResumeServerAssociation> builder)
        {
            builder.HasOne(x => x.Server)
                  .WithMany(d => d.ResumeServerAssociations)
                  .HasForeignKey(x => x.ServerId)
                  .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(x => x.Resume)
                  .WithMany(d => d.ResumeServerAssociations)
                  .HasForeignKey(x => x.ResumeId)
                  .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
