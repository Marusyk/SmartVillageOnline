DECLARE
	@LastUpdDt SMALLDATETIME = GETDATE(),
	@LastUpdUs NVARCHAR(50) = N'SV';

IF NOT EXISTS(SELECT 1 FROM [CityType] WHERE [Name] = N'село')
BEGIN
	INSERT INTO [CityType]([Name], [LastUpdDt], [LastUpdUs])
	SELECT
		N'село'
	,	@LastUpdDt
	,	@LastUpdUs;
END;

IF NOT EXISTS(SELECT 1 FROM [CityType] WHERE [Name] = N'місто')
BEGIN
	INSERT INTO [CityType]([Name], [LastUpdDt], [LastUpdUs])
	SELECT
		N'місто'
	,	@LastUpdDt
	,	@LastUpdUs;
END;

IF NOT EXISTS(SELECT 1 FROM [CityType] WHERE [Name] = N'селище')
BEGIN
	INSERT INTO [CityType]([Name], [LastUpdDt], [LastUpdUs])
	SELECT
		N'селище'
	,	@LastUpdDt
	,	@LastUpdUs;
END;

IF NOT EXISTS(SELECT 1 FROM [CityType] WHERE [Name] = N'хутір')
BEGIN
	INSERT INTO [CityType]([Name], [LastUpdDt], [LastUpdUs])
	SELECT
		N'хутір'
	,	@LastUpdDt
	,	@LastUpdUs;
END;