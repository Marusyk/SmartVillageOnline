using System.Collections.Generic;
using System.Runtime.Serialization;
using DataModel.Abstract;

namespace DataModel.Dictionaries
{
	public class Nationality : BaseDictionary
	{
		//Navigation
		[IgnoreDataMember]
		public virtual ICollection<Person> Persons { get; set; }
	}
}
