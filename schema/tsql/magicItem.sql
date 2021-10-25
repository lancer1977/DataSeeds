USE [Pathfinder]
GO

/****** Object:  Table [dbo].[MagicItemDto]    Script Date: 10/24/2021 1:00:39 AM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[MagicItemDto]') AND type in (N'U'))
DROP TABLE [dbo].[MagicItemDto]
GO

/****** Object:  Table [dbo].[MagicItemDto]    Script Date: 10/24/2021 1:00:39 AM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[MagicItemDto] 
(
	[Id] INT IDENTITY(1, 1) NOT NULL PRIMARY KEY,
	[Name] VARCHAR(80),
	Effect VARCHAR(50),
	Implemented BIT NOT NULL,
	Aura VARCHAR(100),
	CL INT,
	ItemType VARCHAR(50),
	[Weight] INT,
	[WeightValue] INT NULL,
	[Description] VARCHAR(300),
	[Requirements] VARCHAR(300),
	ItemCategory VARCHAR(50),
	[Source] VARCHAR(50),
	Cost INT NOT NULL,
	AL VARCHAR(50),
	[Int] INT,
	Wis INT,
	Cha INT,
	Ego INT,
	Communication VARCHAR(50),
	Senses VARCHAR(85),
	Powers VARCHAR(150),
	MagicItems VARCHAR(250),
	Destruction  BIT NULL,
	MinorArtifactFlag BIT NULL,
	MajorArtifactFlag BIT NULL,
	Abjuration BIT NULL,
	Conjuration BIT NULL,
	Divination BIT NULL,
	Enchantment BIT NULL,
	Evocation BIT NULL,
	Necromancy BIT NULL,
	Transmutation BIT NULL,
	AuraStrength VARCHAR(50),
	Languages VARCHAR(50),
	BaseItem VARCHAR(100)
	)
