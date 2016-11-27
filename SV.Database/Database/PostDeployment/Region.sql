DECLARE
	@LastUpdDt SMALLDATETIME = GETDATE(),
	@LastUpdUs NVARCHAR(50) = N'SV',
	@CountryId INT;

SELECT
	@CountryId = [Id]
FROM  [Country]
WHERE [Name] = N'Україна';

IF NOT EXISTS(SELECT 1 FROM [Region] WHERE [Name] = N'Вінницька')
BEGIN
	INSERT INTO [Region]([Name], [CountryId], [LastUpdDt], [LastUpdUs])
	SELECT
		N'Вінницька'
	,	@CountryId
	,	@LastUpdDt
	,	@LastUpdUs;
END;

IF NOT EXISTS(SELECT 1 FROM [Region] WHERE [Name] = N'Волинська')
BEGIN
	INSERT INTO [Region]([Name], [CountryId], [LastUpdDt], [LastUpdUs])
	SELECT
		N'Волинська'
	,	@CountryId
	,	@LastUpdDt
	,	@LastUpdUs;
END;

IF NOT EXISTS(SELECT 1 FROM [Region] WHERE [Name] = N'Дніпропетровська')
BEGIN
	INSERT INTO [Region]([Name], [CountryId], [LastUpdDt], [LastUpdUs])
	SELECT
		N'Дніпропетровська'
	,	@CountryId
	,	@LastUpdDt
	,	@LastUpdUs;
END;

IF NOT EXISTS(SELECT 1 FROM [Region] WHERE [Name] = N'Донецька')
BEGIN
	INSERT INTO [Region]([Name], [CountryId], [LastUpdDt], [LastUpdUs])
	SELECT
		N'Донецька'
	,	@CountryId
	,	@LastUpdDt
	,	@LastUpdUs;
END

IF NOT EXISTS(SELECT 1 FROM [Region] WHERE [Name] = N'Житомирська')
BEGIN
	INSERT INTO [Region]([Name], [CountryId], [LastUpdDt], [LastUpdUs])
	SELECT
		N'Житомирська'
	,	@CountryId
	,	@LastUpdDt
	,	@LastUpdUs;
END;

IF NOT EXISTS(SELECT 1 FROM [Region] WHERE [Name] = N'Закарпатська')
BEGIN
	INSERT INTO [Region]([Name], [CountryId], [LastUpdDt], [LastUpdUs])
	SELECT
		N'Закарпатська'
	,	@CountryId
	,	@LastUpdDt
	,	@LastUpdUs;
END;

IF NOT EXISTS(SELECT 1 FROM [Region] WHERE [Name] = N'Запорізька')
BEGIN
	INSERT INTO [Region]([Name], [CountryId], [LastUpdDt], [LastUpdUs])
	SELECT
		N'Запорізька'
	,	@CountryId
	,	@LastUpdDt
	,	@LastUpdUs;
END;

IF NOT EXISTS(SELECT 1 FROM [Region] WHERE [Name] = N'Івано-Франківська')
BEGIN
	INSERT INTO [Region]([Name], [CountryId], [LastUpdDt], [LastUpdUs])
	SELECT
		N'Івано-Франківська'
	,	@CountryId
	,	@LastUpdDt
	,	@LastUpdUs;
END;

IF NOT EXISTS(SELECT 1 FROM [Region] WHERE [Name] = N'Київська')
BEGIN
	INSERT INTO [Region]([Name], [CountryId], [LastUpdDt], [LastUpdUs])
	SELECT
		N'Київська'
	,	@CountryId
	,	@LastUpdDt
	,	@LastUpdUs;
END;

IF NOT EXISTS(SELECT 1 FROM [Region] WHERE [Name] = N'Кіровоградська')
BEGIN
	INSERT INTO [Region]([Name], [CountryId], [LastUpdDt], [LastUpdUs])
	SELECT
		N'Кіровоградська'
	,	@CountryId
	,	@LastUpdDt
	,	@LastUpdUs;
END;

IF NOT EXISTS(SELECT 1 FROM [Region] WHERE [Name] = N'Луганська')
BEGIN
	INSERT INTO [Region]([Name], [CountryId], [LastUpdDt], [LastUpdUs])
	SELECT
		N'Луганська'
	,	@CountryId
	,	@LastUpdDt
	,	@LastUpdUs;
END;

