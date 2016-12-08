using System.Collections.Generic;
using DataModel.Abstract;

namespace DataModel.Dictionaries
{
	public class Company : BaseDictionary
	{
		public int? AddressId { get; set; }
		public int CouncilId { get; set; }


		//FK
		public Address Address { get; set; }
		public virtual Council Council { get; set; }


		//Navigation
		public virtual ICollection<Employment> Employments { get; set; }
	}
}
