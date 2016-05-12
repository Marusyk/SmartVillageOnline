declare @LastUpdDt smalldatetime, @LastUpdUs varchar(50)
SET @LastUpdDt = GETDATE()
SET @LastUpdUs = N'SV'

IF NOT EXISTS(select 1 from CityType where Name = N'село')
BEGIN
  insert into CityType(Name, LastUpdDt, LastUpdUs)
  select N'село'
  ,      @LastUpdDt
  ,      @LastUpdUs
END

IF NOT EXISTS(select 1 from CityType where Name = N'місто')
BEGIN
  insert into CityType(Name, LastUpdDt, LastUpdUs)
  select N'місто'
  ,      @LastUpdDt
  ,      @LastUpdUs
END

IF NOT EXISTS(select 1 from CityType where Name = N'селище')
BEGIN
  insert into CityType(Name, LastUpdDt, LastUpdUs)
  select N'селище'
  ,      @LastUpdDt
  ,      @LastUpdUs
END

IF NOT EXISTS(select 1 from CityType where Name = N'хутір')
BEGIN
  insert into CityType(Name, LastUpdDt, LastUpdUs)
  select N'хутір'
  ,      @LastUpdDt
  ,      @LastUpdUs
END