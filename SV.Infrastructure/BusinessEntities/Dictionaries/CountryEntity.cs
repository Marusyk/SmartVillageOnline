using System.Collections.Generic;
using BusinessEntities.BaseBusinessEntities;
using System.Runtime.Serialization;

namespace BusinessEntities.Dictionaries {
	public class CountryEntity : BaseDictionaryEntity
	{
		[IgnoreDataMember]
		public virtual ICollection<RegionEntity> Regions { get; set; }
	}
}
