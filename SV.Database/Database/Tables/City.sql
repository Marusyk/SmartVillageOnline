CREATE TABLE [dbo].[City]
(
	[Id] INT IDENTITY(1,1) NOT NULL PRIMARY KEY
,   [Name] [nvarchar](50) NOT NULL
,   [CityTypeId] [int] NOT NULL
,   [DistrictId] [int] NULL
,   [RegionId] [int] NOT NULL
,   [LastUpdDt] [smalldatetime] NOT NULL
,   [LastUpdUs] [nvarchar](50) NOT NULL
)
