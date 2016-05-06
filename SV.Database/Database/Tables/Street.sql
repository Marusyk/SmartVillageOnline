CREATE TABLE [dbo].[Street]
(
    [Id] INT IDENTITY(1,1) NOT NULL PRIMARY KEY
,   [Name] [nvarchar](50) NOT NULL
,   [StreetTypeId] [int] NOT NULL
,   [LastUpdDt] [smalldatetime] NOT NULL
,   [LastUpdUs] [nvarchar](50) NOT NULL	
)
