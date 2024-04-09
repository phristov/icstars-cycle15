USE [pavel]
GO

INSERT INTO [dbo].[Educations]
           ([GraduationYear]
           ,[UniversityId]
           ,[Degree]
           ,[DegreeTypeId]
           ,[ResumeId])
     VALUES
           (2008
           ,1
           ,'Biology'
           ,1
           ,1);
GO


select * from dbo.Educations
select * from dbo.DegreeTypes

insert into dbo.DegreeTypes
(DegreeTypeName)
values 
('Associate Degree'),
('Bachelor''s Degree'),
('Master''s Degree'),
('Doctorate Degree'),
('Professional Degree'),
('High School');


