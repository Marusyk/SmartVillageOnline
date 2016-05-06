CREATE TABLE [dbo].[DocumentType]
(
    [Id] INT IDENTITY(1,1) NOT NULL PRIMARY KEY
,   [Name] [nvarchar](50) NOT NULL
,   [Code] [nvarchar](20) NULL
,   [LastUpdDt] [smalldatetime] NOT NULL
,   [LastUpdUs] [nvarchar](50) NOT NULL
)
