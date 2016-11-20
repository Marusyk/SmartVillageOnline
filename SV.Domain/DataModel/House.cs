using System.Collections.Generic;
using System.Runtime.Serialization;
using DataModel.Abstract;
using DataModel.Dictionaries;

namespace DataModel
{
	public class House : BaseEntity
	{
		public string HouseNr { get; set; }
		public string KadastrNr { get; set; }
		public string BuildNr { get; set; }
		public int AddressId { get; set; }
		public string PhoneNr { get; set; }
		public string PhoneCode { get; set; }
		public string FaxNr { get; set; }
		public int? Year { get; set; }
		public string Code { get; set; }

		//FK
		public virtual Address Address { get; set; }

		//Navigation
		[IgnoreDataMember]
		public virtual ICollection<People> Peoples { get; set; }
	}
}
