DECLARE
	@LastUpdDt SMALLDATETIME = GETDATE(),
	@LastUpdUs NVARCHAR(50) = N'SV';

INSERT INTO [People]
(	[PersonId]
,	[HouseId]
,	[PeopleNumber]
,	[FamilyRelationId]
,	[DateRegistration]
,	[IsMain]
,	[LastUpdDt]
,	[LastUpdUs]
)
SELECT
	1 -- PersonId
,	1  --HouseId
,	77511
,	2 -- FamilyRelationId
,	CONVERT(date, '14.02.2000', 104)
,	1 
,	@LastUpdDt
,	@LastUpdUs;