using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using BusinessEntities.Dictionaries;
using DataModel.Abstract;
using DataModel.Entities.Dictionaries;
using DataModel.UnitOfWork;
using Infrastructure.Interfaces;

namespace Infrastructure
{
    public abstract class BaseServices<TEntity, TBase> : IServices<TEntity> where TEntity : class where TBase: BaseEntity
    {
        protected readonly UnitOfWork _unitOfWork;

        protected BaseServices(UnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public IEnumerable<TEntity> Get()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<TEntity> GetAll()
        {
            throw new NotImplementedException();
        }

        public TEntity GetById(object id)
        {
            var animal = _unitOfWork.Repository<TBase>().GetById(id);

            if (animal == null)
                return null;
            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<TBase, TEntity>();
            });
            var mapper = config.CreateMapper();
            var animalModel = mapper.Map<TBase, TEntity>(animal);
            return animalModel;
        }

        public TEntity Get(Func<TEntity, bool> @where)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<TEntity> GetMany(Func<TEntity, bool> @where)
        {
            throw new NotImplementedException();
        }

        public IQueryable<TEntity> GetManyQueryable(Func<TEntity, bool> @where)
        {
            throw new NotImplementedException();
        }

        public IQueryable<TEntity> GetWithInclude(Expression<Func<TEntity, bool>> predicate, params string[] include)
        {
            throw new NotImplementedException();
        }

        public TEntity GetSingle(Func<TEntity, bool> predicate)
        {
            throw new NotImplementedException();
        }

        public TEntity GetFirst(Func<TEntity, bool> predicate)
        {
            throw new NotImplementedException();
        }

        public bool Exists(object primaryKey)
        {
            throw new NotImplementedException();
        }

        public void Insert(TEntity entity)
        {
            throw new NotImplementedException();
        }

        public void Update(TEntity entityToUpdate)
        {
            throw new NotImplementedException();
        }

        public void Delete(TEntity entityToDelete)
        {
            throw new NotImplementedException();
        }

        public void Delete(object id)
        {
            throw new NotImplementedException();
        }
    }
}