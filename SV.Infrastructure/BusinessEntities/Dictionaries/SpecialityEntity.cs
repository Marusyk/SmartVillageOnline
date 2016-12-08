using System.Collections.Generic;
using BusinessEntities.BaseBusinessEntities;

namespace BusinessEntities.Dictionaries
{
	public class SpecialityEntity : BaseDictionaryCouncilEntity
	{
		public ICollection<EducationEntity> Educations { get; set; }
	}
}
