declare @LastUpdDt smalldatetime, @LastUpdUs varchar(50)
declare @RegionId int, @DistrictId int, @CityTypeId int

SET @LastUpdDt = GETDATE()
SET @LastUpdUs = N'SV'

select @CityTypeId = Id
from   CityType
where  Name = N'село'   

select @DistrictId = Id
,      @RegionId = RegionId
from   District
where  Name = N'Снятинський' 

IF NOT EXISTS(select 1 from City where Name = N'Тростянець')
BEGIN
  insert into City(Name, CityTypeId, DistrictId, RegionId, LastUpdDt, LastUpdUs)
  select N'Тростянець'
  ,      @CityTypeId
  ,      @DistrictId
  ,      @RegionId
  ,      @LastUpdDt
  ,      @LastUpdUs
END

select @CityTypeId = Id
from   CityType
where  Name = N'місто'

select @RegionId = Id
from   Region
where  Name = N'Івано-Франківська'

IF NOT EXISTS(select 1 from City where Name = N'Снятин')
BEGIN
  insert into City(Name, CityTypeId, DistrictId, RegionId, LastUpdDt, LastUpdUs)
  select N'Снятин'
  ,      @CityTypeId
  ,      NULL
  ,      @RegionId
  ,      @LastUpdDt
  ,      @LastUpdUs
END

select @RegionId = Id
from   Region
where  Name = N'Київська'

IF NOT EXISTS(select 1 from City where Name = N'Київ')
BEGIN
  insert into City(Name, CityTypeId, DistrictId, RegionId, LastUpdDt, LastUpdUs)
  select N'Київ'
  ,      @CityTypeId
  ,      NULL
  ,      @RegionId
  ,      @LastUpdDt
  ,      @LastUpdUs
END

select @RegionId = Id
from   Region
where  Name = N'Чернівецька'

IF NOT EXISTS(select 1 from City where Name = N'Чернівці')
BEGIN
  insert into City(Name, CityTypeId, DistrictId, RegionId, LastUpdDt, LastUpdUs)
  select N'Чернівці'
  ,      @CityTypeId
  ,      NULL
  ,      @RegionId
  ,      @LastUpdDt
  ,      @LastUpdUs
END

select @CityTypeId = Id
from   CityType
where  Name = N'селище'

select @DistrictId = Id
,      @RegionId = RegionId
from   District
where  Name = N'Кіцманський' 

IF NOT EXISTS(select 1 from City where Name = N'Лужани')
BEGIN
  insert into City(Name, CityTypeId, DistrictId, RegionId, LastUpdDt, LastUpdUs)
  select N'Лужани'
  ,      @CityTypeId
  ,      @DistrictId
  ,      @RegionId
  ,      @LastUpdDt
  ,      @LastUpdUs
END