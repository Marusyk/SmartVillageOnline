using System.Collections.Generic;
using DataModel.Abstract;

namespace DataModel.Dictionaries
{
	public class EducationDegree : BaseDictionary
	{
		//Navigation
		public virtual ICollection<Education> Educations { get; set; }
	}
}
