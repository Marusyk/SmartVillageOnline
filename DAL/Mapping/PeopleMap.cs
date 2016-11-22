using System.Data.Entity.ModelConfiguration;
using System.ComponentModel.DataAnnotations.Schema;
using DataModel;

namespace DAL.Mapping
{
	public class PeopleMap : EntityTypeConfiguration<People>
	{
		public PeopleMap()
		{
			HasKey(t => t.Id);
			Property(t => t.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
			Property(t => t.PersonId).IsRequired();
			Property(t => t.HouseId).IsRequired();
			Property(t => t.PeopleNumber).IsRequired();
			Property(t => t.IsMain).IsRequired();
			Property(t => t.LastUpdUs).IsRequired().HasMaxLength(50);
			ToTable("People");
		}
	}
}
