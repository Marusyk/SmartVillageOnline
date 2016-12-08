using DataModel.Dictionaries;

namespace DAL.Mapping.Dictionaries
{
	public class FamilyRelationsMap : BaseModelMap<FamilyRelations>
	{
		public FamilyRelationsMap()
		{
			Property(t => t.Name).IsRequired().HasMaxLength(50);

			HasMany(a => a.Peoples).WithOptional(p => p.FamilyRelations).HasForeignKey(p => p.FamilyRelationId);

			ToTable("FamilyRelations");
		}
	}
}
