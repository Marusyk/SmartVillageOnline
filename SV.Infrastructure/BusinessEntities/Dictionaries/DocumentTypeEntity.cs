using System.Collections.Generic;
using BusinessEntities.BaseBusinessEntities;

namespace BusinessEntities.Dictionaries
{
	public class DocumentTypeEntity : BaseDictionaryCouncilEntity
	{
		public string Code { get; set; }

		public ICollection<DocumentEntity> Documents { get; set; }
	}
}
