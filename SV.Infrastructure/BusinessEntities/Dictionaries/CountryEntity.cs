using System.Collections.Generic;
using BusinessEntities.BaseBusinessEntities;

namespace BusinessEntities.Dictionaries
{
	public class CountryEntity : BaseDictionaryEntity
	{
		public ICollection<RegionEntity> Regions { get; set; }
		public ICollection<PersonEntity> Persons { get; set; }
	}
}
