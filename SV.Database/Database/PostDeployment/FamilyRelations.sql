declare @LastUpdDt smalldatetime, @LastUpdUs varchar(50)

SET @LastUpdDt = GETDATE()
SET @LastUpdUs = N'SV'

insert into FamilyRelations(Name, LastUpdDt, LastUpdUs)
select N'дружина', @LastUpdDt, @LastUpdUs

insert into FamilyRelations(Name, LastUpdDt, LastUpdUs)
select N'чоловік', @LastUpdDt, @LastUpdUs

insert into FamilyRelations(Name, LastUpdDt, LastUpdUs)
select N'син', @LastUpdDt, @LastUpdUs

insert into FamilyRelations(Name, LastUpdDt, LastUpdUs)
select N'дочка', @LastUpdDt, @LastUpdUs

insert into FamilyRelations(Name, LastUpdDt, LastUpdUs)
select N'мати', @LastUpdDt, @LastUpdUs

insert into FamilyRelations(Name, LastUpdDt, LastUpdUs)
select N'батько', @LastUpdDt, @LastUpdUs

insert into FamilyRelations(Name, LastUpdDt, LastUpdUs)
select N'брат', @LastUpdDt, @LastUpdUs

insert into FamilyRelations(Name, LastUpdDt, LastUpdUs)
select N'сестра', @LastUpdDt, @LastUpdUs

insert into FamilyRelations(Name, LastUpdDt, LastUpdUs)
select N'дідусь', @LastUpdDt, @LastUpdUs

insert into FamilyRelations(Name, LastUpdDt, LastUpdUs)
select N'бабуся', @LastUpdDt, @LastUpdUs

