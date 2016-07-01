using System;
using System.Collections.Generic;
using System.Data.Entity.Validation;
using System.Diagnostics;
using DataModel.DBContext;
using DataModel.Entities.Abstract;
using DataModel.Repository;

namespace DataModel.UnitOfWork
{
    public class UnitOfWork : IUnitOfWork, IDisposable
    {
        #region Private member variables...

        private readonly EFDbContext _context;
        private Dictionary<string, object> _repositories;

        #endregion

        public UnitOfWork()
        {
            _context = new EFDbContext();
        }

        #region Public member methods...

        public void Save()
        {
            try
            {
                _context.SaveChanges();
            }
            catch (DbEntityValidationException e)
            {
                var outputLines = new List<string>();
                foreach (var eve in e.EntityValidationErrors)
                {
                    outputLines.Add($"{DateTime.Now}: Entity of type \"{eve.Entry.Entity.GetType().Name}\" in state \"{eve.Entry.State}\"has the following validation errors:");
                    foreach (var ve in eve.ValidationErrors)
                    {
                        outputLines.Add($"- Property: \"{ve.PropertyName}\", Error: \"{ve.ErrorMessage}\"");
                    }
                }
                System.IO.File.AppendAllLines(@"F:\errors.txt", outputLines);
                throw;
            }
        }

        public EFRepository<T> Repository<T>() where T : BaseEntity
        {
            if (_repositories == null)
            {
                _repositories = new Dictionary<string, object>();
            }

            var type = typeof(T).Name;

            if (_repositories.ContainsKey(type))
            {
                return (EFRepository<T>)_repositories[type];
            }

            var repositoryType = typeof(EFRepository<>);
            var repositoryInstance = Activator.CreateInstance(repositoryType.MakeGenericType(typeof(T)), _context);
            _repositories.Add(type, repositoryInstance);
            return (EFRepository<T>)_repositories[type];
        }

        #endregion

        #region Implementing IDiosposable...

        private bool _disposed;

        protected virtual void Dispose(bool disposing)
        {
            if (!_disposed)
            {
                if (disposing)
                {
                    Debug.WriteLine("UnitOfWork is begin _disposed");
                    _context.Dispose();
                }
            }
            _disposed = true;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        #endregion
    }
}
