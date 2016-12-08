using System.Collections.Generic;
using DataModel.Abstract;

namespace DataModel.Dictionaries
{
	public class ActivityType : BaseDictionary
	{
		public int CouncilId { get; set; }

		//FK
		public virtual Council Council { get; set; }
		//Navigation
		public virtual ICollection<Employment> Employments { get; set; }
	}
}
