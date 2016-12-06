using System.Data.Entity.ModelConfiguration;
using System.ComponentModel.DataAnnotations.Schema;
using DataModel;

namespace DAL.Mapping
{
	public class CouncilMap : EntityTypeConfiguration<Council>
	{
		public CouncilMap()
		{
			HasKey(t => t.Id);
			Property(t => t.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
			Property(t => t.ParentId).IsOptional();
			Property(t => t.Name).IsRequired().HasMaxLength(250);
			Property(t => t.ShortName).IsRequired().HasMaxLength(50);
			Property(t => t.AddressId).IsOptional();
			Property(t => t.EDRPOUCode).IsOptional();
			Property(t => t.LastUpdDt).IsRequired();
			Property(t => t.LastUpdUs).IsRequired().HasMaxLength(50);

			HasMany(a => a.ActivityTypes).WithRequired(p => p.Council).HasForeignKey(p => p.CouncilId);
			HasMany(a => a.Addresses).WithRequired(p => p.Council).HasForeignKey(p => p.CouncilId);
			//HasMany(a => a.Animals).WithRequired(p => p.Council).HasForeignKey(p => p.CouncilId);
			/*HasMany(a => a.Companies).WithRequired(p => p.Council).HasForeignKey(p => p.CouncilId);
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
			*/
			ToTable("Council");
		}
	}
}
