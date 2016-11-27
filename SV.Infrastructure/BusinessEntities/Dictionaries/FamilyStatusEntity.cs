using System.Collections.Generic;
using BusinessEntities.BaseBusinessEntities;

namespace DataModel.Dictionaries
{
	public class FamilyStatusEntity : BaseDictionaryEntity
	{
		public virtual ICollection<PersonEntity> Persons { get; set; }
	}
}
