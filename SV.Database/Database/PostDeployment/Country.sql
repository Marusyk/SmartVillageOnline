declare @LastUpdDt smalldatetime, @LastUpdUs varchar(50)
SET @LastUpdDt = GETDATE()
SET @LastUpdUs = N'SV'

IF NOT EXISTS(select 1 from Country where Name = N'Україна')
BEGIN
  insert into Country (Name, LastUpdDt, LastUpdUs) values (N'Україна', @LastUpdDt, @LastUpdUs)	
END

IF NOT EXISTS(select 1 from Country where Name = N'Польща')
BEGIN
  insert into Country (Name, LastUpdDt, LastUpdUs) values (N'Польща', @LastUpdDt, @LastUpdUs)	
END

IF NOT EXISTS(select 1 from Country where Name = N'Білорусія')
BEGIN
  insert into Country (Name, LastUpdDt, LastUpdUs) values (N'Білорусія', @LastUpdDt, @LastUpdUs)	
END

IF NOT EXISTS(select 1 from Country where Name = N'Молдова')
BEGIN
  insert into Country (Name, LastUpdDt, LastUpdUs) values (N'Молдова', @LastUpdDt, @LastUpdUs)	
END

