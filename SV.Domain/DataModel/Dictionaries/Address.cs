using System.Collections.Generic;
using DataModel.Abstract;

namespace DataModel.Dictionaries
{
	public class Address : BaseEntity
	{
		public int CityId { get; set; }
		public int? StreetId { get; set; }
		public int? PostCode { get; set; }
		public string BuildNr { get; set; }
		public string FlatNr { get; set; }
		public int CouncilId { get; set; }

		//FK
		public virtual City City { get; set; }
		public virtual Street Street { get; set; }
		public virtual Council Council { get; set; }

		//Navigation
		public virtual ICollection<House> Houses { get; set; }
		public virtual ICollection<Person> PersonBirthAddress { get; set; }
		public virtual ICollection<Person> PersonLiveAddress { get; set; }
		public virtual ICollection<Council> Councils { get; set; }
		public virtual ICollection<Company> Companies { get; set; }
	}
}
