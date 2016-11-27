DECLARE
	@LastUpdDt SMALLDATETIME = GETDATE(),
	@LastUpdUs NVARCHAR(50) = N'SV',
	@RegionId INT,
	@DistrictId INT,
	@CityTypeId INT;

SELECT
	@CityTypeId = [Id]
FROM  [CityType]
WHERE [Name] = N'село';

SELECT
	@DistrictId = [Id]
,	@RegionId = [RegionId]
FROM  [District]
WHERE [Name] = N'Снятинський';

IF NOT EXISTS(SELECT 1 FROM [City] WHERE [Name] = N'Тростянець')
BEGIN
	INSERT INTO [City]([Name], [CityTypeId], [DistrictId], [RegionId], [LastUpdDt], [LastUpdUs])
	SELECT
		N'Тростянець'
	,	@CityTypeId
	,	@DistrictId
	,	@RegionId
	,	@LastUpdDt
	,	@LastUpdUs;
END;

SELECT
	@CityTypeId = [Id]
FROM  [CityType]
WHERE [Name] = N'місто';

SELECT
	@DistrictId = [Id]
,	@RegionId = [RegionId]
FROM  [District]
WHERE [Name] = N'Івано-Франківська';

IF NOT EXISTS(SELECT 1 FROM [City] WHERE [Name] = N'Снятин')
BEGIN
	INSERT INTO [City]([Name], [CityTypeId], [DistrictId], [RegionId], [LastUpdDt], [LastUpdUs])
	SELECT
		N'Снятин'
	,	@CityTypeId
	,	@DistrictId
	,	@RegionId
	,	@LastUpdDt
	,	@LastUpdUs;
END;

SELECT
	@RegionId = [Id]
FROM  [Region]
WHERE [Name] = N'Київська';

IF NOT EXISTS(SELECT 1 FROM [City] WHERE [Name] = N'Київ')
BEGIN
	INSERT INTO [City]([Name], [CityTypeId], [DistrictId], [RegionId], [LastUpdDt], [LastUpdUs])
	SELECT
		N'Київ'
	,	@CityTypeId
	,	NULL
	,	@RegionId
	,	@LastUpdDt
	,	@LastUpdUs;
END;

SELECT
	@RegionId = [Id]
FROM  [Region]
WHERE [Name] = N'Чернівецька';

IF NOT EXISTS(SELECT 1 FROM [City] WHERE [Name] = N'Чернівці')
BEGIN
	INSERT INTO [City]([Name], [CityTypeId], [DistrictId], [RegionId], [LastUpdDt], [LastUpdUs])
	SELECT
		N'Чернівці'
	,	@CityTypeId
	,	NULL
	,	@RegionId
	,	@LastUpdDt
	,	@LastUpdUs;
END;

SELECT
	@CityTypeId = [Id]
FROM  [CityType]
WHERE [Name] = N'селище';

SELECT
	@DistrictId = [Id]
,	@RegionId = [RegionId]
FROM  [District]
WHERE [Name] = N'Кіцманський';

IF NOT EXISTS(SELECT 1 FROM [City] WHERE [Name] = N'Лужани')
BEGIN
	INSERT INTO [City]([Name], [CityTypeId], [DistrictId], [RegionId], [LastUpdDt], [LastUpdUs])
	SELECT
		N'Снятин'
	,	@CityTypeId
	,	@DistrictId
	,	@RegionId
	,	@LastUpdDt
	,	@LastUpdUs;
END;