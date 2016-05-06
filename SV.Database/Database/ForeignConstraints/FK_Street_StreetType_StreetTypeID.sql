ALTER TABLE [dbo].[Street]
	ADD CONSTRAINT [FK_Street_StreetType_StreetTypeID]
	FOREIGN KEY (StreetTypeId)
	REFERENCES [StreetType] (Id)
