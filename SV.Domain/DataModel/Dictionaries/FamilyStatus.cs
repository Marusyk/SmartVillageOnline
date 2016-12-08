using System.Collections.Generic;
using DataModel.Abstract;

namespace DataModel.Dictionaries
{
	public class FamilyStatus : BaseDictionary
	{
		//Navigation
		public virtual ICollection<Person> Persons { get; set; }
	}
}
