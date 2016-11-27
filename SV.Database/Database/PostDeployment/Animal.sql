DECLARE
	@LastUpdDt SMALLDATETIME = GETDATE(),
	@LastUpdUs NVARCHAR(50) = N'SV',
	@CouncilId INT = 1;

INSERT INTO [Animal]([Name], [CouncilId], [LastUpdDt], [LastUpdUs])
SELECT N'Корова', @CouncilId, @LastUpdDt, @LastUpdUs;

INSERT INTO [Animal]([Name], [CouncilId], [LastUpdDt], [LastUpdUs])
SELECT N'Свиня', @CouncilId, @LastUpdDt, @LastUpdUs;

INSERT INTO [Animal]([Name], [CouncilId], [LastUpdDt], [LastUpdUs])
SELECT N'Собака', @CouncilId, @LastUpdDt, @LastUpdUs;