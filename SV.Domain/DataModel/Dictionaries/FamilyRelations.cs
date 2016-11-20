using System.Collections.Generic;
using System.Runtime.Serialization;
using DataModel.Abstract;

namespace DataModel.Dictionaries
{
	public class FamilyRelations : BaseDictionary
	{
		//Navigation
		[IgnoreDataMember]
		public virtual ICollection<People> Peoples { get; set; }
	}
}
