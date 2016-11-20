using System.Collections.Generic;
using System.Runtime.Serialization;
using DataModel.Abstract;

namespace DataModel.Dictionaries
{
	public class Country : BaseDictionary
	{
		//Navigation
		[IgnoreDataMember]
		public virtual ICollection<Region> Regions { get; set; }
		[IgnoreDataMember]
		public virtual ICollection<Person> Persons { get; set; }
	}
}
