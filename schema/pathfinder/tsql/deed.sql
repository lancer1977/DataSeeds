USE [Pathfinder]
GO

/****** Object:  Table [dbo].[MagicItemDto]    Script Date: 10/24/2021 1:00:39 AM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[DeedDto]') AND type in (N'U'))
DROP TABLE [dbo].[DeedDto]
GO

/****** Object:  Table [dbo].[MagicItemDto]    Script Date: 10/24/2021 1:00:39 AM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DeedDto] (
	[Id] INT IDENTITY(1, 1) NOT NULL PRIMARY KEY,
	[Name] VARCHAR(50),
	[Description] VARCHAR(max),
	[Cost] INT NOT NULL,
	[Level] INT,
	[Passive] BIT,
	[Implemented] BIT,
	[ClassName] VARCHAR(100)
	)
