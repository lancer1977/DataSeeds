USE [GameMaster]
GO

IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Location]') AND type in (N'U'))
DROP TABLE [dbo].[Location]
GO
 
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Location] (
	[Id] INT IDENTITY(1, 1) NOT NULL PRIMARY KEY, 
	[CampaignId] int FOREIGN KEY REFERENCES Campaign(Id),
	[Name] VARCHAR(50),
	[Note] VARCHAR(max),
	[Description] VARCHAR(max) ,
	[Treasure]  VARCHAR(max) ,
	[Creatures]  VARCHAR(max) ,
 	[DmInfo] VARCHAR(max) 
	)

 
 
 