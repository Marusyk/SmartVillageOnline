using System.Collections.Generic;
using DataModel.Abstract;

namespace DataModel.Dictionaries
{
	public class Country : BaseDictionary
	{
		//Navigation
		public virtual ICollection<Region> Regions { get; set; }
		public virtual ICollection<Person> Persons { get; set; }
	}
}
