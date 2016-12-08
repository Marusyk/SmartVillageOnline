using BusinessEntities.BaseBusinessEntities;
using System.Collections.Generic;

namespace BusinessEntities.Dictionaries
{
	public class FamilyRelationsEntity : BaseDictionaryEntity
	{
		public ICollection<PeopleEntity> Peoples { get; set; }
	}
}
