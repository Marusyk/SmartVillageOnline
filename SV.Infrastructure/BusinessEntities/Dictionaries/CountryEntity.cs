using System.Collections.Generic;
using BusinessEntities.BaseBusinessEntities;

namespace BusinessEntities.Dictionaries
{
	public class CountryEntity : BaseDictionaryEntity
	{
		public virtual ICollection<RegionEntity> Regions { get; set; }
		public virtual ICollection<PersonEntity> Persons { get; set; }
	}
}
