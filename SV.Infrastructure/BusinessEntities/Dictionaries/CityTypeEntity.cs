using BusinessEntities.BaseBusinessEntities;
using System.Collections.Generic;

namespace BusinessEntities.Dictionaries
{
	public class CityTypeEntity : BaseDictionaryEntity
	{
		public virtual ICollection<CityEntity> Cities { get; set; }
	}
}
