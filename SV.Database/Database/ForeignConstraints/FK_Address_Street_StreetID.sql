ALTER TABLE [dbo].[Address]
	ADD CONSTRAINT [FK_Address_Street_StreetId]
	FOREIGN KEY (StreetId)
	REFERENCES [Street] (Id)
