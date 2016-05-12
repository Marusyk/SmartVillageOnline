declare @LastUpdDt smalldatetime, @LastUpdUs nvarchar(50)
SET @LastUpdDt = GETDATE()
SET @LastUpdUs = N'SV'

delete from SYS_Dictionary

/* ========================= ADDRESS =======================================*/
insert into SYS_Dictionary (Name, Description, IsStatic, LastUpdDt, LastUpdUS) 
values ('Address', N'Адреси', 0, @LastUpdDt, @LastUpdUs)

/* ========================= ANIMALS ======================================*/
insert into SYS_Dictionary (Name, Description, IsStatic, LastUpdDt, LastUpdUS) 
values ('Animal', N'Тварини', 0, @LastUpdDt, @LastUpdUs)

/* ========================= CITY ==========================================*/
insert into SYS_Dictionary (Name, Description, IsStatic, LastUpdDt, LastUpdUS) 
values ('City', N'Населені пункти', 0, @LastUpdDt, @LastUpdUs)

/* ========================= CITY TYPE =====================================*/
insert into SYS_Dictionary (Name, Description, IsStatic, LastUpdDt, LastUpdUS) 
values ('CityType', N'Типи населених пунктів', 1, @LastUpdDt, @LastUpdUs)

/* ========================= COUNTRY ======================================*/
insert into SYS_Dictionary (Name, Description, IsStatic, LastUpdDt, LastUpdUS) 
values ('Country', N'Країни', 0, @LastUpdDt, @LastUpdUs)

/* ========================= DISTRICT ======================================*/
insert into SYS_Dictionary (Name, Description, IsStatic, LastUpdDt, LastUpdUS) 
values ('District', N'Райони', 0, @LastUpdDt, @LastUpdUs)

/* ========================= DOCUMENT TYPE =================================*/
insert into SYS_Dictionary (Name, Description, IsStatic, LastUpdDt, LastUpdUS) 
values ('DocumentType', N'Типи документів', 0, @LastUpdDt, @LastUpdUs)

/* ========================= FAMILY RELATIONS ==============================*/
insert into SYS_Dictionary (Name, Description, IsStatic, LastUpdDt, LastUpdUS) 
values ('FamilyRelations', N'Родинні відносини', 0, @LastUpdDt, @LastUpdUs)

/* ========================= FAMILY STATUS =================================*/
insert into SYS_Dictionary (Name, Description, IsStatic, LastUpdDt, LastUpdUS) 
values ('FamilyStatus', N'Сімейний стан', 0, @LastUpdDt, @LastUpdUs)

/* ========================= MATERIALS =====================================*/
insert into SYS_Dictionary (Name, Description, IsStatic, LastUpdDt, LastUpdUS) 
values ('Material', N'Матеріали', 0, @LastUpdDt, @LastUpdUs)

/* ========================= NATIONALITY ===================================*/
insert into SYS_Dictionary (Name, Description, IsStatic, LastUpdDt, LastUpdUS) 
values ('Nationality', N'Національності', 0, @LastUpdDt, @LastUpdUs)

/* ========================= PASSAUTHORITY =================================*/
insert into SYS_Dictionary (Name, Description, IsStatic, LastUpdDt, LastUpdUS) 
values ('PassAuthority', N'Орган, який видав документ', 0, @LastUpdDt, @LastUpdUs)

/* ========================= PENSION TYPE ==================================*/
insert into SYS_Dictionary (Name, Description, IsStatic, LastUpdDt, LastUpdUS) 
values ('PensionType', N'Види пенсій', 0, @LastUpdDt, @LastUpdUs)

/* ========================= POSITION ======================================*/
insert into SYS_Dictionary (Name, Description, IsStatic, LastUpdDt, LastUpdUS) 
values ('Position', N'Посади', 0, @LastUpdDt, @LastUpdUs)

/* ========================= REGION ========================================*/
insert into SYS_Dictionary (Name, Description, IsStatic, LastUpdDt, LastUpdUS) 
values ('Region', N'Області', 0, @LastUpdDt, @LastUpdUs)

/* ========================= STREET ========================================*/
insert into SYS_Dictionary (Name, Description, IsStatic, LastUpdDt, LastUpdUS) 
values ('Street', N'Вулиці', 0, @LastUpdDt, @LastUpdUs)

/* ========================= STREET TYPE ===================================*/
insert into SYS_Dictionary (Name, Description, IsStatic, LastUpdDt, LastUpdUS) 
values ('StreetType', N'Типи вулиць', 1, @LastUpdDt, @LastUpdUs)

/* ========================= PERSON ===================================*/
insert into SYS_Dictionary (Name, Description, IsStatic, LastUpdDt, LastUpdUS) 
values ('Person', N'Контрагенти', 0, @LastUpdDt, @LastUpdUs)

/* ========================= INSTITUTION ===================================*/
insert into SYS_Dictionary (Name, Description, IsStatic, LastUpdDt, LastUpdUS) 
values ('Institution', N'Навчальні заклади', 0, @LastUpdDt, @LastUpdUs)

/* ========================= SPECIALITIES ===================================*/
insert into SYS_Dictionary (Name, Description, IsStatic, LastUpdDt, LastUpdUS) 
values ('Speciality', N'Спеціальності', 0, @LastUpdDt, @LastUpdUs)

/* ========================= EDUCATIONDEGREE ===================================*/
insert into SYS_Dictionary (Name, Description, IsStatic, LastUpdDt, LastUpdUS) 
values ('EducationDegree', N'Рівні освіти', 0, @LastUpdDt, @LastUpdUs)

/* ========================= ACTIVITYTYPES ===================================*/
insert into SYS_Dictionary (Name, Description, IsStatic, LastUpdDt, LastUpdUS) 
values ('ActivityType', N'Види діяльності', 0, @LastUpdDt, @LastUpdUs)

/* ========================= COMPANIES ===================================*/
insert into SYS_Dictionary (Name, Description, IsStatic, LastUpdDt, LastUpdUS) 
values ('Company', N'Компанії', 0, @LastUpdDt, @LastUpdUs)