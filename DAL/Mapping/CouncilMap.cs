using DataModel;

namespace DAL.Mapping
{
	public class CouncilMap : BaseModelMap<Council>
	{
		public CouncilMap()
		{
			Property(t => t.ParentId).IsOptional();
			Property(t => t.Name).IsRequired().HasMaxLength(250);
			Property(t => t.ShortName).IsRequired().HasMaxLength(50);
			Property(t => t.AddressId).IsOptional();
			Property(t => t.EDRPOUCode).IsOptional();

			HasMany(a => a.ActivityTypes).WithRequired(p => p.Council).HasForeignKey(p => p.CouncilId);
			HasMany(a => a.Addresses).WithRequired(p => p.Council).HasForeignKey(p => p.CouncilId);
			HasMany(a => a.Catalogs).WithRequired(p => p.Council).HasForeignKey(p => p.CouncilId);
			HasMany(a => a.Animals).WithRequired(p => p.Council).HasForeignKey(p => p.CouncilId);
			HasMany(a => a.Companies).WithRequired(p => p.Council).HasForeignKey(p => p.CouncilId);
			HasMany(a => a.DocumentTypes).WithRequired(p => p.Council).HasForeignKey(p => p.CouncilId);
			HasMany(a => a.Institutions).WithRequired(p => p.Council).HasForeignKey(p => p.CouncilId);
			HasMany(a => a.Materials).WithRequired(p => p.Council).HasForeignKey(p => p.CouncilId);
			HasMany(a => a.PassAuthorities).WithRequired(p => p.Council).HasForeignKey(p => p.CouncilId);
			HasMany(a => a.Persons).WithRequired(p => p.Council).HasForeignKey(p => p.CouncilId);
			HasMany(a => a.Positions).WithRequired(p => p.Council).HasForeignKey(p => p.CouncilId);
			HasMany(a => a.Specialities).WithRequired(p => p.Council).HasForeignKey(p => p.CouncilId);
			HasMany(a => a.Streets).WithRequired(p => p.Council).HasForeignKey(p => p.CouncilId);
			HasMany(a => a.Documents).WithRequired(p => p.Council).HasForeignKey(p => p.CouncilId);
			HasMany(a => a.Houses).WithRequired(p => p.Council).HasForeignKey(p => p.CouncilId);
			
			ToTable("Council");
		}
	}
}
