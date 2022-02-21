CREATE TABLE [dbo].[ExternalUserRecord](
    [Id] INT IDENTITY(1,1) NOT NULL,
    PolyhydraId varchar(50),	
    [Provider] varchar(50),	
    AccessToken varchar(50),	 
);

GO;
CREATE TABLE [dbo].[PolyhydraUser](
  [Id] INT IDENTITY(1,1) NOT NULL,
    PolyhydraId varchar(50),	
    [Name]varchar(255),	
    Email varchar(50),	
);