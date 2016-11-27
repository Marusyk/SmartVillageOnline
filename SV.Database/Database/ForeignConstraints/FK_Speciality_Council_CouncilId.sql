ALTER TABLE [dbo].[Speciality]
	ADD CONSTRAINT [FK_Speciality_Council_CouncilId]
	FOREIGN KEY (CouncilId)
	REFERENCES [Council] (Id)
