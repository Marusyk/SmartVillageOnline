using System.Collections.Generic;
using System.Runtime.Serialization;
using DataModel.Entities.Abstract;

namespace DataModel.Entities.Dictionaries
{
    public class CityType : BaseDictionary
    {
        [IgnoreDataMember]
        public virtual ICollection<City> Cities { get; set; }
    }
}
