ALTER TABLE [dbo].[Education]
	ADD CONSTRAINT [FK_Education_Institution_InstitutionID]
	FOREIGN KEY (InstitutionId)
	REFERENCES [Institution] (Id)
