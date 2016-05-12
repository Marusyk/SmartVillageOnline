declare @LastUpdDt smalldatetime, @LastUpdUs varchar(50)

SET @LastUpdDt = GETDATE()
SET @LastUpdUs = N'SV'

INSERT INTO [dbo].[Animal] (Name, LastUpdDt, LastUpdUs)
select N'Корова', @LastUpdDt, @LastUpdUs

insert into Animal(Name, LastUpdDt, LastUpdUs)
select N'Свиня', @LastUpdDt, @LastUpdUs

insert into Animal(Name, LastUpdDt, LastUpdUs)
select N'Собака', @LastUpdDt, @LastUpdUs