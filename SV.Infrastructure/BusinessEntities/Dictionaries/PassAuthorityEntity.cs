using System.Collections.Generic;
using BusinessEntities.BaseBusinessEntities;

namespace BusinessEntities.Dictionaries
{
	public class PassAuthorityEntity : BaseDictionaryCouncilEntity
	{
		public ICollection<PersonEntity> Persons { get; set; }
		public ICollection<DocumentEntity> Documents { get; set; }
	}
}
