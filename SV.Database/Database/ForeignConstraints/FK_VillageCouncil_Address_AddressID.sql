ALTER TABLE [dbo].[VillageCouncil]
	ADD CONSTRAINT [FK_VillageCouncil_Address_AddressID]
	FOREIGN KEY (AddressId)
	REFERENCES [Address] (Id)
