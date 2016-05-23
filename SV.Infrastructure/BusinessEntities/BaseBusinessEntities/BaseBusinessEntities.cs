using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessEntities.BaseBusinessEntities
{
    public class BaseBusinessEntities
    {
        public int Id { get; set; }
        public DateTime LastUpdDt { get; set; }
        public string LastUpdUs { get; set; }
    }
}
