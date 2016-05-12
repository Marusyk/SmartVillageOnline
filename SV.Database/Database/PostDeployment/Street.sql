declare @LastUpdDt smalldatetime, @LastUpdUs varchar(50)
declare @StreetTypeId int

SET @LastUpdDt = GETDATE()
SET @LastUpdUs = N'SV'

select @StreetTypeId = Id
from   StreetType
where  Name = N'вулиця'

IF NOT EXISTS(select 1 from Street where Name = N'Шевченка')
BEGIN
  insert into Street(Name, StreetTypeId, LastUpdDt, LastUpdUs)
  select N'Шевченка'
  ,      @StreetTypeId
  ,      @LastUpdDt
  ,      @LastUpdUs
END

IF NOT EXISTS(select 1 from Street where Name = N'Головна')
BEGIN
  insert into Street(Name, StreetTypeId, LastUpdDt, LastUpdUs)
  select N'Головна'
  ,      @StreetTypeId
  ,      @LastUpdDt
  ,      @LastUpdUs
END

IF NOT EXISTS(select 1 from Street where Name = N'Січових стрільців')
BEGIN
  insert into Street(Name, StreetTypeId, LastUpdDt, LastUpdUs)
  select N'Січових стрільців'
  ,      @StreetTypeId
  ,      @LastUpdDt
  ,      @LastUpdUs
END

IF NOT EXISTS(select 1 from Street where Name = N'Українська')
BEGIN
  insert into Street(Name, StreetTypeId, LastUpdDt, LastUpdUs)
  select N'Українська'
  ,      @StreetTypeId
  ,      @LastUpdDt
  ,      @LastUpdUs
END

select @StreetTypeId = Id
from   StreetType
where  Name = N'проспект'

IF NOT EXISTS(select 1 from Street where Name = N'Незалежності')
BEGIN
  insert into Street(Name, StreetTypeId, LastUpdDt, LastUpdUs)
  select N'Незалежності'
  ,      @StreetTypeId
  ,      @LastUpdDt
  ,      @LastUpdUs
END