DECLARE
	@LastUpdDt SMALLDATETIME = GETDATE(),
	@LastUpdUs NVARCHAR(50) = N'SV',
	@CouncilId INT,
	@AddressId INT;

SELECT
	@AddressId = [Id]
FROM  [Address]
WHERE [BuildNr] = N'51';

SET @CouncilId = 3;

INSERT INTO [House]
(	[HouseNr]
,	[KadastrNr]
,	[BuildNr]
,	[AddressId]
,	[PhoneNr]
,	[PhoneCode]
,	[FaxNr]
,	[Year]
,	[Code]
,	[CouncilId]
,	[LastUpdDt]
,	[LastUpdUs]
)
SELECT
	N'1'
,	N'3221655100:01:047:0052'
,	N'51'
,	@AddressId
,	N'4-94-74'
,	N'03476'
,	NULL
,	2015
,	N'001'
,	@CouncilId
,	@LastUpdDt
,	@LastUpdUs;

SELECT
	@AddressId = [Id]
FROM  [Address]
WHERE [BuildNr] = N'15';

SET @CouncilId = 2;

INSERT INTO [House]
(	[HouseNr]
,	[KadastrNr]
,	[BuildNr]
,	[AddressId]
,	[PhoneNr]
,	[PhoneCode]
,	[FaxNr]
,	[Year]
,	[Code]
,	[CouncilId]
,	[LastUpdDt]
,	[LastUpdUs]
)
SELECT
	N'2'
,	N'3221655100:01:047:0000'
,	N'15'
,	@AddressId
,	NULL
,	N'0522'
,	NULL
,	2014
,	N'002'
,	@CouncilId
,	@LastUpdDt
,	@LastUpdUs;