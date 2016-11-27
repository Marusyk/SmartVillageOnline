using System.Collections.Generic;
using BusinessEntities.Dictionaries;
using BusinessEntities.BaseBusinessEntities;

namespace BusinessEntities
{
	public class DocumentEntity : BaseDictionaryCouncilEntity
	{
		public int? DocumentTypeId { get; set; }
		public int? PassAuthorityId { get; set; }
		public string Number { get; set; }
		public string Code { get; set; }
		public bool State { get; set; }

		public virtual DocumentTypeEntity DocumentType { get; set; }
		public virtual PassAuthorityEntity PassAuthority { get; set; }

		public virtual ICollection<EducationEntity> Educations { get; set; }
		public virtual ICollection<PersonDocumentEntity> PersonDocuments { get; set; }
	}
}
