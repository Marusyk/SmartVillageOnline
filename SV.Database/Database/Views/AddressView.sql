/* (c) COPYRIGHT SMARTVILLAGE SOLUTIONS
#View=AddressView
#DateCreate=14.07.2015
#DateLastEdit=14.07.2014
#LastEditBy=rmarusyk
#Version=01
#History=
01 14.07.2015 RM Created.
#Description=
*/
CREATE VIEW [dbo].[AddressView]
AS
select ADR.Id AddressId
,      COU.Name Country
,      REG.Name Region
,      DST.Name District
,      CTT.Name CityType
,      CTY.Name City
,      STT.Name StreetType
,      STR.Name Street
,      ADR.BuildNr
,      ADR.FlatNr
,      ADR.PostCode
from   Address ADR
       inner join City CTY on ADR.CityId = CTY.Id
       inner join CityType CTT on CTY.CityTypeId = CTT.Id
       inner join Street STR on ADR.StreetId = STR.Id
       inner join StreetType STT on STR.StreetTypeId = STT.Id
       left  join District DST on CTY.DistrictId = DST.Id
       inner join Region REG on REG.Id = ISNULL(DST.RegionId, CTY.RegionId)
       inner join Country COU on REG.CountryId = COU.Id
