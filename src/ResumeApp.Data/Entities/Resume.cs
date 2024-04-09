using System.ComponentModel.DataAnnotations;

namespace ResumeApp.Data.Entities
{
    public class Resume
    {
        public Resume()
        {
            this.Jobs = new HashSet<Job>();
            this.Educations = new HashSet<Education>();
            this.ResumeProgrammingLanguageAssociations = new HashSet<ResumeProgrammingLanguageAssociation>();
            this.ResumeTechnologyAssociations = new HashSet<ResumeTechnologyAssociation>();
            this.ResumeServerAssociations = new HashSet<ResumeServerAssociation>();
        }

        [Key]
        public long ResumeId { get; set; }

        public long PersonId { get; set; }

        public virtual Person Person { get; set; }

        [Required]
        [MaxLength(500)]
        public string Summary { get; set; }

        public virtual ICollection<Job> Jobs { get; set; }

        public virtual ICollection<ResumeTechnologyAssociation> ResumeTechnologyAssociations { get; set; }

        public virtual ICollection<Education> Educations { get; set; }

        public virtual ICollection<ResumeProgrammingLanguageAssociation> ResumeProgrammingLanguageAssociations { get; set; }

        public virtual ICollection<ResumeServerAssociation> ResumeServerAssociations { get; set; }
    }
}
