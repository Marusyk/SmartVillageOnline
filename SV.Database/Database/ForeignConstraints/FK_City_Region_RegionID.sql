ALTER TABLE [dbo].[City]
	ADD CONSTRAINT [FK_City_Region_RegionID]
	FOREIGN KEY ([RegionID])
	REFERENCES [Region] ([ID])
