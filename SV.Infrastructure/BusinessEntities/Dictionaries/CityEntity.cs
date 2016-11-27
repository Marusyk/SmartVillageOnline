using System.Collections.Generic;
using BusinessEntities.BaseBusinessEntities;

namespace BusinessEntities.Dictionaries
{
	public class CityEntity : BaseDictionaryEntity
	{
		public int CityTypeId { get; set; }
		public int? DistrictId { get; set; }
		public int RegionId { get; set; }

		public virtual CityTypeEntity CityType { get; set; }
		public virtual DistrictEntity District { get; set; }
		public virtual RegionEntity Region { get; set; }
		
		public virtual ICollection<AddressEntity> Addresses { get; set; }
		public virtual ICollection<InstitutionEntity> Institution { get; set; }
	}
}
