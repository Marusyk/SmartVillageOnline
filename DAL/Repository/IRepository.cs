﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using DataModel.Abstract;

namespace DAL.Repository
{
	public interface IRepository<TEntity> where TEntity : BaseEntity
	{
		IEnumerable<TEntity> GetAll();
		TEntity GetById(object id);
		TEntity Get(Func<TEntity, bool> where);
		IEnumerable<TEntity> GetMany(Func<TEntity, bool> where);
		IQueryable<TEntity> GetManyQueryable(Func<TEntity, bool> where);
		IQueryable<TEntity> GetWithInclude(Expression<Func<TEntity, bool>> predicate, params string[] include);
		TEntity GetSingle(Func<TEntity, bool> predicate);
		TEntity GetFirst(Func<TEntity, bool> predicate);
		bool Exists(object primaryKey);
		void Insert(TEntity entity);
		void Update(TEntity entityToUpdate);
		void Delete(TEntity entityToDelete);
		void Delete(object id);
	}
}
