DECLARE @LastUpdDt SMALLDATETIME, @LastUpdUs NVARCHAR(50);

SET @LastUpdDt = GETDATE();
SET @LastUpdUs = N'SV';

DELETE FROM [SYS_Dictionary];

/* ========================= ADDRESS =======================================*/
INSERT INTO [SYS_Dictionary]([Name], [Description], [IsStatic], [LastUpdDt], [LastUpdUs])
VALUES('Address', N'Адреси', 0, @LastUpdDt, @LastUpdUs);

/* ========================= ANIMALS ======================================*/
INSERT INTO [SYS_Dictionary]([Name], [Description], [IsStatic], [LastUpdDt], [LastUpdUs])
VALUES('Animal', N'Тварини', 0, @LastUpdDt, @LastUpdUs);

/* ========================= CITY ==========================================*/
INSERT INTO [SYS_Dictionary]([Name], [Description], [IsStatic], [LastUpdDt], [LastUpdUs])
VALUES('City', N'Населені пункти', 0, @LastUpdDt, @LastUpdUs);

/* ========================= CITY TYPE =====================================*/
INSERT INTO [SYS_Dictionary]([Name], [Description], [IsStatic], [LastUpdDt], [LastUpdUs])
VALUES('CityType', N'Типи населених пунктів', 1, @LastUpdDt, @LastUpdUs);

/* ========================= COUNTRY ======================================*/
INSERT INTO [SYS_Dictionary]([Name], [Description], [IsStatic], [LastUpdDt], [LastUpdUs])
VALUES('Country', N'Країни', 0, @LastUpdDt, @LastUpdUs);

/* ========================= DISTRICT ======================================*/
INSERT INTO [SYS_Dictionary]([Name], [Description], [IsStatic], [LastUpdDt], [LastUpdUs])
VALUES('District', N'Райони', 0, @LastUpdDt, @LastUpdUs);

/* ========================= DOCUMENT TYPE =================================*/
INSERT INTO [SYS_Dictionary]([Name], [Description], [IsStatic], [LastUpdDt], [LastUpdUs])
VALUES('DocumentType', N'Типи документів', 0, @LastUpdDt, @LastUpdUs);

/* ========================= FAMILY RELATIONS ==============================*/
INSERT INTO [SYS_Dictionary]([Name], [Description], [IsStatic], [LastUpdDt], [LastUpdUs])
VALUES('FamilyRelations', N'Родинні відносини', 0, @LastUpdDt, @LastUpdUs);

/* ========================= FAMILY STATUS =================================*/
INSERT INTO [SYS_Dictionary]([Name], [Description], [IsStatic], [LastUpdDt], [LastUpdUs])
VALUES('FamilyStatus', N'Сімейний стан', 0, @LastUpdDt, @LastUpdUs)

/* ========================= MATERIALS =====================================*/
INSERT INTO [SYS_Dictionary]([Name], [Description], [IsStatic], [LastUpdDt], [LastUpdUs])
VALUES('Material', N'Матеріали', 0, @LastUpdDt, @LastUpdUs);

/* ========================= NATIONALITY ===================================*/
INSERT INTO [SYS_Dictionary]([Name], [Description], [IsStatic], [LastUpdDt], [LastUpdUs])
VALUES('Nationality', N'Національності', 0, @LastUpdDt, @LastUpdUs);

/* ========================= PASSAUTHORITY =================================*/
INSERT INTO [SYS_Dictionary]([Name], [Description], [IsStatic], [LastUpdDt], [LastUpdUs])
VALUES('PassAuthority', N'Орган, який видав документ', 0, @LastUpdDt, @LastUpdUs);

/* ========================= PENSION TYPE ==================================*/
INSERT INTO [SYS_Dictionary]([Name], [Description], [IsStatic], [LastUpdDt], [LastUpdUs])
VALUES('PensionType', N'Види пенсій', 0, @LastUpdDt, @LastUpdUs);

/* ========================= POSITION ======================================*/
INSERT INTO [SYS_Dictionary]([Name], [Description], [IsStatic], [LastUpdDt], [LastUpdUs])
VALUES('Position', N'Посади', 0, @LastUpdDt, @LastUpdUs);

/* ========================= REGION ========================================*/
INSERT INTO [SYS_Dictionary]([Name], [Description], [IsStatic], [LastUpdDt], [LastUpdUs])
VALUES('Region', N'Області', 0, @LastUpdDt, @LastUpdUs);

/* ========================= STREET ========================================*/
INSERT INTO [SYS_Dictionary]([Name], [Description], [IsStatic], [LastUpdDt], [LastUpdUs])
VALUES('Street', N'Вулиці', 0, @LastUpdDt, @LastUpdUs);

/* ========================= STREET TYPE ===================================*/
INSERT INTO [SYS_Dictionary]([Name], [Description], [IsStatic], [LastUpdDt], [LastUpdUs])
VALUES('StreetType', N'Типи вулиць', 1, @LastUpdDt, @LastUpdUs);

/* ========================= PERSON ===================================*/
INSERT INTO [SYS_Dictionary]([Name], [Description], [IsStatic], [LastUpdDt], [LastUpdUs])
VALUES('Person', N'Контрагенти', 0, @LastUpdDt, @LastUpdUs);

/* ========================= INSTITUTION ===================================*/
INSERT INTO [SYS_Dictionary]([Name], [Description], [IsStatic], [LastUpdDt], [LastUpdUs])
VALUES('Institution', N'Навчальні заклади', 0, @LastUpdDt, @LastUpdUs);

/* ========================= SPECIALITIES ===================================*/
INSERT INTO [SYS_Dictionary]([Name], [Description], [IsStatic], [LastUpdDt], [LastUpdUs])
VALUES('Speciality', N'Спеціальності', 0, @LastUpdDt, @LastUpdUs);

/* ========================= EDUCATIONDEGREE ===================================*/
INSERT INTO [SYS_Dictionary]([Name], [Description], [IsStatic], [LastUpdDt], [LastUpdUs])
VALUES('EducationDegree', N'Рівні освіти', 0, @LastUpdDt, @LastUpdUs);

/* ========================= ACTIVITYTYPES ===================================*/
INSERT INTO [SYS_Dictionary]([Name], [Description], [IsStatic], [LastUpdDt], [LastUpdUs])
VALUES('ActivityType', N'Види діяльності', 0, @LastUpdDt, @LastUpdUs);

/* ========================= COMPANIES ===================================*/
INSERT INTO [SYS_Dictionary]([Name], [Description], [IsStatic], [LastUpdDt], [LastUpdUs])
VALUES('Company', N'Компанії', 0, @LastUpdDt, @LastUpdUs);