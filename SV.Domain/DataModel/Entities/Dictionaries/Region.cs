using System.Collections.Generic;
using System.Runtime.Serialization;
using DataModel.Abstract;

namespace DataModel.Entities.Dictionaries
{
    public class Region : BaseDictionary
    {
        public int CountryId { get; set; }

        // FK to Country
        public virtual Country Country { get; set; }

        //[IgnoreDataMember]
        //public virtual ICollection<District> Districts { get; set; }

        //[IgnoreDataMember]
        //public virtual ICollection<City> Cities { get; set; }
    }
}
