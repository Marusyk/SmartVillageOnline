using System.Collections.Generic;
using System.Runtime.Serialization;
using DataModel.Abstract;

namespace DataModel.Dictionaries
{
	public class Region : BaseDictionary
	{
		public int CountryId { get; set; }

		//FK
		public virtual Country Country { get; set; }

		//Navigation
		[IgnoreDataMember]
		public virtual ICollection<District> Districts { get; set; }
		[IgnoreDataMember]
		public virtual ICollection<City> Cities { get; set; }
	}
}
