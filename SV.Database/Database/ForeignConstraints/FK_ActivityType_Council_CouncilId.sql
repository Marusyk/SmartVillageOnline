ALTER TABLE [dbo].[ActivityType]
	ADD CONSTRAINT [FK_ActivityType_Council_CouncilId]
	FOREIGN KEY (CouncilId)
	REFERENCES [Council] (Id)
