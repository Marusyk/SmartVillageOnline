using BusinessEntities.BaseBusinessEntities;
using System.Collections.Generic;

namespace BusinessEntities.Dictionaries
{
	public class CityTypeEntity : BaseDictionaryEntity
	{
		public ICollection<CityEntity> Cities { get; set; }
	}
}
