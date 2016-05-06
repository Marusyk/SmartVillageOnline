CREATE TABLE [dbo].[Employment]
(
	[Id] INT IDENTITY(1,1) NOT NULL PRIMARY KEY
,   [PersonId] [int] NOT NULL
,   [ActivityTypesId] [int] NULL
,   [CompanyId] [int] NULL
,   [PositionId] [int] NULL
,   [DateStart] [smalldatetime] NULL
,   [DateEnd] [smalldatetime] NULL
,   [IsCurrent] [bit] NOT NULL DEFAULT 0
,   [Description] [nvarchar](500) NULL
,   [LastUpdDt] [smalldatetime] NOT NULL
,   [LastUpdUs] [nvarchar](50) NOT NULL
)
