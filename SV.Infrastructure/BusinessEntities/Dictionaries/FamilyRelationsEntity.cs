using BusinessEntities.BaseBusinessEntities;
using System.Collections.Generic;

namespace DataModel.Dictionaries
{
	public class FamilyRelationsEntity : BaseDictionaryEntity
	{
		public virtual ICollection<PeopleEntity> Peoples { get; set; }
	}
}
