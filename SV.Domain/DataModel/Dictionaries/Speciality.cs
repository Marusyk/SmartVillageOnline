using System.Collections.Generic;
using DataModel.Abstract;

namespace DataModel.Dictionaries
{
	public class Speciality : BaseDictionary
	{
		public int CouncilId { get; set; }

		//FK
		public virtual Council Council { get; set; }

		//Navigation
		public virtual ICollection<Education> Educations { get; set; }
	}
}
