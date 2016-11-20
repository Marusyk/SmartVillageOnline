﻿CREATE TABLE [dbo].[Material]
(
	[Id] INT NOT NULL IDENTITY(1, 1)
,	[Name] NVARCHAR(50) NOT NULL
,	[CouncilId] INT NOT NULL
,	[LastUpdDt] SMALLDATETIME NOT NULL
,	[LastUpdUs] NVARCHAR(50) NOT NULL
,	CONSTRAINT [PK_Material] PRIMARY KEY CLUSTERED ([Id])
)
