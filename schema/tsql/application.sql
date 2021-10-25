USE [master]
GO

create table [dbo].[Application]
( 
	[Id] INT IDENTITY(1, 1) NOT NULL PRIMARY KEY,
	[Name] VARCHAR(40) NOT NULL,
	[InstallLink] varchar(200)  NULL,
	[PreviewImage] varchar(200)  NULL,
	[Description] varchar(200)  NULL,
)
