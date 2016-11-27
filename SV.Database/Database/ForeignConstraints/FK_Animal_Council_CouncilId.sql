ALTER TABLE [dbo].[Animal]
	ADD CONSTRAINT [FK_Animal_Council_CouncilId]
	FOREIGN KEY (CouncilId)
	REFERENCES [Council] (Id)
