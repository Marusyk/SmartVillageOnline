using System.Collections.Generic;
using BusinessEntities.BaseBusinessEntities;

namespace DataModel.Dictionaries
{
	public class PositionEntity : BaseDictionaryCouncilEntity
	{
		public virtual ICollection<EmploymentEntity> Employments { get; set; }
	}
}
