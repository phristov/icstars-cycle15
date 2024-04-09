using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using ResumeApp.Data.Entities;

namespace ResumeApp.Data.EntityTypeConfiguarations
{
    public class PersonEntityTypeConfiguaration : IEntityTypeConfiguration<Person>
    {
        public void Configure(EntityTypeBuilder<Person> builder)
        {
            builder.HasOne(x => x.State)
                .WithMany(d => d.People)
                .HasForeignKey(x => x.StateId)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
