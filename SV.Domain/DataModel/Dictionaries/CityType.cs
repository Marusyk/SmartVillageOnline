using System.Collections.Generic;
using System.Runtime.Serialization;
using DataModel.Abstract;

namespace DataModel.Dictionaries
{
	public class CityType : BaseDictionary
	{
		//Navigation
		[IgnoreDataMember]
		public virtual ICollection<City> Cities { get; set; }
	}
}
