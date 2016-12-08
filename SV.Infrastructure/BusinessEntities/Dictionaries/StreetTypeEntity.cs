using BusinessEntities.BaseBusinessEntities;
using System.Collections.Generic;

namespace BusinessEntities.Dictionaries
{
	public class StreetTypeEntity : BaseDictionaryEntity
	{
		public ICollection<StreetEntity> Streets { get; set; }
	}
}
