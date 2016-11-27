ALTER TABLE [dbo].[Institution]
	ADD CONSTRAINT [FK_Institution_Council_CouncilId]
	FOREIGN KEY (CouncilId)
	REFERENCES [Council] (Id)
