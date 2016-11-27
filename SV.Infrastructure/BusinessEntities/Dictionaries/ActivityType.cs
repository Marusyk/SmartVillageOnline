using System.Collections.Generic;
using BusinessEntities.BaseBusinessEntities;

namespace DataModel.Dictionaries
{
	public class ActivityTypeEntity : BaseDictionaryCouncilEntity
	{
		public virtual ICollection<EmploymentEntity> Employments { get; set; }
	}
}
