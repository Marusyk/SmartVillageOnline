ALTER TABLE [dbo].[Street]
	ADD CONSTRAINT [FK_Street_StreetType_StreetTypeId]
	FOREIGN KEY (StreetTypeId)
	REFERENCES [StreetType] (Id)