IF NOT EXISTS(SELECT 1 FROM [Region] WHERE [Name] = N'Львівська')
BEGIN
	INSERT INTO [Region]([Name], [CountryId], [LastUpdDt], [LastUpdUs])
	SELECT
		N'Львівська'
	,	@CountryId
	,	@LastUpdDt
	,	@LastUpdUs;
END;

IF NOT EXISTS(SELECT 1 FROM [Region] WHERE [Name] = N'Миколаївська')
BEGIN
	INSERT INTO [Region]([Name], [CountryId], [LastUpdDt], [LastUpdUs])
	SELECT
		N'Миколаївська'
	,	@CountryId
	,	@LastUpdDt
	,	@LastUpdUs;
END;

IF NOT EXISTS(SELECT 1 FROM [Region] WHERE [Name] = N'Одеська')
BEGIN
	INSERT INTO [Region]([Name], [CountryId], [LastUpdDt], [LastUpdUs])
	SELECT
		N'Одеська'
	,	@CountryId
	,	@LastUpdDt
	,	@LastUpdUs;
END;

IF NOT EXISTS(SELECT 1 FROM [Region] WHERE [Name] = N'Полтавська')
BEGIN
	INSERT INTO [Region]([Name], [CountryId], [LastUpdDt], [LastUpdUs])
	SELECT
		N'Полтавська'
	,	@CountryId
	,	@LastUpdDt
	,	@LastUpdUs;
END;

IF NOT EXISTS(SELECT 1 FROM [Region] WHERE [Name] = N'Рівненська')
BEGIN
	INSERT INTO [Region]([Name], [CountryId], [LastUpdDt], [LastUpdUs])
	SELECT
		N'Рівненська'
	,	@CountryId
	,	@LastUpdDt
	,	@LastUpdUs;
END;

IF NOT EXISTS(SELECT 1 FROM [Region] WHERE [Name] = N'Сумська')
BEGIN
	INSERT INTO [Region]([Name], [CountryId], [LastUpdDt], [LastUpdUs])
	SELECT
		N'Сумська'
	,	@CountryId
	,	@LastUpdDt
	,	@LastUpdUs;
END;

IF NOT EXISTS(SELECT 1 FROM [Region] WHERE [Name] = N'Тернопільська')
BEGIN
	INSERT INTO [Region]([Name], [CountryId], [LastUpdDt], [LastUpdUs])
	SELECT
		N'Тернопільська'
	,	@CountryId
	,	@LastUpdDt
	,	@LastUpdUs;
END;

IF NOT EXISTS(SELECT 1 FROM [Region] WHERE [Name] = N'Харківська')
BEGIN
	INSERT INTO [Region]([Name], [CountryId], [LastUpdDt], [LastUpdUs])
	SELECT
		N'Харківська'
	,	@CountryId
	,	@LastUpdDt
	,	@LastUpdUs;
END;

IF NOT EXISTS(SELECT 1 FROM [Region] WHERE [Name] = N'Херсонська')
BEGIN
	INSERT INTO [Region]([Name], [CountryId], [LastUpdDt], [LastUpdUs])
	SELECT
		N'Херсонська'
	,	@CountryId
	,	@LastUpdDt
	,	@LastUpdUs;
END;

IF NOT EXISTS(SELECT 1 FROM [Region] WHERE [Name] = N'Хмельницька')
BEGIN
	INSERT INTO [Region]([Name], [CountryId], [LastUpdDt], [LastUpdUs])
	SELECT
		N'Хмельницька'
	,	@CountryId
	,	@LastUpdDt
	,	@LastUpdUs;
END;

IF NOT EXISTS(SELECT 1 FROM [Region] WHERE [Name] = N'Черкаська')
BEGIN
	INSERT INTO [Region]([Name], [CountryId], [LastUpdDt], [LastUpdUs])
	SELECT
		N'Черкаська'
	,	@CountryId
	,	@LastUpdDt
	,	@LastUpdUs;
END;

IF NOT EXISTS(SELECT 1 FROM [Region] WHERE [Name] = N'Чернівецька')
BEGIN
	INSERT INTO [Region]([Name], [CountryId], [LastUpdDt], [LastUpdUs])
	SELECT
		N'Чернівецька'
	,	@CountryId
	,	@LastUpdDt
	,	@LastUpdUs;
END;

IF NOT EXISTS(SELECT 1 FROM [Region] WHERE [Name] = N'Чернігівська')
BEGIN
	INSERT INTO [Region]([Name], [CountryId], [LastUpdDt], [LastUpdUs])
	SELECT
		N'Чернігівська'
	,	@CountryId
	,	@LastUpdDt
	,	@LastUpdUs;
END;
