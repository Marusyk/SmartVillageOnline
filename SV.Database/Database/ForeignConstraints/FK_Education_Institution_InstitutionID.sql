ALTER TABLE [dbo].[Education]
	ADD CONSTRAINT [FK_Education_Institution_InstitutionId]
	FOREIGN KEY (InstitutionId)
	REFERENCES [Institution] (Id)
