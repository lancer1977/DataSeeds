CREATE TABLE [dbo].[PowerDto] (
	[Id] INT IDENTITY(1, 1) NOT NULL PRIMARY KEY,
	[Name] VARCHAR(275),
	[Type] VARCHAR(50),
	Implemented BIT NOT NULL,
	[Level] INT NOT NULL,
	Subtype VARCHAR(15),
	Prereq VARCHAR(100),
	SpellLike VARCHAR(50),
	Rogue INT,
	Slayer INT,
	Ninja INT,
	Investigator INT,
	[Description] VARCHAR(Max)
	)
