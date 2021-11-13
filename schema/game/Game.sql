

USE [VGCollect]
GO

/****** Object:  Table [dbo].[Games]    Script Date: 11/10/2021 10:59:24 AM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Games](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[GameId] [int] NOT NULL,
	[Name] [varchar](255) NULL,
	[AltName] [varchar](255) NULL,
	[ItemNumber] [varchar](255) NULL,
	[Barcode] [varchar](255) NULL,
	[BoxText] [varchar](max) NULL,
	[OtherText] [varchar](max) NULL,
	[ReleaseMonth] [varchar](255) NULL,
	[ReleaseDay] [varchar](255) NULL,
	[ReleaseYear] [varchar](255) NULL,
	[Image] [varchar](255) NULL,
	[ImageBack] [varchar](255) NULL,
	[CartArt] [varchar](255) NULL,
	[ReleaseType] [varchar](255) NULL,
	[PlatformId] [varchar](255) NULL,
	[Platform] [varchar](255) NULL,
	[PlatformSlug] [varchar](255) NULL,
	[Developer] [varchar](255) NULL,
	[Publisher] [varchar](255) NULL,
	[Genre] [varchar](255) NULL,
	[Rating] [varchar](255) NULL,
	[EstimatedValue] [varchar](255) NULL,
	[Url] [varchar](255) NULL,
     CONSTRAINT AK_GameId UNIQUE(GameId)   

);
GO


