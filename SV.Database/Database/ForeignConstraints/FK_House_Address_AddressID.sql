ALTER TABLE [dbo].[House]
	ADD CONSTRAINT [FK_House_Address_AddressID]
	FOREIGN KEY (AddressId)
	REFERENCES [Address] (Id)
