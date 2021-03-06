﻿using System;
using BusinessEntities.BaseBusinessEntities;
using BusinessEntities.Dictionaries;

namespace BusinessEntities
{
	public class EmploymentEntity : BaseBusinessEntity
	{
		public int PersonId { get; set; }
		public int? ActivityTypesId { get; set; }
		public int? CompanyId { get; set; }
		public int? PositionId { get; set; }
		public DateTime? DateStart { get; set; }
		public DateTime? DateEnd { get; set; }
		public bool IsCurrent { get; set; }
		public string Description { get; set; }

		public PersonEntity Person { get; set; }
		public ActivityTypeEntity ActivityType { get; set; }
		public CompanyEntity Company { get; set; }
		public PositionEntity Position { get; set; }
	}
}
