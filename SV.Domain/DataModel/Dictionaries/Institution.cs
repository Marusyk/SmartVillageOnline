using System.Collections.Generic;
using System.Runtime.Serialization;
using DataModel.Abstract;

namespace DataModel.Dictionaries
{
	public class Institution : BaseDictionaryCouncil
	{
		public int CityId { get; set; }

		//FK
		public virtual City City { get; set; }

		//Navigation
		[IgnoreDataMember]
		public virtual ICollection<Education> Educations { get; set; }
	}
}
