CREATE TABLE [Master].[dbo].[SpeedMathResult] (
	[Id] INT IDENTITY(1, 1) NOT NULL PRIMARY KEY,
	[Name] VARCHAR(255), 
 	[Seconds] INTEGER,
	 [Questions] INTEGER,
	 [Feature] INTEGER,
	 [Difficulty] INTEGER,
	[Date] DATETIME 	 
	)
