ALTER TABLE [dbo].[House]
	ADD CONSTRAINT [FK_House_Address_AddressId]
	FOREIGN KEY (AddressId)
	REFERENCES [Address] (Id)
