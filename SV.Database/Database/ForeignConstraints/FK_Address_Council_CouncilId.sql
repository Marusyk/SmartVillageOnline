ALTER TABLE [dbo].[Address]
	ADD CONSTRAINT [FK_Address_Council_CouncilId]
	FOREIGN KEY (CouncilId)
	REFERENCES [Council] (Id)
