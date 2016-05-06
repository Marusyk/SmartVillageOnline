CREATE TABLE [dbo].[PersonDocument]
(
    [Id] INT IDENTITY(1,1) NOT NULL PRIMARY KEY
,   [PersonId] [int] NOT NULL
,   [DocumentId] [int] NOT NULL
,   [LastUpdDt] [smalldatetime] NOT NULL
,   [LastUpdUs] [nvarchar](50) NOT NULL	
)
