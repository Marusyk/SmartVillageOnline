using System.Collections.Generic;
using BusinessEntities.BaseBusinessEntities;

namespace DataModel.Dictionaries
{
	public class NationalityEntity : BaseDictionaryEntity
	{
		public virtual ICollection<PersonEntity> Persons { get; set; }
	}
}
