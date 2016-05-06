ALTER TABLE [dbo].[Document]
	ADD CONSTRAINT [FK_Document_DocumentType_DocumentTypeID]
	FOREIGN KEY (DocumentTypeId)
	REFERENCES [DocumentType] (Id)
