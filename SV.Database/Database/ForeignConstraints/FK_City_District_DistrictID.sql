ALTER TABLE [dbo].[City]
	ADD CONSTRAINT [FK_City_District_DistrictID]
	FOREIGN KEY (DistrictId)
	REFERENCES [District] (Id)
