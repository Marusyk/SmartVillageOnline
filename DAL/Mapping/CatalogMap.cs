using DataModel;

namespace DAL.Mapping
{
	public class CatalogMap : BaseModelMap<Catalog>
	{
		public CatalogMap()
		{
			HasKey(t => t.Id);
			
			Property(t => t.ParentId).IsOptional();
			Property(t => t.Name).IsRequired().HasMaxLength(50);
			Property(t => t.CouncilId).IsRequired();

			HasMany(a => a.Persons).WithRequired(p => p.Catalog).HasForeignKey(p => p.CatalogId);

			ToTable("Catalog");
		}
	}
}
