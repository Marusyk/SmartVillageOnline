﻿using System.Collections.Generic;
using BusinessEntities.BaseBusinessEntities;
using DataModel.Dictionaries;

namespace DataModel
{
	public class CatalogEntity : BaseDictionaryCouncilEntity
	{
		public int? ParentId { get; set; }

		public virtual ICollection<PersonEntity> Persons { get; set; }
	}
}