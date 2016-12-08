using AutoMapper;
using BusinessEntities;
using BusinessEntities.Dictionaries;
using DataModel;
using DataModel.Dictionaries;

namespace BLL.Mapping
{
	public class AutomapperProfile : Profile
	{
		public AutomapperProfile()
		{
			CreateMap<Animal, AnimalEntity>();
			CreateMap<Council, CouncilEntity>();
			CreateMap<ActivityType, ActivityTypeEntity>();
			CreateMap<Address, AddressEntity>();
			CreateMap<City, CityEntity>();
			CreateMap<CityType, CityTypeEntity>();
			CreateMap<Company, CompanyEntity>();
			CreateMap<Country, CountryEntity>();
			CreateMap<District, DistrictEntity>();
			CreateMap<DocumentType, DocumentTypeEntity>();
			CreateMap<EducationDegree, EducationDegreeEntity>();
			CreateMap<FamilyRelations, FamilyRelationsEntity>();
			CreateMap<FamilyStatus, FamilyStatusEntity>();
			CreateMap<Institution, InstitutionEntity>();
			CreateMap<Material, MaterialEntity>();
			CreateMap<Nationality, NationalityEntity>();
			CreateMap<PassAuthority, PassAuthorityEntity>();
			CreateMap<PensionType, PensionTypeEntity>();
			CreateMap<Person, PersonEntity>();
			CreateMap<Position, PositionEntity>();
			CreateMap<Region, RegionEntity>();
			CreateMap<Speciality, SpecialityEntity>();
			CreateMap<Street, StreetEntity>();
			CreateMap<StreetType, StreetType>();
			CreateMap<Catalog, CatalogEntity>();
			CreateMap<Document, DocumentEntity>();
			CreateMap<Education, EducationEntity>();
			CreateMap<Employment, EmploymentEntity>();
			CreateMap<House, HouseEntity>();
			CreateMap<People, PeopleEntity>();
			CreateMap<PersonDocument, PersonDocumentEntity>();
		}
	}
}
