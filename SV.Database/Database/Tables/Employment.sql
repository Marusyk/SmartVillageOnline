CREATE TABLE [dbo].[Employment]
(
	[Id] INT NOT NULL IDENTITY(1, 1)
,	[PersonId] INT NOT NULL
,	[ActivityTypeId] INT
,	[CompanyId] INT
,	[PositionId] INT
,	[DateStart] SMALLDATETIME
,	[DateEnd] SMALLDATETIME
,	[IsCurrent] BIT NOT NULL DEFAULT 0
,	[Description] NVARCHAR(500)
,	[LastUpdDt] SMALLDATETIME NOT NULL
,	[LastUpdUs] NVARCHAR(50) NOT NULL
,	CONSTRAINT [PK_Employment] PRIMARY KEY CLUSTERED ([Id])
)
