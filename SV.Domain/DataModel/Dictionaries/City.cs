using System.Collections.Generic;
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
		public virtual ICollection<Address> Addresses { get; set; }
		public virtual ICollection<Institution> Institution { get; set; }
	}
}
