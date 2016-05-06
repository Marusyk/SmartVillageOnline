ALTER TABLE [dbo].[PersonDocument]
	ADD CONSTRAINT [FK_PersonDocuments_Document_DocumentID]
	FOREIGN KEY (DocumentId)
	REFERENCES [Document] (Id)
