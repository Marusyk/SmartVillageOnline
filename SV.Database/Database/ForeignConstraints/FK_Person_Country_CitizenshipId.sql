ALTER TABLE [dbo].[Person]
	ADD CONSTRAINT [FK_Person_Country_CitizenshipId]
	FOREIGN KEY (CitizenshipId)
	REFERENCES [Country] (Id)
