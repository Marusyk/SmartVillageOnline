ALTER TABLE [dbo].[Document]
	ADD CONSTRAINT [FK_Document_PassAuthority_PassAuthorityId]
	FOREIGN KEY (PassAuthorityId)
	REFERENCES [PassAuthority] (Id)
