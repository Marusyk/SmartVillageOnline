CREATE TABLE [dbo].[People]
(
	[Id] INT NOT NULL IDENTITY(1, 1)
,	[PersonId] INT NOT NULL
,	[HouseId] INT NOT NULL
,	[PeopleNumber] INT NOT NULL
,	[FamilyRelationId] INT
,	[DateRegistration] DATE
,	[IsMain] BIT NOT NULL DEFAULT 0
,	[LastUpdDt] SMALLDATETIME NOT NULL
,	[LastUpdUs] NVARCHAR(50) NOT NULL
,	CONSTRAINT [PK_People] PRIMARY KEY CLUSTERED ([Id])
)
