CREATE TABLE [dbo].[Education]
(
	[Id] INT NOT NULL IDENTITY(1, 1)
,	[PersonId] INT NOT NULL
,	[InstitutionId] INT NOT NULL
,	[SpecialityId] INT
,	[EducationDegreeId] INT
,	[StartYear] INT
,	[EndYear] INT
,	[DocumentId] INT
,	[Description] NVARCHAR(500)
,	[LastUpdDt] SMALLDATETIME NOT NULL
,	[LastUpdUs] NVARCHAR(50) NOT NULL
,	CONSTRAINT [PK_Education] PRIMARY KEY CLUSTERED ([Id])
)
