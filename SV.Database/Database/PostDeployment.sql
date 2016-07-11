/*
Post-Deployment Script Template							
--------------------------------------------------------------------------------------
 This file contains SQL statements that will be appended to the build script.		
 Use SQLCMD syntax to include a file in the post-deployment script.			
 Example:      :r .\myfile.sql								
 Use SQLCMD syntax to reference a variable in the post-deployment script.		
 Example:      :setvar TableName MyTable							
               SELECT * FROM [$(TableName)]					
--------------------------------------------------------------------------------------
*/
:r .\PostDeployment\EntityType.sql
GO
:r .\PostDeployment\SYS_Dictionary.sql
GO
:r .\PostDeployment\Animal.sql
GO
:r .\PostDeployment\Catalog.sql
GO
:r .\PostDeployment\DocumentType.sql
GO
:r .\PostDeployment\FamilyRelations.sql
GO
:r .\PostDeployment\FamilyStatus.sql
GO
:r .\PostDeployment\Material.sql
GO
:r .\PostDeployment\Nationality.sql
GO
:r .\PostDeployment\Country.sql
GO
:r .\PostDeployment\Region.sql
GO
:r .\PostDeployment\District.sql
GO
:r .\PostDeployment\CityType.sql
GO
:r .\PostDeployment\StreetType.sql
GO
:r .\PostDeployment\City.sql
GO
:r .\PostDeployment\Street.sql
GO
:r .\PostDeployment\Address.sql
GO
:r .\PostDeployment\House.sql
GO
:r .\PostDeployment\Person.sql
GO
:r .\PostDeployment\People.sql
GO