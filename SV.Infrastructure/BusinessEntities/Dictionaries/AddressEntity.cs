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

		public CityEntity City { get; set; }
		public StreetEntity Street { get; set; }

		public ICollection<HouseEntity> Houses { get; set; }
		public ICollection<PersonEntity> PersonBirthAddress { get; set; }
		public ICollection<PersonEntity> PersonLiveAddress { get; set; }
		public ICollection<CouncilEntity> Councils { get; set; }
		public ICollection<CompanyEntity> Companies { get; set; }
	}
}
