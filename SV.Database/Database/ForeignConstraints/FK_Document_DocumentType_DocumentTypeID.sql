ALTER TABLE [dbo].[Document]
	ADD CONSTRAINT [FK_Document_DocumentType_DocumentTypeId]
	FOREIGN KEY (DocumentTypeId)
	REFERENCES [DocumentType] (Id)
