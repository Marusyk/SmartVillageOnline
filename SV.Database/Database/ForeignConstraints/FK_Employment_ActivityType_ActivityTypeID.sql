ALTER TABLE [dbo].[Employment]
	ADD CONSTRAINT [FK_Employment_ActivityType_ActivityTypeID]
	FOREIGN KEY (ActivityTypeId)
	REFERENCES [ActivityType] (Id)
