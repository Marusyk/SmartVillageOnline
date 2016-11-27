using System.Collections.Generic;
using System.Runtime.Serialization;
using DataModel.Abstract;

namespace DataModel.Dictionaries
{
	public class Street : BaseDictionaryCouncil
	{
		public int StreetTypeId { get; set; }

		//FK
		public virtual StreetType StreetType { get; set; }

		//Navigation
		[IgnoreDataMember]
		public virtual ICollection<Address> Addresses { get; set; }
	}
}
