using System.Collections.Generic;
using System.Runtime.Serialization;
using DataModel.Abstract;
using DataModel.Dictionaries;

namespace DataModel
{
	public class Catalog : BaseDictionary
	{
		public int? ParentId { get; set; }
		public int? ModuleId { get; set; }

		//Navigation
		[IgnoreDataMember]
		public virtual ICollection<Person> Persons { get; set; }
	}
}
