﻿using System.Collections.Generic;
using BusinessEntities.BaseBusinessEntities;

namespace DataModel.Dictionaries
{
	public class StreetEntity : BaseDictionaryCouncilEntity
	{
		public int StreetTypeId { get; set; }

		public virtual StreetTypeEntity StreetType { get; set; }

		public virtual ICollection<AddressEntity> Addresses { get; set; }
	}
}
