ALTER TABLE [dbo].[Education]
	ADD CONSTRAINT [FK_Education_Document_DocumentID]
	FOREIGN KEY (DocumentId)
	REFERENCES [Document] (Id)
