﻿CREATE TABLE [dbo].[City]
(
	[Id] INT NOT NULL IDENTITY(1, 1)
,	[Name] NVARCHAR(50) NOT NULL
,	[CityTypeId] INT NOT NULL
,	[DistrictId] INT
,	[RegionId] INT NOT NULL
,	[LastUpdDt] SMALLDATETIME NOT NULL
,	[LastUpdUs] NVARCHAR(50) NOT NULL
,	CONSTRAINT [PK_City] PRIMARY KEY CLUSTERED ([Id])
)
