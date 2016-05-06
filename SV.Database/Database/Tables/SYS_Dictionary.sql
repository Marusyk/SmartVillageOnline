CREATE TABLE [dbo].[SYS_Dictionary]
(
	[Id] INT IDENTITY(1,1) NOT NULL PRIMARY KEY
,   [Name] [nvarchar](50) NOT NULL
,   [Description] [nvarchar](250) NOT NULL
,   [IsStatic] [bit] NOT NULL DEFAULT 0
,   [LastUpdDT] [smalldatetime] NOT NULL
,   [LastUpdUS] [nvarchar](50) NOT NULL	
)
