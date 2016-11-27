ALTER TABLE [dbo].[People]
	ADD CONSTRAINT [FK_People_House_HouseId]
	FOREIGN KEY (HouseId)
	REFERENCES [House] (Id)
