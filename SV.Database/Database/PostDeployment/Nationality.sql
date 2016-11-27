DECLARE
	@LastUpdDt SMALLDATETIME = GETDATE(),
	@LastUpdUs NVARCHAR(50) = N'SV';

INSERT INTO [Nationality]([Name], [LastUpdDt], [LastUpdUs])
SELECT N'українець', @LastUpdDt, @LastUpdUs;

INSERT INTO [Nationality]([Name], [LastUpdDt], [LastUpdUs])
SELECT N'українка', @LastUpdDt, @LastUpdUs;

INSERT INTO [Nationality]([Name], [LastUpdDt], [LastUpdUs])
SELECT N'румун', @LastUpdDt, @LastUpdUs;