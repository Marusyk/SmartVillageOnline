using System.Collections.Generic;
using DataModel.Abstract;

namespace DataModel.Dictionaries
{
	public class DocumentType : BaseDictionary
	{
		public string Code { get; set; }
		public int CouncilId { get; set; }

		//FK
		public virtual Council Council { get; set; }

		//Navigation
		public virtual ICollection<Document> Documents { get; set; }
	}
}
