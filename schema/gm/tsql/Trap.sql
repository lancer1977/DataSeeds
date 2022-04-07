USE [GameMaster]
GO

IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Trap]') AND type in (N'U'))
DROP TABLE [dbo].[Trap]
GO
 
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Trap] (
	[Id] INT IDENTITY(1, 1) NOT NULL PRIMARY KEY, 
	[CampaignId] int FOREIGN KEY REFERENCES Campaign(Id),
	[Name] VARCHAR(50),
	[Note] VARCHAR(max),
	[Description] VARCHAR(max) ,
	[Trigger] VARCHAR(max),
	[Reset] VARCHAR(max),
	[Effect] VARCHAR(max),
	[TrapType] VARCHAR(max),
	[XP] INT,
	[DisableDc] INT,
	[PerceptionDc] INT,
	[Cr] VARCHAR(max),
	)
 