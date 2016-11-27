using BusinessEntities.BaseBusinessEntities;
using System.Collections.Generic;

namespace DataModel.Dictionaries
{
	public class StreetTypeEntity : BaseDictionaryEntity
	{
		public virtual ICollection<StreetEntity> Streets { get; set; }
	}
}
