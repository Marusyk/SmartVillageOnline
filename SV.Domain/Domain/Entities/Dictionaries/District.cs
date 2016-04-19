using System.Collections.Generic;
using System.Runtime.Serialization;
using Domain.Abstract;

namespace Domain.Entities.Dictionaries
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
