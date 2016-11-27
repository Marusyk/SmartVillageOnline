DECLARE
	@LastUpdDt SMALLDATETIME = GETDATE(),
	@LastUpdUs NVARCHAR(50) = N'SV',
	@CouncilId INT = 1;

INSERT INTO [DocumentType]([Name], [CouncilId], [LastUpdDt], [LastUpdUs])
SELECT N'свідоцтво', @CouncilId, @LastUpdDt, @LastUpdUs;

INSERT INTO [DocumentType]([Name], [CouncilId], [LastUpdDt], [LastUpdUs])
SELECT N'посвідчення', @CouncilId, @LastUpdDt, @LastUpdUs;