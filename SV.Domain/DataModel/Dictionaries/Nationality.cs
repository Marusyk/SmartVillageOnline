using System.Collections.Generic;
using DataModel.Abstract;

namespace DataModel.Dictionaries
{
	public class Nationality : BaseDictionary
	{
		//Navigation
		public virtual ICollection<Person> Persons { get; set; }
	}
}
