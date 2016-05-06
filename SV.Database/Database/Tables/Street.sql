CREATE TABLE [dbo].[Street]
(
    [Id] INT IDENTITY(1,1) NOT NULL PRIMARY KEY
,   [Name] [nvarchar](50) NOT NULL
,   [StreetTypeID] [int] NOT NULL
,   [LastUpdDT] [smalldatetime] NOT NULL
,   [LastUpdUS] [nvarchar](50) NOT NULL
)
