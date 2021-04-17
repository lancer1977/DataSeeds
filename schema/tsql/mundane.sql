CREATE TABLE [dbo].[MundaneItemDto] (
	[Id] INT IDENTITY(1, 1) NOT NULL,
	[Name] VARCHAR(250),
	Cost INT NOT NULL,
	[Weight] VARCHAR(50),
	[Category] VARCHAR(50),
	[Description] VARCHAR(max),
	[Source] VARCHAR(16),
	Subtype VARCHAR(16),
	)
