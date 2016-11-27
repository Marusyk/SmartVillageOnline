DECLARE
	@LastUpdDt SMALLDATETIME = GETDATE(),
	@LastUpdUs NVARCHAR(50) = N'SV';

INSERT INTO [FamilyRelations]([Name], [LastUpdDt], [LastUpdUs])
SELECT N'дружина', @LastUpdDt, @LastUpdUs;

INSERT INTO [FamilyRelations]([Name], [LastUpdDt], [LastUpdUs])
SELECT N'чоловік', @LastUpdDt, @LastUpdUs;

INSERT INTO [FamilyRelations]([Name], [LastUpdDt], [LastUpdUs])
SELECT N'син', @LastUpdDt, @LastUpdUs;

INSERT INTO [FamilyRelations]([Name], [LastUpdDt], [LastUpdUs])
SELECT N'дочка', @LastUpdDt, @LastUpdUs;

INSERT INTO [FamilyRelations]([Name], [LastUpdDt], [LastUpdUs])
SELECT N'мати', @LastUpdDt, @LastUpdUs;

INSERT INTO [FamilyRelations]([Name], [LastUpdDt], [LastUpdUs])
SELECT N'батько', @LastUpdDt, @LastUpdUs;

INSERT INTO [FamilyRelations]([Name], [LastUpdDt], [LastUpdUs])
SELECT N'брат', @LastUpdDt, @LastUpdUs;

INSERT INTO [FamilyRelations]([Name], [LastUpdDt], [LastUpdUs])
SELECT N'сестра', @LastUpdDt, @LastUpdUs;

INSERT INTO [FamilyRelations]([Name], [LastUpdDt], [LastUpdUs])
SELECT N'дідусь', @LastUpdDt, @LastUpdUs;

INSERT INTO [FamilyRelations]([Name], [LastUpdDt], [LastUpdUs])
SELECT N'бабуся', @LastUpdDt, @LastUpdUs;

