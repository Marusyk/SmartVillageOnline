CREATE TABLE [dbo].[Document]
(
    [Id] INT IDENTITY(1,1) NOT NULL PRIMARY KEY
,   [DocumentTypeId] [int] NULL
,   [Name] [nvarchar](100) NOT NULL
,   [PassAuthorityId] [int] NULL
,   [Number] [nvarchar](20)
,   [Code] [nvarchar](10)
,   [State] [bit] NOT NULL DEFAULT 0
,   [LastUpdDt] [smalldatetime] NOT NULL
,   [LastUpdUs] [nvarchar](50) NOT NULL
)
