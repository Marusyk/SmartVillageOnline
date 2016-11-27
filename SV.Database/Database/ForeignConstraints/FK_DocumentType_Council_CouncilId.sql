ALTER TABLE [dbo].[DocumentType]
	ADD CONSTRAINT [FK_DocumentType_Council_CouncilId]
	FOREIGN KEY (CouncilId)
	REFERENCES [Council] (Id)
