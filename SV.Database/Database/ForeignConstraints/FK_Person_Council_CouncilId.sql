ALTER TABLE [dbo].[Person]
	ADD CONSTRAINT [FK_Person_Council_CouncilId]
	FOREIGN KEY (CouncilId)
	REFERENCES [Council] (Id)
