using DataModel.Abstract;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace DAL.Mapping
{
	public class BaseModelMap<TEntity> : EntityTypeConfiguration<TEntity> where TEntity : BaseEntity
	{
		public BaseModelMap()
		{

			HasKey(t => t.Id);
			Property(t => t.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
			Property(t => t.LastUpdDt).IsRequired();
			Property(t => t.LastUpdUs).IsRequired().HasMaxLength(50);
		}
	}
}
