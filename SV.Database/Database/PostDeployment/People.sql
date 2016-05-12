declare @LastUpdDt smalldatetime, @LastUpdUs varchar(50)

SET @LastUpdDt = GETDATE()
SET @LastUpdUs = N'SV'

insert into People
( PersonId
, HouseId
, PeopleNumber
, FamilyRelationId
, DateRegistration
, IsMain
, LastUpdDt
, LastUpdUs
)
select 1 -- PersonId
,      1  --HouseId
,      77511
,      2 -- FamilyRelationId
,      CONVERT(date, '14.02.2000', 104)
,      1 
,      @LastUpdDt
,      @LastUpdUs