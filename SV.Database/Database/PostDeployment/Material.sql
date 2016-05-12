declare @LastUpdDt smalldatetime, @LastUpdUs varchar(50)

SET @LastUpdDt = GETDATE()
SET @LastUpdUs = N'SV'

insert into Material(Name, LastUpdDt, LastUpdUs)
select N'дерево', @LastUpdDt, @LastUpdUs

insert into Material(Name, LastUpdDt, LastUpdUs)
select N'цемент', @LastUpdDt, @LastUpdUs

insert into Material(Name, LastUpdDt, LastUpdUs)
select N'цегла', @LastUpdDt, @LastUpdUs

