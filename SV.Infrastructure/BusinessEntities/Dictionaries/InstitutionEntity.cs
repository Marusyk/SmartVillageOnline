using System.Collections.Generic;
using BusinessEntities.BaseBusinessEntities;

namespace DataModel.Dictionaries
{
	public class InstitutionEntity : BaseDictionaryCouncilEntity
	{
		public int CityId { get; set; }

		public virtual CityEntity City { get; set; }

		public virtual ICollection<EducationEntity> Educations { get; set; }
	}
}
