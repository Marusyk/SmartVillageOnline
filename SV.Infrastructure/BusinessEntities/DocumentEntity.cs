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

		public DocumentTypeEntity DocumentType { get; set; }
		public PassAuthorityEntity PassAuthority { get; set; }

		public ICollection<EducationEntity> Educations { get; set; }
		public ICollection<PersonDocumentEntity> PersonDocuments { get; set; }
	}
}
