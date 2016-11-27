﻿using System.Collections.Generic;
using BusinessEntities.BaseBusinessEntities;

namespace DataModel.Dictionaries
{
	public class CountryEntity : BaseDictionaryEntity
	{
		public virtual ICollection<RegionEntity> Regions { get; set; }
		public virtual ICollection<PersonEntity> Persons { get; set; }
	}
}
