CREATE TABLE [dbo].[SYS_Administration]
(
	[Id] INT IDENTITY(1,1) NOT NULL PRIMARY KEY
,   [Name] [nvarchar](50) NOT NULL
,   [Description] [nvarchar](250)
,   [DataBaseName] [nvarchar](100)
,   [SVVersion] [nvarchar](50) NOT NULL
,   [DBVersion] [nvarchar](50) NOT NULL
,   [DataBaseGUID] [uniqueidentifier]
,   [LastUpdDT] [smalldatetime] NOT NULL
,   [LastUpdUS] [nvarchar](50) NOT NULL
)
