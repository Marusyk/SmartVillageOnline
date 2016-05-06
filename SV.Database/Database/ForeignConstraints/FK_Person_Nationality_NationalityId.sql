ALTER TABLE [dbo].[Person]
	ADD CONSTRAINT [FK_Person_Nationality_NationalityId]
	FOREIGN KEY (NationalityId)
	REFERENCES [Nationality] (Id)
