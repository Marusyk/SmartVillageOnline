using DataModel.Dictionaries;

namespace DAL.Mapping.Dictionaries
{
	public class MaterialMap : BaseModelMap<Material>
	{
		public MaterialMap()
		{
			Property(t => t.Name).IsRequired().HasMaxLength(50);
			Property(t => t.CouncilId).IsRequired();

			ToTable("Material");
		}
	}
}
