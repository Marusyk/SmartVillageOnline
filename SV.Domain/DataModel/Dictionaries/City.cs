using System.Collections.Generic;
using System.Runtime.Serialization;
using DataModel.Abstract;

namespace DataModel.Dictionaries
{
	public class City : BaseDictionary
	{
		public int CityTypeId { get; set; }
		public int? DistrictId { get; set; }
		public int RegionId { get; set; }

		//FK
		public virtual CityType CityType { get; set; }
		public virtual District District { get; set; }
		public virtual Region Region { get; set; }
		
		//Navigation
		[IgnoreDataMember]
		public virtual ICollection<Address> Addresses { get; set; }
		[IgnoreDataMember]
		public virtual ICollection<Institution> Institution { get; set; }
	}
}
