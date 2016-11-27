﻿using System.Collections.Generic;
using BusinessEntities.BaseBusinessEntities;

namespace DataModel.Dictionaries
{
	public class CompanyEntity : BaseDictionaryCouncilEntity
	{
		public int? AddressId { get; set; }

		public AddressEntity Address { get; set; }

		public virtual ICollection<EmploymentEntity> Employments { get; set; }
	}
}