ALTER TABLE [dbo].[City]
	ADD CONSTRAINT [FK_City_CityType_CityTypeId]
	FOREIGN KEY (CityTypeId)
	REFERENCES [CityType] (Id)
