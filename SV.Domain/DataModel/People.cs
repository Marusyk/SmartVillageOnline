using System;
using DataModel.Abstract;
using DataModel.Dictionaries;

namespace DataModel
{
	public class People : BaseEntity
	{
		public int PersonId { get; set; }
		public int HouseId { get; set; }
		public int PeopleNumber { get; set; }
		public int? FamilyRelationId { get; set; }
		public DateTime? DateRegistration { get; set; }
		public bool IsMain { get; set; }

		//FK
		public virtual House Houses { get; set; }
		public virtual Person Persons { get; set; }
		public virtual FamilyRelations FamilyRelations { get; set; }
	}
}
