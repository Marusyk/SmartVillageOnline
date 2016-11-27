using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using DataModel.Abstract;
using DataModel.Dictionaries;

namespace DataModel
{
	public class Document : BaseDictionaryCouncil
	{
		public int? DocumentTypeId { get; set; }
		public int? PassAuthorityId { get; set; }
		public string Number { get; set; }
		public string Code { get; set; }
		public bool State { get; set; }

		//FK
		public virtual DocumentType DocumentType { get; set; }
		public virtual PassAuthority PassAuthority { get; set; }

		//Navigation
		[IgnoreDataMember]
		public virtual ICollection<Education> Educations { get; set; }
		[IgnoreDataMember]
		public virtual ICollection<PersonDocument> PersonDocuments { get; set; }
	}
}
