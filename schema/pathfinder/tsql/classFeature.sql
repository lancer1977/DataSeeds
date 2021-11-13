CREATE TABLE [dbo].[ClassFeatureDto] (
	[Id] INT IDENTITY(1, 1) NOT NULL PRIMARY KEY,
	[Name] VARCHAR(200),
	Archtype VARCHAR(50),
	SpellLike VARCHAR(30),
	[Level] INT NOT NULL,
	[Sacrifice] VARCHAR(Max),
	Implemented BIT NOT NULL,
	LevelsPerCharges INT NOT NULL,
	Calculation VARCHAR(30),
	[Description] VARCHAR(MAX),
	ClassName VARCHAR(50)
	)
