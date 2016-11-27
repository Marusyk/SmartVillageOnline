ALTER TABLE [dbo].[PersonDocument]
	ADD CONSTRAINT [FK_PersonDocument_Person_PersonId]
	FOREIGN KEY (PersonId)
	REFERENCES [Person] (Id)
