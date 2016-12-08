using System.Collections.Generic;
using BusinessEntities.BaseBusinessEntities;

namespace BusinessEntities.Dictionaries
{
	public class CompanyEntity : BaseDictionaryCouncilEntity
	{
		public int? AddressId { get; set; }

		public AddressEntity Address { get; set; }

		public ICollection<EmploymentEntity> Employments { get; set; }
	}
}
