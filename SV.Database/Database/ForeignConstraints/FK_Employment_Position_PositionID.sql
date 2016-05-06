ALTER TABLE [dbo].[Employment]
	ADD CONSTRAINT [FK_Employment_Position_PositionID]
	FOREIGN KEY (PositionId)
	REFERENCES [Position] (Id)
