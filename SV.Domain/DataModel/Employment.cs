using System;
using DataModel.Abstract;
using DataModel.Dictionaries;

namespace DataModel
{
	public class Employment : BaseEntity
	{
		public int PersonId { get; set; }
		public int? ActivityTypesId { get; set; }
		public int? CompanyId { get; set; }
		public int? PositionId { get; set; }
		public DateTime? DateStart { get; set; }
		public DateTime? DateEnd { get; set; }
		public bool IsCurrent { get; set; }
		public string Description { get; set; }

		//FK
		public virtual Person Person { get; set; }
		public virtual ActivityType ActivityType { get; set; }
		public virtual Company Company { get; set; }
		public virtual Position Position { get; set; }
	}
}
