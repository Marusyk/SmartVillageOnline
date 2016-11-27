ALTER TABLE [dbo].[House]
	ADD CONSTRAINT [FK_House_Council_CouncilId]
	FOREIGN KEY (CouncilId)
	REFERENCES [Council] (Id)
