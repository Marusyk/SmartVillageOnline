using System.Collections.Generic;
using BusinessEntities.BaseBusinessEntities;

namespace DataModel.Dictionaries
{
	public class RegionEntity : BaseDictionaryEntity
	{
		public int CountryId { get; set; }

		public virtual CountryEntity Country { get; set; }

		public virtual ICollection<DistrictEntity> Districts { get; set; }
		public virtual ICollection<CityEntity> Cities { get; set; }
	}
}
