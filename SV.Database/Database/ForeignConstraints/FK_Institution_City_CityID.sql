ALTER TABLE [dbo].[Institution]
	ADD CONSTRAINT [FK_Institution_City_CityId]
	FOREIGN KEY (CityId)
	REFERENCES [City] (Id)
