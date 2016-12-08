using System.Collections.Generic;
using BusinessEntities.BaseBusinessEntities;

namespace BusinessEntities.Dictionaries
{
	public class DistrictEntity : BaseDictionaryEntity
	{
		public int RegionId { get; set; }

		public RegionEntity Region { get; set; }

		public ICollection<CityEntity> Cities { get; set; }
	}
}
