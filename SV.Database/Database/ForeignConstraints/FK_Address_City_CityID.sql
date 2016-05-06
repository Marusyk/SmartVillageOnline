ALTER TABLE [dbo].[Address]
	ADD CONSTRAINT [FK_Address_City_CityID]
	FOREIGN KEY (CityId)
	REFERENCES [City] (Id)
