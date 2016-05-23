using System.Data.Entity.ModelConfiguration;
using System.ComponentModel.DataAnnotations.Schema;
using DataModel.Entities.Dictionaries;

namespace DataModel.Mapping.Dictionaries
{
    public class FamilyRelationsMap : EntityTypeConfiguration<FamilyRelations>
    {
        public FamilyRelationsMap()
        {
            HasKey(t => t.Id);
            Property(t => t.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(t => t.Name).IsRequired().HasMaxLength(50);
            HasMany(a => a.Peoples).WithOptional(p => p.FamilyRelations).HasForeignKey(p => p.FamilyRelationID);
            Property(t => t.LastUpdUs).IsRequired().HasMaxLength(50);
            ToTable("FamilyRelations");
        }
    }
}
