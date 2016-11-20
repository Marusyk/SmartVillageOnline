CREATE TABLE [dbo].[Person]
(
	[Id] INT NOT NULL IDENTITY(1, 1)
,	[FirstName] NVARCHAR(60) NOT NULL
,	[LastName] NVARCHAR(60) NOT NULL
,	[MiddleName] NVARCHAR(60) NOT NULL
,	[DateBirth] DATE NOT NULL
,	[Sex] BIT
,	[IsResident] BIT NOT NULL DEFAULT 1
,	[AddressBirthId] INT
,	[AddressLiveId] INT
,	[NationalityId] INT
,	[IdentificationCode] NVARCHAR(10)
,	[PassSeria] NVARCHAR(5)
,	[PassNr] INT
,	[PassDate] DATE
,	[PassAuthorityId] INT
,	[FamilyStatusId] INT
,	[CitizenshipId] INT
,	[CatalogId] INT NOT NULL
,	[IsSojourn] BIT NOT NULL DEFAULT 0
,	[Photo] BINARY
,	[PadFirstName] NVARCHAR(60)
,	[PadName] NVARCHAR(60)
,	[PadLastName] NVARCHAR(60)
,	[DatFirstName] NVARCHAR(60)
,	[DatName] NVARCHAR(60)
,	[DatLastName] NVARCHAR(60)
,	[CouncilId] INT NOT NULL
,	[LastUpdDt] SMALLDATETIME NOT NULL
,	[LastUpdUs] NVARCHAR(50) NOT NULL
,	CONSTRAINT [PK_Person] PRIMARY KEY CLUSTERED ([Id])
)
