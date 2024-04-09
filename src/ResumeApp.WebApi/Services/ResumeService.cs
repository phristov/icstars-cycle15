using ResumeApp.Data;
using ResumeApp.WebApi.Dtos;

namespace ResumeApp.WebApi.Services
{
    public interface IResumeService
    {
        ResumeDto GetById(long id);

        ICollection<ResumeDto> GetAll();
    }

    public class ResumeService : IResumeService
    {
        public ResumeService(ResumeAppDbContext dbContext)
        {
            this.DbContext = dbContext;
        }

        public ResumeAppDbContext DbContext { get; }

        public ResumeDto GetById(long id)
        {
            var data = this.DbContext.Resumes
                .Where(x => x.ResumeId == id)
                .Select(x => new ResumeDto()
                {
                    ResumeId = x.ResumeId,
                    Summary = x.Summary,
                    PersonId = x.PersonId,
                    Educations = x.Educations.Select(education => new EducationDto()
                    {
                        EducationId = education.EducationId,
                        GraduationYear = education.GraduationYear,
                        Degree = education.Degree,
                        DegreeTypeId = education.DegreeTypeId,
                        DegreeType = new EducationDegreeTypeDto()
                        {
                            DegreeTypeId = education.DegreeTypeId,
                            DegreeTypeName = education.DegreeType.DegreeTypeName,
                        }
                    })
                    .ToList(),
                    Person = new PersonDto()
                    {
                        PersonId = x.Person.PersonId,
                        LastName = x.Person.LastName,
                        FirstName = x.Person.FirstName,
                        PhoneNumber = x.Person.PhoneNumber,
                        Email = x.Person.Email,
                    },
                    Jobs = x.Jobs.Select(job => new JobDto()
                    {
                        JobId = job.JobId,
                        StateId = job.StateId,
                        State = new StateDto()
                        {
                            StateId = job.State.StateId,
                            StateAbbreviation = job.State.StateAbbreviation,
                            StateName = job.State.StateName,
                        },
                        City = job.City,
                        StartDate = job.StartDate,
                        EndDate = job.EndDate,
                        JobDescription = job.JobDescription,
                        JobTitle = job.JobTitle,
                        EmployerName = job.EmployerName,
                        JobAchievements = job.JobAchievements.Select(a => new JobAchievementDto()
                        {
                            JobAchievementId = a.JobAchievementId,
                            JobAchievementDescription = a.JobAchievementDescription
                        })
                        .ToList(),
                    })
                    .ToList()
                })
               .FirstOrDefault();

            return data;
        }

        public ICollection<ResumeDto> GetAll()
        {
            var data = this.DbContext.Resumes
                .Select(x => new ResumeDto()
                {
                    ResumeId = x.ResumeId,
                    Summary = x.Summary,
                    PersonId = x.PersonId,
                    Educations = x.Educations.Select(education => new EducationDto()
                    {
                        EducationId = education.EducationId,
                        GraduationYear = education.GraduationYear,
                        Degree = education.Degree,
                        DegreeTypeId = education.DegreeTypeId,
                        DegreeType = new EducationDegreeTypeDto()
                        {
                            DegreeTypeId = education.DegreeTypeId,
                            DegreeTypeName = education.DegreeType.DegreeTypeName,
                        }
                    })
                    .ToList(),
                    Person = new PersonDto()
                    {
                        PersonId = x.Person.PersonId,
                        LastName = x.Person.LastName,
                        FirstName = x.Person.FirstName,
                        PhoneNumber = x.Person.PhoneNumber,
                        Email = x.Person.Email,
                    },
                    Jobs = x.Jobs.Select(job => new JobDto()
                    {
                        JobId = job.JobId,
                        StateId = job.StateId,
                        State = new StateDto()
                        {
                            StateId = job.State.StateId,
                            StateAbbreviation = job.State.StateAbbreviation,
                            StateName = job.State.StateName,
                        },
                        City = job.City,
                        StartDate = job.StartDate,
                        EndDate = job.EndDate,
                        JobDescription = job.JobDescription,
                        JobTitle = job.JobTitle,
                        EmployerName = job.EmployerName,
                        JobAchievements = job.JobAchievements.Select(a => new JobAchievementDto()
                        {
                            JobAchievementId = a.JobAchievementId,
                            JobAchievementDescription = a.JobAchievementDescription
                        })
                        .ToList(),
                    })
                    .ToList()
                })
            .ToList();

            return data;
        }
    }
}
