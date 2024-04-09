using System.ComponentModel.DataAnnotations;

namespace ResumeApp.Data.Entities
{
    public class Job
    {
        public Job()
        {
            this.JobAchievements = new HashSet<JobAchievement>();
        }

        [Key]
        public long JobId { get; set; }

        [Required]
        public DateTime StartDate { get; set; }

        public DateTime? EndDate { get; set; }

        [Required]
        [MaxLength(250)]
        public string JobTitle { get; set; }

        [Required]
        [MaxLength(600)]
        public string JobDescription { get; set; }

        [MaxLength(50)]
        public string City { get; set; }

        public long StateId { get; set; }

        public virtual State State { get; set; }

        public long ResumeId { get; set; }

        [Required, MaxLength(250)]
        public string EmployerName { get; set; }

        public virtual Resume Resume { get; set; }

        public virtual ICollection<JobAchievement> JobAchievements { get; set; }
    }
}
