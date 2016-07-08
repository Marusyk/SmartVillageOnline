ALTER TABLE [dbo].[EntityAccess]
	ADD CONSTRAINT [FK_EntityAccess_EntityType_EntityTypeId]
	FOREIGN KEY (EntityTypeId)
	REFERENCES [EntityType] (Id)
