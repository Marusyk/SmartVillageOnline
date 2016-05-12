/* (c) COPYRIGHT SMARTVILLAGE SOLUTIONS
#Procedure=usp_PeopleSetMain
#DateCreate=09.09.2015
#DateLastEdit=09.09.2014
#LastEditBy=rmarusyk
#Version=01
#History=
01 09.09.2015 RM Created [#16].
#Description=
*/
CREATE PROCEDURE [dbo].[usp_PeopleSetMain]
  @PeopleId    int
, @LastUpdUs   varchar(50) = 'SV'
AS
BEGIN
  declare @HouseId int
  
  select @HouseId = HouseId
  from   People
  where  Id = @PeopleId
  
  update PEO
  set    IsMain = 0
  from   People PEO
  where  HouseId = @HouseId
    and  IsMain = 1
  
  update PEO
  set    IsMain = 1
  ,      FamilyRelationId = NULL
  ,      LastUpdUs = @LastUpdUs
  ,      LastUpdDt = GETDATE()
  from   People PEO
  where  HouseId = @HouseId
    and  Id = @PeopleId
  
END -- End procedure usp_PeopleSetMain
