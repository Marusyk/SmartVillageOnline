DECLARE
	@LastUpdDt SMALLDATETIME = GETDATE(),
	@LastUpdUs NVARCHAR(50) = N'SV';

INSERT INTO [FamilyStatus]([Name], [LastUpdDt], [LastUpdUs])
SELECT N'одружений', @LastUpdDt, @LastUpdUs;

INSERT INTO [FamilyStatus]([Name], [LastUpdDt], [LastUpdUs])
SELECT N'заміжня', @LastUpdDt, @LastUpdUs;

INSERT INTO [FamilyStatus]([Name], [LastUpdDt], [LastUpdUs])
SELECT N'не одружений', @LastUpdDt, @LastUpdUs;

INSERT INTO [FamilyStatus]([Name], [LastUpdDt], [LastUpdUs])
SELECT N'не заміжня', @LastUpdDt, @LastUpdUs;