CREATE TABLE [dbo].[Education]
(
	[Id] INT IDENTITY(1,1) NOT NULL PRIMARY KEY
,   [PersonID] [int] NOT NULL
,   [InstitutionID] [int] NOT NULL
,   [SpecialitiesID] [int] NULL
,   [EducationDegreeID] [int] NULL
,   [StartYear] [int] NULL
,   [EndYear] [int] NULL  
,   [DocumentID] [int] NULL
,   [Description] [nvarchar](500) 
,   [LastUpdDT] [smalldatetime] NOT NULL
,   [LastUpdUS] [nvarchar](50) NOT NULL
)
