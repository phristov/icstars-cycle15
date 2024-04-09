namespace ResumeApp.Data.Entities
{
    public class ResumeProgrammingLanguageAssociation
    {
        public long ResumeProgrammingLanguageAssociationId { get; set; }

        public long ResumeId { get; set; }

        public virtual Resume Resume { get; set; }

        public long ProgrammingLanguageId { get; set; }

        public virtual ProgrammingLanguage ProgrammingLanguage { get; set; }
    }
}
