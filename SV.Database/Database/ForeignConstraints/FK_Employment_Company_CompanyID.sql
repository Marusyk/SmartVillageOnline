ALTER TABLE [dbo].[Employment]
	ADD CONSTRAINT [FK_Employment_Company_CompanyId]
	FOREIGN KEY (CompanyId)
	REFERENCES [Company] (Id)
