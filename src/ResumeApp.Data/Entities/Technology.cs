using System.ComponentModel.DataAnnotations;

namespace ResumeApp.Data.Entities
{
    public class Technology
    {
        public Technology()
        {
            this.ResumeTechnologyAssociations = new HashSet<ResumeTechnologyAssociation>();
        }

        [Key]
        public long TechnologyId { get; set; }

        [Required]
        [MaxLength(100)]
        public string TechnologyName { get; set; }

        public ICollection<ResumeTechnologyAssociation> ResumeTechnologyAssociations { get; set; }
    }
}
