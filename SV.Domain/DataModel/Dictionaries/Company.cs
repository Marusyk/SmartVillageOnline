using System.Collections.Generic;
using System.Runtime.Serialization;
using DataModel.Abstract;

namespace DataModel.Dictionaries
{
	public class Company : BaseDictionaryCouncil
	{
		public int? AddressId { get; set; }

		//FK
		public Address Address { get; set; }

		//Navigation
		[IgnoreDataMember]
		public virtual ICollection<Employment> Employments { get; set; }
	}
}
