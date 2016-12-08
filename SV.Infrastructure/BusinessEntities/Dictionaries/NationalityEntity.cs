using System.Collections.Generic;
using BusinessEntities.BaseBusinessEntities;

namespace BusinessEntities.Dictionaries
{
	public class NationalityEntity : BaseDictionaryEntity
	{
		public ICollection<PersonEntity> Persons { get; set; }
	}
}
