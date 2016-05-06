CREATE TABLE [dbo].[Catalog]
(
	[Id] INT IDENTITY(1,1) NOT NULL PRIMARY KEY
,   [ParentId] [int] NULL
,   [Name] [nvarchar](50) NOT NULL
,   [ModuleId] [int] NULL
,   [LastUpdDt] [smalldatetime] NOT NULL
,   [LastUpdUs] [nvarchar](50) NOT NULL
)
