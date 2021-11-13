USE [Pathfinder]
GO

/****** Object:  Table [dbo].[MagicItemDto]    Script Date: 10/24/2021 1:00:39 AM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[WeaponFeatureDto]') AND type in (N'U'))
DROP TABLE [dbo].[WeaponFeatureDto]
GO

/****** Object:  Table [dbo].[WeaponFeatureDto]    Script Date: 10/24/2021 1:00:39 AM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[WeaponFeatureDto] (
	[Id] INT IDENTITY(1, 1) NOT NULL PRIMARY KEY,
	[Name] VARCHAR(50), 
	[Description] VARCHAR(Max), 
	[Cost] INT
	)
