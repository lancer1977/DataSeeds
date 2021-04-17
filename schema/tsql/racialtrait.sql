CREATE TABLE [dbo].[RacialTraitDto] (
	[Id] INT IDENTITY(1, 1) NOT NULL,
	[Name] VARCHAR(255),
	Alternate BIT NOT NULL,
	Race VARCHAR(50),
	Implemented BIT NOT NULL,
	[Replaces] VARCHAR(50),
	BenefitType VARCHAR(50),
	BenefitValue VARCHAR(150),
	[Description] VARCHAR(max)
	)