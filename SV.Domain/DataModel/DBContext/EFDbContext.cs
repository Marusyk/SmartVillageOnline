﻿using System;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Reflection;
using DataModel.Entities.Abstract;

//using DataModel.Migrations;

namespace DataModel.DBContext
{
    //[DbConfigurationType(typeof(CustomDbConfiguration))]
    public class EFDbContext : DbContext   
    {
        public EFDbContext()
            :base("EFDbContext")
        {
            //Configuration.ProxyCreationEnabled = true;
            Configuration.LazyLoadingEnabled = false;
        }

        public new IDbSet<TEntity> Set<TEntity>() where TEntity : BaseEntity
        {
            return base.Set<TEntity>();
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            // remove a convention to enable cascade delete for any required relationships
            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();            

            var typesToRegister = Assembly.GetExecutingAssembly().GetTypes()
                .Where(type => !string.IsNullOrEmpty(type.Namespace))
                .Where(type => type.BaseType != null && type.BaseType.IsGenericType
                    && type.BaseType.GetGenericTypeDefinition() == typeof(EntityTypeConfiguration<>));
            foreach (var configurationInstance in typesToRegister.Select(Activator.CreateInstance))
            {
                modelBuilder.Configurations.Add((dynamic) configurationInstance);
            }
        }

    }
}
