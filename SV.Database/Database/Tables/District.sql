﻿CREATE TABLE [dbo].[District]
(
	[Id] INT NOT NULL IDENTITY(1, 1)
,	[Name] NVARCHAR(50) NOT NULL
,	[RegionId] INT NOT NULL
,	[LastUpdDt] SMALLDATETIME NOT NULL
,	[LastUpdUs] NVARCHAR(50) NOT NULL
,	CONSTRAINT [PK_District] PRIMARY KEY CLUSTERED ([Id])
)
