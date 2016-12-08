using System.Collections.Generic;
using DataModel.Abstract;

namespace DataModel.Dictionaries
{
	public class Region : BaseDictionary
	{
		public int CountryId { get; set; }

		//FK
		public virtual Country Country { get; set; }

		//Navigation
		public virtual ICollection<District> Districts { get; set; }
		public virtual ICollection<City> Cities { get; set; }
	}
}
