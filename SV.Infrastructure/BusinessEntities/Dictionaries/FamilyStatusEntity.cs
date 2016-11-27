using System.Collections.Generic;
using BusinessEntities.BaseBusinessEntities;

namespace BusinessEntities.Dictionaries
{
	public class FamilyStatusEntity : BaseDictionaryEntity
	{
		public virtual ICollection<PersonEntity> Persons { get; set; }
	}
}
