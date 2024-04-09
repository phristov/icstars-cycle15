using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using ResumeApp.Data.Entities;

namespace ResumeApp.Data.EntityTypeConfiguarations
{
    public class ResumeProgrammingLanguageAssociationEntityTypeConfiguaration : IEntityTypeConfiguration<ResumeProgrammingLanguageAssociation>
    {
        public void Configure(EntityTypeBuilder<ResumeProgrammingLanguageAssociation> builder)
        {
            builder.HasOne(x => x.ProgrammingLanguage)
                .WithMany(d => d.ResumeProgrammingLanguagesAssociations)
                .HasForeignKey(x => x.ProgrammingLanguageId)
                .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(x => x.Resume)
                .WithMany(d => d.ResumeProgrammingLanguageAssociations)
                .HasForeignKey(x => x.ResumeId)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
