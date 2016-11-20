DECLARE @LastUpdDt SMALLDATETIME, @LastUpdUs NVARCHAR(50);

SET @LastUpdDt = GETDATE();
SET @LastUpdUs = N'SV';

IF NOT EXISTS(SELECT 1 FROM [Country] WHERE [Name] = N'Україна')
BEGIN
	INSERT INTO [Country]([Name], [LastUpdDt], [LastUpdUs]) VALUES (N'Україна', @LastUpdDt, @LastUpdUs);
END;

IF NOT EXISTS(SELECT 1 FROM [Country] WHERE [Name] = N'Польща')
BEGIN
	INSERT INTO [Country]([Name], [LastUpdDt], [LastUpdUs]) VALUES (N'Польща', @LastUpdDt, @LastUpdUs);
END;

IF NOT EXISTS(SELECT 1 FROM [Country] WHERE [Name] = N'Білорусія')
BEGIN
	INSERT INTO [Country]([Name], [LastUpdDt], [LastUpdUs]) VALUES (N'Білорусія', @LastUpdDt, @LastUpdUs);
END;

IF NOT EXISTS(SELECT 1 FROM [Country] WHERE [Name] = N'Молдова')
BEGIN
	INSERT INTO [Country]([Name], [LastUpdDt], [LastUpdUs]) VALUES (N'Молдова', @LastUpdDt, @LastUpdUs);
END;

IF NOT EXISTS(SELECT 1 FROM [Country] WHERE [Name] = N'Росія')
BEGIN
	INSERT INTO [Country]([Name], [LastUpdDt], [LastUpdUs]) VALUES (N'Росія', @LastUpdDt, @LastUpdUs);
END;