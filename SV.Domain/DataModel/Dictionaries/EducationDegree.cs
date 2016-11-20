using System.Collections.Generic;
using System.Runtime.Serialization;
using DataModel.Abstract;

namespace DataModel.Dictionaries
{
	public class EducationDegree : BaseDictionary
	{
		//Navigation
		[IgnoreDataMember]
		public virtual ICollection<Education> Educations { get; set; }
	}
}
