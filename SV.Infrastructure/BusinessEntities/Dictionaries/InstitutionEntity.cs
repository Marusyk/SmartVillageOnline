using System.Collections.Generic;
using BusinessEntities.BaseBusinessEntities;

namespace BusinessEntities.Dictionaries
{
	public class InstitutionEntity : BaseDictionaryCouncilEntity
	{
		public int CityId { get; set; }

		public CityEntity City { get; set; }

		public ICollection<EducationEntity> Educations { get; set; }
	}
}
