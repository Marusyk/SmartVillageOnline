using System.Collections.Generic;
using System.Runtime.Serialization;
using DataModel.Abstract;

namespace DataModel.Dictionaries
{
	public class Position : BaseDictionaryCouncil
	{
		//Navigation
		[IgnoreDataMember]
		public virtual ICollection<Employment> Employments { get; set; }
	}
}
