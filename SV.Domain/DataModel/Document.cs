using System.Collections.Generic;
using DataModel.Abstract;
using DataModel.Dictionaries;

namespace DataModel
{
	public class Document : BaseDictionary
	{
		public int? DocumentTypeId { get; set; }
		public int? PassAuthorityId { get; set; }
		public string Number { get; set; }
		public string Code { get; set; }
		public bool State { get; set; }
		public int CouncilId { get; set; }


		//FK
		public virtual DocumentType DocumentType { get; set; }
		public virtual PassAuthority PassAuthority { get; set; }
		public virtual Council Council { get; set; }


		//Navigation
		public virtual ICollection<Education> Educations { get; set; }
		public virtual ICollection<PersonDocument> PersonDocuments { get; set; }
	}
}
