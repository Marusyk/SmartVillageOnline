ALTER TABLE [dbo].[Institution]
	ADD CONSTRAINT [FK_Institution_City_CityID]
	FOREIGN KEY (CityId)
	REFERENCES [City] (Id)
