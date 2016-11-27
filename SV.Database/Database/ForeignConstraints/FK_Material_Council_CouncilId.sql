ALTER TABLE [dbo].[Material]
	ADD CONSTRAINT [FK_Material_Council_CouncilId]
	FOREIGN KEY (CouncilId)
	REFERENCES [Council] (Id)
