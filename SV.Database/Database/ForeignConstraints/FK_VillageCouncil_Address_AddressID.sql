ALTER TABLE [dbo].[Council]
	ADD CONSTRAINT [FK_Council_Address_AddressID]
	FOREIGN KEY (AddressId)
	REFERENCES [Address] (Id)
