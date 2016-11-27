ALTER TABLE [dbo].[Council]
	ADD CONSTRAINT [FK_Council_Address_AddressId]
	FOREIGN KEY (AddressId)
	REFERENCES [Address] (Id)
