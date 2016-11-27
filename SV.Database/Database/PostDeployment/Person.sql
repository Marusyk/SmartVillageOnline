DECLARE
	@LastUpdDt SMALLDATETIME = GETDATE(),
	@LastUpdUs NVARCHAR(50) = N'SV',
	@CouncilId INT = 3,
	@AddressID INT = 1;

INSERT INTO [Person]
(	[FirstName]
,	[LastName]
,	[MiddleName]
,	[DateBirth]
,	[Sex]
,	[IsResident]
,	[AddressBirthId]
,	[AddressLiveId]
,	[NationalityId]
,	[IdentificationCode]
,	[PassSeria]
,	[PassNr]
,	[PassDate]
,	[PassAuthorityId]
,	[FamilyStatusId]
,	[CitizenshipId]
,	[CatalogId]
,	[IsSojourn]
,	[Photo]
,	[PadFirstName]
,	[PadName]
,	[PadLastName]
,	[DatFirstName]
,	[DatName]
,	[DatLastName]
,	[CouncilId]
,	[LastUpdDt]
,	[LastUpdUs]
)
SELECT
	N'Роман'
,	N'Марусик'
,	N'Валерійович'
,	CONVERT(date, '14.02.1992', 104)
,	1
,	1
,	@AddressID --AddressBirthId
,	@AddressID --AddressLiveId
,	1 --NationalityId
,	N'1234567890'
,	N'CE'
,	1234567890
,	CONVERT(date, '14.02.2008', 104)
,	NULL --PassAuthorityId
,	3 --FamilyStatusId
,	1 --CitizenshipId
,	1 --CatalogId
,	0
,	NULL
,	N''
,	N''
,	N''
,	N''
,	N''
,	N''
,	@CouncilId
,	@LastUpdDt
,	@LastUpdUs;