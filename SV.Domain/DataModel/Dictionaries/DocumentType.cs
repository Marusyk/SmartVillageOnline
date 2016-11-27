using System.Collections.Generic;
using System.Runtime.Serialization;
using DataModel.Abstract;

namespace DataModel.Dictionaries
{
	public class DocumentType : BaseDictionaryCouncil
	{
		public string Code { get; set; }

		//Navigation
		[IgnoreDataMember]
		public virtual ICollection<Document> Documents { get; set; }
	}
}
