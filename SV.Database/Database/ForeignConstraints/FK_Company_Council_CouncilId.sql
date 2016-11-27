ALTER TABLE [dbo].[Company]
	ADD CONSTRAINT [FK_Company_Council_CouncilId]
	FOREIGN KEY (CouncilId)
	REFERENCES [Council] (Id)
