using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using BusinessEntities.BaseBusinessEntities;

namespace BLL.Interfaces
{
	public interface IService<TBusinessEntity> where TBusinessEntity : BaseBusinessEntity
	{
		IEnumerable<TBusinessEntity> Get();
		//IEnumerable<TEntity> GetAll();
		TBusinessEntity GetById(object id);
		/*TEntity Get(Func<TEntity, bool> where);
		IEnumerable<TEntity> GetMany(Func<TEntity, bool> where);
		IQueryable<TEntity> GetManyQueryable(Func<TEntity, bool> where);
		IQueryable<TEntity> GetWithInclude(Expression<Func<TEntity, bool>> predicate, params string[] include);
		TEntity GetSingle(Func<TEntity, bool> predicate);
		TEntity GetFirst(Func<TEntity, bool> predicate);*/
		bool Exists(object primaryKey);
		int Insert(TBusinessEntity businessEntity);
		bool Update(int id, TBusinessEntity businessEntity);
		bool Delete(TBusinessEntity businessEntity);
		bool Delete(object id);
	}
}
