ALTER TABLE [dbo].[PersonDocument]
	ADD CONSTRAINT [FK_PersonDocument_Person_PersonID]
	FOREIGN KEY (PersonId)
	REFERENCES [Person] (Id)
