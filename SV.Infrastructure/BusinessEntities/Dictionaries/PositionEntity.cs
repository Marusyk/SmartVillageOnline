using System.Collections.Generic;
using BusinessEntities.BaseBusinessEntities;

namespace BusinessEntities.Dictionaries
{
	public class PositionEntity : BaseDictionaryCouncilEntity
	{
		public virtual ICollection<EmploymentEntity> Employments { get; set; }
	}
}
