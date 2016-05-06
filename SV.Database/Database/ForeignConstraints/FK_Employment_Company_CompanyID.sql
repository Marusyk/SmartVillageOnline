ALTER TABLE [dbo].[Employment]
	ADD CONSTRAINT [FK_Employment_Company_CompanyID]
	FOREIGN KEY (CompanyId)
	REFERENCES [Company] (Id)
