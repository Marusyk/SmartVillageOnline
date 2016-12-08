using System.Collections.Generic;
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
		public virtual ICollection<Address> Addresses { get; set; }
		public virtual ICollection<ActivityType> ActivityTypes { get; set; }
		public virtual ICollection<Animal> Animals { get; set; }
		public virtual ICollection<Company> Companies { get; set; }
		public virtual ICollection<DocumentType> DocumentTypes { get; set; }
		public virtual ICollection<House> Houses { get; set; }
		public virtual ICollection<Catalog> Catalogs { get; set; }
		public virtual ICollection<Document> Documents { get; set; }
		public virtual ICollection<Institution> Institutions { get; set; }
		public virtual ICollection<Material> Materials { get; set; }
		public virtual ICollection<PassAuthority> PassAuthorities { get; set; }
		public virtual ICollection<Person> Persons { get; set; }
		public virtual ICollection<Position> Positions { get; set; }
		public virtual ICollection<Speciality> Specialities { get; set; }
		public virtual ICollection<Street> Streets { get; set; }
	}
}
