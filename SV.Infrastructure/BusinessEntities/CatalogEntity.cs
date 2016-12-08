using System.Collections.Generic;
using BusinessEntities.BaseBusinessEntities;
using BusinessEntities.Dictionaries;

namespace BusinessEntities
{
	public class CatalogEntity : BaseDictionaryCouncilEntity
	{
		public int? ParentId { get; set; }

		public ICollection<PersonEntity> Persons { get; set; }
	}
}
