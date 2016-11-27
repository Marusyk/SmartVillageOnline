using System.Collections.Generic;
using System.Runtime.Serialization;
using DataModel.Abstract;

namespace DataModel.Dictionaries
{
	public class Speciality : BaseDictionaryCouncil
	{
		//Navigation
		[IgnoreDataMember]
		public virtual ICollection<Education> Educations { get; set; }
	}
}
