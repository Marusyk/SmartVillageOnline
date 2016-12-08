using System.Collections.Generic;
using DataModel.Abstract;

namespace DataModel.Dictionaries
{
	public class PassAuthority : BaseDictionary
	{
		public int CouncilId { get; set; }

		//FK
		public virtual Council Council { get; set; }

		//Navigation
		public virtual ICollection<Person> Persons { get; set; }
		public virtual ICollection<Document> Documents { get; set; }
	}
}
