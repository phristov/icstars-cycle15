using System.ComponentModel.DataAnnotations;

namespace ResumeApp.Data.Entities
{
    public class JobAchievement
    {
        [Key]
        public long JobAchievementId { get; set; }

        [Required]
        [MaxLength(300)]
        public string JobAchievementDescription { get; set; }

        public long JobId { get; set; }

        public virtual Job Job { get; set; }
    }
}
