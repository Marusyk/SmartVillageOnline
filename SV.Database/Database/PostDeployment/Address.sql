declare @LastUpdDt smalldatetime, @LastUpdUs varchar(50)
declare @CityId int, @StreetId int

SET @LastUpdDt = GETDATE()
SET @LastUpdUs = N'SV'

select @CityId = Id
from   City
where  Name = N'Тростянець'

select @StreetId = Id
from   Street
where  Name = N'Шевченка'

insert into Address(CityId, StreetId, PostCode, BuildNr, FlatNr, LastUpdDt, LastUpdUs)
select @CityId, @StreetId, NULL, N'51', NULL, @LastUpdDt, @LastUpdUs

select @CityId = Id
from   City
where  Name = N'Чернівці'

select @StreetId = Id
from   Street
where  Name = N'Головна'

insert into Address(CityId, StreetId, PostCode, BuildNr, FlatNr, LastUpdDt, LastUpdUs)
select @CityId, @StreetId, 12300, N'24a', N'400', @LastUpdDt, @LastUpdUs

select @CityId = Id
from   City
where  Name = N'Снятин'

select @StreetId = Id
from   Street
where  Name = N'Українська'

insert into Address(CityId, StreetId, PostCode, BuildNr, FlatNr, LastUpdDt, LastUpdUs)
select @CityId, @StreetId, NULL, N'15', N'4', @LastUpdDt, @LastUpdUs


