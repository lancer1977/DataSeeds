CREATE TABLE [dbo].[SkillDto] (
	[Id] INT IDENTITY(1, 1) NOT NULL,
	[Name] VARCHAR(255),
	Stat VARCHAR(50),
	[Description] VARCHAR(MAX),
	Game VARCHAR(50),
	Trained BIT NOT NULL,
	CategoryId INT NOT NULL
	)
