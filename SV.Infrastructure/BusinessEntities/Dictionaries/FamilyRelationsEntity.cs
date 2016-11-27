using BusinessEntities.BaseBusinessEntities;
using System.Collections.Generic;

namespace BusinessEntities.Dictionaries
{
	public class FamilyRelationsEntity : BaseDictionaryEntity
	{
		public virtual ICollection<PeopleEntity> Peoples { get; set; }
	}
}
