﻿CREATE TABLE [dbo].[PersonDocument]
(
	[Id] INT NOT NULL IDENTITY(1, 1)
,	[PersonId] INT NOT NULL
,	[DocumentId] INT NOT NULL
,	[LastUpdDt] SMALLDATETIME NOT NULL
,	[LastUpdUs] NVARCHAR(50) NOT NULL
,	CONSTRAINT [PK_PersonDocument] PRIMARY KEY CLUSTERED ([Id])
)
