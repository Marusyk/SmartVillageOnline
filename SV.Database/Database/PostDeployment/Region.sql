declare @LastUpdDt smalldatetime, @LastUpdUs varchar(50)
declare @CountryId int

SET @LastUpdDt = GETDATE()
SET @LastUpdUs = N'SV'

select @CountryId = Id 
from   Country
where  Name = N'Україна'

IF NOT EXISTS(select 1 from Region where Name = N'Вінницька')
BEGIN
  insert into Region(Name, CountryId, LastUpdDt, LastUpdUs)
  select N'Вінницька'
  ,      @CountryId
  ,      @LastUpdDt
  ,      @LastUpdUs
END

IF NOT EXISTS(select 1 from Region where Name = N'Волинська')
BEGIN
  insert into Region(Name, CountryId, LastUpdDt, LastUpdUs)
  select N'Волинська'
  ,      @CountryId
  ,      @LastUpdDt
  ,      @LastUpdUs
END

IF NOT EXISTS(select 1 from Region where Name = N'Дніпропетровська')
BEGIN
  insert into Region(Name, CountryId, LastUpdDt, LastUpdUs)
  select N'Дніпропетровська'
  ,      @CountryId
  ,      @LastUpdDt
  ,      @LastUpdUs
END

IF NOT EXISTS(select 1 from Region where Name = N'Донецька')
BEGIN
  insert into Region(Name, CountryId, LastUpdDt, LastUpdUs)
  select N'Донецька'
  ,      @CountryId
  ,      @LastUpdDt
  ,      @LastUpdUs
END

IF NOT EXISTS(select 1 from Region where Name = N'Житомирська')
BEGIN
  insert into Region(Name, CountryId, LastUpdDt, LastUpdUs)
  select N'Житомирська'
  ,      @CountryId
  ,      @LastUpdDt
  ,      @LastUpdUs
END

IF NOT EXISTS(select 1 from Region where Name = N'Закарпатська')
BEGIN
  insert into Region(Name, CountryId, LastUpdDt, LastUpdUs)
  select N'Закарпатська'
  ,      @CountryId
  ,      @LastUpdDt
  ,      @LastUpdUs
END

IF NOT EXISTS(select 1 from Region where Name = N'Запорізька')
BEGIN
  insert into Region(Name, CountryId, LastUpdDt, LastUpdUs)
  select N'Запорізька'
  ,      @CountryId
  ,      @LastUpdDt
  ,      @LastUpdUs
END

IF NOT EXISTS(select 1 from Region where Name = N'Івано-Франківська')
BEGIN
  insert into Region(Name, CountryId, LastUpdDt, LastUpdUs)
  select N'Івано-Франківська'
  ,      @CountryId
  ,      @LastUpdDt
  ,      @LastUpdUs
END

IF NOT EXISTS(select 1 from Region where Name = N'Київська')
BEGIN
  insert into Region(Name, CountryId, LastUpdDt, LastUpdUs)
  select N'Київська'
  ,      @CountryId
  ,      @LastUpdDt
  ,      @LastUpdUs
END

IF NOT EXISTS(select 1 from Region where Name = N'Кіровоградська')
BEGIN
  insert into Region(Name, CountryId, LastUpdDt, LastUpdUs)
  select N'Кіровоградська'
  ,      @CountryId
  ,      @LastUpdDt
  ,      @LastUpdUs
END

IF NOT EXISTS(select 1 from Region where Name = N'Луганська')
BEGIN
  insert into Region(Name, CountryId, LastUpdDt, LastUpdUs)
  select N'Луганська'
  ,      @CountryId
  ,      @LastUpdDt
  ,      @LastUpdUs
END

IF NOT EXISTS(select 1 from Region where Name = N'Львівська')
BEGIN
  insert into Region(Name, CountryId, LastUpdDt, LastUpdUs)
  select N'Львівська'
  ,      @CountryId
  ,      @LastUpdDt
  ,      @LastUpdUs
END

IF NOT EXISTS(select 1 from Region where Name = N'Миколаївська')
BEGIN
  insert into Region(Name, CountryId, LastUpdDt, LastUpdUs)
  select N'Миколаївська'
  ,      @CountryId
  ,      @LastUpdDt
  ,      @LastUpdUs
END

IF NOT EXISTS(select 1 from Region where Name = N'Одеська')
BEGIN
  insert into Region(Name, CountryId, LastUpdDt, LastUpdUs)
  select N'Одеська'
  ,      @CountryId
  ,      @LastUpdDt
  ,      @LastUpdUs
END

IF NOT EXISTS(select 1 from Region where Name = N'Полтавська')
BEGIN
  insert into Region(Name, CountryId, LastUpdDt, LastUpdUs)
  select N'Полтавська'
  ,     @CountryId
  ,     @LastUpdDt
  ,     @LastUpdUs
END

IF NOT EXISTS(select 1 from Region where Name = N'Рівненська')
BEGIN
  insert into Region(Name, CountryId, LastUpdDt, LastUpdUs)
  select N'Рівненська'
  ,      @CountryId
  ,      @LastUpdDt
  ,      @LastUpdUs
END

IF NOT EXISTS(select 1 from Region where Name = N'Сумська')
BEGIN
  insert into Region(Name, CountryId, LastUpdDt, LastUpdUs)
  select N'Сумська'
  ,      @CountryId
  ,      @LastUpdDt
  ,      @LastUpdUs
END

IF NOT EXISTS(select 1 from Region where Name = N'Тернопільська')
BEGIN
  insert into Region(Name, CountryId, LastUpdDt, LastUpdUs)
  select N'Тернопільська'
  ,      @CountryId
  ,      @LastUpdDt
  ,      @LastUpdUs
END

IF NOT EXISTS(select 1 from Region where Name = N'Харківська')
BEGIN
  insert into Region(Name, CountryId, LastUpdDt, LastUpdUs)
  select N'Харківська'
  ,      @CountryId
  ,      @LastUpdDt
  ,      @LastUpdUs
END

IF NOT EXISTS(select 1 from Region where Name = N'Херсонська')
BEGIN
  insert into Region(Name, CountryId, LastUpdDt, LastUpdUs)
  select N'Херсонська'
  ,     @CountryId
  ,     @LastUpdDt
  ,     @LastUpdUs
END

IF NOT EXISTS(select 1 from Region where Name = N'Хмельницька')
BEGIN
  insert into Region(Name, CountryId, LastUpdDt, LastUpdUs)
  select N'Хмельницька'
  ,     @CountryId
  ,     @LastUpdDt
  ,     @LastUpdUs
END

IF NOT EXISTS(select 1 from Region where Name = N'Черкаська')
BEGIN
  insert into Region(Name, CountryId, LastUpdDt, LastUpdUs)
  select N'Черкаська'
  ,      @CountryId
  ,      @LastUpdDt
  ,      @LastUpdUs
END

IF NOT EXISTS(select 1 from Region where Name = N'Чернівецька')
BEGIN
  insert into Region(Name, CountryId, LastUpdDt, LastUpdUs)
  select N'Чернівецька'
  ,      @CountryId
  ,      @LastUpdDt
  ,      @LastUpdUs
END

IF NOT EXISTS(select 1 from Region where Name = N'Чернігівська')
BEGIN
  insert into Region(Name, CountryId, LastUpdDt, LastUpdUs)
  select N'Чернігівська'
  ,      @CountryId
  ,      @LastUpdDt
  ,      @LastUpdUs
END
