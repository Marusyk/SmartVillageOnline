ALTER TABLE [dbo].[Person]
	ADD CONSTRAINT [FK_Person_PassAuthority_PassAuthorityId]
	FOREIGN KEY (PassAuthorityId)
	REFERENCES [PassAuthority] (Id)
