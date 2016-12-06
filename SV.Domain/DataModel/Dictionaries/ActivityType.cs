using System.Collections.Generic;
using System.Runtime.Serialization;
using DataModel.Abstract;

namespace DataModel.Dictionaries
{
	public class ActivityType : BaseDictionary
	{
		public int CouncilId { get; set; }

		//FK
		public Council Council { get; set; }
		//Navigation
		[IgnoreDataMember]
		public virtual ICollection<Employment> Employments { get; set; }
	}
}
