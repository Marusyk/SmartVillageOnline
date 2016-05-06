ALTER TABLE [dbo].[Education]
	ADD CONSTRAINT [FK_Education_Speciality_SpecialityId]
	FOREIGN KEY (SpecialityId)
	REFERENCES [Speciality] (Id)
