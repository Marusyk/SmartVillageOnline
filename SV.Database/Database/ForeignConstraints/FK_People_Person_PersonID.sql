ALTER TABLE [dbo].[People]
	ADD CONSTRAINT [FK_People_Person_PersonID]
	FOREIGN KEY (PersonId)
	REFERENCES [Person] (Id)
