using System.ComponentModel.DataAnnotations;

namespace ResumeApp.Data.Entities
{
    public class Server
    {
        public Server()
        {
            this.ResumeServerAssociations = new HashSet<ResumeServerAssociation>();
        }

        [Key]
        public long ServerId { get; set; }

        [Required]
        [MaxLength(50)]
        public string ServerName { get; set; }

        public virtual ICollection<ResumeServerAssociation> ResumeServerAssociations { get; set; }
    }
}
