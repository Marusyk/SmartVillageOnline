CREATE TABLE [dbo].[Employment]
(
	[Id] INT IDENTITY(1,1) NOT NULL PRIMARY KEY
,   [PersonID] [int] NOT NULL
,   [ActivityTypesID] [int] NULL
,   [CompanyID] [int] NULL
,   [PositionID] [int] NULL
,   [DateStart] [smalldatetime] NULL
,   [DateEnd] [smalldatetime] NULL
,   [IsCurrent] [bit] NOT NULL DEFAULT 0
,   [Description] [nvarchar](500) NULL
,   [LastUpdDT] [smalldatetime] NOT NULL
,   [LastUpdUS] [nvarchar](50) NOT NULL
)
