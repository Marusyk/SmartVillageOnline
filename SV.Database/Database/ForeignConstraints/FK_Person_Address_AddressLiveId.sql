ALTER TABLE [dbo].[Person]
	ADD CONSTRAINT [FK_Person_Address_AddressLiveId]
	FOREIGN KEY (AddressLiveId)
	REFERENCES [Address] (Id)
