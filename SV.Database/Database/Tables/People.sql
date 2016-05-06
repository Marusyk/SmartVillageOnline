CREATE TABLE [dbo].[People]
(
	[Id] INT IDENTITY(1,1) NOT NULL PRIMARY KEY
,   [PersonId] [int] NOT NULL
,   [HouseId] [int] NOT NULL
,   [PeopleNumber] [int] NOT NULL
,   [FamilyRelationId] [int] NULL
,   [DateRegistration] [datetime] NULL
,   [IsMain] [bit] NOT NULL DEFAULT 0
,   [LastUpdDt] [smalldatetime] NOT NULL
,   [LastUpdUs] [nvarchar](50) NOT NULL
)
