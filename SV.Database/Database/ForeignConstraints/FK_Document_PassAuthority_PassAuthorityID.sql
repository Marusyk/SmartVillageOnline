ALTER TABLE [dbo].[Document]
	ADD CONSTRAINT [FK_Document_PassAuthority_PassAuthorityID]
	FOREIGN KEY (PassAuthorityId)
	REFERENCES [PassAuthority] (Id)
