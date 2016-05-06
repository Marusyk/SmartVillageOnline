ALTER TABLE [dbo].[City]
	ADD CONSTRAINT [FK_City_Region_RegionID]
	FOREIGN KEY ([RegionId])
	REFERENCES [Region] ([Id])
