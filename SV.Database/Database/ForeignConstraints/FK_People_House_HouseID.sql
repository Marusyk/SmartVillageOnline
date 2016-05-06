ALTER TABLE [dbo].[People]
	ADD CONSTRAINT [FK_People_House_HouseID]
	FOREIGN KEY (HouseId)
	REFERENCES [House] (Id)
