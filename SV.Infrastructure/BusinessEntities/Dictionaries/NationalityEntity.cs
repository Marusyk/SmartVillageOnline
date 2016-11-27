using System.Collections.Generic;
using BusinessEntities.BaseBusinessEntities;

namespace BusinessEntities.Dictionaries
{
	public class NationalityEntity : BaseDictionaryEntity
	{
		public virtual ICollection<PersonEntity> Persons { get; set; }
	}
}
