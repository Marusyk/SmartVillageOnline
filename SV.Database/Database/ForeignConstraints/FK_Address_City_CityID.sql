ALTER TABLE [dbo].[Address]
	ADD CONSTRAINT [FK_Address_City_CityId]
	FOREIGN KEY (CityId)
	REFERENCES [City] (Id)
