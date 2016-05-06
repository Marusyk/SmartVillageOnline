ALTER TABLE [dbo].[Person]
	ADD CONSTRAINT [FK_Person_Address_AddressBirthId]
	FOREIGN KEY (AddressBirthId)
	REFERENCES [Address] (Id)
