ALTER TABLE [dbo].[Address]
	ADD CONSTRAINT [FK_Address_Street_StreetID]
	FOREIGN KEY (StreetId)
	REFERENCES [Street] (Id)
