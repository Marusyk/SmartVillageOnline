ALTER TABLE [dbo].[Education]
	ADD CONSTRAINT [FK_Education_EducationDegree_EducationDegreeID]
	FOREIGN KEY (EducationDegreeId)
	REFERENCES [EducationDegree] (Id)
