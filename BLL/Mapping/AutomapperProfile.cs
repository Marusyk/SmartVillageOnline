using AutoMapper;
using BusinessEntities;
using BusinessEntities.Dictionaries;
using BusinessEntities.SystemEntities;
using DataModel;
using DataModel.Dictionaries;
using DataModel.SystemEntities;

namespace BLL.Mapping
{
	public class AutomapperProfile : Profile
	{
		public AutomapperProfile()
		{
			// from entity to business entity
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
			CreateMap<StreetType, StreetTypeEntity>();
			CreateMap<Catalog, CatalogEntity>();
			CreateMap<Document, DocumentEntity>();
			CreateMap<Education, EducationEntity>();
			CreateMap<Employment, EmploymentEntity>();
			CreateMap<House, HouseEntity>();
			CreateMap<People, PeopleEntity>();
			CreateMap<PersonDocument, PersonDocumentEntity>();
			CreateMap<SYS_Dictionary, SYS_DictionaryEntity>();

			// from business entity to entity
			CreateMap<AnimalEntity, Animal>();
			CreateMap<CouncilEntity, Council>();
			CreateMap<ActivityTypeEntity, ActivityType>();
			CreateMap<AddressEntity, Address>();
			CreateMap<CityEntity, City>();
			CreateMap<CityTypeEntity, CityType>();
			CreateMap<CompanyEntity, Company>();
			CreateMap<CountryEntity, Country>();
			CreateMap<DistrictEntity, District>();
			CreateMap<DocumentTypeEntity, DocumentType>();
			CreateMap<EducationDegreeEntity, EducationDegree>();
			CreateMap<FamilyRelationsEntity, FamilyRelations>();
			CreateMap<FamilyStatusEntity, FamilyStatus>();
			CreateMap<InstitutionEntity, Institution>();
			CreateMap<MaterialEntity, Material>();
			CreateMap<NationalityEntity, Nationality>();
			CreateMap<PassAuthorityEntity, PassAuthority>();
			CreateMap<PensionTypeEntity, PensionType>();
			CreateMap<PersonEntity, Person>();
			CreateMap<PositionEntity, Position>();
			CreateMap<RegionEntity, Region>();
			CreateMap<SpecialityEntity, Speciality>();
			CreateMap<StreetEntity, Street>();
			CreateMap<StreetTypeEntity, StreetType>();
			CreateMap<CatalogEntity, Catalog>();
			CreateMap<DocumentEntity, Document>();
			CreateMap<EducationEntity, Education>();
			CreateMap<EmploymentEntity, Employment>();
			CreateMap<HouseEntity, House>();
			CreateMap<PeopleEntity, People>();
			CreateMap<PersonDocumentEntity, PersonDocument>();
			CreateMap<SYS_DictionaryEntity, SYS_Dictionary>();
		}
	}
}
