ALTER TABLE [dbo].[Education]
	ADD CONSTRAINT [FK_Education_Document_DocumentId]
	FOREIGN KEY (DocumentId)
	REFERENCES [Document] (Id)
