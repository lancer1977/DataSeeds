
CREATE TABLE [dbo].[TraitDto]
(
	[Id] INT IDENTITY(1, 1) NOT NULL PRIMARY KEY, 
	[Name] VARCHAR(255),
	--Imp BIT NOT NULL,
	Options VARCHAR(80),
	BenefitType VARCHAR(50),
	BenefitAmount INT NOT NULL,
	BenefitDescription VARCHAR(300),
	[Description] VARCHAR(MAX),
	Category VARCHAR(50),
	[Type] VARCHAR(50),
	Prerequisites VARCHAR(75),
	PfsLegal VARCHAR(50),
	[Source] VARCHAR(50),
	[Version] VARCHAR(50),
	Implemented bit
	)
