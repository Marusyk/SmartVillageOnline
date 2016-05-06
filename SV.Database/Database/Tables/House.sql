CREATE TABLE [dbo].[House]
(
	[Id] INT IDENTITY(1,1) NOT NULL PRIMARY KEY
,   [HouseNr] [nvarchar](10) NOT NULL
,   [KadastrNr] [nvarchar](30)
,   [BuildNr] [nvarchar](10) NOT NULL
,   [AddressId] [int] NOT NULL
,   [PhoneNr] [nvarchar](12) NULL
,   [PhoneCode] [nvarchar](5) NULL
,   [FaxNr] [nvarchar](12) NULL
,   [Year] [int] NULL
,   [Code] [nvarchar](50) NULL
,   [LastUpdDt] [smalldatetime] NOT NULL
,   [LastUpdUs] [nvarchar](50) NOT NULL
)
