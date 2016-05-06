CREATE TABLE [dbo].[Address]
(
	[Id] INT IDENTITY(1,1) NOT NULL PRIMARY KEY
,   [CityId] [int] NOT NULL
,   [StreetId] [int] NULL
,   [PostCode] [int] NULL
,   [BuildNr] [nvarchar](10) NULL
,   [FlatNr] [nvarchar](10) NULL
,   [LastUpdDt] [smalldatetime] NOT NULL
,   [LastUpdUs] [nvarchar](50) NOT NULL
)
