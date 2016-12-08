using DataModel.Dictionaries;

namespace DAL.Mapping.Dictionaries
{
	public class PassAuthorityMap : BaseModelMap<PassAuthority>
	{
		public PassAuthorityMap()
		{
			Property(t => t.Name).IsRequired().HasMaxLength(50);
			Property(t => t.CouncilId).IsRequired();

			HasMany(a => a.Persons).WithOptional(p => p.PassAuthority).HasForeignKey(p => p.PassAuthorityId);
			HasMany(a => a.Documents).WithOptional(p => p.PassAuthority).HasForeignKey(p => p.PassAuthorityId);

			ToTable("PassAuthority");
		}
	}
}
