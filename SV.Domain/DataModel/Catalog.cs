using System.Collections.Generic;
using DataModel.Abstract;
using DataModel.Dictionaries;

namespace DataModel
{
	public class Catalog : BaseDictionary
	{
		public int? ParentId { get; set; }
		public int CouncilId { get; set; }

		//FK
		public virtual Council Council { get; set; }

		//Navigation
		public virtual ICollection<Person> Persons { get; set; }
	}
}
