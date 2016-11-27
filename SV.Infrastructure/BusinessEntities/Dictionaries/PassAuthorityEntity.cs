using System.Collections.Generic;
using BusinessEntities.BaseBusinessEntities;

namespace BusinessEntities.Dictionaries
{
	public class PassAuthorityEntity : BaseDictionaryCouncilEntity
	{
		public virtual ICollection<PersonEntity> Persons { get; set; }
		public virtual ICollection<DocumentEntity> Documents { get; set; }
	}
}
