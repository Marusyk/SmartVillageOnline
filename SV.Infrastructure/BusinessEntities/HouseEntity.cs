using System.Collections.Generic;
using BusinessEntities.BaseBusinessEntities;
using DataModel.Dictionaries;

namespace DataModel
{
	public class HouseEntity : BaseBusinessCouncilEntity
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

		public virtual AddressEntity Address { get; set; }

		public virtual ICollection<PeopleEntity> Peoples { get; set; }
	}
}
