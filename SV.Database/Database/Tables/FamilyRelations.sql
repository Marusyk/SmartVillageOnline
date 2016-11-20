﻿CREATE TABLE [dbo].[FamilyRelations]
(
	[Id] INT NOT NULL IDENTITY(1, 1)
,	[Name] NVARCHAR(50) NOT NULL
,	[LastUpdDt] SMALLDATETIME NOT NULL
,	[LastUpdUs] NVARCHAR(50) NOT NULL
,	CONSTRAINT [PK_FamilyRelations] PRIMARY KEY CLUSTERED ([Id])
)
