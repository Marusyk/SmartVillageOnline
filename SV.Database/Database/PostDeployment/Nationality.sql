declare @LastUpdDt smalldatetime, @LastUpdUs varchar(50)

SET @LastUpdDt = GETDATE()
SET @LastUpdUs = N'SV'

insert into Nationality(Name, LastUpdDt, LastUpdUs)
select N'українець', @LastUpdDt, @LastUpdUs

insert into Nationality(Name, LastUpdDt, LastUpdUs)
select N'українка', @LastUpdDt, @LastUpdUs

insert into Nationality(Name, LastUpdDt, LastUpdUs)
select N'румун', @LastUpdDt, @LastUpdUs

