declare @LastUpdDt smalldatetime, @LastUpdUs varchar(50)

SET @LastUpdDt = GETDATE()
SET @LastUpdUs = N'SV'

insert into Catalog(ParentId, Name, ModuleId, LastUpdDt, LastUpdUs)
select NULL, N'Фізичні особи', NULL, @LastUpdDt, @LastUpdUs

