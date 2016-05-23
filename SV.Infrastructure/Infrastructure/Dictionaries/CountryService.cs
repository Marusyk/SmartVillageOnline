using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessEntities.Dictionaries;
using DataModel.Entities.Dictionaries;
using DataModel.UnitOfWork;

namespace Infrastructure.Dictionaries {
	public class CountryService : BaseServices<CountryEntity, Country>
	{
		public CountryService(UnitOfWork unitOfWork) : base(unitOfWork)
        {
		}
	}
}
