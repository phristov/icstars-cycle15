namespace ResumeApp.WebApi.Dtos
{
    public class ServerDto
    {
        public long ServerId { get; set; }

        public string ServerName { get; set; }
    }

    public class EducationDegreeTypeDto
    {
        public string DegreeTypeName { get; set; }
        public long DegreeTypeId { get; internal set; }
    }
}