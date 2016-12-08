using System.Collections.Generic;
using BusinessEntities.BaseBusinessEntities;

namespace BusinessEntities.Dictionaries
{
	public class StreetEntity : BaseDictionaryCouncilEntity
	{
		public int StreetTypeId { get; set; }

		public StreetTypeEntity StreetType { get; set; }

		public ICollection<AddressEntity> Addresses { get; set; }
	}
}
