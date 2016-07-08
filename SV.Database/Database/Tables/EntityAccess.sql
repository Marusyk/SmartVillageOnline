CREATE TABLE [dbo].[EntityAccess]
(
	[Id] INT IDENTITY(1,1) NOT NULL PRIMARY KEY
,	[EntityTypeId] INT NOT NULL
,	[EntityId] INT NOT NULL
,	[VillageCouncilId] INT NOT NULL
)
