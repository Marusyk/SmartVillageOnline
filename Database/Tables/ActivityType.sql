CREATE TABLE [dbo].[ActivityType]
(
	[Id] INT IDENTITY(1,1) NOT NULL PRIMARY KEY
,	[Name] [nvarchar](50) NOT NULL
,   [LastUpdDT] [smalldatetime] NOT NULL
,   [LastUpdUS] [nvarchar](50) NOT NULL
)
