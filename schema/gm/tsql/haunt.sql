USE [GameMaster]
GO

IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Haunt]') AND type in (N'U'))
DROP TABLE [dbo].[Haunt]
GO
 
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Haunt] (
	[Id] INT IDENTITY(1, 1) NOT NULL PRIMARY KEY, 
	[CampaignId] int FOREIGN KEY REFERENCES Campaign(Id),
	[Name] VARCHAR(50),
	[Note] VARCHAR(max),
	[Description] VARCHAR(max),
	 [Treasure] VARCHAR(250), 
        [Alignment] VARCHAR(250), 
 		[CasterLevel] int, 
        [Notice] VARCHAR(250),
        [HP] int, 
        [Weakness] VARCHAR(250), 
        [Trigger] VARCHAR(250), 
        [Reset] VARCHAR(250), 
        [Effect] VARCHAR(250), 
        [Destruction] VARCHAR(250), 
        [Notes] VARCHAR(250), 
        [XP] int
	)

 