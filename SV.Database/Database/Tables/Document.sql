﻿CREATE TABLE [dbo].[Document]
(
	[Id] INT NOT NULL IDENTITY(1, 1)
,	[DocumentTypeId] INT
,	[Name] NVARCHAR(100) NOT NULL
,	[PassAuthorityId] INT
,	[Number] NVARCHAR(20)
,	[Code] NVARCHAR(10)
,	[State] BIT NOT NULL DEFAULT 0
,	[CouncilId] INT NOT NULL
,	[LastUpdDt] SMALLDATETIME NOT NULL
,	[LastUpdUs] NVARCHAR(50) NOT NULL
,	CONSTRAINT [PK_Document] PRIMARY KEY CLUSTERED ([Id])
)
