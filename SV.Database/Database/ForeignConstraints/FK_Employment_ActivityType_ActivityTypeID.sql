ALTER TABLE [dbo].[Employment]
	ADD CONSTRAINT [FK_Employment_ActivityType_ActivityTypeId]
	FOREIGN KEY (ActivityTypeId)
	REFERENCES [ActivityType] (Id)
