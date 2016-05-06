CREATE TABLE [dbo].[PensionType]
(
    [Id] INT IDENTITY(1,1) NOT NULL PRIMARY KEY
,   [Name] [nvarchar](50) NOT NULL
,   [LastUpdDt] [smalldatetime] NOT NULL
,   [LastUpdUs] [nvarchar](50) NOT NULL
)
