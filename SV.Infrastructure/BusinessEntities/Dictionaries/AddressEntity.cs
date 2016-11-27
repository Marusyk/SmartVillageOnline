using System.Collections.Generic;
using BusinessEntities.BaseBusinessEntities;

namespace BusinessEntities.Dictionaries
{
	public class AddressEntity : BaseBusinessCouncilEntity
	{
		public int CityId { get; set; }
		public int? StreetId { get; set; }
		public int? PostCode { get; set; }
		public string BuildNr { get; set; }
		public string FlatNr { get; set; }

		public virtual CityEntity City { get; set; }
		public virtual StreetEntity Street { get; set; }

		public virtual ICollection<HouseEntity> Houses { get; set; }
		public virtual ICollection<PersonEntity> PersonBirthAddress { get; set; }
		public virtual ICollection<PersonEntity> PersonLiveAddress { get; set; }
		public virtual ICollection<CouncilEntity> Councils { get; set; }
		public virtual ICollection<CompanyEntity> Companies { get; set; }
	}
}
