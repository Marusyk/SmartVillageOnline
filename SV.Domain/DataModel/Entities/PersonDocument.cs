using DataModel.Entities.Abstract;
using DataModel.Entities.Dictionaries;


namespace DataModel.Entities
{
    public class PersonDocument : BaseEntity
    {
        public int PersonID { get; set; }

        public int DocumentID { get; set; }

        //FK
        public virtual Person Person { get; set; }
        public virtual Document Document { get; set; }
    }
}
