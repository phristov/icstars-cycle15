USE [pavel]
GO

INSERT INTO [dbo].[Jobs]
           ([StartDate]
           ,[EndDate]
           ,[JobTitle]
           ,[JobDescription]
           ,[City]
           ,[StateId]
           ,[ResumeId]
           ,[EmployerName])
     VALUES
           ('2010-06-01', '2012-03-15', 'Software Developer',
           'Lorem ipsum dolor sit amet, consectetur adipiscing elit. Quisque eu egestas nibh, at pretium urna. Nunc ut hendrerit elit. Duis tempor orci maximus ligula aliquam, eget mollis mi consequat. Nam pretium leo sed ante dignissim finibus. Nullam ut lacinia sem. Praesent porta eget sapien a molestie. Sed vestibulum purus arcu, accumsan sollicitudin ligula ultricies et. Nulla sed suscipit turpis. Maecenas placerat condimentum mauris, eu sagittis leo vehicula vel. Donec scelerisque ante sem, venenatis tempor enim bibendum nec.'
           ,'Milwaukee'
           ,51
           ,1
           ,'Employer')
GO

select * from dbo.states


