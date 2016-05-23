using System.Data.Entity.ModelConfiguration;
using System.ComponentModel.DataAnnotations.Schema;
using DataModel.Entities;

namespace DataModel.Mapping
{
    public class CatalogMap: EntityTypeConfiguration<Catalog>
    {
        public CatalogMap()
        {
            HasKey(t => t.Id);
            Property(t => t.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(t => t.Name).IsRequired().HasMaxLength(50);
            HasMany(a => a.Persons).WithRequired(p => p.Catalog).HasForeignKey(p => p.CatalogId);
            Property(t => t.LastUpdUs).IsRequired().HasMaxLength(50);
            ToTable("Catalog");
        }
    }
}
