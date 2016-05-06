CREATE TABLE [dbo].[City]
(
	[Id] INT IDENTITY(1,1) NOT NULL PRIMARY KEY
,   [Name] [nvarchar](50) NOT NULL
,   [CityTypeID] [int] NOT NULL
,   [DistrictID] [int] NULL
,   [RegionID] [int] NOT NULL
,   [LastUpdDT] [smalldatetime] NOT NULL
,   [LastUpdUS] [nvarchar](50) NOT NULL	
)
