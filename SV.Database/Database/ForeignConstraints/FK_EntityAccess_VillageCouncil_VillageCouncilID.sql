ALTER TABLE [dbo].[EntityAccess]
	ADD CONSTRAINT [FK_EntityAccess_VillageCouncil_VillageCouncilID]
	FOREIGN KEY (VillageCouncilId)
	REFERENCES [VillageCouncil] (Id)
