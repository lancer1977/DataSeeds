CREATE TABLE [dbo].[RaceDto] (
	[Id] INT IDENTITY(1, 1) NOT NULL,
	[Name] VARCHAR(50),
	[Str] INT NOT NULL,
	[Dex] INT NOT NULL,
	[Con] INT NOT NULL,
	[Wis] INT NOT NULL,
	[Int] INT NOT NULL,
	[Cha] INT NOT NULL,
	[Move] INT NOT NULL,
	[Advanced] INT NOT NULL,
	[Subtype] VARCHAR(50),
	[Languages] VARCHAR(50),
	[Source] VARCHAR(50)
	)
