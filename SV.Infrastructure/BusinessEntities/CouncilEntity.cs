using System.Collections.Generic;
using BusinessEntities.BaseBusinessEntities;
using DataModel.Dictionaries;

namespace DataModel
{
	public class CouncilEntity : BaseBusinessEntity
	{
		public int? ParentId { get; set; }
		public string Name { get; set; }
		public string ShortName { get; set; }
		public int? AddressId { get; set; }
		public string EDRPOUCode { get; set; }

		public virtual AddressEntity Address { get; set; }

		public virtual ICollection<AddressEntity> Addresses { get; set; }
		public virtual ICollection<ActivityTypeEntity> ActivityTypes { get; set; }
		public virtual ICollection<AnimalEntity> Animals { get; set; }
		public virtual ICollection<CompanyEntity> Companies { get; set; }
		public virtual ICollection<DocumentTypeEntity> DocumentTypes { get; set; }
		public virtual ICollection<HouseEntity> Houses { get; set; }
		public virtual ICollection<CatalogEntity> Catalogs { get; set; }
		public virtual ICollection<DocumentEntity> Documents { get; set; }
		public virtual ICollection<InstitutionEntity> Institutions { get; set; }
		public virtual ICollection<MaterialEntity> Materials { get; set; }
		public virtual ICollection<PassAuthorityEntity> PassAuthorities { get; set; }
		public virtual ICollection<PersonEntity> Persons { get; set; }
		public virtual ICollection<PositionEntity> Positions { get; set; }
		public virtual ICollection<SpecialityEntity> Specialities { get; set; }
		public virtual ICollection<StreetEntity> Streets { get; set; }
	}
}
