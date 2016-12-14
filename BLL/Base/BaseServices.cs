using System.Collections.Generic;
using System.Linq;
using AutoMapper;
using BLL.Interfaces;
using DataModel.Abstract;
using DAL.Repository;
using DAL.UnitOfWork;
using BusinessEntities.BaseBusinessEntities;
using System.Transactions;
using BLL.Extensions;

namespace BLL
{
	public class BaseServices<TEntity, TBusinessEntity> : IService<TBusinessEntity> where TBusinessEntity : BaseBusinessEntity where TEntity : BaseEntity
	{
		protected readonly IUnitOfWork UnitOfWork;
		protected readonly IRepository<TEntity> Repository;

		protected BaseServices(IUnitOfWork unitOfWork)
		{
			UnitOfWork = unitOfWork;
			Repository = UnitOfWork.Repository<TEntity>();
		}

		public IEnumerable<TBusinessEntity> GetAll()
		{
			var entities = Repository.GetAll();
			var entitiesModel = Mapper.Map<List<TEntity>, List<TBusinessEntity>>(entities.ToList());

			return entitiesModel;
		}

		public PaginatedList<TBusinessEntity> Get(int pageNo, int pageSize)
		{
			var entities = Repository.GetAll();
			var entitiesModel = Mapper.Map<List<TEntity>, List<TBusinessEntity>>(entities.ToList());

			pageNo = pageNo > 0 ? pageNo : 1;
			pageSize = pageSize > 0 ? pageSize : 0;

			return entitiesModel.ToPaginatedList(pageNo, pageSize);
		}

		public TBusinessEntity GetById(object id)
		{
			var entity = Repository.GetById(id);

			if (entity == null)
				return null;

			var entityModel = Mapper.Map<TEntity, TBusinessEntity>(entity);

			return entityModel;
		}

		//public TBusinessEntity Get(Func<TBusinessEntity, bool> @where)
		//{
		//	throw new NotImplementedException();
		//}

		//public IEnumerable<TBusinessEntity> GetMany(Func<TBusinessEntity, bool> @where)
		//{
		//	throw new NotImplementedException();
		//}

		//public IQueryable<TBusinessEntity> GetManyQueryable(Func<TBusinessEntity, bool> @where)
		//{
		//	throw new NotImplementedException();
		//}

		//public IQueryable<TBusinessEntity> GetWithInclude(Expression<Func<TBusinessEntity, bool>> predicate, params string[] include)
		//{
		//	throw new NotImplementedException();
		//}

		//public TBusinessEntity GetSingle(Func<TBusinessEntity, bool> predicate)
		//{
		//	throw new NotImplementedException();
		//}

		//public TBusinessEntity GetFirst(Func<TBusinessEntity, bool> predicate)
		//{
		//	throw new NotImplementedException();
		//}

		public bool Exists(object primaryKey) => Repository.Exists(primaryKey);

		public int Insert(TBusinessEntity businessEntity)
		{
			if (businessEntity == null)
				return default(int);

			using (var scope = new TransactionScope())
			{
				var entity = Mapper.Map<TBusinessEntity, TEntity>(businessEntity);
				Repository.Insert(entity);
				UnitOfWork.Save();
				scope.Complete();
				return entity.Id;
			}
		}

		public bool Update(int id, TBusinessEntity businessEntity)
		{
			if (businessEntity == null)
				return false;

			using (var scope = new TransactionScope())
			{
				var entity = Repository.GetById(id);
				if (entity == null)
					return false;

				Mapper.Map(businessEntity, entity);
				Repository.Update(entity);
				UnitOfWork.Save();
				scope.Complete();
			}
			return true;
		}

		public bool Delete(TBusinessEntity businessEntity)
		{
			if (businessEntity == null)
				return false;

			using (var scope = new TransactionScope())
			{
				var entity = Mapper.Map<TBusinessEntity, TEntity>(businessEntity);
				Repository.Delete(entity);
				UnitOfWork.Save();
				scope.Complete();
			}
			return true;
		}

		public bool Delete(object id)
		{
			if ((int) id <= 0)
				return false;

			using (var scope = new TransactionScope())
			{
				var entity = Repository.GetById(id);
				if (entity == null)
					return false;

				Repository.Delete(entity);
				UnitOfWork.Save();
				scope.Complete();
			}
			return true;
		}
	}
}