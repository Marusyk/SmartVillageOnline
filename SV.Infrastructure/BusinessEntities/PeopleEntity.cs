﻿using System;
using BusinessEntities.BaseBusinessEntities;
using BusinessEntities.Dictionaries;

namespace BusinessEntities
{
	public class PeopleEntity : BaseBusinessEntity
	{
		public int PersonId { get; set; }
		public int HouseId { get; set; }
		public int PeopleNumber { get; set; }
		public int? FamilyRelationId { get; set; }
		public DateTime? DateRegistration { get; set; }
		public bool IsMain { get; set; }

		public HouseEntity Houses { get; set; }
		public PersonEntity Persons { get; set; }
		public FamilyRelationsEntity FamilyRelations { get; set; }
	}
}
