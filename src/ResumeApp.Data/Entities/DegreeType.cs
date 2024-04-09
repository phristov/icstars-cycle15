using System.ComponentModel.DataAnnotations;

namespace ResumeApp.Data.Entities
{
    public class DegreeType
    {
        public DegreeType()
        {
            this.Educations = new HashSet<Education>();
        }

        [Key]
        public long DegreeTypeId { get; set; }

        [Required]
        [MaxLength(50)]
        public string DegreeTypeName { get; set; }

        public virtual ICollection<Education> Educations { get; set; }
    }
}
