INSERT INTO pavel.[dbo].[Servers]
(ServerName)
VALUES
('NGINX'),
('MS SQL Server'),
('MariaDb'),
('MongoDb'),
('Redis'),
('PostgreSQL'),
('IIS'),
('Tomcat'),
('JBoss');

SELECT TOP (1000) [ServerId]
      ,[ServerName]

  FROM [dbo].[Servers]