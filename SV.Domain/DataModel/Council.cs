using System.Collections.Generic;
using System.Runtime.Serialization;
using DataModel.Abstract;
using DataModel.Dictionaries;

namespace DataModel
{
	public class Council : BaseEntity
	{
		public int? ParentId { get; set; }
		public string Name { get; set; }
		public string ShortName { get; set; }
		public int? AddressId { get; set; }
		public string EDRPOUCode { get; set; }

		//FK
		public virtual Address Address { get; set; }

		//Navigation
		[IgnoreDataMember]
		public virtual ICollection<Address> Addresses { get; set; }
		[IgnoreDataMember]
		public virtual ICollection<ActivityType> ActivityTypes { get; set; }
		[IgnoreDataMember]
		public virtual ICollection<Animal> Animals { get; set; }
		[IgnoreDataMember]
		public virtual ICollection<Company> Companys { get; set; }
		[IgnoreDataMember]
		public virtual ICollection<DocumentType> DocumentTypes { get; set; }
		[IgnoreDataMember]
		public virtual ICollection<House> Houses { get; set; }
		[IgnoreDataMember]
		public virtual ICollection<Catalog> Catalogs { get; set; }
		[IgnoreDataMember]
		public virtual ICollection<Document> Documents { get; set; }
		[IgnoreDataMember]
		public virtual ICollection<Institution> Institutions { get; set; }
		[IgnoreDataMember]
		public virtual ICollection<Material> Materials { get; set; }
		[IgnoreDataMember]
		public virtual ICollection<PassAuthority> PassAuthorities { get; set; }
		[IgnoreDataMember]
		public virtual ICollection<Person> Persons { get; set; }
		[IgnoreDataMember]
		public virtual ICollection<Position> Positions { get; set; }
		[IgnoreDataMember]
		public virtual ICollection<Speciality> Specialities { get; set; }
		[IgnoreDataMember]
		public virtual ICollection<Street> Streets { get; set; }
	}
}
