namespace ResumeApp.Data.Entities
{
    public class ResumeServerAssociation
    {
        public long ResumeServerAssociationId { get; set; }

        public long ResumeId { get; set; }

        public virtual Resume Resume { get; set; }

        public long ServerId { get; set; }

        public virtual Server Server { get; set; }
    }
}
