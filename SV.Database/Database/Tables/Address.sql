CREATE TABLE [dbo].[Address]
(
	[Id] INT IDENTITY(1,1) NOT NULL PRIMARY KEY
,   [CityID] [int] NOT NULL
,   [StreetID] [int] NULL
,   [PostCode] [int] NULL
,   [BuildNr] [nvarchar](10) NULL
,   [FlatNr] [nvarchar](10) NULL
,   [LastUpdDT] [smalldatetime] NOT NULL
,   [LastUpdUS] [nvarchar](50) NOT NULL	
)
