using System.Collections.Generic;
using System.Runtime.Serialization;
using BusinessEntities.BaseBusinessEntities;

namespace BusinessEntities.Dictionaries {
	public class RegionEntity : BaseDictionaryEntity
	{
		public int CountryId { get; set; }
		public virtual CountryEntity Country { get; set; }
		//Navigation
		[IgnoreDataMember]
		public virtual ICollection<DistrictEntity> Districts { get; set; }
	}
}
