ALTER TABLE [dbo].[Person]
	ADD CONSTRAINT [FK_Person_Catalog_CatalogId]
	FOREIGN KEY (CatalogId)
	REFERENCES [Catalog] (Id)
