using System.Collections.Generic;
using System.Runtime.Serialization;
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


		//FK
		public virtual City City { get; set; }
		public virtual Street Street { get; set; }

		//Navigation
		[IgnoreDataMember]
		public virtual ICollection<House> Houses { get; set; }
		[IgnoreDataMember]
		public virtual ICollection<Person> PersonBirthAddress { get; set; }
		[IgnoreDataMember]
		public virtual ICollection<Person> PersonLiveAddress { get; set; }
	}
}
