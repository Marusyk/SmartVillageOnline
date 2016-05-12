declare @LastUpdDt smalldatetime, @LastUpdUs varchar(50)
declare @AddressId int

SET @LastUpdDt = GETDATE()
SET @LastUpdUs = N'SV'

select @AddressId = Id
from   Address
where  BuildNr = N'51'

insert into House 
( HouseNr
, KadastrNr
, BuildNr
, AddressId
, PhoneNr
, PhoneCode
, FaxNr
, Year
, Code
, LastUpdDt
, LastUpdUs
)
select N'1'
,      N'3221655100:01:047:0052'
,      N'51'
,      @AddressId
,      N'4-94-74'
,      N'03476'
,      NULL
,      2015
,      N'001'
,      @LastUpdDt
,      @LastUpdUs


select @AddressId = Id
from   Address
where  BuildNr = N'15'

insert into House 
( HouseNr
, KadastrNr
, BuildNr
, AddressId
, PhoneNr
, PhoneCode
, FaxNr
, Year
, Code
, LastUpdDt
, LastUpdUs
)
select N'2'
,      N'3221655100:01:047:0000'
,      N'15'
,      @AddressId
,      NULL
,      N'0522'
,      NULL
,      2014
,      N'002'
,      @LastUpdDt
,      @LastUpdUs