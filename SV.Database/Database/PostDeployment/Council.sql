/* --- SYSTEM SECTION --- */
SET IDENTITY_INSERT [dbo].[Council] ON

INSERT INTO [dbo].[Council]
	([Id], [ParentId], [Name], [ShortName], [AddressId], [EDRPOUCode])
	VALUES
	(1, NULL, N'SYSTEM', NULL, NULL, '00000000');

SET IDENTITY_INSERT [dbo].[Council] OFF
/* === SYSTEM SECTION === */

SET IDENTITY_INSERT [dbo].[Council] ON -- TEMP
INSERT INTO [dbo].[Council]([Id], [ParentId], [Name], [ShortName], [AddressId], [EDRPOUCode])
VALUES(2, 1, N'Снятинська районна рада', N'СРР', NULL, '00000000');
INSERT INTO [dbo].[Council]([Id], [ParentId], [Name], [ShortName], [AddressId], [EDRPOUCode])
VALUES(3, 2, N'Тростянецька сільська рада', N'ТСР', NULL, '00000000');
SET IDENTITY_INSERT [dbo].[Council] OFF -- TEMP