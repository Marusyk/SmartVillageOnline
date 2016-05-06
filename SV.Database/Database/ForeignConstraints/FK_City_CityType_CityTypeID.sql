ALTER TABLE [dbo].[City]
	ADD CONSTRAINT [FK_City_CityType_CityTypeID]
	FOREIGN KEY (CityTypeId)
	REFERENCES [CityType] (Id)
