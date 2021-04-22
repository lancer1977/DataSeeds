CREATE TABLE [dbo].[DeedDto] (
	[Id] INT IDENTITY(1, 1) NOT NULL PRIMARY KEY,
	[Name] VARCHAR(50),
	[Description] VARCHAR(max),
	[Cost] INT NOT NULL,
	[Level] INT,
	[Passive] BIT,
	[Implemented] BIT,
	[ClassName] VARCHAR(100)
	)
