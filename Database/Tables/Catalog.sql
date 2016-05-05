CREATE TABLE [dbo].[Catalog]
(
	[Id] INT IDENTITY(1,1) NOT NULL PRIMARY KEY
,   [ParentId] [int] NULL
,   [Name] [nvarchar](50) NOT NULL
,   [ModuleId] [int] NULL
,   [LastUpdDT] [smalldatetime] NOT NULL
,   [LastUpdUS] [nvarchar](50) NOT NULL
)
