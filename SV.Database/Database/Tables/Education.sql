CREATE TABLE [dbo].[Education]
(
	[Id] INT IDENTITY(1,1) NOT NULL PRIMARY KEY
,   [PersonId] [int] NOT NULL
,   [InstitutionId] [int] NOT NULL
,   [SpecialitiesId] [int] NULL
,   [EducationDegreeId] [int] NULL
,   [StartYear] [int] NULL
,   [EndYear] [int] NULL  
,   [DocumentId] [int] NULL
,   [Description] [nvarchar](500) 
,   [LastUpdDt] [smalldatetime] NOT NULL
,   [LastUpdUs] [nvarchar](50) NOT NULL
)
