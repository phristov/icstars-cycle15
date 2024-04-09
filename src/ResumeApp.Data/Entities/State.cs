using System.ComponentModel.DataAnnotations;

namespace ResumeApp.Data.Entities
{
    public class State
    {
        public State()
        {
            this.Jobs = new HashSet<Job>();
            this.People = new HashSet<Person>();
        }

        [Key]
        public long StateId { get; set; }

        public string StateName { get; set; }

        public string StateAbbreviation { get; set; }

        public ICollection<Job> Jobs { get;  set; }

        public ICollection<Person> People { get; set; }
    }
}
