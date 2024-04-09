using System.ComponentModel.DataAnnotations;

namespace ResumeApp.WebApi.Dtos
{
    public class ResumeDto
    {
        public long ResumeId { get; set; }

        public string Summary { get; set; }

        public ICollection<JobDto> Jobs { get; set; }

        public ICollection<EducationDto> Educations { get; set; }

        public long PersonId { get; set; }

        public PersonDto Person { get; set; }
    }

    public class PersonDto
    {
        public long PersonId { get; set; }

        public string LastName { get; set; }

        public string FirstName { get; set; }

        public string PhoneNumber { get; set; }

        public string Email { get; set; }
    }

    public class EducationDto
    {
        public long EducationId { get; set; }

        public string Degree { get; set; }

        public string GraduationYear { get; set; }

        public EducationDegreeTypeDto DegreeType { get; set; }

        public long DegreeTypeId { get; set; }
    }

    public class JobDto
    {
        public long JobId { get; set; }

        [Required]
        public DateTime StartDate { get; set; }

        public DateTime? EndDate { get; set; }

        [Required]
        [MaxLength(100)]
        public string JobTitle { get; set; }

        [Required]
        [MaxLength(300)]
        public string JobDescription { get; set; }

        [MaxLength(50)]
        public string City { get; set; }

        public long StateId { get; set; }

        public StateDto State { get; set; }

        public long ResumeId { get; set; }

        public virtual ICollection<JobAchievementDto> JobAchievements { get; set; }

        public string EmployerName { get; internal set; }
    }

    public class JobAchievementDto
    {
        public string JobAchievementDescription { get; set; }

        public long JobAchievementId { get; set; }
    }

    public class StateDto
    {
        public long StateId { get; set; }

        public string StateAbbreviation { get; set; }

        public string StateName { get; set; }
    }
}
