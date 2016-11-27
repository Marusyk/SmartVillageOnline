ALTER TABLE [dbo].[Education]
	ADD CONSTRAINT [FK_Education_Person_PersonId]
	FOREIGN KEY (PersonId)
	REFERENCES [Person] (Id)
