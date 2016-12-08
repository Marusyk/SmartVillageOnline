using System.Collections.Generic;
using DataModel.Abstract;

namespace DataModel.Dictionaries
{
	public class CityType : BaseDictionary
	{
		//Navigation
		public virtual ICollection<City> Cities { get; set; }
	}
}
