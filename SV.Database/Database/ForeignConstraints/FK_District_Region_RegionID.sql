ALTER TABLE [dbo].[District]
	ADD CONSTRAINT [FK_District_Region_RegionID]
	FOREIGN KEY (RegionId)
	REFERENCES [Region] (Id)
