using System.Collections.Generic;
using System.Runtime.Serialization;
using DataModel.Abstract;

namespace DataModel.Dictionaries
{
	public class District : BaseDictionary
	{
		public int RegionId { get; set; }

		//FK
		public virtual Region Region { get; set; }

		//Navigation
		[IgnoreDataMember]
		public virtual ICollection<City> Cities { get; set; }
	}
}
