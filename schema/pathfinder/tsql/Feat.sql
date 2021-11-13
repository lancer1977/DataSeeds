CREATE TABLE [dbo].[FeatDto] (
	[Id] [int] IDENTITY(1, 1) NOT NULL,
	[Name] VARCHAR(255) NOT NULL,
	[Type] VARCHAR(50) NULL,
	Implemented BIT NOT NULL,
	Prerequistites VARCHAR(300) NULL,
	[Description] VARCHAR(MAX) NULL,
	Benefits VARCHAR(300) NULL,
	[Source] VARCHAR(40) NULL,
	[System] VARCHAR(10) NULL,
	License VARCHAR(50) NULL,
	Multiple BIT NOT NULL,
	Options VARCHAR(50) NULL,
	[PrereqFeat] VARCHAR(150) NULL
	)
