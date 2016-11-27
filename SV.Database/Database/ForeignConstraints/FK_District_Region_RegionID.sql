ALTER TABLE [dbo].[District]
	ADD CONSTRAINT [FK_District_Region_RegionId]
	FOREIGN KEY (RegionId)
	REFERENCES [Region] (Id)
