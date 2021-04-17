--DROp  TABLE [dbo].[ArmorDto]
CREATE TABLE [dbo].[ArmorDto] (
	[Id] INT IDENTITY(1, 1) NOT NULL,
	[Name] VARCHAR(40) NOT NULL,
	[Cost] INT NULL,
	[Weight] INT NULL,
	[BaseAC] INT NULL,
	[MaxDex] INT NULL,
	[ArmorCheckPenalty] INT NULL,
	[ArcaneSpellFailure] INT NULL,
	[Move30] INT NULL,
	[Move20] INT NULL,
	[Category] VARCHAR(15) NULL,
	[ItemType] VARCHAR(15) NULL,
	[Source] VARCHAR(15) NULL,
	[License] VARCHAR(10),
	[Subtype] VARCHAR(10),
	[System] VARCHAR(10)
	);
