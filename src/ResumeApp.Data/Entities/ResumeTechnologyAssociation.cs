namespace ResumeApp.Data.Entities
{
    public class ResumeTechnologyAssociation
    {
        public long ResumeTechnologyAssociationId { get; set; }

        public long ResumeId { get; set; }

        public virtual Resume Resume { get; set; }

        public long TechnologyId { get; set; }

        public virtual Technology Technology { get; set; }
    }
}
