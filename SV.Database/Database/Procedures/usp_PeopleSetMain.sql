CREATE PROCEDURE [dbo].[usp_PeopleSetMain]
	@PeopleId INT
,	@LastUpdUs NVARCHAR(50) = 'SV'
AS
BEGIN
	DECLARE @HouseId INT;

	SELECT
		@HouseId = HouseId
	FROM People
	WHERE Id = @PeopleId;

	UPDATE PEO
	SET
		IsMain = 0
	FROM People PEO
	WHERE HouseId = @HouseId AND IsMain = 1;

	UPDATE PEO
	SET
		IsMain = 1
	,	FamilyRelationId = NULL
	,	LastUpdUs = @LastUpdUs
	,	LastUpdDt = GETDATE()
	FROM People PEO
	WHERE HouseId = @HouseId AND Id = @PeopleId;
END
