using System.Collections.Generic;
using BusinessEntities.BaseBusinessEntities;

namespace DataModel.Dictionaries
{
	public class DistrictEntity : BaseDictionaryEntity
	{
		public int RegionId { get; set; }

		public virtual RegionEntity Region { get; set; }

		public virtual ICollection<CityEntity> Cities { get; set; }
	}
}
