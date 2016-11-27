ALTER TABLE [dbo].[Catalog]
	ADD CONSTRAINT [FK_Catalog_Council_CouncilId]
	FOREIGN KEY (CouncilId)
	REFERENCES [Council] (Id)
