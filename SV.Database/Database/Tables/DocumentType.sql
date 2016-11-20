﻿CREATE TABLE [dbo].[DocumentType]
(
	[Id] INT NOT NULL IDENTITY(1, 1)
,	[Name] NVARCHAR(50) NOT NULL
,	[Code] NVARCHAR(20)
,	[CouncilId] INT NOT NULL
,	[LastUpdDt] SMALLDATETIME NOT NULL
,	[LastUpdUs] NVARCHAR(50) NOT NULL
,	CONSTRAINT [PK_DocumentType] PRIMARY KEY CLUSTERED ([Id])
)
