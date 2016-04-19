using Domain.Abstract;

namespace Domain.Entities.SystemEntities
{
    public class SYS_Dictionary : BaseEntity
    {
        public string Name { get; set; }

        public string Description { get; set; }

        public bool IsStatic { get; set; }
    }
}
