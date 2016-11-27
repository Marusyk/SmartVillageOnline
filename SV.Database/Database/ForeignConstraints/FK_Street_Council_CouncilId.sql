ALTER TABLE [dbo].[Street]
	ADD CONSTRAINT [FK_Street_Council_CouncilId]
	FOREIGN KEY (CouncilId)
	REFERENCES [Council] (Id)
