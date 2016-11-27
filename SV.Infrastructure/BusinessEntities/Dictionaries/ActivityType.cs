using System.Collections.Generic;
using BusinessEntities.BaseBusinessEntities;

namespace BusinessEntities.Dictionaries
{
	public class ActivityTypeEntity : BaseDictionaryCouncilEntity
	{
		public virtual ICollection<EmploymentEntity> Employments { get; set; }
	}
}
