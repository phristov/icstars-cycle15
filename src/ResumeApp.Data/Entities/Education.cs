using System.ComponentModel.DataAnnotations;

namespace ResumeApp.Data.Entities
{
    public class Education
    {
        [Key]
        public long EducationId { get; set; }

        [Required]
        [MaxLength(4)]
        public string GraduationYear { get; set; }

        public long UniversityId { get; set; }

        public virtual University University { get; set; }

        [Required]
        [MaxLength(100)]
        public string Degree { get; set; }

        public long DegreeTypeId { get; set; }

        public virtual DegreeType DegreeType { get; set; }

        public long ResumeId { get; set; }

        public virtual Resume Resume { get; set; }
    }
}
