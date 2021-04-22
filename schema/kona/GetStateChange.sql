USE [Kona]
GO

/****** Object: SqlProcedure [dbo].[GetAllChanges] Script Date: 4/21/2021 1:21:21 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

ALTER procedure dbo.GetAllChanges 
as
select 
	county.Cases,
	county.Deaths,
	County.Fips,
	County.[Date],
	loc.County,
	loc.[State]
from CountyChange county
left join  dbo.Location loc on loc.Fips = County.Fips

Select * from Location where State = "California"