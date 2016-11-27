using System.Collections.Generic;
using BusinessEntities.BaseBusinessEntities;

namespace DataModel.Dictionaries
{
	public class PassAuthorityEntity : BaseDictionaryCouncilEntity
	{
		public virtual ICollection<PersonEntity> Persons { get; set; }
		public virtual ICollection<DocumentEntity> Documents { get; set; }
	}
}
