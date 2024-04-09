using System.ComponentModel.DataAnnotations;

namespace ResumeApp.Data.Entities
{
    public class University
    {
        public University()
        {
            this.Educations = new HashSet<Education>();    
        }

        [Key]
        public long UniversityId { get; set; }

        [MaxLength(50)]
        public string UniversityName { get; set; }

        public ICollection<Education> Educations { get;  set; }
    }
}
