ALTER TABLE [dbo].[PersonDocument]
	ADD CONSTRAINT [FK_PersonDocuments_Document_DocumentId]
	FOREIGN KEY (DocumentId)
	REFERENCES [Document] (Id)
