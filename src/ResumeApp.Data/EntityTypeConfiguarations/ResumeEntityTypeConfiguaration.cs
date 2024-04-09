using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using ResumeApp.Data.Entities;

namespace ResumeApp.Data.EntityTypeConfiguarations
{
    public class ResumeEntityTypeConfiguaration : IEntityTypeConfiguration<Resume>
    {
        public void Configure(EntityTypeBuilder<Resume> builder)
        {
            builder.HasOne(x => x.Person)
                  .WithMany(d => d.Resumes)
                  .HasForeignKey(x => x.PersonId)
                  .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
