using System;

namespace Domain.Abstract
{
    public abstract class BaseEntity
    {
        protected BaseEntity()
        {
            LastUpdUS = "SV";
            LastUpdDT = DateTime.Now;
        }

        public int ID { get; set; }
        
        public DateTime LastUpdDT { get; set; }

        public string LastUpdUS { get; set; }
    }
}
