ALTER TABLE [dbo].[PassAuthority]
	ADD CONSTRAINT [FK_PassAuthority_Council_CouncilId]
	FOREIGN KEY (CouncilId)
	REFERENCES [Council] (Id)
