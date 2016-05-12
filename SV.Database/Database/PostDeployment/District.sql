declare @LastUpdDt smalldatetime, @LastUpdUs varchar(50)
declare @RegionId int

SET @LastUpdDt = GETDATE()
SET @LastUpdUs = N'SV'

select @RegionId = Id
from   Region
where  Name = N'Івано-Франківська'

IF NOT EXISTS(select 1 from District where Name = N'Снятинський')
BEGIN
  insert into District(Name, RegionId, LastUpdDt, LastUpdUs)
  select N'Снятинський'
  ,      @RegionId
  ,      @LastUpdDt
  ,      @LastUpdUs
END

IF NOT EXISTS(select 1 from District where Name = N'Косівський')
BEGIN
  insert into District(Name, RegionId, LastUpdDt, LastUpdUs)
  select N'Косівський'
  ,      @RegionId
  ,      @LastUpdDt
  ,      @LastUpdUs
END

select @RegionId = Id
from   Region
where  Name = N'Чернівецька'

IF NOT EXISTS(select 1 from District where Name = N'Кіцманський')
BEGIN
  insert into District(Name, RegionId, LastUpdDt, LastUpdUs)
  select N'Кіцманський'
  ,     @RegionId
  ,     @LastUpdDt
  ,     @LastUpdUs
END

IF NOT EXISTS(select 1 from District where Name = N'Вижницький')
BEGIN
  insert into District(Name, RegionId, LastUpdDt, LastUpdUs)
  select N'Вижницький'
  ,     @RegionId
  ,     @LastUpdDt
  ,     @LastUpdUs
END