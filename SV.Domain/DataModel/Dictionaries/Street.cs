using System.Collections.Generic;
using DataModel.Abstract;

namespace DataModel.Dictionaries
{
	public class Street : BaseDictionary
	{
		public int StreetTypeId { get; set; }
		public int CouncilId { get; set; }


		//FK
		public virtual StreetType StreetType { get; set; }
		public virtual Council Council { get; set; }


		//Navigation
		public virtual ICollection<Address> Addresses { get; set; }
	}
}
