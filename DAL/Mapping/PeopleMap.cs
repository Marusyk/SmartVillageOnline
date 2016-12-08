using DataModel;

namespace DAL.Mapping
{
	public class PeopleMap : BaseModelMap<People>
	{
		public PeopleMap()
		{
			Property(t => t.PersonId).IsRequired();
			Property(t => t.HouseId).IsRequired();
			Property(t => t.PeopleNumber).IsRequired();
			Property(t => t.FamilyRelationId).IsOptional();
			Property(t => t.DateRegistration).IsOptional();
			Property(t => t.IsMain).IsRequired();

			ToTable("People");
		}
	}
}
