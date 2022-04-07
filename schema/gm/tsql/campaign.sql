USE [GameMaster]
GO

/****** Object:  Table [dbo].[MagicItemDto]    Script Date: 10/24/2021 1:00:39 AM ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Campaign]') AND type in (N'U'))
DROP TABLE [dbo].[Campaign]
GO
 
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Campaign] (
	[Id] INT IDENTITY(1, 1) NOT NULL PRIMARY KEY,
	[Name] VARCHAR(50),
	[GameMasterName] VARCHAR(250),
	[StartDate] DateTime, 
	[Note] VARCHAR(max),
	[Description] VARCHAR(max) 
	)
