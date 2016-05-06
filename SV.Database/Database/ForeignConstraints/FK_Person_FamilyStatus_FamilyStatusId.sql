ALTER TABLE [dbo].[Person]
	ADD CONSTRAINT [FK_Person_FamilyStatus_FamilyStatusId]
	FOREIGN KEY (FamilyStatusId)
	REFERENCES [FamilyStatus] (Id)
