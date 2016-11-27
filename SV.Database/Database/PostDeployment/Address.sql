DECLARE
	@LastUpdDt SMALLDATETIME = GETDATE(),
	@LastUpdUs NVARCHAR(50) = N'SV',
	@CouncilId INT,
	@CityId INT,
	@StreetId INT;

SELECT
	@CityId = [Id]
FROM  [City]
WHERE [Name] = N'Тростянець';

SELECT
	@StreetId = [Id]
FROM  [Street]
WHERE [Name] = N'Шевченка';

SET @CouncilId = 3;

INSERT INTO [Address]([CityId], [StreetId], [PostCode], [BuildNr], [FlatNr], [CouncilId], [LastUpdDt], [LastUpdUs])
SELECT @CityId, @StreetId, NULL, N'51', NULL, @CouncilId, @LastUpdDt, @LastUpdUs;

SELECT
	@CityId = [Id]
FROM  [City]
WHERE [Name] = N'Чернівці';

SELECT
	@StreetId = [Id]
FROM  [Street]
WHERE [Name] = N'Головна';

SET @CouncilId = 1;

INSERT INTO [Address]([CityId], [StreetId], [PostCode], [BuildNr], [FlatNr], [CouncilId], [LastUpdDt], [LastUpdUs])
SELECT @CityId, @StreetId, 12300, N'24a', N'400', @CouncilId, @LastUpdDt, @LastUpdUs;

SELECT
	@CityId = [Id]
FROM  [City]
WHERE [Name] = N'Снятин';

SELECT
	@StreetId = [Id]
FROM  [Street]
WHERE [Name] = N'Українська';

SET @CouncilId = 2;

INSERT INTO [Address]([CityId], [StreetId], [PostCode], [BuildNr], [FlatNr], [CouncilId], [LastUpdDt], [LastUpdUs])
SELECT @CityId, @StreetId, NULL, N'15', N'4', @CouncilId, @LastUpdDt, @LastUpdUs;