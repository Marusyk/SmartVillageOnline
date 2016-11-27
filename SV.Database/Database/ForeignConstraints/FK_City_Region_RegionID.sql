ALTER TABLE [dbo].[City]
	ADD CONSTRAINT [FK_City_Region_RegionId]
	FOREIGN KEY (RegionId)
	REFERENCES [Region] (Id)
