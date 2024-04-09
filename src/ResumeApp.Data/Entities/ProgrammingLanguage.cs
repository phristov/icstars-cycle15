using System.ComponentModel.DataAnnotations;

namespace ResumeApp.Data.Entities
{
    public class ProgrammingLanguage
    {
        public ProgrammingLanguage()
        {
            this.ResumeProgrammingLanguagesAssociations = new HashSet<ResumeProgrammingLanguageAssociation>();
        }

        [Key]
        public long ProgrammingLanguageId { get; set; }

        [Required]
        [MaxLength(50)]
        public string ProgrammingLanguageName { get; set; }

        public virtual ICollection<ResumeProgrammingLanguageAssociation> ResumeProgrammingLanguagesAssociations { get; set; }
    }
}
