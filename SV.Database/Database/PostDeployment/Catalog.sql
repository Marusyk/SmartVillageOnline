DECLARE
	@LastUpdDt SMALLDATETIME = GETDATE(),
	@LastUpdUs NVARCHAR(50) = N'SV',
	@CouncilId INT = 1;

INSERT INTO [Catalog]([ParentId], [Name], [CouncilId], [LastUpdDt], [LastUpdUs])
SELECT NULL, N'ФІЗИЧНІ ОСОБИ', @CouncilId, @LastUpdDt, @LastUpdUs;