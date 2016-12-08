using System.Collections.Generic;
using BusinessEntities.BaseBusinessEntities;
using BusinessEntities.Dictionaries;

namespace BusinessEntities
{
	public class CouncilEntity : BaseBusinessEntity
	{
		public int? ParentId { get; set; }
		public string Name { get; set; }
		public string ShortName { get; set; }
		public int? AddressId { get; set; }
		public string EDRPOUCode { get; set; }

		public AddressEntity Address { get; set; }

		public ICollection<AddressEntity> Addresses { get; set; }
		public ICollection<ActivityTypeEntity> ActivityTypes { get; set; }
		public ICollection<AnimalEntity> Animals { get; set; }
		public ICollection<CompanyEntity> Companies { get; set; }
		public ICollection<DocumentTypeEntity> DocumentTypes { get; set; }
		public ICollection<HouseEntity> Houses { get; set; }
		public ICollection<CatalogEntity> Catalogs { get; set; }
		public ICollection<DocumentEntity> Documents { get; set; }
		public ICollection<InstitutionEntity> Institutions { get; set; }
		public ICollection<MaterialEntity> Materials { get; set; }
		public ICollection<PassAuthorityEntity> PassAuthorities { get; set; }
		public ICollection<PersonEntity> Persons { get; set; }
		public ICollection<PositionEntity> Positions { get; set; }
		public ICollection<SpecialityEntity> Specialities { get; set; }
		public ICollection<StreetEntity> Streets { get; set; }
	}
}
