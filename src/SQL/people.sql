INSERT INTO [dbo].[People]
           ([FirstName]
           ,[LastName]
           ,[PhoneNumber]
           ,[Email]
           ,[StreetLineOne]
           ,[StreetLineTwo]
           ,[City]
           ,[StateId])
     VALUES
           ('Michael','Smith', '233-634-4605','michael@smith.com','Steet Address','Stree Address2','Milwaukee',51)
GO

select * from dbo.People;

INSERT INTO [dbo].[Resumes]
           ([PersonId]
           ,[Summary])
     VALUES
           (1, 'A highly skilled Software Developer with 4 years of professional experience in design, development, testing, and optimization of software applications, striving to provide best-in-class solutions. Developed, maintained and optimized software applications to uphold superior customer satisfaction and achieved 200% performance improvement. Selected and implemented a new testing tool and trained a team to generate potential areas for improvement in software architecture, to achieve strategic and');
GO

select * from dbo.Resumes;






