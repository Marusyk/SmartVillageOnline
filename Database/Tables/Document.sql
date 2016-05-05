CREATE TABLE [dbo].[Document]
(
    [Id] INT IDENTITY(1,1) NOT NULL PRIMARY KEY
,   [DocumentTypeID] [int] NULL
,   [Name] [nvarchar](100) NOT NULL
,   [PassAuthorityID] [int] NULL
,   [Number] [nvarchar](20)
,   [Code] [nvarchar](10)
,   [State] [bit] NOT NULL DEFAULT 0
,   [LastUpdDT] [smalldatetime] NOT NULL
,   [LastUpdUS] [nvarchar](50) NOT NULL
)
