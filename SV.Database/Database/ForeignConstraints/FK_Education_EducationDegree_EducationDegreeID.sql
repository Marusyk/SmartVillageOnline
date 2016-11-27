ALTER TABLE [dbo].[Education]
	ADD CONSTRAINT [FK_Education_EducationDegree_EducationDegreeId]
	FOREIGN KEY (EducationDegreeId)
	REFERENCES [EducationDegree] (Id)
