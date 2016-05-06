ALTER TABLE [dbo].[Region]
	ADD CONSTRAINT [FK_Region_Country_CountryID]
	FOREIGN KEY (CountryId)
	REFERENCES [Country] (Id)
