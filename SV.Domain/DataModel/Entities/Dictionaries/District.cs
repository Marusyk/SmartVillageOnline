using System.Collections.Generic;
using System.Runtime.Serialization;
using DataModel.Abstract;

namespace DataModel.Entities.Dictionaries
{
    public class District : BaseDictionary
    {
        public int RegionID { get; set; }

        // FK to Region        
        public virtual Region Region { get; set; }

        [IgnoreDataMember]
        public virtual ICollection<City> Cities { get; set; }
    }
}
