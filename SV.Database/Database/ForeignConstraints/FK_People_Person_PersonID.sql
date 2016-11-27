ALTER TABLE [dbo].[People]
	ADD CONSTRAINT [FK_People_Person_PersonId]
	FOREIGN KEY (PersonId)
	REFERENCES [Person] (Id)
