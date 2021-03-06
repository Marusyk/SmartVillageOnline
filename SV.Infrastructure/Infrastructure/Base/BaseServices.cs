﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;
using AutoMapper;
using BusinessEntities.Dictionaries;
using DataModel.Entities.Abstract;
using DataModel.Entities.Dictionaries;
using DataModel.UnitOfWork;
using Infrastructure.Interfaces;

namespace Infrastructure
{
    public abstract class BaseServices<TEntity, TBusinessEntity> : IServices<TBusinessEntity> where TBusinessEntity : class where TEntity: BaseEntity
    {
        protected readonly UnitOfWork UnitOfWork;

        protected BaseServices(UnitOfWork unitOfWork)
        {
            UnitOfWork = unitOfWork;
        }

        public IEnumerable<TBusinessEntity> Get() 
		{
	        var entities = UnitOfWork.Repository<TEntity>().Get();

	       // if (entities == null)
		        return null;
			
			
        }

        public IEnumerable<TBusinessEntity> GetAll() {

	        var entities = UnitOfWork.Repository<TEntity>().GetAll().ToList();

	        if (!entities.Any()) 
				return null;

	        var config = new MapperConfiguration(cfg =>
	        {
				cfg.CreateMap<TEntity, TBusinessEntity>();
	        });
	        var mapper = config.CreateMapper();
	        var entitiesModel = mapper.Map<List<TEntity>, List<TBusinessEntity>>(entities);
	        return entitiesModel;
        }

        public TBusinessEntity GetById(object id)
        {
            var entity = UnitOfWork.Repository<TEntity>().GetById(id);

            if (entity == null)
                return null;

            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<TEntity, TBusinessEntity>();
            });
            var mapper = config.CreateMapper();
            var entityModel = mapper.Map<TEntity, TBusinessEntity>(entity);

            return entityModel;
        }

        public TBusinessEntity Get(Func<TBusinessEntity, bool> @where)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<TBusinessEntity> GetMany(Func<TBusinessEntity, bool> @where)
        {
            throw new NotImplementedException();
        }

        public IQueryable<TBusinessEntity> GetManyQueryable(Func<TBusinessEntity, bool> @where)
        {
            throw new NotImplementedException();
        }

        public IQueryable<TBusinessEntity> GetWithInclude(Expression<Func<TBusinessEntity, bool>> predicate, params string[] include)
        {
            throw new NotImplementedException();
        }

        public TBusinessEntity GetSingle(Func<TBusinessEntity, bool> predicate)
        {
            throw new NotImplementedException();
        }

        public TBusinessEntity GetFirst(Func<TBusinessEntity, bool> predicate)
        {
            throw new NotImplementedException();
        }

        public bool Exists(object primaryKey)
        {
            throw new NotImplementedException();
        }

        public int Insert(TBusinessEntity entity)
        {
            throw new NotImplementedException();
        }

        public bool Update(int id, TBusinessEntity entityToUpdate) 
		{
	        var success = false;
	        if (entityToUpdate != null) 
			{
		        using (var scope = new TransactionScope()) 
				{
			        var entity = UnitOfWork.Repository<TEntity>().GetById(id);
			        if (entity != null) 
					{
						var config = new MapperConfiguration(cfg =>
						{
							cfg.CreateMap<TBusinessEntity, TEntity>();
						});
						var mapper = config.CreateMapper();
						var entityModel = mapper.Map<TBusinessEntity, TEntity>(entityToUpdate);
						entity = entityModel;
						UnitOfWork.Repository<TEntity>().Update(entity);
						UnitOfWork.Save();
						scope.Complete();
				        success = true;
			        }
		        }
	        }
	        return success;
        }

        public bool Delete(TBusinessEntity entityToDelete)
        {
			var success = false;

			if (entityToDelete != null) {
				using (var scope = new TransactionScope()) 
				{
					UnitOfWork.Repository<TEntity>().Delete(entityToDelete);
					UnitOfWork.Save();
					scope.Complete();
					success = true;
				}
			}
			return success;
		}

        public bool Delete(object id) 
		{
	        var success = false;

	        if ((int) id > 0) 
			{
		        using (var scope = new TransactionScope()) 
				{
					var entity = UnitOfWork.Repository<TEntity>().GetById(id);
					if (entity != null) 
					{
						UnitOfWork.Repository<TEntity>().Delete(entity);
						UnitOfWork.Save();
				        scope.Complete();
						success = true;
					}
				}
	        }
	        return success;
        }
    }
}