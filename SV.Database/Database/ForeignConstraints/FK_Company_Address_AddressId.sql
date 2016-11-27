ALTER TABLE [dbo].[Company]
	ADD CONSTRAINT [FK_Company_Address_AddressId]
	FOREIGN KEY (AddressId)
	REFERENCES [Address] (Id)
