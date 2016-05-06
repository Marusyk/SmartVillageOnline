ALTER TABLE [dbo].[Education]
	ADD CONSTRAINT [FK_Education_Person_PersonID]
	FOREIGN KEY (PersonId)
	REFERENCES [Person] (Id)
