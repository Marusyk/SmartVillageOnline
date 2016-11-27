DECLARE
	@LastUpdDt SMALLDATETIME = GETDATE(),
	@LastUpdUs NVARCHAR(50) = N'SV',
	@RegionId INT;

SELECT
	@RegionId = [Id]
FROM  [Region]
WHERE [Name] = N'Івано-Франківська';

IF NOT EXISTS(SELECT 1 FROM [District] WHERE [Name] = N'Снятинський')
BEGIN
	INSERT INTO [District]([Name], [RegionId], [LastUpdDt], [LastUpdUs])
	SELECT
		N'Снятинський'
	,	@RegionId
	,	@LastUpdDt
	,	@LastUpdUs;
END;

IF NOT EXISTS(SELECT 1 FROM [District] WHERE [Name] = N'Косівський')
BEGIN
	INSERT INTO [District]([Name], [RegionId], [LastUpdDt], [LastUpdUs])
	SELECT
		N'Косівський'
	,	@RegionId
	,	@LastUpdDt
	,	@LastUpdUs;
END;

SELECT
	@RegionId = [Id]
FROM  [Region]
WHERE [Name] = N'Чернівецька';

IF NOT EXISTS(SELECT 1 FROM [District] WHERE [Name] = N'Кіцманський')
BEGIN
	INSERT INTO [District]([Name], [RegionId], [LastUpdDt], [LastUpdUs])
	SELECT
		N'Кіцманський'
	,	@RegionId
	,	@LastUpdDt
	,	@LastUpdUs;
END;

IF NOT EXISTS(SELECT 1 FROM [District] WHERE [Name] = N'Вижницький')
BEGIN
	INSERT INTO [District]([Name], [RegionId], [LastUpdDt], [LastUpdUs])
	SELECT
		N'Вижницький'
	,	@RegionId
	,	@LastUpdDt
	,	@LastUpdUs;
END;