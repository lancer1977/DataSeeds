DROP TABLE dbo.AmmoDto;

CREATE TABLE [dbo].[AmmoDto] (
	[Id] INT IDENTITY(1, 1) NOT NULL,
	[Name] VARCHAR(50),
	Cost INT NOT NULL,
	[Weight] INT,
	DamageType VARCHAR(20),
	[Source] VARCHAR(15),
	AmmoType VARCHAR(15),
	Quantity INT,
	Special VARCHAR(15),
	Misfire INT,
	[Range] INT,
	Subtype VARCHAR(10),
	Category VARCHAR(1)
	)
