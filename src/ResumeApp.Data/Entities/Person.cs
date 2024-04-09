using System.ComponentModel.DataAnnotations;

namespace ResumeApp.Data.Entities
{
    public class Person
    {
        public Person()
        {
            this.Resumes = new HashSet<Resume>();
        }

        [Key]
        public long PersonId { get; set; }

        [Required]
        [MaxLength(50)]
        public string FirstName { get; set; }

        [Required]
        [MaxLength(50)]
        public string LastName { get; set; }

        [Required]
        [MaxLength(12)]
        public string PhoneNumber { get; set; }

        [Required]
        [MaxLength(50)]
        public string Email { get; set; }

        [Required]
        [MaxLength(50)]
        public string StreetLineOne { get; set; }

        [MaxLength(50)]
        public string? StreetLineTwo { get; set; }

        [Required]
        [MaxLength(50)]
        public string City { get; set; }

        public long StateId { get; set; }

        public virtual State State { get; set; }

        public ICollection<Resume> Resumes { get; set; }
    }
}
