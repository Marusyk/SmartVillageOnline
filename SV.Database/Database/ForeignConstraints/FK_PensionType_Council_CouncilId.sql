ALTER TABLE [dbo].[PensionType]
	ADD CONSTRAINT [FK_PensionType_Council_CouncilId]
	FOREIGN KEY (CouncilId)
	REFERENCES [Council] (Id)
