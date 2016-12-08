using System.Collections.Generic;
using DataModel.Abstract;

namespace DataModel.Dictionaries
{
	public class Institution : BaseDictionary
	{
		public int CityId { get; set; }
		public int CouncilId { get; set; }


		//FK
		public virtual City City { get; set; }
		public virtual Council Council { get; set; }


		//Navigation
		public virtual ICollection<Education> Educations { get; set; }
	}
}
