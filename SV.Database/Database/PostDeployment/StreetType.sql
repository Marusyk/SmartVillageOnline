DECLARE
	@LastUpdDt SMALLDATETIME = GETDATE(),
	@LastUpdUs NVARCHAR(50) = N'SV';

IF NOT EXISTS(SELECT 1 FROM [StreetType] WHERE [Name] = N'вулиця')
BEGIN
	INSERT INTO [StreetType]([Name], [LastUpdDt], [LastUpdUs])
	SELECT
		N'вулиця'
	,	@LastUpdDt
	,	@LastUpdUs;
END;

IF NOT EXISTS(SELECT 1 FROM [StreetType] WHERE [Name] = N'урочище')
BEGIN
	INSERT INTO [StreetType]([Name], [LastUpdDt], [LastUpdUs])
	SELECT
		N'урочище'
	,	@LastUpdDt
	,	@LastUpdUs;
END;

IF NOT EXISTS(SELECT 1 FROM [StreetType] WHERE [Name] = N'провулок')
BEGIN
	INSERT INTO [StreetType]([Name], [LastUpdDt], [LastUpdUs])
	SELECT
		N'провулок'
	,	@LastUpdDt
	,	@LastUpdUs;
END;

IF NOT EXISTS(SELECT 1 FROM [StreetType] WHERE [Name] = N'проспект')
BEGIN
	INSERT INTO [StreetType]([Name], [LastUpdDt], [LastUpdUs])
	SELECT
		N'проспект'
	,	@LastUpdDt
	,	@LastUpdUs;
END;
