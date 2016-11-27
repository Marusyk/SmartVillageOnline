DECLARE
	@LastUpdDt SMALLDATETIME = GETDATE(),
	@LastUpdUs NVARCHAR(50) = N'SV',
	@CouncilId INT = 1,
	@StreetTypeId INT;

SELECT
	@StreetTypeId = [Id]
FROM  [StreetType]
WHERE [Name] = N'вулиця';

IF NOT EXISTS(SELECT 1 FROM [Street] WHERE [Name] = N'Шевченка')
BEGIN
	INSERT INTO [Street]([Name], [StreetTypeId], [CouncilId], [LastUpdDt], [LastUpdUs])
	SELECT
		N'Шевченка'
	,	@StreetTypeId
	,	@CouncilId
	,	@LastUpdDt
	,	@LastUpdUs;
END;

IF NOT EXISTS(SELECT 1 FROM [Street] WHERE [Name] = N'Головна')
BEGIN
	INSERT INTO [Street]([Name], [StreetTypeId], [CouncilId], [LastUpdDt], [LastUpdUs])
	SELECT
		N'Головна'
	,	@StreetTypeId
	,	@CouncilId
	,	@LastUpdDt
	,	@LastUpdUs;
END;

IF NOT EXISTS(SELECT 1 FROM [Street] WHERE [Name] = N'Січових стрільців')
BEGIN
	INSERT INTO [Street]([Name], [StreetTypeId], [CouncilId], [LastUpdDt], [LastUpdUs])
	SELECT
		N'Січових стрільців'
	,	@StreetTypeId
	,	@CouncilId
	,	@LastUpdDt
	,	@LastUpdUs;
END;

IF NOT EXISTS(SELECT 1 FROM [Street] WHERE [Name] = N'Українська')
BEGIN
	INSERT INTO [Street]([Name], [StreetTypeId], [CouncilId], [LastUpdDt], [LastUpdUs])
	SELECT
		N'Українська'
	,	@StreetTypeId
	,	@CouncilId
	,	@LastUpdDt
	,	@LastUpdUs;
END;

SELECT
	@StreetTypeId = [Id]
FROM  [StreetType]
WHERE [Name] = N'проспект';

IF NOT EXISTS(SELECT 1 FROM [Street] WHERE [Name] = N'Незалежності')
BEGIN
	INSERT INTO [Street]([Name], [StreetTypeId], [CouncilId], [LastUpdDt], [LastUpdUs])
	SELECT
		N'Незалежності'
	,	@StreetTypeId
	,	@CouncilId
	,	@LastUpdDt
	,	@LastUpdUs;
END;