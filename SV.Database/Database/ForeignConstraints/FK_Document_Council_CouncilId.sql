ALTER TABLE [dbo].[Document]
	ADD CONSTRAINT [FK_Document_Council_CouncilId]
	FOREIGN KEY (CouncilId)
	REFERENCES [Council] (Id)
