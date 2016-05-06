ALTER TABLE [dbo].[People]
	ADD CONSTRAINT [FK_People_FamilyRelations_FamilyRelationId]
	FOREIGN KEY (FamilyRelationId)
	REFERENCES [FamilyRelations] (Id)
