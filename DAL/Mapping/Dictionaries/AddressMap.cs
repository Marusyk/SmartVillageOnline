using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using DataModel.Dictionaries;

namespace DAL.Mapping.Dictionaries
{
	public class AddressMap : EntityTypeConfiguration<Address>
	{
		public AddressMap()
		{
			HasKey(t => t.Id);
			Property(t => t.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
			Property(t => t.CityId).IsRequired();
			Property(t => t.StreetId).IsOptional();
			Property(t => t.PostCode).IsOptional();
			Property(t => t.BuildNr).IsOptional().HasMaxLength(10);
			Property(t => t.FlatNr).IsOptional().HasMaxLength(10);
			Property(t => t.CouncilId).IsRequired();
			Property(t => t.LastUpdDt).IsRequired();
			Property(t => t.LastUpdUs).IsRequired().HasMaxLength(50);

			HasMany(a => a.Companies).WithOptional(p => p.Address).HasForeignKey(p => p.AddressId);
			HasMany(a => a.PersonBirthAddress).WithOptional(p => p.AddressBith).HasForeignKey(p => p.AddressBirthId);
			HasMany(a => a.PersonLiveAddress).WithOptional(p => p.AddressLive).HasForeignKey(p => p.AddressLiveId);
			HasMany(a => a.Houses).WithRequired(p => p.Address).HasForeignKey(p => p.AddressId);
			HasMany(a => a.Councils).WithOptional(p => p.Address).HasForeignKey(p => p.AddressId);
			
			ToTable("Address");
		}
	}
}
