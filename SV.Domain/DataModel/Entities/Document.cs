using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using DataModel.Abstract;
using DataModel.Entities.Dictionaries;

namespace DataModel.Entities
{
    public class Document : BaseDictionary
    {
        public int? DocumentTypeID { get; set; }

        public int? PassAuthorityID { get; set; }

        public string Number { get; set; }

        public string Code { get; set; }

        public bool State { get; set; }

        public DateTime DateReg { get; set; }

        //FK
        public virtual DocumentType DocumentType { get; set; }
        public virtual PassAuthority PassAuthority { get; set; }

        [IgnoreDataMember]
        public virtual ICollection<Education> Educations { get; set; }

        [IgnoreDataMember]
        public virtual ICollection<PersonDocument> PersonDocuments { get; set; }
    }
}
