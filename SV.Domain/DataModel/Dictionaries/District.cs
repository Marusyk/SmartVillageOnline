using System.Collections.Generic;
using DataModel.Abstract;

namespace DataModel.Dictionaries
{
	public class District : BaseDictionary
	{
		public int RegionId { get; set; }

		//FK
		public virtual Region Region { get; set; }

		//Navigation
		public virtual ICollection<City> Cities { get; set; }
	}
}
