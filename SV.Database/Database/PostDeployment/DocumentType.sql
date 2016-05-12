declare @LastUpdDt smalldatetime, @LastUpdUs varchar(50)

SET @LastUpdDt = GETDATE()
SET @LastUpdUs = N'SV'

insert into DocumentType(Name, LastUpdDt, LastUpdUs)
select N'свідоцтво', @LastUpdDt, @LastUpdUs

insert into DocumentType(Name, LastUpdDt, LastUpdUs)
select N'посвідчення', @LastUpdDt, @LastUpdUs

