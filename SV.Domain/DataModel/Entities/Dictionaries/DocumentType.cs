using System.Collections.Generic;
using System.Runtime.Serialization;
using DataModel.Abstract;

namespace DataModel.Entities.Dictionaries
{
    public class DocumentType : BaseDictionary
    {        
        public string Code { get; set; }

        [IgnoreDataMember]
        public virtual ICollection<Document> Documents { get; set; }
    }
}
