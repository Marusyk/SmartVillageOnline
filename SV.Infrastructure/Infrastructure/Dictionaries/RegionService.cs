using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessEntities.Dictionaries;
using DataModel.Entities.Dictionaries;
using DataModel.UnitOfWork;

namespace Infrastructure.Dictionaries {
	public class RegionService : BaseServices<Region, RegionEntity> 
	{
		public RegionService(UnitOfWork unitOfWork) : base(unitOfWork) 
		{
		}
	}
}
