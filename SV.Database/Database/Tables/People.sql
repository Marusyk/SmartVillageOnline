CREATE TABLE [dbo].[People]
(
	[Id] INT IDENTITY(1,1) NOT NULL PRIMARY KEY
,   [PersonID] [int] NOT NULL
,   [HouseID] [int] NOT NULL
,   [PeopleNumber] [int] NOT NULL
,   [FamilyRelationID] [int] NULL
,   [DateRegistration] [datetime] NULL
,   [IsMain] [bit] NOT NULL DEFAULT 0
,   [LastUpdDT] [smalldatetime] NOT NULL
,   [LastUpdUS] [nvarchar](50) NOT NULL	
)
