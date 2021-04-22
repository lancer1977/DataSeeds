CREATE TABLE [dbo].[LocationModel] (
	[Id] INT NOT NULL IDENTITY(1,1),
	[Fips] INT NULL,
	[County] VARCHAR(150),
	[State] VARCHAR(150),
	[Population] INT NOT NULL
	)
 
CREATE TABLE [dbo].[CountyChange] (
    [Fips]   INT       NOT NULL,
    [Date]   Date  NOT NULL,
    [Cases]  INT     NOT NULL  ,
    [Deaths] INT     NOT NULL
);
