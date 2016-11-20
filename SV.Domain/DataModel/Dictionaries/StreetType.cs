using System.Collections.Generic;
using System.Runtime.Serialization;
using DataModel.Abstract;

namespace DataModel.Dictionaries
{
	public class StreetType : BaseDictionary
	{
		//Navigation
		[IgnoreDataMember]
		public virtual ICollection<Street> Streets { get; set; }
	}
}
