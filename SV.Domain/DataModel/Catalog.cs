using System.Collections.Generic;
using System.Runtime.Serialization;
using DataModel.Abstract;
using DataModel.Dictionaries;

namespace DataModel
{
	public class Catalog : BaseDictionaryCouncil
	{
		public int? ParentId { get; set; }

		//Navigation
		[IgnoreDataMember]
		public virtual ICollection<Person> Persons { get; set; }
	}
}
