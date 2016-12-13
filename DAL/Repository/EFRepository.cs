using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using DataModel.Abstract;

namespace DAL.Repository
{
	public class EFRepository<TEntity> : IRepository<TEntity> where TEntity : BaseEntity
	{
		#region Private member variables...

		internal DbContext Context;
		internal DbSet<TEntity> DbSet;

		#endregion

		#region Public Constructor...

		public EFRepository(DbContext context)
		{
			if (context == null)
			{
				throw new ArgumentNullException(nameof(context));
			}

			Context = context;
			DbSet = context.Set<TEntity>();
		}

		#endregion

		#region Implementing IRepository...

		public IEnumerable<TEntity> GetAll() => DbSet.ToList();

		public TEntity GetById(object id) => DbSet.Find(id);

		public TEntity Get(Func<TEntity, bool> where) => DbSet.Where(where).FirstOrDefault();

		public IEnumerable<TEntity> GetMany(Func<TEntity, bool> where) => DbSet.Where(where).ToList();

		public virtual IQueryable<TEntity> GetManyQueryable(Func<TEntity, bool> where) =>
			DbSet.Where(where).AsQueryable();

		public IQueryable<TEntity> GetWithInclude(Expression<Func<TEntity, bool>> predicate, params string[] include)
		{
			IQueryable<TEntity> query = DbSet;
			query = include.Aggregate(query, (current, inc) => current.Include(inc));
			return query.Where(predicate);
		}

		public TEntity GetSingle(Func<TEntity, bool> predicate) => DbSet.Single(predicate);

		public TEntity GetFirst(Func<TEntity, bool> predicate) => DbSet.First(predicate);

		public bool Exists(object primaryKey) => DbSet.Find(primaryKey) != null;

		public void Insert(TEntity entity) => DbSet.Add(entity);

		public virtual void Update(TEntity entityToUpdate)
		{
			var attachedEntity = Context.ChangeTracker.Entries<TEntity>().FirstOrDefault(e => e.Entity.Id == entityToUpdate.Id);
			if (attachedEntity != null)
			{
				Context.Entry(attachedEntity.Entity).State = EntityState.Detached;
			}

			Context.Entry(entityToUpdate).State = EntityState.Modified;
		}

		public virtual void Delete(TEntity entityToDelete)
		{
			if (Context.Entry(entityToDelete).State == EntityState.Detached)
			{
				DbSet.Attach(entityToDelete);
			}
			DbSet.Remove(entityToDelete);
		}

		public virtual void Delete(object id)
		{
			var entityToDelete = DbSet.Find(id);
			Delete(entityToDelete);
		}

		#endregion
	}
}
