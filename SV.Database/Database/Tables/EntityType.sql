﻿CREATE TABLE [dbo].[EntityType]
(
	[Id] INT IDENTITY(1,1) NOT NULL PRIMARY KEY
,	[ParentId] INT
,	[Name] NVARCHAR(250) NOT NULL
,	[Description] NVARCHAR(500)
,	[SystemName] NVARCHAR(50) NOT NULL
)
