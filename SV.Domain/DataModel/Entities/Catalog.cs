using System.Collections.Generic;
using System.Runtime.Serialization;
using DataModel.Abstract;
using DataModel.Entities.Dictionaries;

namespace DataModel.Entities
{
    public class Catalog : BaseDictionary
    {
        public int? ParentId { get; set; }

        public int? ModuleId { get; set; }

        [IgnoreDataMember]
        public virtual ICollection<Person> Persons { get; set; }
    }
}
