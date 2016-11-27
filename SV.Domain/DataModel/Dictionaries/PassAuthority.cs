using System.Collections.Generic;
using System.Runtime.Serialization;
using DataModel.Abstract;

namespace DataModel.Dictionaries
{
	public class PassAuthority : BaseDictionaryCouncil
	{
		//Navigation
		[IgnoreDataMember]
		public virtual ICollection<Person> Persons { get; set; }
		[IgnoreDataMember]
		public virtual ICollection<Document> Documents { get; set; }
	}
}
