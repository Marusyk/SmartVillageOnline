ALTER TABLE [dbo].[Region]
	ADD CONSTRAINT [FK_Region_Country_CountryId]
	FOREIGN KEY (CountryId)
	REFERENCES [Country] (Id)
