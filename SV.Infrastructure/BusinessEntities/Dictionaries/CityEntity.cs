using System.Collections.Generic;
using BusinessEntities.BaseBusinessEntities;

namespace BusinessEntities.Dictionaries
{
	public class CityEntity : BaseDictionaryEntity
	{
		public int CityTypeId { get; set; }
		public int? DistrictId { get; set; }
		public int RegionId { get; set; }

		public CityTypeEntity CityType { get; set; }
		public DistrictEntity District { get; set; }
		public RegionEntity Region { get; set; }
			   
		public ICollection<AddressEntity> Addresses { get; set; }
		public ICollection<InstitutionEntity> Institution { get; set; }
	}
}
