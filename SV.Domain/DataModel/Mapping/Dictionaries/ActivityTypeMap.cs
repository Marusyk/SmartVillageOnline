﻿using System.Data.Entity.ModelConfiguration;
using System.ComponentModel.DataAnnotations.Schema;
using DataModel.Entities.Dictionaries;

namespace DataModel.Mapping.Dictionaries
{
    public class ActivityTypeMap : EntityTypeConfiguration<ActivityType>
    {
        public ActivityTypeMap()
        {
            HasKey(t => t.ID);
            Property(t => t.ID).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            Property(t => t.Name).IsRequired().HasMaxLength(50);
            HasMany(a => a.Employments).WithOptional(p => p.ActivityType).HasForeignKey(p => p.ActivityTypesID);
            Property(t => t.LastUpdUS).IsRequired().HasMaxLength(50);
            ToTable("ActivityType");
        }
    }
}