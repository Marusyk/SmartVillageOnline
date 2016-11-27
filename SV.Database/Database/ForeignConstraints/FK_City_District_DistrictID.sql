ALTER TABLE [dbo].[City]
	ADD CONSTRAINT [FK_City_District_DistrictId]
	FOREIGN KEY (DistrictId)
	REFERENCES [District] (Id)
