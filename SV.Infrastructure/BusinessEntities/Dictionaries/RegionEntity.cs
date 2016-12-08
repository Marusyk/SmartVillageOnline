using System.Collections.Generic;
using BusinessEntities.BaseBusinessEntities;

namespace BusinessEntities.Dictionaries
{
	public class RegionEntity : BaseDictionaryEntity
	{
		public int CountryId { get; set; }

		public CountryEntity Country { get; set; }

		public ICollection<DistrictEntity> Districts { get; set; }
		public ICollection<CityEntity> Cities { get; set; }
	}
}
