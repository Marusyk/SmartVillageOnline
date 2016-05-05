CREATE TABLE [dbo].[PersonDocument]
(
    [Id] INT IDENTITY(1,1) NOT NULL PRIMARY KEY
,   [PersonID] [int] NOT NULL
,   [DocumentID] [int] NOT NULL
,   [LastUpdDT] [smalldatetime] NOT NULL
,   [LastUpdUS] [nvarchar](50) NOT NULL
)
